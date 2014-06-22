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
    public class VariableTest
    {
        #region Valid Cases
        [TestMethod]
        public void Constructor()
        {
            new Variable();
        }

        [TestMethod]
        public void DataType()
        {
            var item = new Variable();
            var data = Guid.NewGuid().ToString();
            item.DataType = data;
            Assert.AreEqual<string>(data, item.DataType);
        }

        [TestMethod]
        public void Name()
        {
            var item = new Variable();
            var data = Guid.NewGuid().ToString();
            item.Name = data;
            Assert.AreEqual<string>(data, item.Name);
        }

        [TestMethod]
        public void MaxLength()
        {
            var random = new Random();
            var item = new Variable();
            var data = random.Next();
            item.MaxLength = data;
            Assert.AreEqual<int>(data, item.MaxLength);
        }
        #endregion
    }
}
