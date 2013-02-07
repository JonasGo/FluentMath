using System;
using System.Collections.Generic;

using FluentLib;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentLibTest.FluentMathTest
{
    [TestClass]
    public class FluentMathTest
    {
        [TestMethod]
        public void SumTest()
        {
            int sum;

            sum = FluentMath.SumOf(new List<int>() { 2, 4, 6, 8 });
            Assert.AreEqual(20, sum);

            sum = FluentMath.SumOf(new List<int>() { 3, 6 });
            Assert.AreEqual(9, sum);

            try
            {
                sum = FluentMath.SumOf(null);
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
                // This is the right way, yay
            }

        }

        [TestMethod]
        public void LeastCommonMultipleTest()
        {
            long result;

            result = FluentMath.LeastCommonMultipleOf(2, 3);
            Assert.AreEqual(6, result);
            result = FluentMath.LeastCommonMultipleOf(3, 4);
            Assert.AreEqual(12, result);
            result = FluentMath.LeastCommonMultipleOf(53667, 459486);
            Assert.AreEqual(40894254, result);

            result = FluentMath.LeastCommonMultipleOf(new List<long>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Assert.AreEqual(2520, result);
            result = FluentMath.LeastCommonMultipleOf(new List<long>() { 11, 12, 13 });
            Assert.AreEqual(1716, result);
            result = FluentMath.LeastCommonMultipleOf(new List<long>() { 2, 3 });
            Assert.AreEqual(6, result);

            // Illegal calls

            try
            {
                FluentMath.LeastCommonMultipleOf(null);
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
            }
        }

        [TestMethod]
        public void GreatestCommonDivisorTest()
        {
            long result;

            result = FluentMath.GreatestCommonDivisorOf(6, 9);
            Assert.AreEqual(3, result);
            result = FluentMath.GreatestCommonDivisorOf(17, 19);
            Assert.AreEqual(1, result);

            try
            {
                FluentMath.GreatestCommonDivisorOf(0, 1);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }

            try
            {
                FluentMath.GreatestCommonDivisorOf(1, 0);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }
        }



    }

}
