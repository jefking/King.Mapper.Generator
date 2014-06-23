namespace King.Mapper.Generator.Unit.Models
{
    using King.Mapper.Generator.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using King.Mapper;

    [TestClass]
    public class SchemaTests
    {
        [TestMethod]
        public void Constructor()
        {
            new Schema();
        }

        [TestMethod]
        public void Parameter()
        {
            var item = new Schema();
            var data = Guid.NewGuid().ToString();
            item.Parameter = data;
            Assert.AreEqual<string>(data, item.Parameter);
        }

        [TestMethod]
        public void DataType()
        {
            var item = new Schema();
            var data = Guid.NewGuid().ToString();
            item.DataType = data;
            Assert.AreEqual<string>(data, item.DataType);
        }

        [TestMethod]
        public void Name()
        {
            var item = new Schema();
            var data = Guid.NewGuid().ToString();
            item.Name = data;
            Assert.AreEqual<string>(data, item.Name);
        }

        [TestMethod]
        public void NameAction()
        {
            var item = new Schema();
            var property = (from p in item.GetType().GetProperties()
                            where p.Name == "Preface"
                            select p).FirstOrDefault();

            Assert.IsNotNull(property);
            var action = property.GetAttribute<ActionNameAttribute>();
            Assert.IsNotNull(action);
            Assert.AreEqual<string>("Schema", action.Name);
            Assert.AreEqual<ActionFlags>(ActionFlags.Load, action.Action);
        }

        [TestMethod]
        public void Preface()
        {
            var item = new Schema();
            var data = Guid.NewGuid().ToString();
            item.Preface = data;
            Assert.AreEqual<string>(data, item.Preface);
        }

        [TestMethod]
        public void MaxLength()
        {
            var item = new Schema();
            var data = Guid.NewGuid().ToString();
            item.MaxLength = data;
            Assert.AreEqual<string>(data, item.MaxLength);
        }
    }
}