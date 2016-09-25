using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BalanceParantheses.Test
{
    using BalanceParentheses;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, Kata.IsBalanced("(Sensei says yes!)", "()"));            
        }

        [TestMethod]
        public void TestMethod2()
        {           
            Assert.AreEqual(false, Kata.IsBalanced("(Sensei says no!", "()"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(true, Kata.IsBalanced("(Sensei [says] yes!)", "()[]"));            
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(false, Kata.IsBalanced("(Sensei [says) no!]", "()[]"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(true, Kata.IsBalanced("Sensei says -yes-!", "--"));            
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(false, Kata.IsBalanced("Sensei -says no!", "--"));
        }
    }
}
