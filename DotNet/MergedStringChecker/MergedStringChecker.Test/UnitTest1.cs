using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MergedStringChecker.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HappyPath1()
        {
            Assert.IsTrue(StringMerger.isMerge("codewars", "code", "wars"), "codewars can be created from code and wars");
        }

        [TestMethod]
        public void HappyPath2()
        {
            Assert.IsTrue(StringMerger.isMerge("codewars", "cdwr", "oeas"), "codewars can be created from cdwr and oeas");
        }

        [TestMethod]
        public void SadPath1()
        {
            Assert.IsFalse(StringMerger.isMerge("codewars", "cod", "wars"), "Codewars are not codwars");
        }

        [TestMethod]
        public void CanHandleExtraChars()
        {
            Assert.IsFalse(StringMerger.isMerge("codewars", "code", "warss"), "codewars is not codewarss");
        }

        [TestMethod]
        public void CanHandleBananas()
        {
            Assert.IsTrue(StringMerger.isMerge("Bananas from Bahamas", "Bahas", "Bananas from am"), "Going bananas!");            
        }
    }
}
