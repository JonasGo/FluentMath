using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Versuch1.Math;

namespace TestVersuch1
{
    [TestClass]
    public class MathlibTest
    {
        [TestMethod]
        public void SumTest()
        {
            int sum;

            sum = Mathlib.SumOf(new List<int>() { 2, 4, 6, 8 });
            Assert.AreEqual(20, sum);

            sum = Mathlib.SumOf(new List<int>() { 3, 6 });
            Assert.AreEqual(9, sum);

            try
            {
                sum = Mathlib.SumOf(null);
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

            result = Mathlib.LeastCommonMultipleOf(2, 3);
            Assert.AreEqual(6, result);
            result = Mathlib.LeastCommonMultipleOf(3, 4);
            Assert.AreEqual(12, result);
            result = Mathlib.LeastCommonMultipleOf(53667, 459486);
            Assert.AreEqual(40894254, result);

            result = Mathlib.LeastCommonMultipleOf(new List<long>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Assert.AreEqual(2520, result);
            result = Mathlib.LeastCommonMultipleOf(new List<long>() { 11, 12, 13 });
            Assert.AreEqual(1716, result);
            result = Mathlib.LeastCommonMultipleOf(new List<long>() { 2, 3 });
            Assert.AreEqual(6, result);

            // Illegal calls

            try
            {
                Mathlib.LeastCommonMultipleOf(null);
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

            result = Mathlib.GreatestCommonDivisorOf(6, 9);
            Assert.AreEqual(3, result);
            result = Mathlib.GreatestCommonDivisorOf(17, 19);
            Assert.AreEqual(1, result);

            try
            {
                Mathlib.GreatestCommonDivisorOf(0, 1);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }

            try
            {
                Mathlib.GreatestCommonDivisorOf(1, 0);
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }
        }



    }

}
