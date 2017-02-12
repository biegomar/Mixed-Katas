using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelpYourGranny.Test
{
    using System.Collections;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] friends1 = new string[] { "A1", "A2", "A3", "A4", "A5" };
            string[][] fTowns1 = { new string[] { "A1", "X1" }, new string[] { "A2", "X2" }, new string[] { "A3", "X3" }, new string[] { "A4", "X4" } };
            Hashtable distTable1 = new Hashtable { { "X1", 100.0 }, { "X2", 200.0 }, { "X3", 250.0 }, { "X4", 300.0 } };
            Assert.AreEqual(889, Tour.tour(friends1, fTowns1, distTable1));
        }
    }
}
