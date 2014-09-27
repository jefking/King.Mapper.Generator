namespace King.Mapper.Generator.Unit.Templates
{
    using King.Data.Sql.Reflection.Models;
    using King.Mapper.Generator.Templates;
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class StoredProceduresUnitTestsTests
    {
        [Test]
        public void Constructor()
        {
            new StoredProceduresUnitTests();
        }

        [Test]
        public void IsIManifestTemplate()
        {
            Assert.IsNotNull(new StoredProceduresUnitTests() as IManifestTemplate);
        }

        [Test]
        public void Manifest()
        {
            var expected = new Dictionary<int, IDefinition>();
            var sp = new StoredProceduresUnitTests()
            {
                Manifest = expected,
            };

            Assert.AreEqual(expected, sp.Manifest);
        }

        [Test]
        public void TestingNamespaceMSTest()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.MSTest);

            Assert.AreEqual("Microsoft.VisualStudio.TestTools.UnitTesting", sp.TestingNamespace);
        }

        [Test]
        public void TestingNamespaceNUnit()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.NUnit);

            Assert.AreEqual("NUnit.Framework", sp.TestingNamespace);
        }

        [Test]
        public void AreEqualGenericMSTest()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.MSTest);

            Assert.IsTrue(sp.AreEqualGeneric);
        }

        [Test]
        public void AreEqualGenericNUnit()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.NUnit);

            Assert.IsFalse(sp.AreEqualGeneric);
        }

        [Test]
        public void TestClassAttributeMSTest()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.MSTest);

            Assert.AreEqual("TestClass", sp.TestClassAttribute);
        }

        [Test]
        public void TestClassAttributeNUnit()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.NUnit);

            Assert.AreEqual("TestFixture", sp.TestClassAttribute);
        }

        [Test]
        public void TestMethodAttributeMSTest()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.MSTest);

            Assert.AreEqual("TestMethod", sp.TestMethodAttribute);
        }

        [Test]
        public void TestMethodAttributeNUnit()
        {
            var sp = new StoredProceduresUnitTests(TestSuite.NUnit);

            Assert.AreEqual("Test", sp.TestMethodAttribute);
        }

        [Test]
        public void TransformText()
        {
            var sp = new StoredProceduresUnitTests()
            {
                Manifest = new Dictionary<int, IDefinition>() as IDictionary<int, IDefinition>,
            };

            Assert.IsFalse(string.IsNullOrWhiteSpace(sp.TransformText()));
        }
    }
}