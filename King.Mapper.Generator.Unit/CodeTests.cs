namespace King.Mapper.Generator.Unit
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class CodeTests
    {
        [TestMethod]
        public void Constructor()
        {
            new Code(Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorConnectionStringNull()
        {
            new Code(null, Guid.NewGuid().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorFolderNull()
        {
            new Code(Guid.NewGuid().ToString(), null);
        }
    }
}