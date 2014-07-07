namespace King.Mapper.Generator.Unit
{
    using King.Mapper.Generator.Models;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class StoredProceduresRenderTests
    {
        [Test]
        public void Constructor()
        {
            new StoredProceduresRender(new Dictionary<int, Definition>());
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorSchemasNull()
        {
            new StoredProceduresRender(null);
        }

        [Test]
        public void FileName()
        {
            var c = new StoredProceduresRender(new Dictionary<int, Definition>());
            Assert.AreEqual("StoredProcedures.Generated.cs", c.FileName);
        }

        [Test]
        public void Render()
        {
            var c = new StoredProceduresRender(new Dictionary<int, Definition>());
            var output = c.Render();

            Assert.IsFalse(string.IsNullOrWhiteSpace(output));
        }
    }
}