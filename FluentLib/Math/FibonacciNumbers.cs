using System.Collections.Generic;

namespace FluentLib.Math
{
    public class FibonacciNumbers
    {
        public List<int> ToValue(int limit)
        {
            List<int> numbers = new List<int>() { 0, 1 };
            if (limit == 1) return numbers;

            int index = 2;
            int currentNumber = numbers[index - 2] + numbers[index - 1];
            while (currentNumber <= limit)
            {
                currentNumber = numbers[index - 2] + numbers[index - 1];
                if (currentNumber > limit) break;
                numbers.Add(currentNumber);
                index++;
            }
            return numbers;
        }

        public int At(int index)
        {
            double sqrtOfFive = System.Math.Sqrt(5);
            return (int)System.Math.Floor((1.0 / sqrtOfFive) * System.Math.Pow((1.0 + sqrtOfFive) / 2.0, index) + 0.5);
        }
    }
}
