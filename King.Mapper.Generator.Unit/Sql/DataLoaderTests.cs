namespace King.Mapper.Generator.Unit.Sql
{
    using King.Mapper.Data;
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Sql;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NSubstitute;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    [TestClass]
    public class DataLoaderTests
    {
        [TestMethod]
        public void Constructor()
        {
            new DataLoader(Guid.NewGuid().ToString());
        }

        [TestMethod]
        public void ConstructorWithLoader()
        {
            var loader = Substitute.For<ILoader<Schema>>();
            new DataLoader(Guid.NewGuid().ToString(), loader);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorConnectionStringNull()
        {
            var loader = Substitute.For<ILoader<Schema>>();
            new DataLoader(null, loader);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorLoaderNull()
        {
            new DataLoader(Guid.NewGuid().ToString(), null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BuildManifestDefinitionsNull()
        {
            var loader = Substitute.For<ILoader<Schema>>();
            var dl = new DataLoader(Guid.NewGuid().ToString(), loader);
            dl.BuildManifest(null, new List<Schema>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BuildManifestSchemaNull()
        {
            var loader = Substitute.For<ILoader<Schema>>();
            var dl = new DataLoader(Guid.NewGuid().ToString(), loader);
            dl.BuildManifest(new List<Definition>(), null);
        }

        [TestMethod]
        public void BuildManifest()
        {
            var random = new Random();
            var defs = new List<Definition>();
            var schemas = new List<Schema>();
            var schema = new Schema()
            {
                Name = Guid.NewGuid().ToString(),
                Preface = Guid.NewGuid().ToString(),
            };
            var def = schema.Map<Definition>(); 
            defs.Add(def);

            var schemaCount = random.Next(15);
            for (var i = 0; i < schemaCount; i++)
            {
                var s = new Schema()
                {
                    Name = schema.Name,
                    Preface = schema.Preface,
                    DataType = Guid.NewGuid().ToString(),
                    Parameter = Guid.NewGuid().ToString(),
                };
                schemas.Add(s);
            }
            var count = random.Next(15);
            for (var i = 0; i < count; i++)
            {
                var d = new Definition()
                {
                    Name = Guid.NewGuid().ToString(),
                    Preface = Guid.NewGuid().ToString(),
                };
                defs.Add(d);
            }

            var loader = Substitute.For<ILoader<Schema>>();
            var dl = new DataLoader(Guid.NewGuid().ToString(), loader);
            var manifest = dl.BuildManifest(defs, schemas);
            Assert.IsNotNull(manifest);
            Assert.AreEqual<int>(count + 1, manifest.Count);
            var c = new DefinitionComparer();
            Assert.AreEqual<int>(schemaCount, manifest[c.GetHashCode(def)].Variables.Count());
        }

        [TestMethod]
        public void BuildManifestEmtpy()
        {
            var loader = Substitute.For<ILoader<Schema>>();
            var dl = new DataLoader(Guid.NewGuid().ToString(), loader);
            var returned = dl.BuildManifest(new List<Definition>(), new List<Schema>());
            Assert.IsNotNull(returned);
            Assert.AreEqual<int>(0, returned.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MinimizeSchemaNull()
        {
            var loader = Substitute.For<ILoader<Schema>>();
            var dl = new DataLoader(Guid.NewGuid().ToString(), loader);
            dl.Minimize(null);
        }

        [TestMethod]
        public void Minimize()
        {
            var schemas = new List<Schema>();
            var schema = new Schema()
            {
                Name = Guid.NewGuid().ToString(),
                Preface = Guid.NewGuid().ToString(),
            };

            schemas.AddRange(new[] { schema, schema, schema, schema });
            
            var loader = Substitute.For<ILoader<Schema>>();
            var dl = new DataLoader(Guid.NewGuid().ToString(), loader);
            var returned = dl.Minimize(schemas);

            Assert.IsNotNull(returned);
            Assert.AreEqual<int>(1, returned.Count());
            var def = returned.FirstOrDefault();
            Assert.IsNotNull(def);
            Assert.AreEqual<string>(schema.Name, def.Name);
            Assert.AreEqual<string>(schema.Preface, def.Preface);
        }
    }
}