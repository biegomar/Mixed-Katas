using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SplitString.Test
{
    [TestClass]
    public class SplitStringTest
    {
        [TestMethod]
        public void BasicTests()
        {
            var expected = new string[] { "ab", "c_" };
            var res = SplitString.Solution("abc");
            //Assert.AreEqual(expected, res);
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitString.Solution("abcdef"));
        }
    }
}
