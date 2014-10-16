#if FAT

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using Theraot.Core;

namespace Theraot.Collections.Specialized
{
    [System.Diagnostics.DebuggerDisplay("Count={Count}")]
    public sealed partial class NullAwareDictionary<TKey, TValue> : IExtendedDictionary<TKey, TValue>
    {
        IEnumerable<TKey> IReadOnlyDictionary<TKey, TValue>.Keys
        {
            get
            {
                return _keys;
            }
        }

        IEnumerable<TValue> IReadOnlyDictionary<TKey, TValue>.Values
        {
            get
            {
                return _values;
            }
        }

        IReadOnlyCollection<KeyValuePair<TKey, TValue>> IExtendedCollection<KeyValuePair<TKey, TValue>>.AsReadOnly
        {
            get
            {
                return _readOnly;
            }
        }

        IReadOnlyCollection<TKey> IExtendedReadOnlyDictionary<TKey, TValue>.Keys
        {
            get
            {
                return _keys;
            }
        }

        IReadOnlyCollection<TValue> IExtendedReadOnlyDictionary<TKey, TValue>.Values
        {
            get
            {
                return _values;
            }
        }
    }
}

#endif