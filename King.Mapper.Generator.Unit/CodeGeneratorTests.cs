namespace King.Mapper.Generator.Unit
{
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Sql;
    using NSubstitute;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [TestFixture]
    public class CodeGeneratorTests
    {
        [Test]
        public void Constructor()
        {
            var loader = Substitute.For<IDataLoader>();
            var factory = Substitute.For<IRenderFactory>();
            var writer = Substitute.For<IFileWriter>();

            new CodeGenerator(loader, factory, writer);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorLoaderNull()
        {
            var factory = Substitute.For<IRenderFactory>();
            var writer = Substitute.For<IFileWriter>();

            new CodeGenerator(null, factory, writer);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorFactoryNull()
        {
            var loader = Substitute.For<IDataLoader>();
            var writer = Substitute.For<IFileWriter>();

            new CodeGenerator(loader, null, writer);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorWriterNull()
        {
            var loader = Substitute.For<IDataLoader>();
            var factory = Substitute.For<IRenderFactory>();

            new CodeGenerator(loader, factory, null);
        }

        [Test]
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
