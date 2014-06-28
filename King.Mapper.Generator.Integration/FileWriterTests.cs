namespace King.Mapper.Generator.Integration
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NSubstitute;
    using System;
    using System.Collections.Generic;
    using System.IO;

    [TestClass]
    public class FileWriterTests
    {
        [TestMethod]
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
            Assert.AreEqual<string>(contents, returned);
            File.Delete(file);
        }
    }
}
