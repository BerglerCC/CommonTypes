#region ...   [Header]   ...

// Solution    : Bergler.CRM.Integration.Carerix
// Project     : Bergler.Common.Tools
// File        : Quintet.cs
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
    public class Quintet<TFirst, TSecond, TThird, TFourth, TFifth> : Quartet<TFirst, TSecond, TThird, TFourth>
    {
        public Quintet(TFirst first, TSecond second, TThird third, TFourth fourth, TFifth fifth)
            : this(first, second, third, fourth, fifth, new[] {"first", "second", "third", "fourth", "fifth"})
        {
        }

        public Quintet(TFirst first, TSecond second, TThird third, TFourth fourth, TFifth fifth, string[] propertyNames)
            : base(first, second, third, fourth, propertyNames)
        {
            Fifth = fifth;
            Collection[UniqueIdentifier].Add(Fifth.ToString());
            KeyIndex = 4;
        }

        public TFifth Fifth { get; set; }
    }
}