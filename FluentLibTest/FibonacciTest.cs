using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Versuch1.Math;

namespace TestVersuch1
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void GenerateFibonacciNumbersListTest()
        {
            List<int> fibonacciNumbers = new List<int>();

            fibonacciNumbers = Mathlib.Get().FibonacciNumbers.ToValue(89);
            Assert.IsTrue(fibonacciNumbers.SequenceEqual(new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 }));
            fibonacciNumbers = Mathlib.Get().FibonacciNumbers.ToValue(13);
            Assert.IsTrue(fibonacciNumbers.SequenceEqual(new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13 }));
        }

        [TestMethod]
        public void GenerateFibonacciNumberAtIndexTest()
        {
            Assert.AreEqual(1, Mathlib.Get().FibonacciNumbers.At(2));
            Assert.AreEqual(13, Mathlib.Get().FibonacciNumbers.At(7));
            Assert.AreEqual(317811, Mathlib.Get().FibonacciNumbers.At(28));
        }
    }
}
