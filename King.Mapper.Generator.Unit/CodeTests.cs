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
            new Code(new List<Schema>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorSchemasNull()
        {
            new Code(null);
        }
    }
}