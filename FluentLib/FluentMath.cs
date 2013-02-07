using System;
using System.Collections.Generic;
using System.Linq;

using FluentLib.Math;

namespace FluentLib
{
    public static class FluentMath
    {

        /// <summary>
        /// Generates a Multiples object which generates multiples
        /// </summary>
        /// <param name="value">the value wich will be multiplied</param>
        /// <returns>An instance of Multiples</returns>
        public static Multiples MultiplesOf(int value)
        {
            return new Multiples(value);
        }

        /// <summary>
        /// Generates the sum of a given list of integer
        /// </summary>
        /// <param name="values">the list</param>
        /// <returns>sum of the list</returns>
        public static int SumOf(IEnumerable<int> values)
        {
            return values.Aggregate((value1, value2) => value1 + value2);
        }

        public static Is Is(long value)
        {
            return new Is(value);
        }

        public static long LeastCommonMultipleOf(List<long> values)
        {
            if (values == null) throw new ArgumentNullException("values");

            if (values.Count == 2) return LeastCommonMultipleOf(values[0], values[1]);
            long x = values[0];
            values.RemoveAt(0);
            return LeastCommonMultipleOf(x,LeastCommonMultipleOf(values));
        }

        public static long LeastCommonMultipleOf(long x, long y)
        {
            return x * y / GreatestCommonDivisorOf(x, y);
        }

        public static long GreatestCommonDivisorOf(long x, long y)
        {
            if (x < 1 || y < 1) throw new ArgumentException("Values have to be greater than zero (x is " + x + ", y is " + y + ")");

            long divisor = y;
            long numerator = x;
            long remainder = numerator % divisor;

            while (remainder != 0)
            {
                numerator = divisor;
                divisor = remainder;
                remainder = numerator % divisor;
            }
            return divisor;
        }


        public static Get Get()
        {
            return new Get();
        }
    }

}
