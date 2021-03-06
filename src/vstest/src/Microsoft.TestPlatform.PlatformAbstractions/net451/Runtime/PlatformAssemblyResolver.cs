// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#if NETFRAMEWORK || NETSTANDARD2_0

namespace Microsoft.VisualStudio.TestPlatform.PlatformAbstractions
{
    using System;
    using System.Reflection;

    using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions.Interfaces;

    /// <inheritdoc/>
    public class PlatformAssemblyResolver : IAssemblyResolver
    {
        /// <summary>
        /// Specifies whether the resolver is disposed or not
        /// </summary>
        private bool disposed;

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformAssemblyResolver"/> class.
        /// </summary>
        public PlatformAssemblyResolver()
        {
            AppDomain.CurrentDomain.AssemblyResolve += this.AssemblyResolverEvent;
        }

        ~PlatformAssemblyResolver()
        {
            this.Dispose(false);
        }

        /// <inheritdoc/>
        public event AssemblyResolveEventHandler AssemblyResolve;

        public void Dispose()
        {
            this.Dispose(true);

            // Use SupressFinalize in case a subclass
            // of this type implements a finalizer.
            GC.SuppressFinalize(this);
        }

        protected void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    AppDomain.CurrentDomain.AssemblyResolve -= this.AssemblyResolverEvent;
                }

                this.disposed = true;
            }
        }

        /// <summary>
        /// Assembly Resolve event handler for App Domain - called when CLR loader cannot resolve assembly.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="eventArgs">
        /// The event Args.
        /// </param>
        /// <returns>
        /// The <see cref="Assembly"/>.
        /// </returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Justification")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadFrom", Justification = "Justification")]
        private Assembly AssemblyResolverEvent(object sender, object eventArgs)
        {
            ResolveEventArgs args = eventArgs as ResolveEventArgs;

            return args == null ? null : this.AssemblyResolve(this, new AssemblyResolveEventArgs(args.Name));
        }
    }
}

#endif
