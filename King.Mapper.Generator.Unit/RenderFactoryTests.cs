namespace King.Mapper.Generator.Unit
{
    using King.Mapper.Generator.Models;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    public class RenderFactoryTests
    {
        [Test]
        public void IsIRenderFactory()
        {
            Assert.IsNotNull(new RenderFactory() as IRenderFactory);
        }

        [Test]
        public void Load()
        {
            var factory = new RenderFactory(true);
            var renderers = factory.Load(new Dictionary<int, IDefinition>());

            Assert.IsNotNull(renderers);
            Assert.AreEqual(1, renderers.Count());
        }

        [Test]
        public void LoadMSTest()
        {
            var factory = new RenderFactory(false, TestSuite.MSTest);
            var renderers = factory.Load(new Dictionary<int, IDefinition>());

            Assert.IsNotNull(renderers);
            Assert.AreEqual(1, renderers.Count());
        }

        [Test]
        public void LoadNUnitTest()
        {
            var factory = new RenderFactory(false, TestSuite.NUnit);
            var renderers = factory.Load(new Dictionary<int, IDefinition>());

            Assert.IsNotNull(renderers);
            Assert.AreEqual(1, renderers.Count());
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LoadManifestNull()
        {
            var factory = new RenderFactory();
            var renderers = factory.Load(null);
        }
    }
}