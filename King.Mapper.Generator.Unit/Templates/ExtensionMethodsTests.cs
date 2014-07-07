namespace King.Mapper.Generator.Unit.Templates
{
    using King.Mapper.Generator.Templates;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtensionMethodsTests
    {
        [Test]
        public void ConvertToCamelCaseParameter()
        {
            var data = "test string test";
            var expected = "Test String Test";
            Assert.AreEqual(expected, data.CamelCase());
        }

        [Test]
        public void ConvertToCamelCaseParameterTrim()
        {
            var data = "  test     string  test          ";
            var expected = "Test     String  Test";
            Assert.AreEqual(expected, data.CamelCase());
        }

        [Test]
        public void CamelCaseStringNull()
        {
            string data = null;
            Assert.IsNull(data.CamelCase());
        }
    }
}