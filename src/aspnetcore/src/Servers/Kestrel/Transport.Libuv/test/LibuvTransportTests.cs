// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Internal;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Tests.TestHelpers;
using Microsoft.AspNetCore.Testing;
using Xunit;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Tests
{
    public class LibuvTransportTests
    {
        public static IEnumerable<object[]> OneToTen => Enumerable.Range(1, 10).Select(i => new object[] { i });

        [Fact]
        public async Task TransportCanBindAndStop()
        {
            var transportContext = new TestLibuvTransportContext();
            var transport = new LibuvConnectionListener(transportContext, new IPEndPoint(IPAddress.Loopback, 0));

            // The transport can no longer start threads without binding to an endpoint.
            await transport.BindAsync();
            await transport.DisposeAsync();
        }

        [Fact]
        public async Task TransportCanBindUnbindAndStop()
        {
            var transportContext = new TestLibuvTransportContext();
            var transport = new LibuvConnectionListener(transportContext, new IPEndPoint(IPAddress.Loopback, 0));

            await transport.BindAsync();
            await transport.UnbindAsync();
            await transport.DisposeAsync();
        }

        [Fact]
        public async Task ConnectionCanReadAndWrite()
        {
            var transportContext = new TestLibuvTransportContext();
            await using var transport = new LibuvConnectionListener(transportContext, new IPEndPoint(IPAddress.Loopback, 0));

            await transport.BindAsync();
            var endpoint = (IPEndPoint)transport.EndPoint;

            async Task EchoServerAsync()
            {
                while (true)
                {
                    await using var connection = await transport.AcceptAsync();

                    if (connection == null)
                    {
                        break;
                    }

                    while (true)
                    {
                        var result = await connection.Transport.Input.ReadAsync();

                        if (result.IsCompleted)
                        {
                            break;
                        }
                        await connection.Transport.Output.WriteAsync(result.Buffer.ToArray());

                        connection.Transport.Input.AdvanceTo(result.Buffer.End);
                    }
                }
            }

            var serverTask = EchoServerAsync();

            using (var socket = TestConnection.CreateConnectedLoopbackSocket(endpoint.Port))
            {
                var data = Encoding.ASCII.GetBytes("Hello World");
                await socket.SendAsync(data, SocketFlags.None);

                var buffer = new byte[data.Length];
                var read = 0;
                while (read < data.Length)
                {
                    read += await socket.ReceiveAsync(buffer.AsMemory(read, buffer.Length - read), SocketFlags.None);
                }

                Assert.Equal(data, buffer);
            }

            await transport.UnbindAsync();

            await serverTask.DefaultTimeout();
        }

        [Fact]
        public async Task UnacceptedConnectionsAreAborted()
        {
            var transportContext = new TestLibuvTransportContext();
            var transport = new LibuvConnectionListener(transportContext, new IPEndPoint(IPAddress.Loopback, 0));

            await transport.BindAsync();
            var endpoint = (IPEndPoint)transport.EndPoint;

            async Task ConnectAsync()
            {
                using (var socket = TestConnection.CreateConnectedLoopbackSocket(endpoint.Port))
                {
                    try
                    {
                        var read = await socket.ReceiveAsync(new byte[10], SocketFlags.None);
                        Assert.Equal(0, read);
                    }
                    catch (SocketException)
                    {
                        // The connection can be reset sometimes
                    }
                }
            }

            var connectTask = ConnectAsync();

            await transport.UnbindAsync();
            await transport.DisposeAsync();

            // The connection was accepted because libuv eagerly accepts connections
            // they sit in a queue in each listener, we want to make sure that resources
            // are cleaned up if they are never accepted by the caller

            await connectTask.DefaultTimeout();
        }

        [Fact]
        public async Task CallingAcceptAfterDisposeAsyncThrows()
        {
            var transportContext = new TestLibuvTransportContext();
            var transport = new LibuvConnectionListener(transportContext, new IPEndPoint(IPAddress.Loopback, 0));

            await transport.BindAsync();
            var endpoint = (IPEndPoint)transport.EndPoint;

            await transport.UnbindAsync();
            await transport.DisposeAsync();

            await Assert.ThrowsAsync<ObjectDisposedException>(() => transport.AcceptAsync().AsTask());
        }

        [Fact]
        public async Task CallingDisposeAsyncWillYieldPendingAccepts()
        {
            var transportContext = new TestLibuvTransportContext();
            await using var transport = new LibuvConnectionListener(transportContext, new IPEndPoint(IPAddress.Loopback, 0));

            await transport.BindAsync();

            var acceptTask = transport.AcceptAsync();

            await transport.UnbindAsync();

            var connection = await acceptTask.DefaultTimeout();

            Assert.Null(connection);
        }

        [ConditionalTheory]
        [MemberData(nameof(OneToTen))]
        [OSSkipCondition(OperatingSystems.MacOSX, SkipReason = "Tests fail on OS X due to low file descriptor limit.")]
        public async Task OneToTenThreads(int threadCount)
        {
            var listenOptions = new ListenOptions(new IPEndPoint(IPAddress.Loopback, 0));
            var serviceContext = new TestServiceContext();
            var testApplication = new DummyApplication(context =>
            {
                return context.Response.WriteAsync("Hello World");
            });

            listenOptions.UseHttpServer(serviceContext, testApplication, Core.HttpProtocols.Http1, addAltSvcHeader: false);

            var transportContext = new TestLibuvTransportContext
            {
#pragma warning disable CS0618
                Options = new LibuvTransportOptions { ThreadCount = threadCount }
#pragma warning restore CS0618
            };

            await using var transport = new LibuvConnectionListener(transportContext, listenOptions.EndPoint);
            await transport.BindAsync();
            listenOptions.EndPoint = transport.EndPoint;

            var transportConnectionManager = new TransportConnectionManager(serviceContext.ConnectionManager);
            var dispatcher = new ConnectionDispatcher<ConnectionContext>(serviceContext, c => listenOptions.Build()(c), transportConnectionManager);
            var acceptTask = dispatcher.StartAcceptingConnections(new GenericConnectionListener(transport));

            using (var client = new HttpClient())
            {
                // Send 20 requests just to make sure we don't get any failures
                var requestTasks = new List<Task<string>>();
                for (int i = 0; i < 20; i++)
                {
                    var requestTask = client.GetStringAsync($"http://127.0.0.1:{listenOptions.IPEndPoint.Port}/");
                    requestTasks.Add(requestTask);
                }

                foreach (var result in await Task.WhenAll(requestTasks))
                {
                    Assert.Equal("Hello World", result);
                }
            }

            await transport.UnbindAsync();

            await acceptTask;

            if (!await transportConnectionManager.CloseAllConnectionsAsync(default))
            {
                await transportConnectionManager.AbortAllConnectionsAsync();
            }
        }

        private class GenericConnectionListener : IConnectionListener<ConnectionContext>
        {
            private readonly IConnectionListener _connectionListener;

            public GenericConnectionListener(IConnectionListener connectionListener)
            {
                _connectionListener = connectionListener;
            }

            public EndPoint EndPoint => _connectionListener.EndPoint;

            public ValueTask<ConnectionContext> AcceptAsync(CancellationToken cancellationToken = default)
                 => _connectionListener.AcceptAsync(cancellationToken);

            public ValueTask UnbindAsync(CancellationToken cancellationToken = default)
                => _connectionListener.UnbindAsync();

            public ValueTask DisposeAsync()
                => _connectionListener.DisposeAsync();
        }
    }
}
