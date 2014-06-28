namespace King.Mapper.Generator.Unit.Models
{
    using King.Mapper.Generator.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestClass]
    public class DefinitionComparerTests
    {
        [TestMethod]
        public void EqualsTrue()
        {
            var preface = Guid.NewGuid().ToString();
            var name = Guid.NewGuid().ToString();
            var x = new Definition()
            {
                Preface = preface,
                Name = name,
            };
            var y = new Definition()
            {
                Preface = preface,
                Name = name,
            };
            var c = new DefinitionComparer();
            Assert.IsTrue(c.Equals(x, y));
        }

        [TestMethod]
        public void EqualsSame()
        {
            var preface = Guid.NewGuid().ToString();
            var name = Guid.NewGuid().ToString();
            var x = new Definition()
            {
                Preface = preface,
                Name = name,
            };

            var c = new DefinitionComparer();
            Assert.IsTrue(c.Equals(x, x));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EqualsXNull()
        {
            var x = new Definition()
            {
                Preface = Guid.NewGuid().ToString(),
                Name = Guid.NewGuid().ToString(),
            };

            var c = new DefinitionComparer();
            c.Equals(null, x);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EqualsYNull()
        {
            var x = new Definition()
            {
                Preface = Guid.NewGuid().ToString(),
                Name = Guid.NewGuid().ToString(),
            };

            var c = new DefinitionComparer();
            c.Equals(x, null);
        }

        [TestMethod]
        public void Equalsfalse()
        {
            var x = new Definition()
            {
                Preface = Guid.NewGuid().ToString(),
                Name = Guid.NewGuid().ToString(),
            };
            var y = new Definition()
            {
                Preface = Guid.NewGuid().ToString(),
                Name = Guid.NewGuid().ToString(),
            };

            var c = new DefinitionComparer();
            Assert.IsFalse(c.Equals(x, y));
        }

        [TestMethod]
        public void GetHashCodeTest()
        {
            var x = new Definition()
            {
                Preface = Guid.NewGuid().ToString(),
                Name = Guid.NewGuid().ToString(),
            };

            var hash = string.Format("{0}{1}", x.Preface, x.Name).GetHashCode();
            var c = new DefinitionComparer();
            Assert.AreEqual<int>(hash, c.GetHashCode(x));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetHashCodeDefinitionNull()
        {
            var c = new DefinitionComparer();
            c.GetHashCode(null);
        }
    }
}