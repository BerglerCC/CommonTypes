#region ...   [Header]   ...

// Solution    : Bergler.CRM.Integration.Carerix
// Project     : Bergler.Common.Tools
// File        : Single.cs
//  
// Created on  : 06-12-2016 12:03
// Altered on  : 06-12-2016 12:30
// Altered by  : Ace aka Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Bergler.Common.Tools.Types
{
    [Serializable]
    public class Single<TFirst>
    {
        protected readonly Dictionary<Guid, List<string>> Collection = new Dictionary<Guid, List<string>>();

        protected readonly List<string> PropertyNames = new List<string>();

        public Single(TFirst first)
            : this(first, new[] {"first"})
        {
        }

        public Single(TFirst first, string[] propertyNames)
        {
            UniqueIdentifier = new Guid();
            PropertyNames.AddRange(propertyNames);
            First = first;
            Collection.Add(UniqueIdentifier, new List<string> {first.ToString()});
            KeyIndex = 0;
        }

        public Guid UniqueIdentifier { get; }

        public TFirst First { get; set; }

        public int KeyIndex { get; set; }

        public object this[int index] => Collection[UniqueIdentifier][index];

        public object this[string name]
            => PropertyNames.Any(propertyName => name == propertyName) ? this[PropertyNames.IndexOf(name)] : this[0];

        public object ValueAtKeyIndex => this[KeyIndex];

        public Dictionary<Guid, List<string>> ToList() => Collection;
    }
}