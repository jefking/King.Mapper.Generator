﻿namespace King.Mapper.Generator.Integration.Sql
{
    using King.Mapper.Data;
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Sql;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NSubstitute;
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;

    [TestClass]
    public class DataLoaderTests
    {
        #region Members
        private readonly string connectionString = ConfigurationManager.AppSettings["database"];
        #endregion

        [TestMethod]
        public async Task Load()
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

            var loader = Substitute.For<ILoader<Schema>>();
            loader.Models(Arg.Any<SqlCommand>()).Returns(schemas);

            var dl = new DataLoader(connectionString, loader);
            var manifest = await dl.Load();

            Assert.IsNotNull(manifest);
            var c = new DefinitionComparer();
            Assert.AreEqual<int>(schemaCount, manifest[c.GetHashCode(def)].Variables.Count());
        }

        [TestMethod]
        public async Task Schemas()
        {
            var loader = Substitute.For<ILoader<Schema>>();
            loader.Models(Arg.Any<SqlCommand>()).Returns(new List<Schema>());

            var dl = new DataLoader(connectionString, loader);
            var data = await dl.Schemas();

            Assert.IsNotNull(data);

            loader.Received().Models(Arg.Any<SqlCommand>());
        }
    }
}