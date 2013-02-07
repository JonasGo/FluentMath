using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Versuch1.Math;

namespace TestVersuch1
{
    /// <summary>
    /// Summary description for GetTest
    /// </summary>
    [TestClass]
    public class GetTest
    {
        [TestMethod]
        public void GetEvenNumbersOutOfTest()
        {
            List<int> evenValues;

            evenValues = Mathlib.Get().EvenValues.OutOf(new List<int>() { 1, 2, 3, 4, 5, 6 });
            Assert.IsTrue(new List<int>() { 2, 4, 6 }.SequenceEqual(evenValues));

            evenValues = Mathlib.Get().EvenValues.OutOf(new List<int>() { 8, 8, 5, 3, 2, 9, 10 });
            Assert.IsTrue(new List<int>() { 8, 8, 2, 10 }.SequenceEqual(evenValues));

        }
    }
}
