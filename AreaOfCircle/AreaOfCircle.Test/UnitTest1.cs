using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaOfCircle.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ShouldFailNegativeNumber()
        {
            Kata.CalculateAreaOfCircle("-123");
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void ShouldFailAlphaNumeric()
        {
            Kata.CalculateAreaOfCircle("number");
        }

        [TestMethod]
        public void ShouldPass1()
        {
            Assert.AreEqual(5881.25, Kata.CalculateAreaOfCircle("43.2673"));
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void WrongFormat()
        {
            Kata.CalculateAreaOfCircle("43,2673");
        }
    }
}
