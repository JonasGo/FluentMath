using System;
using System.Collections.Generic;

using FluentLib;
using FluentLib.Math;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentLibTest.FluentMathTest
{
    /// <summary>
    /// Summary description for IsTest
    /// </summary>
    [TestClass]
    public class IsTest
    {
        [TestMethod]
        public void InitializeIs()
        {
            Is isClass = FluentMath.Is((int)5);
            Assert.AreEqual(5, isClass.Value);
        }

        [TestMethod]
        public void IsValueEvenlyDivisableBy()
        {   
            bool result;

            // Single calls
            
            result = FluentMath.Is(5).EvenlyDivisableBy(5);
            Assert.IsTrue(result);
            result = FluentMath.Is(5).EvenlyDivisableBy(2);
            Assert.IsFalse(result);

            // Illegal calls

            try
            {
                result = FluentMath.Is(5).EvenlyDivisableBy(0);
                Assert.Fail("Exception not thrown");
            }
            catch (DivideByZeroException)
            {
                // Everything went like planned :)
            }

            // Multiple calls

            result = FluentMath.Is(6).EvenlyDivisableBy(new List<int>() {2, 3, 6});
            Assert.IsTrue(result);
            result = FluentMath.Is(6).EvenlyDivisableBy(new List<int>() { 2, 3, 7 });
            Assert.IsFalse(result);


        }
    }
}
