// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Runtime.InteropServices;

namespace Microsoft.DotNet.Cli.Build.Framework
{
    public static class Constants
    {
        //public static readonly string ProjectFileName = "project.json";
        public static readonly string ExeSuffix = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? ".exe" : string.Empty;
    }
}
