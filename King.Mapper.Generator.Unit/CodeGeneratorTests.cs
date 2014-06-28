namespace King.Mapper.Generator.Unit
{
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Sql;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NSubstitute;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestClass]
    public class CodeGeneratorTests
    {
        [TestMethod]
        public void Constructor()
        {
            var loader = Substitute.For<IDataLoader>();
            var factory = Substitute.For<IRenderFactory>();
            var writer = Substitute.For<IFileWriter>();

            new CodeGenerator(loader, factory, writer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorLoaderNull()
        {
            var factory = Substitute.For<IRenderFactory>();
            var writer = Substitute.For<IFileWriter>();

            new CodeGenerator(null, factory, writer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorFactoryNull()
        {
            var loader = Substitute.For<IDataLoader>();
            var writer = Substitute.For<IFileWriter>();

            new CodeGenerator(loader, null, writer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorWriterNull()
        {
            var loader = Substitute.For<IDataLoader>();
            var factory = Substitute.For<IRenderFactory>();

            new CodeGenerator(loader, factory, null);
        }

        [TestMethod]
        public async Task Generate()
        {
            IDictionary<int, Definition> manifest = new Dictionary<int, Definition>();
            var loader = Substitute.For<IDataLoader>();
            loader.Load().Returns(Task.FromResult(manifest));

            var renderers = new List<IRender>();
            var factory = Substitute.For<IRenderFactory>();
            factory.Load(manifest).Returns(renderers);

            var writer = Substitute.For<IFileWriter>();
            writer.WriteAll(renderers);

            var c = new CodeGenerator(loader, factory, writer);
            await c.Generate();
        }
    }
}
