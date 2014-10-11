namespace King.Mapper.Generator.Integration
{
    using King.Mapper.Data;
    using King.Mapper.Generated.Sql;
    using King.Mapper.Integration.Model;
    using NUnit.Framework;
    using System;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    [TestFixture]
    public class Integration
    {
        #region Members
        private readonly string connectionString = ConfigurationManager.AppSettings["database"];
        #endregion

        [Test]
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

        [Test]
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
                Assert.AreEqual(sproc.TestInt, obj.Identifier);
                Assert.AreEqual(sproc.TestBigInt, obj.BigInt);
                Assert.AreEqual(sproc.TestBit, obj.Bit);
                Assert.AreEqual(sproc.TestDateTime.Value.Date, obj.DateTime.Date);
                Assert.AreEqual(sproc.TestDecimal, obj.Decimal);
                Assert.AreEqual(sproc.TestNText, obj.NText);
                Assert.AreEqual(sproc.TestGuid, obj.Unique);
                Assert.AreEqual(Math.Round(sproc.TestMoney.Value, 4), obj.Money);
                Assert.AreEqual(sproc.TestDateTime2.Value.Date, obj.DateTime2.Date);
                Assert.AreEqual(sproc.TestDate.Value.Date, obj.Date.Date);
                Assert.AreEqual(sproc.TestFloat, obj.Float);
                Assert.AreEqual(sproc.TestNChar, obj.NChar.ToString());
                Assert.AreEqual(sproc.TestText, obj.Text);
                Assert.AreEqual(sproc.TestXml, obj.Xml);
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
                TestChar = "x",
                TestDate = DateTime.UtcNow,
                TestDateTime = DateTime.UtcNow,
                TestDateTime2 = DateTime.UtcNow,
                TestDecimal = Convert.ToDecimal(random.NextDouble()),
                TestFloat = Convert.ToSingle(random.NextDouble()),
                TestMoney = Convert.ToDecimal(random.NextDouble()),
                TestNChar = "y",
                TestNText = Guid.NewGuid().ToString(),
                TestText = Guid.NewGuid().ToString(),
                TestGuid = Guid.NewGuid(),
                TestXml = "<data />"
            };

            data.TestBinary = new byte[64];
            random.NextBytes(data.TestBinary);

            data.TestImage = new byte[64];
            random.NextBytes(data.TestImage);

            return data;
        }
    }
}