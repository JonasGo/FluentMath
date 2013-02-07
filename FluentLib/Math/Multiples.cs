using System;
using System.Collections.Generic;

namespace FluentLib.Math
{
    /// <summary>
    /// Instantiates a Multiples object which can generate a multiples List
    /// </summary>
    public class Multiples
    {
        public List<int> Values { get; private set; }

        public Multiples(int value)
        {
            if (value <= 0) throw new ArgumentOutOfRangeException("value", "Value has to be greater than zero");
            Values = new List<int> { value };
        }

        public List<int> Under(int limit)
        {
            List<int> multiples = new List<int>();

            foreach (var value in Values)
            {
                for (int i = 1; i < limit; i++)
                {
                    int result = value * i;
                    if (result >= limit)
                    {
                        break;
                    }
                    if (!multiples.Contains(result)) multiples.Add(result);
                }
            }

            multiples.Sort();

            return multiples;
        }

        public Multiples Or(int value)
        {
            Values.Add(value);
            return this;
        }
    }
}
