namespace King.Mapper.Generator.Unit
{
    using King.Mapper.Generator.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class CodeTests
    {
        [TestMethod]
        public void Constructor()
        {
            new StoredProceduresRender(new Dictionary<int, Definition>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorSchemasNull()
        {
            new StoredProceduresRender(null);
        }

        [TestMethod]
        public void FileName()
        {
            var c = new StoredProceduresRender(new Dictionary<int, Definition>());
            Assert.AreEqual<string>("StoredProcedures.Generated.cs", c.FileName);
        }

        [TestMethod]
        public void Render()
        {
            var c = new StoredProceduresRender(new Dictionary<int, Definition>());
            var output = c.Render();

            Assert.IsFalse(string.IsNullOrWhiteSpace(output));
        }
    }
}