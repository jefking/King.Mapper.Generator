namespace King.Mapper.Generator.Unit.Models
{
    using King.Mapper.Generator.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class DefinitionTests
    {
        [TestMethod]
        public void Constructor()
        {
            new Definition();
        }

        [TestMethod]
        public void IsIComparable()
        {
            Assert.IsNotNull(new Definition() as IComparable);
        }

        [TestMethod]
        public void Preface()
        {
            var item = new Definition();
            var data = Guid.NewGuid().ToString();
            item.Preface = data;
            Assert.AreEqual<string>(data, item.Preface);
        }

        [TestMethod]
        public void Name()
        {
            var item = new Definition();
            var data = Guid.NewGuid().ToString();
            item.Name = data;
            Assert.AreEqual<string>(data, item.Name);
        }

        [TestMethod]
        public void Variables()
        {
            var item = new Definition();
            var data = new List<Variable>();
            item.Variables = data;
            Assert.AreEqual<IEnumerable<Variable>>(data, item.Variables);
        }

        [TestMethod]
        public void CompareTo()
        {
            var item = new Definition()
            {
                Name = Guid.NewGuid().ToString(),
                Preface = Guid.NewGuid().ToString(),
            };
            var compare = new Definition()
            {
                Name = Guid.NewGuid().ToString(),
                Preface = Guid.NewGuid().ToString(),
            };
            Assert.AreEqual<int>(item.Preface.CompareTo(compare.Preface) + item.Name.CompareTo(compare.Name), item.CompareTo(compare));
        }
    }
}