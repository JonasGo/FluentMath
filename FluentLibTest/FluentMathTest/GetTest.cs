using System.Collections.Generic;
using System.Linq;

using FluentLib;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentLibTest.FluentMathTest
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

            evenValues = FluentMath.Get().EvenValues.OutOf(new List<int>() { 1, 2, 3, 4, 5, 6 });
            Assert.IsTrue(new List<int>() { 2, 4, 6 }.SequenceEqual(evenValues));

            evenValues = FluentMath.Get().EvenValues.OutOf(new List<int>() { 8, 8, 5, 3, 2, 9, 10 });
            Assert.IsTrue(new List<int>() { 8, 8, 2, 10 }.SequenceEqual(evenValues));
        }
    }
}
