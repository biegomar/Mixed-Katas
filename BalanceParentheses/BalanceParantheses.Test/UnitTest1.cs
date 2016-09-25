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
            Assert.AreEqual(false, Kata.IsBalanced("(Sensei says no!", "()"));

            Assert.AreEqual(true, Kata.IsBalanced("(Sensei [says] yes!)", "()[]"));
            Assert.AreEqual(false, Kata.IsBalanced("(Sensei [says) no!]", "()[]"));

            Assert.AreEqual(true, Kata.IsBalanced("Sensei says -yes-!", "--"));
            Assert.AreEqual(false, Kata.IsBalanced("Sensei -says no!", "--"));
        }
    }
}
