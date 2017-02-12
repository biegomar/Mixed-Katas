using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimplePigLatin.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KataTests1()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));         
        }

        [TestMethod]
        public void KataTests2()
        {            
            Assert.AreEqual("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
        }
    }
}
