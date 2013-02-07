using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Versuch1;
using Versuch1.Math;

namespace TestVersuch1
{
    [TestClass]
    public class MultiplesTest
    {
        [TestMethod]
        public void InstantiateMultiplesClass()
        {
            // Intitialize variables

            Multiples multipleClass;

            //Tests

            multipleClass = Mathlib.MultiplesOf(3);
            Assert.IsNotNull(multipleClass);
            Assert.IsTrue(multipleClass.Values.Contains(3));

            multipleClass = Mathlib.MultiplesOf(2);
            Assert.IsNotNull(multipleClass);
            Assert.IsTrue(multipleClass.Values.Contains(2));

            // Impossible calls
            try
            {
                multipleClass = Mathlib.MultiplesOf(-1);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
                // This is the right way, yay
            }

        }

        [TestMethod]
        public void GenerateMultiplesList()
        {
            List<int> multiples;

            multiples = Mathlib.MultiplesOf(3).Under(10);
            Assert.IsTrue(multiples.SequenceEqual(new List<int>() { 3, 6, 9 }));

            multiples = Mathlib.MultiplesOf(2).Under(10);
            Assert.IsTrue(multiples.SequenceEqual(new List<int>() { 2, 4, 6, 8 }));

            multiples = Mathlib.MultiplesOf(2).Under(10);
            Assert.IsFalse(multiples.SequenceEqual(new List<int>() { 2, 4, 6 }));

            multiples = Mathlib.MultiplesOf(5).Under(5);
            Assert.AreEqual(0, multiples.Count);
        }

        [TestMethod]
        public void GenerateMultiplesListFromSeveralValues()
        {
            List<int> multiples;

            multiples = Mathlib.MultiplesOf(3).Or(5).Under(10);
            Assert.IsTrue(multiples.SequenceEqual(new List<int>() { 3, 5, 6, 9 }));
        }
    }
}