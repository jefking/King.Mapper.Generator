namespace King.Mapper.Generator.Unit.Templates
{
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Templates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class StoredProceduresTests
    {
        [TestMethod]
        public void Constructor()
        {
            new StoredProcedures();
        }

        [TestMethod]
        public void Manifest()
        {
            var expected = new Dictionary<string, Definition>();
            var sp = new StoredProcedures()
            {
                Manifest = expected,
            };

            Assert.AreEqual<IDictionary<string, Definition>>(expected, sp.Manifest);
        }

        [TestMethod]
        public void TransformText()
        {
            var sp = new StoredProcedures()
            {
                Manifest = new Dictionary<string, Definition>(),
            };

            Assert.IsFalse(string.IsNullOrWhiteSpace(sp.TransformText()));
        }
    }
}