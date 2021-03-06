// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Globalization;
using System.Collections;
using System.Collections.Specialized;
using Microsoft.DotNet.RemoteExecutor;
using Xunit;

namespace System.Diagnostics.Tests
{
    public static class PerformanceCounterTests
    {
        [Fact]
        public static void PerformanceCounter_CreateCounter_EmptyCounter()
        {
            using (PerformanceCounter counterSample = new PerformanceCounter())
            {
                Assert.Equal(".", counterSample.MachineName);
                Assert.Equal(string.Empty, counterSample.CategoryName);
                Assert.Equal(string.Empty, counterSample.CounterName);
                Assert.Equal(string.Empty, counterSample.InstanceName);
                Assert.True(counterSample.ReadOnly);
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndCanWriteToPerfCounters))]
        public static void PerformanceCounter_CreateCounter_Count0()
        {
            var name = nameof(PerformanceCounter_CreateCounter_Count0) + "_Counter";
            using (PerformanceCounter counterSample = CreateCounterWithCategory(name, false, PerformanceCounterCategoryType.SingleInstance))
            {
                counterSample.RawValue = 0;

                Assert.Equal(0, counterSample.RawValue);
                Helpers.DeleteCategory(name);
            }
        }

        [Fact]
        public static void PerformanceCounter_CreateCounter_ProcessorCounter()
        {
            using (PerformanceCounter counterSample = new PerformanceCounter("Processor", "Interrupts/sec", "0", "."))
            {
                Assert.Equal(0, Helpers.RetryOnAllPlatforms(() => counterSample.NextValue()));

                Assert.True(counterSample.RawValue > 0);
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndCanWriteAndReadNetPerfCounters))]
        public static void PerformanceCounter_CreateCounter_MultiInstanceReadOnly()
        {
            var name = nameof(PerformanceCounter_CreateCounter_MultiInstanceReadOnly) + "_Counter";
            var instance = name + "_Instance";

            var category = Helpers.CreateCategory(name, PerformanceCounterCategoryType.MultiInstance);

            using (PerformanceCounter counterSample = Helpers.RetryOnAllPlatforms(() => new PerformanceCounter(category, name, instance)))
            {
                Assert.Equal(name, counterSample.CounterName);
                Assert.Equal(category, counterSample.CategoryName);
                Assert.Equal(instance, counterSample.InstanceName);
                Assert.Equal("counter description",  Helpers.RetryOnAllPlatforms(() => counterSample.CounterHelp));
                Assert.True(counterSample.ReadOnly);
                Helpers.DeleteCategory(name);
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndCanWriteAndReadNetPerfCounters))]
        public static void PerformanceCounter_CreateCounter_SetReadOnly()
        {
            var name = nameof(PerformanceCounter_CreateCounter_SetReadOnly) + "_Counter";

            var category = Helpers.CreateCategory(name, PerformanceCounterCategoryType.SingleInstance);

            using (PerformanceCounter counterSample = Helpers.RetryOnAllPlatforms(() => new PerformanceCounter(category, name)))
            {
                counterSample.ReadOnly = false;

                Assert.False(counterSample.ReadOnly);
            }

            Helpers.DeleteCategory(name);
        }

        [Fact]
        public static void PerformanceCounter_SetProperties_Null()
        {
            using (PerformanceCounter counterSample = new PerformanceCounter())
            {
                Assert.Throws<ArgumentNullException>(() => counterSample.CategoryName = null);
                Assert.Throws<ArgumentNullException>(() => counterSample.CounterName = null);
                Assert.Throws<ArgumentException>(() => counterSample.MachineName = null);
            }
        }

        [Fact]
        public static void PerformanceCounter_SetRawValue_ReadOnly()
        {
            using (PerformanceCounter counterSample = new PerformanceCounter())
            {
                Assert.Throws<InvalidOperationException>(() => counterSample.RawValue = 10);
            }
        }

        [Fact]
        public static void PerformanceCounter_GetRawValue_EmptyCategoryName()
        {
            var name = nameof(PerformanceCounter_GetRawValue_EmptyCategoryName) + "_Counter";
            using (PerformanceCounter counterSample = new PerformanceCounter())
            {
                counterSample.ReadOnly = false;
                counterSample.CounterName = name;

                Assert.Throws<InvalidOperationException>(() => counterSample.RawValue);
            }
        }

        [Fact]
        public static void PerformanceCounter_GetRawValue_EmptyCounterName()
        {
            var name = nameof(PerformanceCounter_GetRawValue_EmptyCounterName) + "_Counter";
            using (PerformanceCounter counterSample = new PerformanceCounter())
            {
                counterSample.ReadOnly = false;
                counterSample.CategoryName = name + "_Category";

                Assert.Throws<InvalidOperationException>(() => counterSample.RawValue);
            }
        }

        [Fact]
        public static void PerformanceCounter_GetRawValue_CounterDoesNotExist()
        {
            var name = nameof(PerformanceCounter_GetRawValue_CounterDoesNotExist) + "_Counter";
            using (PerformanceCounter counterSample = new PerformanceCounter())
            {
                counterSample.ReadOnly = false;
                counterSample.CounterName = name;
                counterSample.CategoryName = name + "_Category";

                Assert.Throws<InvalidOperationException>(() => counterSample.RawValue);
            }
        }

        [ActiveIssue("https://github.com/dotnet/runtime/issues/29753")]
        [Fact]
        public static void PerformanceCounter_NextValue_ProcessorCounter()
        {
            using (PerformanceCounter counterSample = new PerformanceCounter("Processor", "Interrupts/sec", "0", "."))
            {
                Helpers.RetryOnAllPlatforms(() => counterSample.NextValue());
                System.Threading.Thread.Sleep(30);

                Assert.True(Helpers.RetryOnAllPlatforms(() => counterSample.NextValue()) > 0);
            }
        }

        [Fact]
        public static void PerformanceCounter_BeginInit_ProcessorCounter()
        {
            using (PerformanceCounter counterSample = new PerformanceCounter("Processor", "Interrupts/sec", "0", "."))
            {
                counterSample.BeginInit();

                Assert.NotNull(counterSample);
            }
        }

        [Fact]
        public static void PerformanceCounter_BeginInitEndInit_ProcessorCounter()
        {
            using (PerformanceCounter counterSample = new PerformanceCounter("Processor", "Interrupts/sec", "0", "."))
            {
                counterSample.BeginInit();
                counterSample.EndInit();

                Assert.NotNull(counterSample);
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndCanWriteAndReadNetPerfCounters))]
        public static void PerformanceCounter_Decrement()
        {
            var name = nameof(PerformanceCounter_Decrement) + "_Counter";
            using (PerformanceCounter counterSample = CreateCounterWithCategory(name, false, PerformanceCounterCategoryType.SingleInstance))
            {
                counterSample.RawValue = 10;
                Helpers.RetryOnAllPlatforms(() => counterSample.Decrement());

                Assert.Equal(9, counterSample.RawValue);
                Helpers.DeleteCategory(name);
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndCanWriteAndReadNetPerfCounters))]
        public static void PerformanceCounter_Increment()
        {
            var name = nameof(PerformanceCounter_Increment) + "_Counter";
            using (PerformanceCounter counterSample = CreateCounterWithCategory(name, false, PerformanceCounterCategoryType.SingleInstance))
            {
                counterSample.RawValue = 10;
                Helpers.RetryOnAllPlatforms(() => counterSample.Increment());

                Assert.Equal(11, Helpers.RetryOnAllPlatforms(() => counterSample.NextSample().RawValue));
                Helpers.DeleteCategory(name);
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndCanWriteAndReadNetPerfCounters))]
        public static void PerformanceCounter_IncrementBy_IncrementBy2()
        {
            var name = nameof(PerformanceCounter_IncrementBy_IncrementBy2) + "_Counter";
            using (PerformanceCounter counterSample = CreateCounterWithCategory(name, false, PerformanceCounterCategoryType.SingleInstance))
            {
                counterSample.RawValue = 10;
                Helpers.RetryOnAllPlatforms(() => counterSample.IncrementBy(2));

                Assert.Equal(12, counterSample.RawValue);
                Helpers.DeleteCategory(name);
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndCanWriteAndReadNetPerfCounters))]
        public static void PerformanceCounter_IncrementBy_IncrementByReadOnly()
        {
            var name = nameof(PerformanceCounter_IncrementBy_IncrementByReadOnly) + "_Counter";
            using (PerformanceCounter counterSample = CreateCounterWithCategory(name, true, PerformanceCounterCategoryType.SingleInstance))
            {
                Assert.Throws<InvalidOperationException>(() => counterSample.IncrementBy(2));
                Helpers.DeleteCategory(name);
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndCanWriteAndReadNetPerfCounters))]
        public static void PerformanceCounter_Increment_IncrementReadOnly()
        {
            var name = nameof(PerformanceCounter_Increment_IncrementReadOnly) + "_Counter";
            using (PerformanceCounter counterSample = CreateCounterWithCategory(name, true, PerformanceCounterCategoryType.SingleInstance))
            {
                Assert.Throws<InvalidOperationException>(() => counterSample.Increment());
                Helpers.DeleteCategory(name);
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndCanWriteAndReadNetPerfCounters))]
        public static void PerformanceCounter_Decrement_DecrementReadOnly()
        {
            var name = nameof(PerformanceCounter_Decrement_DecrementReadOnly) + "_Counter";
            using (PerformanceCounter counterSample = CreateCounterWithCategory(name, true, PerformanceCounterCategoryType.SingleInstance))
            {
                Assert.Throws<InvalidOperationException>(() => counterSample.Decrement());
                Helpers.DeleteCategory(name);
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndCanWriteToPerfCounters))]
        public static void PerformanceCounter_RemoveInstance()
        {
            var name = nameof(PerformanceCounter_RemoveInstance) + "_Counter";
            using (PerformanceCounter counterSample = CreateCounterWithCategory(name, false, PerformanceCounterCategoryType.SingleInstance))
            {
                counterSample.RawValue = 100;
                counterSample.RemoveInstance();
                counterSample.Close();

                Assert.NotNull(counterSample);
                Helpers.DeleteCategory(name);
            }
        }

        [ConditionalFact(typeof(Helpers), nameof(Helpers.IsElevatedAndCanWriteAndReadNetPerfCounters))]
        public static void PerformanceCounter_NextSample_MultiInstance()
        {
            var name = nameof(PerformanceCounter_NextSample_MultiInstance) + "_Counter";
            var instance = name + "_Instance";

            var category = Helpers.CreateCategory(name, PerformanceCounterCategoryType.MultiInstance);

            using (PerformanceCounter counterSample = new PerformanceCounter(category, name, instance, false))
            {
                counterSample.RawValue = 10;
                Helpers.RetryOnAllPlatforms(() => counterSample.Decrement());

                Assert.Equal(9, counterSample.RawValue);
                Helpers.DeleteCategory(name);
            }
        }

        private static bool CanRunInInvariantMode => RemoteExecutor.IsSupported && !PlatformDetection.IsNetFramework;

        [ConditionalTheory(nameof(CanRunInInvariantMode))]
        [PlatformSpecific(TestPlatforms.Windows)]
        [InlineData(true)]
        [InlineData(false)]
        public static void RunWithGlobalizationInvariantModeTest(bool predefinedCultures)
        {
            ProcessStartInfo psi = new ProcessStartInfo() {  UseShellExecute = false };
            psi.Environment.Add("DOTNET_SYSTEM_GLOBALIZATION_INVARIANT", "1");
            psi.Environment.Add("DOTNET_SYSTEM_GLOBALIZATION_PREDEFINED_CULTURES_ONLY", predefinedCultures ? "1" : "0");
            RemoteExecutor.Invoke(() =>
            {
                // Ensure we are running inside the Globalization invariant mode.
                Assert.Equal("", CultureInfo.CurrentCulture.Name);

                // This test ensure creating PerformanceCounter object while we are running with Globalization Invariant Mode.
                // PerformanceCounter used to create cultures using LCID's which fail in Globalization Invariant Mode.
                // This test ensure no failure should be encountered in this case.
                using (PerformanceCounter counterSample = new PerformanceCounter("Processor", "Interrupts/sec", "0", "."))
                {
                    Assert.Equal("Processor", counterSample.CategoryName);
                }
            }, new RemoteInvokeOptions { StartInfo =  psi}).Dispose();
        }

        public static PerformanceCounter CreateCounterWithCategory(string name, bool readOnly, PerformanceCounterCategoryType categoryType )
        {
            var category = Helpers.CreateCategory(name, categoryType);

            PerformanceCounter counterSample =  Helpers.RetryOnAllPlatforms(() => new PerformanceCounter(category, name, readOnly));

            return counterSample;
        }
    }
}
