// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// ------------------------------------------------------------------------------
// Changes to this file must follow the http://aka.ms/api-review process.
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AllowPartiallyTrustedCallers]
[assembly: ReferenceAssembly]
[assembly: AssemblyTitle("System.Diagnostics.FileVersionInfo")]
[assembly: AssemblyDescription("System.Diagnostics.FileVersionInfo")]
[assembly: AssemblyDefaultAlias("System.Diagnostics.FileVersionInfo")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("1.0.24212.01")]
[assembly: AssemblyInformationalVersion("1.0.24212.01 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("4.0.0.0")]




namespace System.Diagnostics
{
    public sealed partial class FileVersionInfo
    {
        internal FileVersionInfo() { }
        public string Comments { get { throw null; } }
        public string CompanyName { get { throw null; } }
        public int FileBuildPart { get { throw null; } }
        public string FileDescription { get { throw null; } }
        public int FileMajorPart { get { throw null; } }
        public int FileMinorPart { get { throw null; } }
        public string FileName { get { throw null; } }
        public int FilePrivatePart { get { throw null; } }
        public string FileVersion { get { throw null; } }
        public string InternalName { get { throw null; } }
        public bool IsDebug { get { throw null; } }
        public bool IsPatched { get { throw null; } }
        public bool IsPreRelease { get { throw null; } }
        public bool IsPrivateBuild { get { throw null; } }
        public bool IsSpecialBuild { get { throw null; } }
        public string Language { get { throw null; } }
        public string LegalCopyright { get { throw null; } }
        public string LegalTrademarks { get { throw null; } }
        public string OriginalFilename { get { throw null; } }
        public string PrivateBuild { get { throw null; } }
        public int ProductBuildPart { get { throw null; } }
        public int ProductMajorPart { get { throw null; } }
        public int ProductMinorPart { get { throw null; } }
        public string ProductName { get { throw null; } }
        public int ProductPrivatePart { get { throw null; } }
        public string ProductVersion { get { throw null; } }
        public string SpecialBuild { get { throw null; } }
        public static System.Diagnostics.FileVersionInfo GetVersionInfo(string fileName) { throw null; }
        public override string ToString() { throw null; }
    }
}
