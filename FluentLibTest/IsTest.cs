using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Versuch1;
using Versuch1.Math;

namespace TestVersuch1
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
            Is isClass = Mathlib.Is((int)5);
            Assert.AreEqual(5, isClass.Value);
            Assert.AreEqual(typeof(long), isClass.Type);
        }

        [TestMethod]
        public void IsValueEvenlyDivisableBy()
        {   
            bool result;

            // Single calls
            
            result = Mathlib.Is(5).EvenlyDivisableBy(5);
            Assert.IsTrue(result);
            result = Mathlib.Is(5).EvenlyDivisableBy(2);
            Assert.IsFalse(result);

            // Illegal calls

            try
            {
                result = Mathlib.Is(5).EvenlyDivisableBy(0);
                Assert.Fail("Exception not thrown");
            }
            catch (DivideByZeroException)
            {
                // Everything went like planned :)
            }

            // Multiple calls

            result = Mathlib.Is(6).EvenlyDivisableBy(new List<int>() {2, 3, 6});
            Assert.IsTrue(result);
            result = Mathlib.Is(6).EvenlyDivisableBy(new List<int>() { 2, 3, 7 });
            Assert.IsFalse(result);


        }
    }
}
