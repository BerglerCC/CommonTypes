#region ...   [Header]   ...

// Solution    : Bergler.CRM.Integration.Carerix
// Project     : Bergler.Common.Tools
// File        : Triplet.cs
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
    public class Triplet<TFirst, TSecond, TThird> : Pair<TFirst, TSecond>
    {
        public Triplet(TFirst first, TSecond second, TThird third)
            : this(first, second, third, new[] {"first", "second", "third"})
        {
        }

        public Triplet(TFirst first, TSecond second, TThird third, string[] propertyNames)
            : base(first, second, propertyNames)
        {
            Third = third;
            Collection[UniqueIdentifier].Add(Third.ToString());
            KeyIndex = 2;
        }

        public TThird Third { get; set; }
    }
}