using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromeChainLength.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given87OutputShouldBe4()
        {
            Assert.AreEqual(4, Kata.palindromeChainLength(87));
        }

        [TestMethod]
        public void Given88OutputShouldBe0()
        {
            Assert.AreEqual(0, Kata.palindromeChainLength(88));
        }
    }
}
