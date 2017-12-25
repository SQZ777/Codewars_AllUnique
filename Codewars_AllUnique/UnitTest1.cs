using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_AllUnique
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_StringEmpty_Should_Be_True()
        {
            Assert.IsTrue(new Kata().HasUniqueChars(string.Empty));
        }

        [TestMethod]
        public void Input_a_Should_Be_True()
        {
            Assert.IsTrue(new Kata().HasUniqueChars("a"));
        }

        [TestMethod]
        public void Input_aa_Should_Be_False()
        {
            Assert.IsFalse(new Kata().HasUniqueChars("aa"));
        }
    }
}
