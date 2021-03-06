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
[assembly: AssemblyTitle("System.Security.Cryptography.Cng")]
[assembly: AssemblyDescription("System.Security.Cryptography.Cng")]
[assembly: AssemblyDefaultAlias("System.Security.Cryptography.Cng")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("1.0.24212.01")]
[assembly: AssemblyInformationalVersion("1.0.24212.01 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("4.2.0.0")]




namespace Microsoft.Win32.SafeHandles
{
    public abstract partial class SafeNCryptHandle : System.Runtime.InteropServices.SafeHandle
    {
        protected SafeNCryptHandle() : base (default(System.IntPtr), default(bool)) { }
        public override bool IsInvalid { get { throw null; } }
        protected override bool ReleaseHandle() { throw null; }
        protected abstract bool ReleaseNativeHandle();
    }
    public sealed partial class SafeNCryptKeyHandle : Microsoft.Win32.SafeHandles.SafeNCryptHandle
    {
        public SafeNCryptKeyHandle() { }
        protected override bool ReleaseNativeHandle() { throw null; }
    }
    public sealed partial class SafeNCryptProviderHandle : Microsoft.Win32.SafeHandles.SafeNCryptHandle
    {
        public SafeNCryptProviderHandle() { }
        protected override bool ReleaseNativeHandle() { throw null; }
    }
    public sealed partial class SafeNCryptSecretHandle : Microsoft.Win32.SafeHandles.SafeNCryptHandle
    {
        public SafeNCryptSecretHandle() { }
        protected override bool ReleaseNativeHandle() { throw null; }
    }
}
namespace System.Security.Cryptography
{
    public sealed partial class AesCng : System.Security.Cryptography.Aes
    {
        public AesCng() { }
        public AesCng(string keyName) { }
        public AesCng(string keyName, System.Security.Cryptography.CngProvider provider) { }
        public AesCng(string keyName, System.Security.Cryptography.CngProvider provider, System.Security.Cryptography.CngKeyOpenOptions openOptions) { }
        public override byte[] Key { get { throw null; } set { } }
        public override int KeySize { get { throw null; } set { } }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor() { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor() { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override void GenerateIV() { }
        public override void GenerateKey() { }
    }
    public sealed partial class CngAlgorithm : System.IEquatable<System.Security.Cryptography.CngAlgorithm>
    {
        public CngAlgorithm(string algorithm) { }
        public string Algorithm { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDiffieHellman { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDiffieHellmanP256 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDiffieHellmanP384 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDiffieHellmanP521 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDsa { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDsaP256 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDsaP384 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm ECDsaP521 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm MD5 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm Rsa { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm Sha1 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm Sha256 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm Sha384 { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithm Sha512 { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.CngAlgorithm other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Security.Cryptography.CngAlgorithm left, System.Security.Cryptography.CngAlgorithm right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.CngAlgorithm left, System.Security.Cryptography.CngAlgorithm right) { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class CngAlgorithmGroup : System.IEquatable<System.Security.Cryptography.CngAlgorithmGroup>
    {
        public CngAlgorithmGroup(string algorithmGroup) { }
        public string AlgorithmGroup { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithmGroup DiffieHellman { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithmGroup Dsa { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithmGroup ECDiffieHellman { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithmGroup ECDsa { get { throw null; } }
        public static System.Security.Cryptography.CngAlgorithmGroup Rsa { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.CngAlgorithmGroup other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Security.Cryptography.CngAlgorithmGroup left, System.Security.Cryptography.CngAlgorithmGroup right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.CngAlgorithmGroup left, System.Security.Cryptography.CngAlgorithmGroup right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum CngExportPolicies
    {
        AllowArchiving = 4,
        AllowExport = 1,
        AllowPlaintextArchiving = 8,
        AllowPlaintextExport = 2,
        None = 0,
    }
    public sealed partial class CngKey : System.IDisposable
    {
        internal CngKey() { }
        public System.Security.Cryptography.CngAlgorithm Algorithm { get { throw null; } }
        public System.Security.Cryptography.CngAlgorithmGroup AlgorithmGroup { get { throw null; } }
        public System.Security.Cryptography.CngExportPolicies ExportPolicy { get { throw null; } }
        public Microsoft.Win32.SafeHandles.SafeNCryptKeyHandle Handle { get { throw null; } }
        public bool IsEphemeral { get { throw null; } }
        public bool IsMachineKey { get { throw null; } }
        public string KeyName { get { throw null; } }
        public int KeySize { get { throw null; } }
        public System.Security.Cryptography.CngKeyUsages KeyUsage { get { throw null; } }
        public System.IntPtr ParentWindowHandle { get { throw null; } set { } }
        public System.Security.Cryptography.CngProvider Provider { get { throw null; } }
        public Microsoft.Win32.SafeHandles.SafeNCryptProviderHandle ProviderHandle { get { throw null; } }
        public System.Security.Cryptography.CngUIPolicy UIPolicy { get { throw null; } }
        public string UniqueName { get { throw null; } }
        public static System.Security.Cryptography.CngKey Create(System.Security.Cryptography.CngAlgorithm algorithm) { throw null; }
        public static System.Security.Cryptography.CngKey Create(System.Security.Cryptography.CngAlgorithm algorithm, string keyName) { throw null; }
        public static System.Security.Cryptography.CngKey Create(System.Security.Cryptography.CngAlgorithm algorithm, string keyName, System.Security.Cryptography.CngKeyCreationParameters creationParameters) { throw null; }
        public void Delete() { }
        public void Dispose() { }
        public static bool Exists(string keyName) { throw null; }
        public static bool Exists(string keyName, System.Security.Cryptography.CngProvider provider) { throw null; }
        public static bool Exists(string keyName, System.Security.Cryptography.CngProvider provider, System.Security.Cryptography.CngKeyOpenOptions options) { throw null; }
        public byte[] Export(System.Security.Cryptography.CngKeyBlobFormat format) { throw null; }
        public System.Security.Cryptography.CngProperty GetProperty(string name, System.Security.Cryptography.CngPropertyOptions options) { throw null; }
        public bool HasProperty(string name, System.Security.Cryptography.CngPropertyOptions options) { throw null; }
        public static System.Security.Cryptography.CngKey Import(byte[] keyBlob, System.Security.Cryptography.CngKeyBlobFormat format) { throw null; }
        public static System.Security.Cryptography.CngKey Import(byte[] keyBlob, System.Security.Cryptography.CngKeyBlobFormat format, System.Security.Cryptography.CngProvider provider) { throw null; }
        public static System.Security.Cryptography.CngKey Open(Microsoft.Win32.SafeHandles.SafeNCryptKeyHandle keyHandle, System.Security.Cryptography.CngKeyHandleOpenOptions keyHandleOpenOptions) { throw null; }
        public static System.Security.Cryptography.CngKey Open(string keyName) { throw null; }
        public static System.Security.Cryptography.CngKey Open(string keyName, System.Security.Cryptography.CngProvider provider) { throw null; }
        public static System.Security.Cryptography.CngKey Open(string keyName, System.Security.Cryptography.CngProvider provider, System.Security.Cryptography.CngKeyOpenOptions openOptions) { throw null; }
        public void SetProperty(System.Security.Cryptography.CngProperty property) { }
    }
    public sealed partial class CngKeyBlobFormat : System.IEquatable<System.Security.Cryptography.CngKeyBlobFormat>
    {
        public CngKeyBlobFormat(string format) { }
        public static System.Security.Cryptography.CngKeyBlobFormat EccFullPrivateBlob { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat EccFullPublicBlob { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat EccPrivateBlob { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat EccPublicBlob { get { throw null; } }
        public string Format { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat GenericPrivateBlob { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat GenericPublicBlob { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat OpaqueTransportBlob { get { throw null; } }
        public static System.Security.Cryptography.CngKeyBlobFormat Pkcs8PrivateBlob { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.CngKeyBlobFormat other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Security.Cryptography.CngKeyBlobFormat left, System.Security.Cryptography.CngKeyBlobFormat right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.CngKeyBlobFormat left, System.Security.Cryptography.CngKeyBlobFormat right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum CngKeyCreationOptions
    {
        MachineKey = 32,
        None = 0,
        OverwriteExistingKey = 128,
    }
    public sealed partial class CngKeyCreationParameters
    {
        public CngKeyCreationParameters() { }
        public System.Nullable<System.Security.Cryptography.CngExportPolicies> ExportPolicy { get { throw null; } set { } }
        public System.Security.Cryptography.CngKeyCreationOptions KeyCreationOptions { get { throw null; } set { } }
        public System.Nullable<System.Security.Cryptography.CngKeyUsages> KeyUsage { get { throw null; } set { } }
        public System.Security.Cryptography.CngPropertyCollection Parameters { get { throw null; } }
        public System.IntPtr ParentWindowHandle { get { throw null; } set { } }
        public System.Security.Cryptography.CngProvider Provider { get { throw null; } set { } }
        public System.Security.Cryptography.CngUIPolicy UIPolicy { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum CngKeyHandleOpenOptions
    {
        EphemeralKey = 1,
        None = 0,
    }
    [System.FlagsAttribute]
    public enum CngKeyOpenOptions
    {
        MachineKey = 32,
        None = 0,
        Silent = 64,
        UserKey = 0,
    }
    [System.FlagsAttribute]
    public enum CngKeyUsages
    {
        AllUsages = 16777215,
        Decryption = 1,
        KeyAgreement = 4,
        None = 0,
        Signing = 2,
    }
    public partial struct CngProperty : System.IEquatable<System.Security.Cryptography.CngProperty>
    {
        public CngProperty(string name, byte[] value, System.Security.Cryptography.CngPropertyOptions options) { throw null; }
        public string Name { get { throw null; } }
        public System.Security.Cryptography.CngPropertyOptions Options { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.CngProperty other) { throw null; }
        public override int GetHashCode() { throw null; }
        public byte[] GetValue() { throw null; }
        public static bool operator ==(System.Security.Cryptography.CngProperty left, System.Security.Cryptography.CngProperty right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.CngProperty left, System.Security.Cryptography.CngProperty right) { throw null; }
    }
    public sealed partial class CngPropertyCollection : System.Collections.ObjectModel.Collection<System.Security.Cryptography.CngProperty>
    {
        public CngPropertyCollection() { }
    }
    [System.FlagsAttribute]
    public enum CngPropertyOptions
    {
        CustomProperty = 1073741824,
        None = 0,
        Persist = -2147483648,
    }
    public sealed partial class CngProvider : System.IEquatable<System.Security.Cryptography.CngProvider>
    {
        public CngProvider(string provider) { }
        public static System.Security.Cryptography.CngProvider MicrosoftSmartCardKeyStorageProvider { get { throw null; } }
        public static System.Security.Cryptography.CngProvider MicrosoftSoftwareKeyStorageProvider { get { throw null; } }
        public string Provider { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Security.Cryptography.CngProvider other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Security.Cryptography.CngProvider left, System.Security.Cryptography.CngProvider right) { throw null; }
        public static bool operator !=(System.Security.Cryptography.CngProvider left, System.Security.Cryptography.CngProvider right) { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class CngUIPolicy
    {
        public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel) { }
        public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel, string friendlyName) { }
        public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel, string friendlyName, string description) { }
        public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel, string friendlyName, string description, string useContext) { }
        public CngUIPolicy(System.Security.Cryptography.CngUIProtectionLevels protectionLevel, string friendlyName, string description, string useContext, string creationTitle) { }
        public string CreationTitle { get { throw null; } }
        public string Description { get { throw null; } }
        public string FriendlyName { get { throw null; } }
        public System.Security.Cryptography.CngUIProtectionLevels ProtectionLevel { get { throw null; } }
        public string UseContext { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum CngUIProtectionLevels
    {
        ForceHighProtection = 2,
        None = 0,
        ProtectKey = 1,
    }
    public sealed partial class ECDsaCng : System.Security.Cryptography.ECDsa
    {
        public ECDsaCng() { }
        public ECDsaCng(int keySize) { }
        public ECDsaCng(System.Security.Cryptography.CngKey key) { }
        public ECDsaCng(System.Security.Cryptography.ECCurve curve) { }
        public System.Security.Cryptography.CngKey Key { get { throw null; } }
        public override int KeySize { get { throw null; } set { } }
        public override System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public override System.Security.Cryptography.ECParameters ExportExplicitParameters(bool includePrivateParameters) { throw null; }
        public override System.Security.Cryptography.ECParameters ExportParameters(bool includePrivateParameters) { throw null; }
        public override void GenerateKey(System.Security.Cryptography.ECCurve curve) { }
        protected override byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        protected override byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public override void ImportParameters(System.Security.Cryptography.ECParameters parameters) { }
        public override byte[] SignHash(byte[] hash) { throw null; }
        public override bool VerifyHash(byte[] hash, byte[] signature) { throw null; }
    }
    public sealed partial class RSACng : System.Security.Cryptography.RSA
    {
        public RSACng() { }
        public RSACng(int keySize) { }
        public RSACng(System.Security.Cryptography.CngKey key) { }
        public System.Security.Cryptography.CngKey Key { get { throw null; } }
        public override System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw null; } }
        public override byte[] Decrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override byte[] Encrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { throw null; }
        public override System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters) { throw null; }
        protected override byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        protected override byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public override void ImportParameters(System.Security.Cryptography.RSAParameters parameters) { }
        public override byte[] SignHash(byte[] hash, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public override bool VerifyHash(byte[] hash, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
    }
    public sealed partial class TripleDESCng : System.Security.Cryptography.TripleDES
    {
        public TripleDESCng() { }
        public TripleDESCng(string keyName) { }
        public TripleDESCng(string keyName, System.Security.Cryptography.CngProvider provider) { }
        public TripleDESCng(string keyName, System.Security.Cryptography.CngProvider provider, System.Security.Cryptography.CngKeyOpenOptions openOptions) { }
        public override byte[] Key { get { throw null; } set { } }
        public override int KeySize { get { throw null; } set { } }
        public override System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw null; } }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor() { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor() { throw null; }
        public override System.Security.Cryptography.ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override void GenerateIV() { }
        public override void GenerateKey() { }
    }
}
