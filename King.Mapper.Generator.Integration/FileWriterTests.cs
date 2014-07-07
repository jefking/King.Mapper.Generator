namespace King.Mapper.Generator.Integration
{
    using NUnit.Framework;
    using NSubstitute;
    using System;
    using System.Collections.Generic;
    using System.IO;

    [TestFixture]
    public class FileWriterTests
    {
        [Test]
        public void WriteAll()
        {
            var fileName = "test.write";
            var contents = Guid.NewGuid().ToString();
            var folder = Directory.GetCurrentDirectory();
            var file = string.Format("{0}{1}", folder, fileName);
            
            var renderer = Substitute.For<IRender>();
            renderer.FileName.Returns(fileName);
            renderer.Render().Returns(contents);

            var renderers = new List<IRender>();
            renderers.Add(renderer);

            var fw = new FileWriter(folder);
            fw.WriteAll(renderers);

            renderer.Received().Render();

            var returned = File.ReadAllText(file);
            Assert.AreEqual(contents, returned);
            File.Delete(file);
        }
    }
}
