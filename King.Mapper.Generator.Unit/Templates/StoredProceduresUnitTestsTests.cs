namespace King.Mapper.Generator.Unit.Templates
{
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Templates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class StoredProceduresUnitTestsTests
    {
        [TestMethod]
        public void Constructor()
        {
            new StoredProceduresUnitTests();
        }

        [TestMethod]
        public void IsIManifestTemplate()
        {
            Assert.IsNotNull(new StoredProceduresUnitTests() as IManifestTemplate);
        }

        [TestMethod]
        public void Manifest()
        {
            var expected = new Dictionary<int, Definition>();
            var sp = new StoredProceduresUnitTests()
            {
                Manifest = expected,
            };

            Assert.AreEqual<IDictionary<int, Definition>>(expected, sp.Manifest);
        }

        [TestMethod]
        public void TestingNamespaceMSTest()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.MSTest);

            Assert.AreEqual<string>("Microsoft.VisualStudio.TestTools.UnitTesting", sp.TestingNamespace);
        }

        [TestMethod]
        public void TestingNamespaceNUnit()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.NUnit);

            Assert.AreEqual<string>("NUnit.Framework", sp.TestingNamespace);
        }

        [TestMethod]
        public void TestClassAttributeMSTest()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.MSTest);

            Assert.AreEqual<string>("TestClass", sp.TestClassAttribute);
        }

        [TestMethod]
        public void TestClassAttributeNUnit()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.NUnit);

            Assert.AreEqual<string>("TestFixture", sp.TestClassAttribute);
        }

        [TestMethod]
        public void TestMethodAttributeMSTest()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.MSTest);

            Assert.AreEqual<string>("TestMethod", sp.TestMethodAttribute);
        }

        [TestMethod]
        public void TestMethodAttributeNUnit()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.NUnit);

            Assert.AreEqual<string>("Test", sp.TestMethodAttribute);
        }

        [TestMethod]
        public void TransformText()
        {
            var sp = new StoredProceduresUnitTests()
            {
                Manifest = new Dictionary<int, Definition>(),
            };

            Assert.IsFalse(string.IsNullOrWhiteSpace(sp.TransformText()));
        }
    }
}
