#region ...   [Header]   ...

// Solution    : Bergler.CRM.Integration.Carerix
// Project     : Bergler.Common.Tools
// File        : Quartet.cs
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
    public class Quartet<TFirst, TSecond, TThird, TFourth> : Triplet<TFirst, TSecond, TThird>
    {
        public Quartet(TFirst first, TSecond second, TThird third, TFourth fourth)
            : this(first, second, third, fourth, new[] {"first", "second", "third", "fourth"})
        {
        }

        public Quartet(TFirst first, TSecond second, TThird third, TFourth fourth, string[] propertyNames)
            : base(first, second, third, propertyNames)
        {
            Fourth = fourth;
            Collection[UniqueIdentifier].Add(Fourth.ToString());
            KeyIndex = 3;
        }

        public TFourth Fourth { get; set; }
    }
}