namespace King.Mapper.Generator.Unit
{
    using King.Data.Sql.Reflection;
    using King.Data.Sql.Reflection.Models;
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
            var loader = Substitute.For<ISchemaReader>();
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
            var loader = Substitute.For<ISchemaReader>();
            var writer = Substitute.For<IFileWriter>();

            new CodeGenerator(loader, null, writer);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorWriterNull()
        {
            var loader = Substitute.For<ISchemaReader>();
            var factory = Substitute.For<IRenderFactory>();

            new CodeGenerator(loader, factory, null);
        }

        [Test]
        public async Task Generate()
        {
            var manifest = new List<IDefinition>();
            var loader = Substitute.For<ISchemaReader>();
            loader.Load().Returns(Task.FromResult<IEnumerable<IDefinition>>(manifest));

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
