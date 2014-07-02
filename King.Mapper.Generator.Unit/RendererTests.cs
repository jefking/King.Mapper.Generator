namespace King.Mapper.Generator.Unit
{
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Templates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NSubstitute;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class RendererTests
    {
        [TestMethod]
        public void Constructor()
        {
            var template = Substitute.For<IManifestTemplate>();
            new Renderer(template, new Dictionary<int, Definition>(), Guid.NewGuid().ToString());
        }

        [TestMethod]
        public void IsIRender()
        {
            var template = Substitute.For<IManifestTemplate>();
            Assert.IsNotNull(new Renderer(template, new Dictionary<int, Definition>(), Guid.NewGuid().ToString()) as IRender);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorSchemasNull()
        {
            var template = Substitute.For<IManifestTemplate>();
            new Renderer(template, null, Guid.NewGuid().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorTemplateNull()
        {
            new Renderer(null, new Dictionary<int, Definition>(), Guid.NewGuid().ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorFileNull()
        {
            var template = Substitute.For<IManifestTemplate>();
            new Renderer(template, new Dictionary<int, Definition>(), null);
        }

        [TestMethod]
        public void FileName()
        {
            var file = Guid.NewGuid().ToString();
            var template = Substitute.For<IManifestTemplate>();
            var c = new Renderer(template, new Dictionary<int, Definition>(), file);
            Assert.AreEqual<string>(file, c.FileName);
        }

        [TestMethod]
        public void Render()
        {
            var template = Substitute.For<IManifestTemplate>();
            template.TransformText().Returns(Guid.NewGuid().ToString());
            var c = new Renderer(template, new Dictionary<int, Definition>(), Guid.NewGuid().ToString());
            var output = c.Render();

            template.Received().TransformText();
        }
    }
}