// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.Internal.Log
{
    /// <summary>
    /// LogMessage that creates key value map lazily
    /// </summary>
    internal sealed class KeyValueLogMessage : LogMessage
    {
        private static readonly ObjectPool<KeyValueLogMessage> s_pool = new(() => new KeyValueLogMessage(), 20);

        public static readonly KeyValueLogMessage NoProperty = new();

        /// <summary>
        /// Creates a <see cref="KeyValueLogMessage"/> with default <see cref="LogLevel.Information"/>, since
        /// KV Log Messages are by default more informational and should be logged as such. 
        /// </summary>
        public static KeyValueLogMessage Create(Action<Dictionary<string, object>> propertySetter, LogLevel logLevel = LogLevel.Information)
        {
            var logMessage = s_pool.Allocate();
            logMessage.Construct(LogType.Trace, propertySetter, logLevel);

            return logMessage;
        }

        public static KeyValueLogMessage Create(LogType kind, LogLevel logLevel = LogLevel.Information)
            => Create(kind, propertySetter: null, logLevel);

        public static KeyValueLogMessage Create(LogType kind, Action<Dictionary<string, object>> propertySetter, LogLevel logLevel = LogLevel.Information)
        {
            var logMessage = s_pool.Allocate();
            logMessage.Construct(kind, propertySetter, logLevel);

            return logMessage;
        }

        private LogType _kind;
        private Dictionary<string, object> _map;
        private Action<Dictionary<string, object>> _propertySetter;

        private KeyValueLogMessage()
        {
            // prevent it from being created directly
            _kind = LogType.Trace;
        }

        private void Construct(LogType kind, Action<Dictionary<string, object>> propertySetter, LogLevel logLevel)
        {
            _kind = kind;
            _propertySetter = propertySetter;
            LogLevel = logLevel;
        }

        public LogType Kind => _kind;

        public bool ContainsProperty
        {
            get
            {
                EnsureMap();
                return _map.Count > 0;
            }
        }

        public IEnumerable<KeyValuePair<string, object>> Properties
        {
            get
            {
                EnsureMap();
                return _map;
            }
        }

        protected override string CreateMessage()
        {
            EnsureMap();
            return string.Join("|", _map.Select(kv => string.Format("{0}={1}", kv.Key, kv.Value)));
        }

        protected override void FreeCore()
        {
            if (this == NoProperty)
            {
                return;
            }

            if (_map != null)
            {
                SharedPools.Default<Dictionary<string, object>>().ClearAndFree(_map);
                _map = null;
            }

            if (_propertySetter != null)
            {
                _propertySetter = null;
            }

            // always pool it back
            s_pool.Free(this);
        }

        private void EnsureMap()
        {
            // always create _map
            if (_map == null)
            {
                _map = SharedPools.Default<Dictionary<string, object>>().AllocateAndClear();
            }

            _propertySetter?.Invoke(_map);
        }
    }

    /// <summary>
    /// Type of log it is making.
    /// </summary>
    internal enum LogType
    {
        /// <summary>
        /// Log some traces of an activity (default)
        /// </summary>
        Trace,

        /// <summary>
        /// Log an user explicit action
        /// </summary>
        UserAction,
    }
}
