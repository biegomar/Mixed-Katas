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
            Assert.AreEqual(483559, Kata.NextBiggerNumber(459853));
            Assert.AreEqual(21, Kata.NextBiggerNumber(12));
            Assert.AreEqual(531, Kata.NextBiggerNumber(513));
            Assert.AreEqual(2071, Kata.NextBiggerNumber(2017));
            Assert.AreEqual(441, Kata.NextBiggerNumber(414));
            Assert.AreEqual(414, Kata.NextBiggerNumber(144));            
            Assert.AreEqual(1234567908, Kata.NextBiggerNumber(1234567890));
            Assert.AreEqual(59884848483559, Kata.NextBiggerNumber(59884848459853));
            Assert.AreEqual(1205712228, Kata.NextBiggerNumber(1205287221));
        }

        [TestMethod]
        public void NoSolution()
        {
            Assert.AreEqual(-1, Kata.NextBiggerNumber(9));
            Assert.AreEqual(-1, Kata.NextBiggerNumber(111));
            Assert.AreEqual(-1, Kata.NextBiggerNumber(531));
        }
    }
}
