namespace King.Mapper.Generator.Unit.Sql
{
    using King.Mapper.Data;
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Sql;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NSubstitute;
    using System;

    [TestClass]
    public class DataLoaderTests
    {
        [TestMethod]
        public void Constructor()
        {
            var loader = Substitute.For<ILoader<Schema>>();
            new DataLoader(Guid.NewGuid().ToString(), loader);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorConnectionStringNull()
        {
            var loader = Substitute.For<ILoader<Schema>>();
            new DataLoader(null, loader);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorLoaderNull()
        {
            new DataLoader(Guid.NewGuid().ToString(), null);
        }
    }
}