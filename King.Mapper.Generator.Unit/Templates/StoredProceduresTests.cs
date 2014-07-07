namespace King.Mapper.Generator.Unit.Templates
{
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Templates;
    using NUnit.Framework;
    using System.Collections.Generic;

    [TestFixture]
    public class StoredProceduresTests
    {
        [Test]
        public void Constructor()
        {
            new StoredProcedures();
        }

        [Test]
        public void IsIManifestTemplate()
        {
            Assert.IsNotNull(new StoredProcedures() as IManifestTemplate);
        }

        [Test]
        public void Manifest()
        {
            var expected = new Dictionary<int, Definition>();
            var sp = new StoredProcedures()
            {
                Manifest = expected,
            };

            Assert.AreEqual(expected, sp.Manifest);
        }

        [Test]
        public void TransformText()
        {
            var sp = new StoredProcedures()
            {
                Manifest = new Dictionary<int, Definition>(),
            };

            Assert.IsFalse(string.IsNullOrWhiteSpace(sp.TransformText()));
        }
    }
}