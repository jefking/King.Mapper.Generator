namespace King.Mapper.Generator.Unit
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class FileWriterTests
    {
        [Test]
        public void Constructor()
        {
            new FileWriter(Guid.NewGuid().ToString());
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorFolderNull()
        {
            new FileWriter(null);
        }

        [Test]
        public void IsIFileWriter()
        {
            Assert.IsNotNull(new FileWriter(Guid.NewGuid().ToString()) as IFileWriter);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WriteAllRenderersNull()
        {
            var fw = new FileWriter(Guid.NewGuid().ToString());
            fw.WriteAll(null);
        }
    }
}
