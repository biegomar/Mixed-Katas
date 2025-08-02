using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GetTheLoop.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FourNodesWithLoopSize3()
        {
            var n1 = new LoopDetector.Node();
            var n2 = new LoopDetector.Node();
            var n3 = new LoopDetector.Node();
            var n4 = new LoopDetector.Node();
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n2;
            Assert.AreEqual(3, Kata.getLoopSize(n1));
        }
    }
}
