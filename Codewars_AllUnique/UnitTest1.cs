using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_AllUnique
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_StringEmpty_Should_Be_True()
        {
            //arrange
            var input = string.Empty;
            var kata = new Kata();
            //actual
            var isUniqueChars = kata.HasUniqueChars(input);
            //assert
            Assert.IsTrue(isUniqueChars);
        }
    }
}
