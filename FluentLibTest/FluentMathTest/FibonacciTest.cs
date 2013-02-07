using System.Collections.Generic;
using System.Linq;

using FluentLib;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentLibTest.FluentMathTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void GenerateFibonacciNumbersListTest()
        {
            List<int> fibonacciNumbers = new List<int>();

            fibonacciNumbers = FluentMath.Get().FibonacciNumbers.ToValue(89);
            Assert.IsTrue(fibonacciNumbers.SequenceEqual(new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 }));
            fibonacciNumbers = FluentMath.Get().FibonacciNumbers.ToValue(13);
            Assert.IsTrue(fibonacciNumbers.SequenceEqual(new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13 }));
        }

        [TestMethod]
        public void GenerateFibonacciNumberAtIndexTest()
        {
            Assert.AreEqual(1, FluentMath.Get().FibonacciNumbers.At(2));
            Assert.AreEqual(13, FluentMath.Get().FibonacciNumbers.At(7));
            Assert.AreEqual(317811, FluentMath.Get().FibonacciNumbers.At(28));
        }
    }
}
