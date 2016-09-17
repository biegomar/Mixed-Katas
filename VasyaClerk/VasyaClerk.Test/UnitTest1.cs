using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VasyaClerk.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            Assert.AreEqual("YES", Line.Tickets(peopleInLine));
        }

        [TestMethod]
        public void Test2()
        {
            int[] peopleInLine = new int[] { 25, 100 };
            Assert.AreEqual("NO", Line.Tickets(peopleInLine));
        }
       
        [TestMethod]
        public void Test3()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 50, 100, 50 };
            Assert.AreEqual("YES", Line.Tickets(peopleInLine));
        }

        [TestMethod]
        public void Test4()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 100, 100 };
            Assert.AreEqual("NO", Line.Tickets(peopleInLine));
        }
    }
}
