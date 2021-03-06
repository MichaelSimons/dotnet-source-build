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
using System.Runtime.InteropServices;
using System.Security;

[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AllowPartiallyTrustedCallers]
[assembly: ReferenceAssembly]
[assembly: AssemblyTitle("System.Runtime.InteropServices")]
[assembly: AssemblyDescription("System.Runtime.InteropServices")]
[assembly: AssemblyDefaultAlias("System.Runtime.InteropServices")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyProduct("Microsoft® .NET Framework")]
[assembly: AssemblyCopyright("© Microsoft Corporation.  All rights reserved.")]
[assembly: AssemblyFileVersion("1.0.24212.01")]
[assembly: AssemblyInformationalVersion("1.0.24212.01 built by: SOURCEBUILD")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyMetadata("", "")]
[assembly: AssemblyVersion("4.1.0.0")]




namespace System
{
    public sealed partial class DataMisalignedException : System.Exception
    {
        public DataMisalignedException() { }
        public DataMisalignedException(string message) { }
        public DataMisalignedException(string message, System.Exception innerException) { }
    }
    public partial class DllNotFoundException : System.TypeLoadException
    {
        public DllNotFoundException() { }
        public DllNotFoundException(string message) { }
        public DllNotFoundException(string message, System.Exception inner) { }
    }
}
namespace System.Reflection
{
    public sealed partial class Missing
    {
        internal Missing() { }
        public static readonly System.Reflection.Missing Value;
    }
}
namespace System.Runtime.InteropServices
{
    public partial struct ArrayWithOffset
    {
        public ArrayWithOffset(object array, int offset) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Runtime.InteropServices.ArrayWithOffset obj) { throw null; }
        public object GetArray() { throw null; }
        public override int GetHashCode() { throw null; }
        public int GetOffset() { throw null; }
        public static bool operator ==(System.Runtime.InteropServices.ArrayWithOffset a, System.Runtime.InteropServices.ArrayWithOffset b) { throw null; }
        public static bool operator !=(System.Runtime.InteropServices.ArrayWithOffset a, System.Runtime.InteropServices.ArrayWithOffset b) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Interface | System.AttributeTargets.Struct, Inherited=false)]
    public sealed partial class BestFitMappingAttribute : System.Attribute
    {
        public bool ThrowOnUnmappableChar;
        public BestFitMappingAttribute(bool BestFitMapping) { }
        public bool BestFitMapping { get { throw null; } }
    }
    [System.ObsoleteAttribute("BStrWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
    public sealed partial class BStrWrapper
    {
        public BStrWrapper(object value) { }
        public BStrWrapper(string value) { }
        public string WrappedObject { get { throw null; } }
    }
    public enum CallingConvention
    {
        Cdecl = 2,
        StdCall = 3,
        ThisCall = 4,
        Winapi = 1,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class, Inherited=false)]
    public sealed partial class ClassInterfaceAttribute : System.Attribute
    {
        public ClassInterfaceAttribute(short classInterfaceType) { }
        public ClassInterfaceAttribute(System.Runtime.InteropServices.ClassInterfaceType classInterfaceType) { }
        public System.Runtime.InteropServices.ClassInterfaceType Value { get { throw null; } }
    }
    public enum ClassInterfaceType
    {
        [System.ObsoleteAttribute("Support for IDispatch may be unavailable in future releases.")]
        AutoDispatch = 1,
        [System.ObsoleteAttribute("Support for IDispatch may be unavailable in future releases.")]
        AutoDual = 2,
        None = 0,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Interface, Inherited=false)]
    public sealed partial class CoClassAttribute : System.Attribute
    {
        public CoClassAttribute(System.Type coClass) { }
        public System.Type CoClass { get { throw null; } }
    }
    [System.ObsoleteAttribute("ComAwareEventInfo may be unavailable in future releases.")]
    public partial class ComAwareEventInfo : System.Reflection.EventInfo
    {
        public ComAwareEventInfo(System.Type type, string eventName) { }
        public override System.Reflection.EventAttributes Attributes { get { throw null; } }
        public override System.Type DeclaringType { get { throw null; } }
        public override string Name { get { throw null; } }
        public override void AddEventHandler(object target, System.Delegate handler) { }
        public override void RemoveEventHandler(object target, System.Delegate handler) { }
 public override System.Reflection.MethodInfo GetAddMethod(bool nonPublic) { throw null; }
 public override System.Reflection.MethodInfo GetRaiseMethod(bool nonPublic) { throw null; }
 public override System.Reflection.MethodInfo GetRemoveMethod(bool nonPublic) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, Inherited=false)]
    public sealed partial class ComDefaultInterfaceAttribute : System.Attribute
    {
        public ComDefaultInterfaceAttribute(System.Type defaultInterface) { }
        public System.Type Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Interface, Inherited=false)]
    [System.ObsoleteAttribute("ComEventInterfaceAttribute may be unavailable in future releases.")]
    public sealed partial class ComEventInterfaceAttribute : System.Attribute
    {
        public ComEventInterfaceAttribute(System.Type SourceInterface, System.Type EventProvider) { }
        public System.Type EventProvider { get { throw null; } }
        public System.Type SourceInterface { get { throw null; } }
    }
    [System.ObsoleteAttribute("ComEventsHelper may be unavailable in future releases.")]
    public static partial class ComEventsHelper
    {
        public static void Combine(object rcw, System.Guid iid, int dispid, System.Delegate d) { }
        public static System.Delegate Remove(object rcw, System.Guid iid, int dispid, System.Delegate d) { throw null; }
    }
    public partial class COMException : System.Exception
    {
        public COMException() { }
        public COMException(string message) { }
        public COMException(string message, System.Exception inner) { }
        public COMException(string message, int errorCode) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface, Inherited=false)]
    public sealed partial class ComImportAttribute : System.Attribute
    {
        public ComImportAttribute() { }
    }
    public enum ComInterfaceType
    {
        [System.ObsoleteAttribute("Support for IDispatch may be unavailable in future releases.")]
        InterfaceIsDual = 0,
        [System.ObsoleteAttribute("Support for IDispatch may be unavailable in future releases.")]
        InterfaceIsIDispatch = 2,
        InterfaceIsIInspectable = 3,
        InterfaceIsIUnknown = 1,
    }
    public enum ComMemberType
    {
        Method = 0,
        PropGet = 1,
        PropSet = 2,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, Inherited=true)]
    [System.ObsoleteAttribute("ComSourceInterfacesAttribute may be unavailable in future releases.")]
    public sealed partial class ComSourceInterfacesAttribute : System.Attribute
    {
        public ComSourceInterfacesAttribute(string sourceInterfaces) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface1, System.Type sourceInterface2) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface1, System.Type sourceInterface2, System.Type sourceInterface3) { }
        public ComSourceInterfacesAttribute(System.Type sourceInterface1, System.Type sourceInterface2, System.Type sourceInterface3, System.Type sourceInterface4) { }
        public string Value { get { throw null; } }
    }
    [System.ObsoleteAttribute("CurrencyWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
    public sealed partial class CurrencyWrapper
    {
        public CurrencyWrapper(decimal obj) { }
        public CurrencyWrapper(object obj) { }
        public decimal WrappedObject { get { throw null; } }
    }
    [System.ObsoleteAttribute("CustomQueryInterfaceMode and support for ICustomQueryInterface may be unavailable in future releases.")]
    public enum CustomQueryInterfaceMode
    {
        Allow = 1,
        Ignore = 0,
    }
    [System.ObsoleteAttribute("CustomQueryInterfaceResult and support for ICustomQueryInterface may be unavailable in future releases.")]
    public enum CustomQueryInterfaceResult
    {
        Failed = 2,
        Handled = 0,
        NotHandled = 1,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Module, Inherited=false)]
    public sealed partial class DefaultCharSetAttribute : System.Attribute
    {
        public DefaultCharSetAttribute(System.Runtime.InteropServices.CharSet charSet) { }
        public System.Runtime.InteropServices.CharSet CharSet { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Method, AllowMultiple=false)]
    public sealed partial class DefaultDllImportSearchPathsAttribute : System.Attribute
    {
        public DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath paths) { }
        public System.Runtime.InteropServices.DllImportSearchPath Paths { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter)]
    public sealed partial class DefaultParameterValueAttribute : System.Attribute
    {
        public DefaultParameterValueAttribute(object value) { }
        public object Value { get { throw null; } }
    }
    [System.ObsoleteAttribute("DispatchWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
    public sealed partial class DispatchWrapper
    {
        public DispatchWrapper(object obj) { }
        public object WrappedObject { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Event | System.AttributeTargets.Field | System.AttributeTargets.Method | System.AttributeTargets.Property, Inherited=false)]
    public sealed partial class DispIdAttribute : System.Attribute
    {
        public DispIdAttribute(int dispId) { }
        public int Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class DllImportAttribute : System.Attribute
    {
        public bool BestFitMapping;
        public System.Runtime.InteropServices.CallingConvention CallingConvention;
        public System.Runtime.InteropServices.CharSet CharSet;
        public string EntryPoint;
        public bool ExactSpelling;
        public bool PreserveSig;
        public bool SetLastError;
        public bool ThrowOnUnmappableChar;
        public DllImportAttribute(string dllName) { }
        public string Value { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum DllImportSearchPath
    {
        ApplicationDirectory = 512,
        AssemblyDirectory = 2,
        LegacyBehavior = 0,
        SafeDirectories = 4096,
        System32 = 2048,
        UseDllDirectoryForDependencies = 256,
        UserDirectories = 1024,
    }
    [System.ObsoleteAttribute("ErrorWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
    public sealed partial class ErrorWrapper
    {
        public ErrorWrapper(System.Exception e) { }
        public ErrorWrapper(int errorCode) { }
        public ErrorWrapper(object errorCode) { }
        public int ErrorCode { get { throw null; } }
    }
    public partial struct GCHandle
    {
        public bool IsAllocated { get { throw null; } }
        public object Target { get { throw null; } set { } }
        public System.IntPtr AddrOfPinnedObject() { throw null; }
        public static System.Runtime.InteropServices.GCHandle Alloc(object value) { throw null; }
        public static System.Runtime.InteropServices.GCHandle Alloc(object value, System.Runtime.InteropServices.GCHandleType type) { throw null; }
        public override bool Equals(object o) { throw null; }
        public void Free() { }
        public static System.Runtime.InteropServices.GCHandle FromIntPtr(System.IntPtr value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Runtime.InteropServices.GCHandle a, System.Runtime.InteropServices.GCHandle b) { throw null; }
        public static explicit operator System.Runtime.InteropServices.GCHandle (System.IntPtr value) { throw null; }
        public static explicit operator System.IntPtr (System.Runtime.InteropServices.GCHandle value) { throw null; }
        public static bool operator !=(System.Runtime.InteropServices.GCHandle a, System.Runtime.InteropServices.GCHandle b) { throw null; }
        public static System.IntPtr ToIntPtr(System.Runtime.InteropServices.GCHandle value) { throw null; }
    }
    public enum GCHandleType
    {
        Normal = 2,
        Pinned = 3,
        Weak = 0,
        WeakTrackResurrection = 1,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Interface | System.AttributeTargets.Struct, Inherited=false)]
    public sealed partial class GuidAttribute : System.Attribute
    {
        public GuidAttribute(string guid) { }
        public string Value { get { throw null; } }
    }
    public sealed partial class HandleCollector
    {
        public HandleCollector(string name, int initialThreshold) { }
        public HandleCollector(string name, int initialThreshold, int maximumThreshold) { }
        public int Count { get { throw null; } }
        public int InitialThreshold { get { throw null; } }
        public int MaximumThreshold { get { throw null; } }
        public string Name { get { throw null; } }
        public void Add() { }
        public void Remove() { }
    }
    [System.ObsoleteAttribute("ICustomAdapter may be unavailable in future releases.")]
    public partial interface ICustomAdapter
    {
        object GetUnderlyingObject();
    }
    [System.ObsoleteAttribute("ICustomQueryInterface may be unavailable in future releases.")]
    public partial interface ICustomQueryInterface
    {
        System.Runtime.InteropServices.CustomQueryInterfaceResult GetInterface(ref System.Guid iid, out System.IntPtr ppv);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, Inherited=false)]
    public sealed partial class InAttribute : System.Attribute
    {
        public InAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Interface, Inherited=false)]
    public sealed partial class InterfaceTypeAttribute : System.Attribute
    {
        public InterfaceTypeAttribute(short interfaceType) { }
        public InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType interfaceType) { }
        public System.Runtime.InteropServices.ComInterfaceType Value { get { throw null; } }
    }
    public partial class InvalidComObjectException : System.Exception
    {
        public InvalidComObjectException() { }
        public InvalidComObjectException(string message) { }
        public InvalidComObjectException(string message, System.Exception inner) { }
    }
    public partial class InvalidOleVariantTypeException : System.Exception
    {
        public InvalidOleVariantTypeException() { }
        public InvalidOleVariantTypeException(string message) { }
        public InvalidOleVariantTypeException(string message, System.Exception inner) { }
    }
    public static partial class Marshal
    {
        public static readonly int SystemDefaultCharSize;
        public static readonly int SystemMaxDBCSCharSize;
        public static int AddRef(System.IntPtr pUnk) { throw null; }
        public static System.IntPtr AllocCoTaskMem(int cb) { throw null; }
        public static System.IntPtr AllocHGlobal(int cb) { throw null; }
        public static System.IntPtr AllocHGlobal(System.IntPtr cb) { throw null; }
        public static bool AreComObjectsAvailableForCleanup() { throw null; }
        public static void Copy(byte[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(char[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(double[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(short[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(int[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(long[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(System.IntPtr source, byte[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, char[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, double[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, short[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, int[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, long[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, System.IntPtr[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr source, float[] destination, int startIndex, int length) { }
        public static void Copy(System.IntPtr[] source, int startIndex, System.IntPtr destination, int length) { }
        public static void Copy(float[] source, int startIndex, System.IntPtr destination, int length) { }
        [System.ObsoleteAttribute("CreateAggregatedObject(IntPtr, Object) may be unavailable in future releases. Instead, use CreateAggregatedObject<T>(IntPtr, T). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296518")]
        public static System.IntPtr CreateAggregatedObject(System.IntPtr pOuter, object o) { throw null; }
        public static System.IntPtr CreateAggregatedObject<T>(System.IntPtr pOuter, T o) { throw null; }
        [System.ObsoleteAttribute("CreateWrapperOfType(Object, Type) may be unavailable in future releases. Instead, use CreateWrapperOfType<T,T2>(T). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296519")]
        public static object CreateWrapperOfType(object o, System.Type t) { throw null; }
        public static TWrapper CreateWrapperOfType<T, TWrapper>(T o) { throw null; }
        [System.ObsoleteAttribute("DestroyStructure(IntPtr, Type) may be unavailable in future releases. Instead, use DestroyStructure<T>(IntPtr). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296520")]
        public static void DestroyStructure(System.IntPtr ptr, System.Type structuretype) { }
        public static void DestroyStructure<T>(System.IntPtr ptr) { }
        public static int FinalReleaseComObject(object o) { throw null; }
        public static void FreeBSTR(System.IntPtr ptr) { }
        public static void FreeCoTaskMem(System.IntPtr ptr) { }
        public static void FreeHGlobal(System.IntPtr hglobal) { }
        [System.ObsoleteAttribute("GetComInterfaceForObject(Object, Type) may be unavailable in future releases. Instead, use GetComInterfaceForObject<T,T2>(T). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296509")]
        public static System.IntPtr GetComInterfaceForObject(object o, System.Type T) { throw null; }
        [System.ObsoleteAttribute("GetComInterfaceForObject(Object, Type, CustomQueryInterfaceMode) and support for ICustomQueryInterface may be unavailable in future releases.")]
        public static System.IntPtr GetComInterfaceForObject(object o, System.Type T, System.Runtime.InteropServices.CustomQueryInterfaceMode mode) { throw null; }
        public static System.IntPtr GetComInterfaceForObject<T, TInterface>(T o) { throw null; }
        [System.ObsoleteAttribute("GetDelegateForFunctionPointer(IntPtr, Type) may be unavailable in future releases. Instead, use GetDelegateForFunctionPointer<T>(IntPtr). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296521")]
        public static System.Delegate GetDelegateForFunctionPointer(System.IntPtr ptr, System.Type t) { throw null; }
        public static TDelegate GetDelegateForFunctionPointer<TDelegate>(System.IntPtr ptr) { throw null; }
        [System.ObsoleteAttribute("GetExceptionCode() may be unavailable in future releases.")]
        public static int GetExceptionCode() { throw null; }
        public static System.Exception GetExceptionForHR(int errorCode) { throw null; }
        public static System.Exception GetExceptionForHR(int errorCode, System.IntPtr errorInfo) { throw null; }
        [System.ObsoleteAttribute("GetFunctionPointerForDelegate(Delegate) may be unavailable in future releases. Instead, use GetFunctionPointerForDelegate<T>(T). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296522")]
        public static System.IntPtr GetFunctionPointerForDelegate(System.Delegate d) { throw null; }
        public static System.IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { throw null; }
        public static int GetHRForException(System.Exception e) { throw null; }
        public static int GetHRForLastWin32Error() { throw null; }
        public static System.IntPtr GetIUnknownForObject(object o) { throw null; }
        public static int GetLastWin32Error() { throw null; }
        [System.ObsoleteAttribute("GetNativeVariantForObject(Object, IntPtr) may be unavailable in future releases.")]
        public static void GetNativeVariantForObject(object obj, System.IntPtr pDstNativeVariant) { }
        [System.ObsoleteAttribute("GetNativeVariantForObject<T>(T, IntPtr) may be unavailable in future releases.")]
        public static void GetNativeVariantForObject<T>(T obj, System.IntPtr pDstNativeVariant) { }
        public static object GetObjectForIUnknown(System.IntPtr pUnk) { throw null; }
        [System.ObsoleteAttribute("GetObjectForNativeVariant(IntPtr) may be unavailable in future releases.")]
        public static object GetObjectForNativeVariant(System.IntPtr pSrcNativeVariant) { throw null; }
        [System.ObsoleteAttribute("GetObjectForNativeVariant<T>(IntPtr) may be unavailable in future releases.")]
        public static T GetObjectForNativeVariant<T>(System.IntPtr pSrcNativeVariant) { throw null; }
        [System.ObsoleteAttribute("GetObjectsForNativeVariants(IntPtr, Int32) may be unavailable in future releases.")]
        public static object[] GetObjectsForNativeVariants(System.IntPtr aSrcNativeVariant, int cVars) { throw null; }
        [System.ObsoleteAttribute("GetObjectsForNativeVariants<T>(IntPtr, Int32) may be unavailable in future releases.")]
        public static T[] GetObjectsForNativeVariants<T>(System.IntPtr aSrcNativeVariant, int cVars) { throw null; }
        public static int GetStartComSlot(System.Type t) { throw null; }
        public static System.Type GetTypeFromCLSID(System.Guid clsid) { throw null; }
        public static string GetTypeInfoName(System.Runtime.InteropServices.ComTypes.ITypeInfo typeInfo) { throw null; }
        public static object GetUniqueObjectForIUnknown(System.IntPtr unknown) { throw null; }
        public static bool IsComObject(object o) { throw null; }
        [System.ObsoleteAttribute("OffsetOf(Type, string) may be unavailable in future releases. Instead, use OffsetOf<T>(string). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296511")]
        public static System.IntPtr OffsetOf(System.Type t, string fieldName) { throw null; }
        public static System.IntPtr OffsetOf<T>(string fieldName) { throw null; }
        public static string PtrToStringAnsi(System.IntPtr ptr) { throw null; }
        public static string PtrToStringAnsi(System.IntPtr ptr, int len) { throw null; }
        public static string PtrToStringBSTR(System.IntPtr ptr) { throw null; }
        public static string PtrToStringUni(System.IntPtr ptr) { throw null; }
        public static string PtrToStringUni(System.IntPtr ptr, int len) { throw null; }
        [System.ObsoleteAttribute("PtrToStructure(IntPtr, Object) may be unavailable in future releases. Instead, use PtrToStructure<T>(IntPtr). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296512")]
        public static void PtrToStructure(System.IntPtr ptr, object structure) { }
        [System.ObsoleteAttribute("PtrToStructure(IntPtr, Type) may be unavailable in future releases. Instead, use PtrToStructure<T>(IntPtr). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296513")]
        public static object PtrToStructure(System.IntPtr ptr, System.Type structureType) { throw null; }
        public static T PtrToStructure<T>(System.IntPtr ptr) { throw null; }
        public static void PtrToStructure<T>(System.IntPtr ptr, T structure) { }
        public static int QueryInterface(System.IntPtr pUnk, ref System.Guid iid, out System.IntPtr ppv) { throw null; }
        public static byte ReadByte(System.IntPtr ptr) { throw null; }
        public static byte ReadByte(System.IntPtr ptr, int ofs) { throw null; }
        [System.ObsoleteAttribute("ReadByte(Object, Int32) may be unavailable in future releases.")]
        public static byte ReadByte(object ptr, int ofs) { throw null; }
        public static short ReadInt16(System.IntPtr ptr) { throw null; }
        public static short ReadInt16(System.IntPtr ptr, int ofs) { throw null; }
        [System.ObsoleteAttribute("ReadInt16(Object, Int32) may be unavailable in future releases.")]
        public static short ReadInt16(object ptr, int ofs) { throw null; }
        public static int ReadInt32(System.IntPtr ptr) { throw null; }
        public static int ReadInt32(System.IntPtr ptr, int ofs) { throw null; }
        [System.ObsoleteAttribute("ReadInt32(Object, Int32) may be unavailable in future releases.")]
        public static int ReadInt32(object ptr, int ofs) { throw null; }
        public static long ReadInt64(System.IntPtr ptr) { throw null; }
        public static long ReadInt64(System.IntPtr ptr, int ofs) { throw null; }
        [System.ObsoleteAttribute("ReadInt64(Object, Int32) may be unavailable in future releases.")]
        public static long ReadInt64(object ptr, int ofs) { throw null; }
        public static System.IntPtr ReadIntPtr(System.IntPtr ptr) { throw null; }
        public static System.IntPtr ReadIntPtr(System.IntPtr ptr, int ofs) { throw null; }
        [System.ObsoleteAttribute("ReadIntPtr(Object, Int32) may be unavailable in future releases.")]
        public static System.IntPtr ReadIntPtr(object ptr, int ofs) { throw null; }
        public static System.IntPtr ReAllocCoTaskMem(System.IntPtr pv, int cb) { throw null; }
        public static System.IntPtr ReAllocHGlobal(System.IntPtr pv, System.IntPtr cb) { throw null; }
        public static int Release(System.IntPtr pUnk) { throw null; }
        public static int ReleaseComObject(object o) { throw null; }
        [System.ObsoleteAttribute("SizeOf(Object) may be unavailable in future releases. Instead, use SizeOf<T>(). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296514")]
        public static int SizeOf(object structure) { throw null; }
        [System.ObsoleteAttribute("SizeOf(Type) may be unavailable in future releases. Instead, use SizeOf<T>(). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296515")]
        public static int SizeOf(System.Type t) { throw null; }
        public static int SizeOf<T>() { throw null; }
        public static int SizeOf<T>(T structure) { throw null; }
        public static System.IntPtr StringToBSTR(string s) { throw null; }
        public static System.IntPtr StringToCoTaskMemAnsi(string s) { throw null; }
        public static System.IntPtr StringToCoTaskMemUni(string s) { throw null; }
        public static System.IntPtr StringToHGlobalAnsi(string s) { throw null; }
        public static System.IntPtr StringToHGlobalUni(string s) { throw null; }
        [System.ObsoleteAttribute("StructureToPtr(Object, IntPtr, Boolean) may be unavailable in future releases. Instead, use StructureToPtr<T>(T, IntPtr, Boolean). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296516")]
        public static void StructureToPtr(object structure, System.IntPtr ptr, bool fDeleteOld) { }
        public static void StructureToPtr<T>(T structure, System.IntPtr ptr, bool fDeleteOld) { }
        public static void ThrowExceptionForHR(int errorCode) { }
        public static void ThrowExceptionForHR(int errorCode, System.IntPtr errorInfo) { }
        [System.ObsoleteAttribute("UnsafeAddrOfPinnedArrayElement(Array, Int32) may be unavailable in future releases. Instead, use UnsafeAddrOfPinnedArrayElement<T>(T[], Int32). For more info, go to http://go.microsoft.com/fwlink/?LinkID=296517")]
        public static System.IntPtr UnsafeAddrOfPinnedArrayElement(System.Array arr, int index) { throw null; }
        public static System.IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { throw null; }
        public static void WriteByte(System.IntPtr ptr, byte val) { }
        public static void WriteByte(System.IntPtr ptr, int ofs, byte val) { }
        [System.ObsoleteAttribute("WriteByte(Object, Int32, Byte) may be unavailable in future releases.")]
        public static void WriteByte(object ptr, int ofs, byte val) { }
        public static void WriteInt16(System.IntPtr ptr, char val) { }
        public static void WriteInt16(System.IntPtr ptr, short val) { }
        public static void WriteInt16(System.IntPtr ptr, int ofs, char val) { }
        public static void WriteInt16(System.IntPtr ptr, int ofs, short val) { }
        [System.ObsoleteAttribute("WriteInt16(Object, Int32, Char) may be unavailable in future releases.")]
        public static void WriteInt16(object ptr, int ofs, char val) { }
        [System.ObsoleteAttribute("WriteInt16(Object, Int32, Int16) may be unavailable in future releases.")]
        public static void WriteInt16(object ptr, int ofs, short val) { }
        public static void WriteInt32(System.IntPtr ptr, int val) { }
        public static void WriteInt32(System.IntPtr ptr, int ofs, int val) { }
        [System.ObsoleteAttribute("WriteInt32(Object, Int32, Int32) may be unavailable in future releases.")]
        public static void WriteInt32(object ptr, int ofs, int val) { }
        public static void WriteInt64(System.IntPtr ptr, int ofs, long val) { }
        public static void WriteInt64(System.IntPtr ptr, long val) { }
        [System.ObsoleteAttribute("WriteInt64(Object, Int32, Int64) may be unavailable in future releases.")]
        public static void WriteInt64(object ptr, int ofs, long val) { }
        public static void WriteIntPtr(System.IntPtr ptr, int ofs, System.IntPtr val) { }
        public static void WriteIntPtr(System.IntPtr ptr, System.IntPtr val) { }
        [System.ObsoleteAttribute("WriteIntPtr(Object, Int32, IntPtr) may be unavailable in future releases.")]
        public static void WriteIntPtr(object ptr, int ofs, System.IntPtr val) { }
        public static void ZeroFreeBSTR(System.IntPtr s) { }
        public static void ZeroFreeCoTaskMemAnsi(System.IntPtr s) { }
        public static void ZeroFreeCoTaskMemUnicode(System.IntPtr s) { }
        public static void ZeroFreeGlobalAllocAnsi(System.IntPtr s) { }
        public static void ZeroFreeGlobalAllocUnicode(System.IntPtr s) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.ReturnValue, Inherited=false)]
    public sealed partial class MarshalAsAttribute : System.Attribute
    {
        public System.Runtime.InteropServices.UnmanagedType ArraySubType;
        public int IidParameterIndex;
        public string MarshalCookie;
        public string MarshalType;
        public System.Type MarshalTypeRef;
        public System.Runtime.InteropServices.VarEnum SafeArraySubType;
        public System.Type SafeArrayUserDefinedSubType;
        public int SizeConst;
        public short SizeParamIndex;
        public MarshalAsAttribute(short unmanagedType) { }
        public MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType unmanagedType) { }
        public System.Runtime.InteropServices.UnmanagedType Value { get { throw null; } }
    }
    public partial class MarshalDirectiveException : System.Exception
    {
        public MarshalDirectiveException() { }
        public MarshalDirectiveException(string message) { }
        public MarshalDirectiveException(string message, System.Exception inner) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter, Inherited=false)]
    public sealed partial class OptionalAttribute : System.Attribute
    {
        public OptionalAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class PreserveSigAttribute : System.Attribute
    {
        public PreserveSigAttribute() { }
    }
    public partial class SafeArrayRankMismatchException : System.Exception
    {
        public SafeArrayRankMismatchException() { }
        public SafeArrayRankMismatchException(string message) { }
        public SafeArrayRankMismatchException(string message, System.Exception inner) { }
    }
    public partial class SafeArrayTypeMismatchException : System.Exception
    {
        public SafeArrayTypeMismatchException() { }
        public SafeArrayTypeMismatchException(string message) { }
        public SafeArrayTypeMismatchException(string message, System.Exception inner) { }
    }
    public abstract partial class SafeBuffer : System.Runtime.InteropServices.SafeHandle
    {
        protected SafeBuffer(bool ownsHandle) : base (default(System.IntPtr), default(bool)) { }
        [System.CLSCompliantAttribute(false)]
        public ulong ByteLength { get { throw null; } }
        public override bool IsInvalid { get { throw null; } }
        [System.CLSCompliantAttribute(false)]
        public unsafe void AcquirePointer(ref byte* pointer) { }
        [System.CLSCompliantAttribute(false)]
        public void Initialize(uint numElements, uint sizeOfEachElement) { }
        [System.CLSCompliantAttribute(false)]
        public void Initialize(ulong numBytes) { }
        [System.CLSCompliantAttribute(false)]
        public void Initialize<T>(uint numElements) where T : struct { }
        [System.CLSCompliantAttribute(false)]
        public void ReadArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct { }
        [System.CLSCompliantAttribute(false)]
        public T Read<T>(ulong byteOffset) where T : struct { throw null; }
        public void ReleasePointer() { }
        [System.CLSCompliantAttribute(false)]
        public void WriteArray<T>(ulong byteOffset, T[] array, int index, int count) where T : struct { }
        [System.CLSCompliantAttribute(false)]
        public void Write<T>(ulong byteOffset, T value) where T : struct { }
    }
    public partial class SEHException : System.Exception
    {
        public SEHException() { }
        public SEHException(string message) { }
        public SEHException(string message, System.Exception inner) { }
        public virtual bool CanResume() { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Delegate | System.AttributeTargets.Enum | System.AttributeTargets.Interface | System.AttributeTargets.Struct, AllowMultiple=false, Inherited=false)]
    public sealed partial class TypeIdentifierAttribute : System.Attribute
    {
        public TypeIdentifierAttribute() { }
        public TypeIdentifierAttribute(string scope, string identifier) { }
        public string Identifier { get { throw null; } }
        public string Scope { get { throw null; } }
    }
    [System.ObsoleteAttribute("UnknownWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
    public sealed partial class UnknownWrapper
    {
        public UnknownWrapper(object obj) { }
        public object WrappedObject { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Delegate, AllowMultiple=false, Inherited=false)]
    public sealed partial class UnmanagedFunctionPointerAttribute : System.Attribute
    {
        public bool BestFitMapping;
        public System.Runtime.InteropServices.CharSet CharSet;
        public bool SetLastError;
        public bool ThrowOnUnmappableChar;
        public UnmanagedFunctionPointerAttribute(System.Runtime.InteropServices.CallingConvention callingConvention) { }
        public System.Runtime.InteropServices.CallingConvention CallingConvention { get { throw null; } }
    }
    public enum UnmanagedType
    {
        [System.ObsoleteAttribute("Marshalling as AnsiBStr may be unavailable in future releases.")]
        AnsiBStr = 35,
        [System.ObsoleteAttribute("Marshalling arbitrary types may be unavailable in future releases. Please specify the type you wish to marshal as.")]
        AsAny = 40,
        Bool = 2,
        BStr = 19,
        ByValArray = 30,
        ByValTStr = 23,
        [System.ObsoleteAttribute("Marshalling as Currency may be unavailable in future releases.")]
        Currency = 15,
        Error = 45,
        FunctionPtr = 38,
        HString = 47,
        I1 = 3,
        I2 = 5,
        I4 = 7,
        I8 = 9,
        [System.ObsoleteAttribute("Marshalling as IDispatch may be unavailable in future releases.")]
        IDispatch = 26,
        IInspectable = 46,
        Interface = 28,
        IUnknown = 25,
        LPArray = 42,
        LPStr = 20,
        LPStruct = 43,
        LPTStr = 22,
        LPWStr = 21,
        R4 = 11,
        R8 = 12,
        [System.ObsoleteAttribute("Marshalling as SafeArray may be unavailable in future releases.")]
        SafeArray = 29,
        [System.ObsoleteAttribute("Applying UnmanagedType.Struct is unnecessary when marshalling a struct. Support for UnmanagedType.Struct when marshalling a reference type may be unavailable in future releases.")]
        Struct = 27,
        SysInt = 31,
        SysUInt = 32,
        [System.ObsoleteAttribute("Marshalling as TBstr may be unavailable in future releases.")]
        TBStr = 36,
        U1 = 4,
        U2 = 6,
        U4 = 8,
        U8 = 10,
        [System.ObsoleteAttribute("Marshalling as VariantBool may be unavailable in future releases.")]
        VariantBool = 37,
        [System.ObsoleteAttribute("Marshalling as VBByRefString may be unavailable in future releases.")]
        VBByRefStr = 34,
    }
    [System.ObsoleteAttribute("Marshalling VARIANTs may be unavailable in future releases.")]
    public enum VarEnum
    {
        VT_ARRAY = 8192,
        VT_BLOB = 65,
        VT_BLOB_OBJECT = 70,
        VT_BOOL = 11,
        VT_BSTR = 8,
        VT_BYREF = 16384,
        VT_CARRAY = 28,
        VT_CF = 71,
        VT_CLSID = 72,
        VT_CY = 6,
        VT_DATE = 7,
        VT_DECIMAL = 14,
        VT_DISPATCH = 9,
        VT_EMPTY = 0,
        VT_ERROR = 10,
        VT_FILETIME = 64,
        VT_HRESULT = 25,
        VT_I1 = 16,
        VT_I2 = 2,
        VT_I4 = 3,
        VT_I8 = 20,
        VT_INT = 22,
        VT_LPSTR = 30,
        VT_LPWSTR = 31,
        VT_NULL = 1,
        VT_PTR = 26,
        VT_R4 = 4,
        VT_R8 = 5,
        VT_RECORD = 36,
        VT_SAFEARRAY = 27,
        VT_STORAGE = 67,
        VT_STORED_OBJECT = 69,
        VT_STREAM = 66,
        VT_STREAMED_OBJECT = 68,
        VT_UI1 = 17,
        VT_UI2 = 18,
        VT_UI4 = 19,
        VT_UI8 = 21,
        VT_UINT = 23,
        VT_UNKNOWN = 13,
        VT_USERDEFINED = 29,
        VT_VARIANT = 12,
        VT_VECTOR = 4096,
        VT_VOID = 24,
    }
    [System.ObsoleteAttribute("VariantWrapper and support for marshalling to the VARIANT type may be unavailable in future releases.")]
    public sealed partial class VariantWrapper
    {
        public VariantWrapper(object obj) { }
        public object WrappedObject { get { throw null; } }
    }
}
namespace System.Runtime.InteropServices.ComTypes
{
    [System.FlagsAttribute]
    public enum ADVF
    {
        ADVFCACHE_FORCEBUILTIN = 16,
        ADVFCACHE_NOHANDLER = 8,
        ADVFCACHE_ONSAVE = 32,
        ADVF_DATAONSTOP = 64,
        ADVF_NODATA = 1,
        ADVF_ONLYONCE = 4,
        ADVF_PRIMEFIRST = 2,
    }
    public partial struct BINDPTR
    {
        public System.IntPtr lpfuncdesc;
        public System.IntPtr lptcomp;
        public System.IntPtr lpvardesc;
    }
    public partial struct BIND_OPTS
    {
        public int cbStruct;
        public int dwTickCountDeadline;
        public int grfFlags;
        public int grfMode;
    }
    public enum CALLCONV
    {
        CC_CDECL = 1,
        CC_MACPASCAL = 3,
        CC_MAX = 9,
        CC_MPWCDECL = 7,
        CC_MPWPASCAL = 8,
        CC_MSCPASCAL = 2,
        CC_PASCAL = 2,
        CC_RESERVED = 5,
        CC_STDCALL = 4,
        CC_SYSCALL = 6,
    }
    public partial struct CONNECTDATA
    {
        public int dwCookie;
        public object pUnk;
    }
    public enum DATADIR
    {
        DATADIR_GET = 1,
        DATADIR_SET = 2,
    }
    public enum DESCKIND
    {
        DESCKIND_FUNCDESC = 1,
        DESCKIND_IMPLICITAPPOBJ = 4,
        DESCKIND_MAX = 5,
        DESCKIND_NONE = 0,
        DESCKIND_TYPECOMP = 3,
        DESCKIND_VARDESC = 2,
    }
    public partial struct DISPPARAMS
    {
        public int cArgs;
        public int cNamedArgs;
        public System.IntPtr rgdispidNamedArgs;
        public System.IntPtr rgvarg;
    }
    [System.FlagsAttribute]
    public enum DVASPECT
    {
        DVASPECT_CONTENT = 1,
        DVASPECT_DOCPRINT = 8,
        DVASPECT_ICON = 4,
        DVASPECT_THUMBNAIL = 2,
    }
    public partial struct ELEMDESC
    {
        public System.Runtime.InteropServices.ComTypes.ELEMDESC.DESCUNION desc;
        public System.Runtime.InteropServices.ComTypes.TYPEDESC tdesc;
        public partial struct DESCUNION
        {
            public System.Runtime.InteropServices.ComTypes.IDLDESC idldesc;
            public System.Runtime.InteropServices.ComTypes.PARAMDESC paramdesc;
        }
    }
    public partial struct EXCEPINFO
    {
        public string bstrDescription;
        public string bstrHelpFile;
        public string bstrSource;
        public int dwHelpContext;
        public System.IntPtr pfnDeferredFillIn;
        public System.IntPtr pvReserved;
        public int scode;
        public short wCode;
        public short wReserved;
    }
    public partial struct FILETIME
    {
        public int dwHighDateTime;
        public int dwLowDateTime;
    }
    public partial struct FORMATETC
    {
        public short cfFormat;
        public System.Runtime.InteropServices.ComTypes.DVASPECT dwAspect;
        public int lindex;
        public System.IntPtr ptd;
        public System.Runtime.InteropServices.ComTypes.TYMED tymed;
    }
    public partial struct FUNCDESC
    {
        public System.Runtime.InteropServices.ComTypes.CALLCONV callconv;
        public short cParams;
        public short cParamsOpt;
        public short cScodes;
        public System.Runtime.InteropServices.ComTypes.ELEMDESC elemdescFunc;
        public System.Runtime.InteropServices.ComTypes.FUNCKIND funckind;
        public System.Runtime.InteropServices.ComTypes.INVOKEKIND invkind;
        public System.IntPtr lprgelemdescParam;
        public System.IntPtr lprgscode;
        public int memid;
        public short oVft;
        public short wFuncFlags;
    }
    [System.FlagsAttribute]
    public enum FUNCFLAGS : short
    {
        FUNCFLAG_FBINDABLE = (short)4,
        FUNCFLAG_FDEFAULTBIND = (short)32,
        FUNCFLAG_FDEFAULTCOLLELEM = (short)256,
        FUNCFLAG_FDISPLAYBIND = (short)16,
        FUNCFLAG_FHIDDEN = (short)64,
        FUNCFLAG_FIMMEDIATEBIND = (short)4096,
        FUNCFLAG_FNONBROWSABLE = (short)1024,
        FUNCFLAG_FREPLACEABLE = (short)2048,
        FUNCFLAG_FREQUESTEDIT = (short)8,
        FUNCFLAG_FRESTRICTED = (short)1,
        FUNCFLAG_FSOURCE = (short)2,
        FUNCFLAG_FUIDEFAULT = (short)512,
        FUNCFLAG_FUSESGETLASTERROR = (short)128,
    }
    public enum FUNCKIND
    {
        FUNC_DISPATCH = 4,
        FUNC_NONVIRTUAL = 2,
        FUNC_PUREVIRTUAL = 1,
        FUNC_STATIC = 3,
        FUNC_VIRTUAL = 0,
    }
    public partial interface IAdviseSink
    {
        void OnClose();
        void OnDataChange(ref System.Runtime.InteropServices.ComTypes.FORMATETC format, ref System.Runtime.InteropServices.ComTypes.STGMEDIUM stgmedium);
        void OnRename(System.Runtime.InteropServices.ComTypes.IMoniker moniker);
        void OnSave();
        void OnViewChange(int aspect, int index);
    }
    public partial interface IBindCtx
    {
        void EnumObjectParam(out System.Runtime.InteropServices.ComTypes.IEnumString ppenum);
        void GetBindOptions(ref System.Runtime.InteropServices.ComTypes.BIND_OPTS pbindopts);
        void GetObjectParam(string pszKey, out object ppunk);
        void GetRunningObjectTable(out System.Runtime.InteropServices.ComTypes.IRunningObjectTable pprot);
        void RegisterObjectBound(object punk);
        void RegisterObjectParam(string pszKey, object punk);
        void ReleaseBoundObjects();
        void RevokeObjectBound(object punk);
        int RevokeObjectParam(string pszKey);
        void SetBindOptions(ref System.Runtime.InteropServices.ComTypes.BIND_OPTS pbindopts);
    }
    public partial interface IConnectionPoint
    {
        void Advise(object pUnkSink, out int pdwCookie);
        void EnumConnections(out System.Runtime.InteropServices.ComTypes.IEnumConnections ppEnum);
        void GetConnectionInterface(out System.Guid pIID);
        void GetConnectionPointContainer(out System.Runtime.InteropServices.ComTypes.IConnectionPointContainer ppCPC);
        void Unadvise(int dwCookie);
    }
    public partial interface IConnectionPointContainer
    {
        void EnumConnectionPoints(out System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints ppEnum);
        void FindConnectionPoint(ref System.Guid riid, out System.Runtime.InteropServices.ComTypes.IConnectionPoint ppCP);
    }
    public partial struct IDLDESC
    {
        public System.IntPtr dwReserved;
        public System.Runtime.InteropServices.ComTypes.IDLFLAG wIDLFlags;
    }
    [System.FlagsAttribute]
    public enum IDLFLAG : short
    {
        IDLFLAG_FIN = (short)1,
        IDLFLAG_FLCID = (short)4,
        IDLFLAG_FOUT = (short)2,
        IDLFLAG_FRETVAL = (short)8,
        IDLFLAG_NONE = (short)0,
    }
    public partial interface IEnumConnectionPoints
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumConnectionPoints ppenum);
        int Next(int celt, System.Runtime.InteropServices.ComTypes.IConnectionPoint[] rgelt, System.IntPtr pceltFetched);
        void Reset();
        int Skip(int celt);
    }
    public partial interface IEnumConnections
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumConnections ppenum);
        int Next(int celt, System.Runtime.InteropServices.ComTypes.CONNECTDATA[] rgelt, System.IntPtr pceltFetched);
        void Reset();
        int Skip(int celt);
    }
    public partial interface IEnumFORMATETC
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumFORMATETC newEnum);
        int Next(int celt, System.Runtime.InteropServices.ComTypes.FORMATETC[] rgelt, int[] pceltFetched);
        int Reset();
        int Skip(int celt);
    }
    public partial interface IEnumMoniker
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumMoniker ppenum);
        int Next(int celt, System.Runtime.InteropServices.ComTypes.IMoniker[] rgelt, System.IntPtr pceltFetched);
        void Reset();
        int Skip(int celt);
    }
    public partial interface IEnumString
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IEnumString ppenum);
        int Next(int celt, string[] rgelt, System.IntPtr pceltFetched);
        void Reset();
        int Skip(int celt);
    }
    public partial interface IEnumVARIANT
    {
        System.Runtime.InteropServices.ComTypes.IEnumVARIANT Clone();
        int Next(int celt, object[] rgVar, System.IntPtr pceltFetched);
        int Reset();
        int Skip(int celt);
    }
    public partial interface IMoniker
    {
        void BindToObject(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, ref System.Guid riidResult, out object ppvResult);
        void BindToStorage(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, ref System.Guid riid, out object ppvObj);
        void CommonPrefixWith(System.Runtime.InteropServices.ComTypes.IMoniker pmkOther, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkPrefix);
        void ComposeWith(System.Runtime.InteropServices.ComTypes.IMoniker pmkRight, bool fOnlyIfNotGeneric, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkComposite);
        void Enum(bool fForward, out System.Runtime.InteropServices.ComTypes.IEnumMoniker ppenumMoniker);
        void GetClassID(out System.Guid pClassID);
        void GetDisplayName(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, out string ppszDisplayName);
        void GetSizeMax(out long pcbSize);
        void GetTimeOfLastChange(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, out System.Runtime.InteropServices.ComTypes.FILETIME pFileTime);
        void Hash(out int pdwHash);
        void Inverse(out System.Runtime.InteropServices.ComTypes.IMoniker ppmk);
        int IsDirty();
        int IsEqual(System.Runtime.InteropServices.ComTypes.IMoniker pmkOtherMoniker);
        int IsRunning(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, System.Runtime.InteropServices.ComTypes.IMoniker pmkNewlyRunning);
        int IsSystemMoniker(out int pdwMksys);
        void Load(System.Runtime.InteropServices.ComTypes.IStream pStm);
        void ParseDisplayName(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, System.Runtime.InteropServices.ComTypes.IMoniker pmkToLeft, string pszDisplayName, out int pchEaten, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkOut);
        void Reduce(System.Runtime.InteropServices.ComTypes.IBindCtx pbc, int dwReduceHowFar, ref System.Runtime.InteropServices.ComTypes.IMoniker ppmkToLeft, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkReduced);
        void RelativePathTo(System.Runtime.InteropServices.ComTypes.IMoniker pmkOther, out System.Runtime.InteropServices.ComTypes.IMoniker ppmkRelPath);
        void Save(System.Runtime.InteropServices.ComTypes.IStream pStm, bool fClearDirty);
    }
    [System.FlagsAttribute]
    public enum IMPLTYPEFLAGS
    {
        IMPLTYPEFLAG_FDEFAULT = 1,
        IMPLTYPEFLAG_FDEFAULTVTABLE = 8,
        IMPLTYPEFLAG_FRESTRICTED = 4,
        IMPLTYPEFLAG_FSOURCE = 2,
    }
    [System.FlagsAttribute]
    public enum INVOKEKIND
    {
        INVOKE_FUNC = 1,
        INVOKE_PROPERTYGET = 2,
        INVOKE_PROPERTYPUT = 4,
        INVOKE_PROPERTYPUTREF = 8,
    }
    public partial interface IPersistFile
    {
        void GetClassID(out System.Guid pClassID);
        void GetCurFile(out string ppszFileName);
        int IsDirty();
        void Load(string pszFileName, int dwMode);
        void Save(string pszFileName, bool fRemember);
        void SaveCompleted(string pszFileName);
    }
    public partial interface IRunningObjectTable
    {
        void EnumRunning(out System.Runtime.InteropServices.ComTypes.IEnumMoniker ppenumMoniker);
        int GetObject(System.Runtime.InteropServices.ComTypes.IMoniker pmkObjectName, out object ppunkObject);
        int GetTimeOfLastChange(System.Runtime.InteropServices.ComTypes.IMoniker pmkObjectName, out System.Runtime.InteropServices.ComTypes.FILETIME pfiletime);
        int IsRunning(System.Runtime.InteropServices.ComTypes.IMoniker pmkObjectName);
        void NoteChangeTime(int dwRegister, ref System.Runtime.InteropServices.ComTypes.FILETIME pfiletime);
        int Register(int grfFlags, object punkObject, System.Runtime.InteropServices.ComTypes.IMoniker pmkObjectName);
        void Revoke(int dwRegister);
    }
    public partial interface IStream
    {
        void Clone(out System.Runtime.InteropServices.ComTypes.IStream ppstm);
        void Commit(int grfCommitFlags);
        void CopyTo(System.Runtime.InteropServices.ComTypes.IStream pstm, long cb, System.IntPtr pcbRead, System.IntPtr pcbWritten);
        void LockRegion(long libOffset, long cb, int dwLockType);
        void Read(byte[] pv, int cb, System.IntPtr pcbRead);
        void Revert();
        void Seek(long dlibMove, int dwOrigin, System.IntPtr plibNewPosition);
        void SetSize(long libNewSize);
        void Stat(out System.Runtime.InteropServices.ComTypes.STATSTG pstatstg, int grfStatFlag);
        void UnlockRegion(long libOffset, long cb, int dwLockType);
        void Write(byte[] pv, int cb, System.IntPtr pcbWritten);
    }
    public partial interface ITypeComp
    {
        void Bind(string szName, int lHashVal, short wFlags, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfo, out System.Runtime.InteropServices.ComTypes.DESCKIND pDescKind, out System.Runtime.InteropServices.ComTypes.BINDPTR pBindPtr);
        void BindType(string szName, int lHashVal, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfo, out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
    }
    public partial interface ITypeInfo
    {
        void AddressOfMember(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, out System.IntPtr ppv);
        void CreateInstance(object pUnkOuter, ref System.Guid riid, out object ppvObj);
        void GetContainingTypeLib(out System.Runtime.InteropServices.ComTypes.ITypeLib ppTLB, out int pIndex);
        void GetDllEntry(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, System.IntPtr pBstrDllName, System.IntPtr pBstrName, System.IntPtr pwOrdinal);
        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetFuncDesc(int index, out System.IntPtr ppFuncDesc);
        void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
        void GetImplTypeFlags(int index, out System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS pImplTypeFlags);
        void GetMops(int memid, out string pBstrMops);
        void GetNames(int memid, string[] rgBstrNames, int cMaxNames, out int pcNames);
        void GetRefTypeInfo(int hRef, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTI);
        void GetRefTypeOfImplType(int index, out int href);
        void GetTypeAttr(out System.IntPtr ppTypeAttr);
        void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        void GetVarDesc(int index, out System.IntPtr ppVarDesc);
        void Invoke(object pvInstance, int memid, short wFlags, ref System.Runtime.InteropServices.ComTypes.DISPPARAMS pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, out int puArgErr);
        void ReleaseFuncDesc(System.IntPtr pFuncDesc);
        void ReleaseTypeAttr(System.IntPtr pTypeAttr);
        void ReleaseVarDesc(System.IntPtr pVarDesc);
    }
    public partial interface ITypeInfo2 : System.Runtime.InteropServices.ComTypes.ITypeInfo
    {
        new void AddressOfMember(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, out System.IntPtr ppv);
        new void CreateInstance(object pUnkOuter, ref System.Guid riid, out object ppvObj);
        void GetAllCustData(System.IntPtr pCustData);
        void GetAllFuncCustData(int index, System.IntPtr pCustData);
        void GetAllImplTypeCustData(int index, System.IntPtr pCustData);
        void GetAllParamCustData(int indexFunc, int indexParam, System.IntPtr pCustData);
        void GetAllVarCustData(int index, System.IntPtr pCustData);
        new void GetContainingTypeLib(out System.Runtime.InteropServices.ComTypes.ITypeLib ppTLB, out int pIndex);
        void GetCustData(ref System.Guid guid, out object pVarVal);
        new void GetDllEntry(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, System.IntPtr pBstrDllName, System.IntPtr pBstrName, System.IntPtr pwOrdinal);
        new void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetDocumentation2(int memid, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);
        void GetFuncCustData(int index, ref System.Guid guid, out object pVarVal);
        new void GetFuncDesc(int index, out System.IntPtr ppFuncDesc);
        void GetFuncIndexOfMemId(int memid, System.Runtime.InteropServices.ComTypes.INVOKEKIND invKind, out int pFuncIndex);
        new void GetIDsOfNames(string[] rgszNames, int cNames, int[] pMemId);
        void GetImplTypeCustData(int index, ref System.Guid guid, out object pVarVal);
        new void GetImplTypeFlags(int index, out System.Runtime.InteropServices.ComTypes.IMPLTYPEFLAGS pImplTypeFlags);
        new void GetMops(int memid, out string pBstrMops);
        new void GetNames(int memid, string[] rgBstrNames, int cMaxNames, out int pcNames);
        void GetParamCustData(int indexFunc, int indexParam, ref System.Guid guid, out object pVarVal);
        new void GetRefTypeInfo(int hRef, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTI);
        new void GetRefTypeOfImplType(int index, out int href);
        new void GetTypeAttr(out System.IntPtr ppTypeAttr);
        new void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        void GetTypeFlags(out int pTypeFlags);
        void GetTypeKind(out System.Runtime.InteropServices.ComTypes.TYPEKIND pTypeKind);
        void GetVarCustData(int index, ref System.Guid guid, out object pVarVal);
        new void GetVarDesc(int index, out System.IntPtr ppVarDesc);
        void GetVarIndexOfMemId(int memid, out int pVarIndex);
        new void Invoke(object pvInstance, int memid, short wFlags, ref System.Runtime.InteropServices.ComTypes.DISPPARAMS pDispParams, System.IntPtr pVarResult, System.IntPtr pExcepInfo, out int puArgErr);
        new void ReleaseFuncDesc(System.IntPtr pFuncDesc);
        new void ReleaseTypeAttr(System.IntPtr pTypeAttr);
        new void ReleaseVarDesc(System.IntPtr pVarDesc);
    }
    public partial interface ITypeLib
    {
        void FindName(string szNameBuf, int lHashVal, System.Runtime.InteropServices.ComTypes.ITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
        void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetLibAttr(out System.IntPtr ppTLibAttr);
        void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        void GetTypeInfo(int index, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTI);
        int GetTypeInfoCount();
        void GetTypeInfoOfGuid(ref System.Guid guid, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfo);
        void GetTypeInfoType(int index, out System.Runtime.InteropServices.ComTypes.TYPEKIND pTKind);
        bool IsName(string szNameBuf, int lHashVal);
        void ReleaseTLibAttr(System.IntPtr pTLibAttr);
    }
    public partial interface ITypeLib2 : System.Runtime.InteropServices.ComTypes.ITypeLib
    {
        new void FindName(string szNameBuf, int lHashVal, System.Runtime.InteropServices.ComTypes.ITypeInfo[] ppTInfo, int[] rgMemId, ref short pcFound);
        void GetAllCustData(System.IntPtr pCustData);
        void GetCustData(ref System.Guid guid, out object pVarVal);
        new void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);
        void GetDocumentation2(int index, out string pbstrHelpString, out int pdwHelpStringContext, out string pbstrHelpStringDll);
        new void GetLibAttr(out System.IntPtr ppTLibAttr);
        void GetLibStatistics(System.IntPtr pcUniqueNames, out int pcchUniqueNames);
        new void GetTypeComp(out System.Runtime.InteropServices.ComTypes.ITypeComp ppTComp);
        new void GetTypeInfo(int index, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTI);
        new int GetTypeInfoCount();
        new void GetTypeInfoOfGuid(ref System.Guid guid, out System.Runtime.InteropServices.ComTypes.ITypeInfo ppTInfo);
        new void GetTypeInfoType(int index, out System.Runtime.InteropServices.ComTypes.TYPEKIND pTKind);
        new bool IsName(string szNameBuf, int lHashVal);
        new void ReleaseTLibAttr(System.IntPtr pTLibAttr);
    }
    [System.FlagsAttribute]
    public enum LIBFLAGS : short
    {
        LIBFLAG_FCONTROL = (short)2,
        LIBFLAG_FHASDISKIMAGE = (short)8,
        LIBFLAG_FHIDDEN = (short)4,
        LIBFLAG_FRESTRICTED = (short)1,
    }
    public partial struct PARAMDESC
    {
        public System.IntPtr lpVarValue;
        public System.Runtime.InteropServices.ComTypes.PARAMFLAG wParamFlags;
    }
    [System.FlagsAttribute]
    public enum PARAMFLAG : short
    {
        PARAMFLAG_FHASCUSTDATA = (short)64,
        PARAMFLAG_FHASDEFAULT = (short)32,
        PARAMFLAG_FIN = (short)1,
        PARAMFLAG_FLCID = (short)4,
        PARAMFLAG_FOPT = (short)16,
        PARAMFLAG_FOUT = (short)2,
        PARAMFLAG_FRETVAL = (short)8,
        PARAMFLAG_NONE = (short)0,
    }
    public partial struct STATDATA
    {
        public System.Runtime.InteropServices.ComTypes.ADVF advf;
        public System.Runtime.InteropServices.ComTypes.IAdviseSink advSink;
        public int connection;
        public System.Runtime.InteropServices.ComTypes.FORMATETC formatetc;
    }
    public partial struct STATSTG
    {
        public System.Runtime.InteropServices.ComTypes.FILETIME atime;
        public long cbSize;
        public System.Guid clsid;
        public System.Runtime.InteropServices.ComTypes.FILETIME ctime;
        public int grfLocksSupported;
        public int grfMode;
        public int grfStateBits;
        public System.Runtime.InteropServices.ComTypes.FILETIME mtime;
        public string pwcsName;
        public int reserved;
        public int type;
    }
    public partial struct STGMEDIUM
    {
        public object pUnkForRelease;
        public System.Runtime.InteropServices.ComTypes.TYMED tymed;
        public System.IntPtr unionmember;
    }
    public enum SYSKIND
    {
        SYS_MAC = 2,
        SYS_WIN16 = 0,
        SYS_WIN32 = 1,
        SYS_WIN64 = 3,
    }
    [System.FlagsAttribute]
    public enum TYMED
    {
        TYMED_ENHMF = 64,
        TYMED_FILE = 2,
        TYMED_GDI = 16,
        TYMED_HGLOBAL = 1,
        TYMED_ISTORAGE = 8,
        TYMED_ISTREAM = 4,
        TYMED_MFPICT = 32,
        TYMED_NULL = 0,
    }
    public partial struct TYPEATTR
    {
        public short cbAlignment;
        public int cbSizeInstance;
        public short cbSizeVft;
        public short cFuncs;
        public short cImplTypes;
        public short cVars;
        public int dwReserved;
        public System.Guid guid;
        public System.Runtime.InteropServices.ComTypes.IDLDESC idldescType;
        public int lcid;
        public System.IntPtr lpstrSchema;
        public const int MEMBER_ID_NIL = -1;
        public int memidConstructor;
        public int memidDestructor;
        public System.Runtime.InteropServices.ComTypes.TYPEDESC tdescAlias;
        public System.Runtime.InteropServices.ComTypes.TYPEKIND typekind;
        public short wMajorVerNum;
        public short wMinorVerNum;
        public System.Runtime.InteropServices.ComTypes.TYPEFLAGS wTypeFlags;
    }
    public partial struct TYPEDESC
    {
        public System.IntPtr lpValue;
        public short vt;
    }
    [System.FlagsAttribute]
    public enum TYPEFLAGS : short
    {
        TYPEFLAG_FAGGREGATABLE = (short)1024,
        TYPEFLAG_FAPPOBJECT = (short)1,
        TYPEFLAG_FCANCREATE = (short)2,
        TYPEFLAG_FCONTROL = (short)32,
        TYPEFLAG_FDISPATCHABLE = (short)4096,
        TYPEFLAG_FDUAL = (short)64,
        TYPEFLAG_FHIDDEN = (short)16,
        TYPEFLAG_FLICENSED = (short)4,
        TYPEFLAG_FNONEXTENSIBLE = (short)128,
        TYPEFLAG_FOLEAUTOMATION = (short)256,
        TYPEFLAG_FPREDECLID = (short)8,
        TYPEFLAG_FPROXY = (short)16384,
        TYPEFLAG_FREPLACEABLE = (short)2048,
        TYPEFLAG_FRESTRICTED = (short)512,
        TYPEFLAG_FREVERSEBIND = (short)8192,
    }
    public enum TYPEKIND
    {
        TKIND_ALIAS = 6,
        TKIND_COCLASS = 5,
        TKIND_DISPATCH = 4,
        TKIND_ENUM = 0,
        TKIND_INTERFACE = 3,
        TKIND_MAX = 8,
        TKIND_MODULE = 2,
        TKIND_RECORD = 1,
        TKIND_UNION = 7,
    }
    public partial struct TYPELIBATTR
    {
        public System.Guid guid;
        public int lcid;
        public System.Runtime.InteropServices.ComTypes.SYSKIND syskind;
        public System.Runtime.InteropServices.ComTypes.LIBFLAGS wLibFlags;
        public short wMajorVerNum;
        public short wMinorVerNum;
    }
    public partial struct VARDESC
    {
        public System.Runtime.InteropServices.ComTypes.VARDESC.DESCUNION desc;
        public System.Runtime.InteropServices.ComTypes.ELEMDESC elemdescVar;
        public string lpstrSchema;
        public int memid;
        public System.Runtime.InteropServices.ComTypes.VARKIND varkind;
        public short wVarFlags;
        public partial struct DESCUNION
        {
            public System.IntPtr lpvarValue;
            public int oInst;
        }
    }
    [System.FlagsAttribute]
    public enum VARFLAGS : short
    {
        VARFLAG_FBINDABLE = (short)4,
        VARFLAG_FDEFAULTBIND = (short)32,
        VARFLAG_FDEFAULTCOLLELEM = (short)256,
        VARFLAG_FDISPLAYBIND = (short)16,
        VARFLAG_FHIDDEN = (short)64,
        VARFLAG_FIMMEDIATEBIND = (short)4096,
        VARFLAG_FNONBROWSABLE = (short)1024,
        VARFLAG_FREADONLY = (short)1,
        VARFLAG_FREPLACEABLE = (short)2048,
        VARFLAG_FREQUESTEDIT = (short)8,
        VARFLAG_FRESTRICTED = (short)128,
        VARFLAG_FSOURCE = (short)2,
        VARFLAG_FUIDEFAULT = (short)512,
    }
    public enum VARKIND
    {
        VAR_CONST = 2,
        VAR_DISPATCH = 3,
        VAR_PERINSTANCE = 0,
        VAR_STATIC = 1,
    }
}
