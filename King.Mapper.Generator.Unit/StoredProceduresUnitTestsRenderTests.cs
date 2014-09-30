namespace King.Mapper.Generator.Unit
{
    using King.Data.Sql.Reflection.Models;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class StoredProceduresUnitTestsRenderTests
    {
        [Test]
        public void Constructor()
        {
            new StoredProceduresUnitTestsRender(new List<IDefinition>());
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorSchemasNull()
        {
            new StoredProceduresUnitTestsRender(null);
        }

        [Test]
        public void FileName()
        {
            var c = new StoredProceduresUnitTestsRender(new List<IDefinition>());
            Assert.AreEqual("StoredProcedures.Unit.Test.Generated.cs", c.FileName);
        }

        [Test]
        public void Render()
        {
            var c = new StoredProceduresUnitTestsRender(new List<IDefinition>());
            var output = c.Render();

            Assert.IsFalse(string.IsNullOrWhiteSpace(output));
        }
    }
}