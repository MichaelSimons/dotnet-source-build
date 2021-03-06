// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using Microsoft.AspNetCore.Testing;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Tests
{
    public class HttpConnectionManagerTests
    {
        [Fact]
        public void UnrootedConnectionsGetRemovedFromHeartbeat()
        {
            var connectionId = "0";
            var trace = new Mock<IKestrelTrace>();
            var httpConnectionManager = new ConnectionManager(trace.Object, ResourceCounter.Unlimited);

            // Create HttpConnection in inner scope so it doesn't get rooted by the current frame.
            UnrootedConnectionsGetRemovedFromHeartbeatInnerScope(connectionId, httpConnectionManager, trace);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            var connectionCount = 0;
            httpConnectionManager.Walk(_ => connectionCount++);

            Assert.Equal(0, connectionCount);
            trace.Verify(t => t.ApplicationNeverCompleted(connectionId), Times.Once());
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private void UnrootedConnectionsGetRemovedFromHeartbeatInnerScope(
            string connectionId,
            ConnectionManager httpConnectionManager,
            Mock<IKestrelTrace> trace)
        {
            var serviceContext = new TestServiceContext();
            var mock = new Mock<DefaultConnectionContext>() { CallBase = true };
            mock.Setup(m => m.ConnectionId).Returns(connectionId);
            var transportConnectionManager = new TransportConnectionManager(httpConnectionManager);
            var httpConnection = new KestrelConnection<ConnectionContext>(0, serviceContext, transportConnectionManager, _ => Task.CompletedTask, mock.Object, Mock.Of<IKestrelTrace>());
            transportConnectionManager.AddConnection(0, httpConnection);

            var connectionCount = 0;
            httpConnectionManager.Walk(_ => connectionCount++);

            Assert.Equal(1, connectionCount);
            trace.Verify(t => t.ApplicationNeverCompleted(connectionId), Times.Never());

            // Ensure httpConnection doesn't get GC'd before this point.
            GC.KeepAlive(httpConnection);
        }
    }
}
