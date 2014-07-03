namespace King.Mapper.Generator.Unit
{
    using King.Mapper.Generator.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class RenderFactoryTests
    {
        [TestMethod]
        public void IsIRenderFactory()
        {
            Assert.IsNotNull(new RenderFactory() as IRenderFactory);
        }

        [TestMethod]
        public void Load()
        {
            var factory = new RenderFactory();
            var renderers = factory.Load(new Dictionary<int, Definition>());

            Assert.IsNotNull(renderers);
            Assert.AreEqual<int>(1, renderers.Count());
        }

        [TestMethod]
        public void LoadTest()
        {
            var factory = new RenderFactory(true);
            var renderers = factory.Load(new Dictionary<int, Definition>());

            Assert.IsNotNull(renderers);
            Assert.AreEqual<int>(2, renderers.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LoadManifestNull()
        {
            var factory = new RenderFactory();
            var renderers = factory.Load(null);
        }
    }
}