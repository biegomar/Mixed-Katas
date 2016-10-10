using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NextBiggerNumber.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1234567908, Kata.NextBiggerNumber(1234567890));
            Assert.AreEqual(21, Kata.NextBiggerNumber(12));
            Assert.AreEqual(531, Kata.NextBiggerNumber(513));
            Assert.AreEqual(2071, Kata.NextBiggerNumber(2017));
            Assert.AreEqual(441, Kata.NextBiggerNumber(414));
            Assert.AreEqual(414, Kata.NextBiggerNumber(144));            
            //1234567890
        }
    }
}
