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

        [TestMethod]
        public void Input_AB_Should_Be_True()
        {
            Assert.IsTrue(new Kata().HasUniqueChars("AB"));
        }

        [TestMethod]
        public void Input_baa_Should_Be_False()
        {
            Assert.IsFalse(new Kata().HasUniqueChars("baa"));
        }

        [TestMethod]
        public void Input_Should_Should_Be_True()
        {
            Assert.IsTrue(new Kata().HasUniqueChars("Should"));
        }

        [TestMethod]
        public void Input_abcdef_Should_Be_True()
        {
            Assert.IsTrue(new Kata().HasUniqueChars("abcdef"));
        }

        [TestMethod]
        public void Input_¥[¥[´î_Should_Be_False()
        {
            Assert.IsFalse(new Kata().HasUniqueChars("++-"));
        }

        [TestMethod]
        public void Input_SpaceSpacenAa_Should_Be_False()
        {
            Assert.IsFalse(new Kata().HasUniqueChars("  nAa"));
        }

        [TestMethod]
        public void Input_aba_Should_Be_False()
        {
            Assert.IsFalse(new Kata().HasUniqueChars("aba"));
        }

    }
}
