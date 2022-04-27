﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Resources {
    using System;
    using System.Reflection;

    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.VisualStudio.TestPlatform.CrossPlatEngine.Resources.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Access denied while trying to create &quot;TestResults&quot; folder in mentioned location. You are getting this exception because you are running vstest.console.exe from a folder which requires having write access. To solve the issue: please  run vstest.console.exe from a folder where you have write privileges..
        /// </summary>
        internal static string AccessDenied {
            get {
                return ResourceManager.GetString("AccessDenied", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot attach the debugger to the default test host with process ID: {0}..
        /// </summary>
        internal static string AttachDebuggerToDefaultTestHostFailure {
            get {
                return ResourceManager.GetString("AttachDebuggerToDefaultTestHostFailure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DataCollector debugging is enabled. Please attach debugger to datacollector process to continue..
        /// </summary>
        internal static string DataCollectorDebuggerWarning {
            get {
                return ResourceManager.GetString("DataCollectorDebuggerWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Adapter lookup is being changed, please follow https://github.com/Microsoft/vstest-docs/blob/main/RFCs/0022-User-Specified-TestAdapter-Lookup.md#roadmap for more details..
        /// </summary>
        internal static string DeprecatedAdapterPath {
            get {
                return ResourceManager.GetString("DeprecatedAdapterPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exception occurred while instantiating discoverer : {0}.
        /// </summary>
        internal static string DiscovererInstantiationException {
            get {
                return ResourceManager.GetString("DiscovererInstantiationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple test adapters with the same uri &apos;{0}&apos; were found. Ignoring adapter &apos;{1}&apos;. Please uninstall the conflicting adapter(s) to avoid this warning..
        /// </summary>
        internal static string DuplicateAdaptersFound {
            get {
                return ResourceManager.GetString("DuplicateAdaptersFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ignoring the specified duplicate source &apos;{0}&apos;..
        /// </summary>
        internal static string DuplicateSource {
            get {
                return ResourceManager.GetString("DuplicateSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while test discoverer &apos;{0}&apos; was loading tests. Exception: {1}.
        /// </summary>
        internal static string ExceptionFromLoadTests {
            get {
                return ResourceManager.GetString("ExceptionFromLoadTests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while invoking executor &apos;{0}&apos;: {1}.
        /// </summary>
        internal static string ExceptionFromRunTests {
            get {
                return ResourceManager.GetString("ExceptionFromRunTests", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ExecutionThreadApartmentState option not supported for framework: {0}..
        /// </summary>
        internal static string ExecutionThreadApartmentStateNotSupportedForFramework {
            get {
                return ResourceManager.GetString("ExecutionThreadApartmentStateNotSupportedForFramework", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to launch testhost with error: {0}.
        /// </summary>
        internal static string FailedToLaunchTestHost {
            get {
                return ResourceManager.GetString("FailedToLaunchTestHost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find file {0}..
        /// </summary>
        internal static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Host debugging is enabled. Please attach debugger to testhost process to continue..
        /// </summary>
        internal static string HostDebuggerWarning {
            get {
                return ResourceManager.GetString("HostDebuggerWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ignoring the test executor corresponding to test discoverer {0} because the discoverer does not have the DefaultExecutorUri attribute . You might need to re-install the test adapter add-in..
        /// </summary>
        internal static string IgnoringExecutorAsNoDefaultExecutorUriAttribute {
            get {
                return ResourceManager.GetString("IgnoringExecutorAsNoDefaultExecutorUriAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to initialize client proxy: could not connect to test process..
        /// </summary>
        internal static string InitializationFailed {
            get {
                return ResourceManager.GetString("InitializationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This operation is not allowed in the context of a non-debug run..
        /// </summary>
        internal static string LaunchDebugProcessNotAllowedForANonDebugRun {
            get {
                return ResourceManager.GetString("LaunchDebugProcessNotAllowedForANonDebugRun", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find an available proxy to deque..
        /// </summary>
        internal static string NoAvailableProxyForDeque {
            get {
                return ResourceManager.GetString("NoAvailableProxyForDeque", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find {0}. Make sure that the dotnet is installed on the machine..
        /// </summary>
        internal static string NoDotnetExeFound {
            get {
                return ResourceManager.GetString("NoDotnetExeFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find test executor with URI &apos;{0}&apos;.  Make sure that the test executor is installed and supports .net runtime version {1}..
        /// </summary>
        internal static string NoMatchingExecutor {
            get {
                return ResourceManager.GetString("NoMatchingExecutor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not find extensions: {0}.
        /// </summary>
        internal static string NonExistingExtensions {
            get {
                return ResourceManager.GetString("NonExistingExtensions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Proxy with id {0} is not managed by the current session manager..
        /// </summary>
        internal static string NoSuchProxyId {
            get {
                return ResourceManager.GetString("NoSuchProxyId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No test matches the given testcase filter `{0}` in {1}.
        /// </summary>
        internal static string NoTestsAvailableForGivenTestCaseFilter {
            get {
                return ResourceManager.GetString("NoTestsAvailableForGivenTestCaseFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to None of the specified source(s) &apos;{0}&apos; is valid. Fix the above errors/warnings and then try again. .
        /// </summary>
        internal static string NoValidSourceFoundForDiscovery {
            get {
                return ResourceManager.GetString("NoValidSourceFoundForDiscovery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are using an older version of Microsoft.NET.Test.Sdk. Kindly move to a version equal or greater than 15.3.0..
        /// </summary>
        internal static string OldTestHostIsGettingUsed {
            get {
                return ResourceManager.GetString("OldTestHostIsGettingUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Proxy with id {0} is already available and cannot be re-enqueued..
        /// </summary>
        internal static string ProxyIsAlreadyAvailable {
            get {
                return ResourceManager.GetString("ProxyIsAlreadyAvailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to , .
        /// </summary>
        internal static string StringSeperator {
            get {
                return ResourceManager.GetString("StringSeperator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Discovery of tests cancelled..
        /// </summary>
        internal static string TestDiscoveryCancelled {
            get {
                return ResourceManager.GetString("TestDiscoveryCancelled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Logging TestHost Diagnostics in file: {0}.
        /// </summary>
        internal static string TesthostDiagLogOutputFile {
            get {
                return ResourceManager.GetString("TesthostDiagLogOutputFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Testhost process exited with error: {0}. Please check the diagnostic logs for more information..
        /// </summary>
        internal static string TestHostExitedWithError {
            get {
                return ResourceManager.GetString("TestHostExitedWithError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No test is available in {0}. Make sure that test discoverer &amp; executors are registered and platform &amp; framework version settings are appropriate and try again..
        /// </summary>
        internal static string TestRunFailed_NoDiscovererFound_NoTestsAreAvailableInTheSources {
            get {
                return ResourceManager.GetString("TestRunFailed_NoDiscovererFound_NoTestsAreAvailableInTheSources", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No tests matched the filter because it contains one or more properties that are not valid ({0}). Specify filter expression containing valid properties ({1})..
        /// </summary>
        internal static string UnsupportedPropertiesInTestCaseFilter {
            get {
                return ResourceManager.GetString("UnsupportedPropertiesInTestCaseFilter", resourceCulture);
            }
        }
    }
}