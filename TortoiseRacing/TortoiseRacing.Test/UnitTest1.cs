using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TortoiseRacing.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual({ 0, 32, 18 }, Tortoise.Race(720, 850, 70));                        
        }

        [TestMethod]
        public void TestMethod2()
        {            
            Assert.AreEqual(new int[] { 3, 21, 49 }, Tortoise.Race(80, 91, 37));            
        }

        [TestMethod]
        public void TestMethod3()
        {            
            Assert.AreEqual(new int[] { 2, 0, 0 }, Tortoise.Race(80, 100, 40));
        }
    }
}
