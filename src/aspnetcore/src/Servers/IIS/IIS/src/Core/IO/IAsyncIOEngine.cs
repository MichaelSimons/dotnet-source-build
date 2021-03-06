// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Buffers;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.IIS.Core.IO
{
    internal interface IAsyncIOEngine
    {
        ValueTask<int> ReadAsync(Memory<byte> memory);
        ValueTask<int> WriteAsync(ReadOnlySequence<byte> data);
        ValueTask FlushAsync(bool moreData);
        void NotifyCompletion(int hr, int bytes);
        void Complete();
    }
}
