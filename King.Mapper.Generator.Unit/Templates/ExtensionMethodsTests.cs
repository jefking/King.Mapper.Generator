namespace King.Mapper.Generator.Unit.Templates
{
    using King.Mapper.Generator.Templates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class ExtensionMethodsTests
    {
        [TestMethod]
        public void ConvertToCamelCaseParameter()
        {
            var data = "test string test";
            var expected = "Test String Test";
            Assert.AreEqual(expected, data.CamelCase());
        }

        [TestMethod]
        public void ConvertToCamelCaseParameterTrim()
        {
            var data = "  test     string  test          ";
            var expected = "Test     String  Test";
            Assert.AreEqual(expected, data.CamelCase());
        }

        [TestMethod]
        public void CamelCaseStringNull()
        {
            string data = null;
            Assert.IsNull(data.CamelCase());
        }
    }
}