using System.Collections.Generic;
using System.Linq;

namespace FluentLib.Math
{
    public class Is
    {
        public long Value { get; private set; }

        public Is(long value)
        {
            Value = value;
        }

        public bool EvenlyDivisableBy(int divisor)
        {
            return Value % divisor == 0;
        }

        public bool EvenlyDivisableBy(List<int> divisors)
        {
            return divisors.All(EvenlyDivisableBy);
        }

        public bool PrimeNumber()
        {

            return true;
        }
    }
}
