namespace King.Mapper.Generator.Unit.Models
{
    using King.Mapper.Generator.Models;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class DefinitionTests
    {
        [Test]
        public void Constructor()
        {
            new Definition();
        }

        [Test]
        public void Preface()
        {
            var item = new Definition();
            var data = Guid.NewGuid().ToString();
            item.Preface = data;
            Assert.AreEqual(data, item.Preface);
        }

        [Test]
        public void Name()
        {
            var item = new Definition();
            var data = Guid.NewGuid().ToString();
            item.Name = data;
            Assert.AreEqual(data, item.Name);
        }

        [Test]
        public void Variables()
        {
            var item = new Definition();
            var data = new List<Variable>();
            item.Variables = data;
            Assert.AreEqual(data, item.Variables);
        }
    }
}