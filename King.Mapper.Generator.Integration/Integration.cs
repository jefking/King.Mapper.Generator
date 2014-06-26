﻿namespace King.Mapper.Generator.Integration
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Configuration;
    using System.Threading.Tasks;
    using System.Data.SqlClient;
    using King.Mapper.Integration.Model;
    using King.Mapper.Generated.Sql;
    using King.Mapper.Data;

    [TestClass]
    public class Integration
    {
        #region Members
        private readonly string connectionString = ConfigurationManager.AppSettings["database"];
        #endregion

        [TestMethod]
        public async Task Insert()
        {
            var random = new Random();
            using (var con = new SqlConnection(connectionString))
            {
                var sproc = new dboSimulatedInsertStatement()
                {
                    TestInt = random.Next(),
                };

                var executor = new Executor(con);
                var results = await executor.NonQuery(sproc);

                Assert.AreEqual(1, results);
            }
        }

        [TestMethod]
        public async Task Select()
        {
            using (var con = new SqlConnection(connectionString))
            {
                var sproc = Create();

                var executor = new Executor(con);
                var data = await executor.Query(sproc);

                Assert.IsNotNull(data);

                var obj = data.Model<SelectData>();

                Assert.IsNotNull(obj);
                Assert.AreEqual<int?>(sproc.TestInt, obj.Identifier);
                Assert.AreEqual<long?>(sproc.TestBigInt, obj.BigInt);
                Assert.AreEqual<bool?>(sproc.TestBit, obj.Bit);
                Assert.AreEqual<DateTime?>(sproc.TestDateTime.Value.Date, obj.DateTime.Date);
                Assert.AreEqual<decimal?>(sproc.TestDecimal, obj.Decimal);
                Assert.AreEqual<string>(sproc.TestNText, obj.NText);
                Assert.AreEqual<Guid?>(sproc.TestGuid, obj.Unique);
                Assert.AreEqual<decimal>(Math.Round(sproc.TestMoney.Value, 4), obj.Money);
                Assert.AreEqual<DateTime>(sproc.TestDateTime2.Value.Date, obj.DateTime2.Date);
                Assert.AreEqual<DateTime>(sproc.TestDate.Value.Date, obj.Date.Date);
                Assert.AreEqual<float?>(sproc.TestFloat, obj.Float);
                Assert.AreEqual<char?>(sproc.TestNChar, obj.NChar);
                Assert.AreEqual<string>(sproc.TestText, obj.Text);
                CollectionAssert.AreEqual(sproc.TestBinary, obj.Binary);
                CollectionAssert.AreEqual(sproc.TestImage, obj.Image);
            }
        }

        public dboSimulatedSelectStatement Create()
        {
            var random = new Random();
            var data = new dboSimulatedSelectStatement()
            {
                TestInt = random.Next(),
                TestBigInt = random.Next(),
                TestBit = true,
                TestChar = 'x',
                TestDate = DateTime.UtcNow,
                TestDateTime = DateTime.UtcNow,
                TestDateTime2 = DateTime.UtcNow,
                TestDecimal = Convert.ToDecimal(random.NextDouble()),
                TestFloat = Convert.ToSingle(random.NextDouble()),
                TestMoney = Convert.ToDecimal(random.NextDouble()),
                TestNChar = 'y',
                TestNText = Guid.NewGuid().ToString(),
                TestText = Guid.NewGuid().ToString(),
                TestGuid = Guid.NewGuid(),
            };

            data.TestBinary = new byte[64];
            random.NextBytes(data.TestBinary);

            data.TestImage = new byte[64];
            random.NextBytes(data.TestImage);

            return data;
        }
    }
}