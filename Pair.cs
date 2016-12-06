#region ...   [Header]   ...

// Solution    : Bergler.CRM.Integration.Carerix
// Project     : Bergler.Common.Tools
// File        : Pair.cs
//  
// Created on  : 06-12-2016 12:03
// Altered on  : 06-12-2016 12:30
// Altered by  : Ace aka Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System;

#endregion

namespace Bergler.Common.Tools.Types
{
    [Serializable]
    public class Pair<TFirst, TSecond> : Single<TFirst>
    {
        public Pair(TFirst first, TSecond second)
            : this(first, second, new[] {"first", "second"})
        {
        }

        public Pair(TFirst first, TSecond second, string[] propertyNames)
            : base(first, propertyNames)
        {
            Second = second;
            Collection[UniqueIdentifier].Add(Second.ToString());
            KeyIndex = 1;
        }

        public TSecond Second { get; set; }
    }
}