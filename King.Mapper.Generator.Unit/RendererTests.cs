namespace King.Mapper.Generator.Unit
{
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Templates;
    using NUnit.Framework;
    using NSubstitute;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class RendererTests
    {
        [Test]
        public void Constructor()
        {
            var template = Substitute.For<IManifestTemplate>();
            new Renderer(template, new Dictionary<int, IDefinition>(), Guid.NewGuid().ToString());
        }

        [Test]
        public void IsIRender()
        {
            var template = Substitute.For<IManifestTemplate>();
            Assert.IsNotNull(new Renderer(template, new Dictionary<int, IDefinition>(), Guid.NewGuid().ToString()) as IRender);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorSchemasNull()
        {
            var template = Substitute.For<IManifestTemplate>();
            new Renderer(template, null, Guid.NewGuid().ToString());
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorTemplateNull()
        {
            new Renderer(null, new Dictionary<int, IDefinition>(), Guid.NewGuid().ToString());
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorFileNull()
        {
            var template = Substitute.For<IManifestTemplate>();
            new Renderer(template, new Dictionary<int, IDefinition>(), null);
        }

        [Test]
        public void FileName()
        {
            var file = Guid.NewGuid().ToString();
            var template = Substitute.For<IManifestTemplate>();
            var c = new Renderer(template, new Dictionary<int, IDefinition>(), file);
            Assert.AreEqual(file, c.FileName);
        }

        [Test]
        public void Render()
        {
            var template = Substitute.For<IManifestTemplate>();
            template.TransformText().Returns(Guid.NewGuid().ToString());
            var c = new Renderer(template, new Dictionary<int, IDefinition>(), Guid.NewGuid().ToString());
            var output = c.Render();

            template.Received().TransformText();
        }
    }
}