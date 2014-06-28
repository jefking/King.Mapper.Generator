namespace King.Mapper.Generator.Unit
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestClass]
    public class FileWriterTests
    {
        [TestMethod]
        public void Constructor()
        {
            new FileWriter(Guid.NewGuid().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorFolderNull()
        {
            new FileWriter(null);
        }

        [TestMethod]
        public void IsIFileWriter()
        {
            Assert.IsNotNull(new FileWriter(Guid.NewGuid().ToString()) as IFileWriter);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WriteAllRenderersNull()
        {
            var fw = new FileWriter(Guid.NewGuid().ToString());
            fw.WriteAll(null);
        }
    }
}
