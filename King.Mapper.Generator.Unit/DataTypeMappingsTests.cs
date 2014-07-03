namespace King.Mapper.Generator.Unit
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestClass]
    public class DataTypeMappingsTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTypeCSharpDataTypeNull()
        {
            DataTypeMappings.DataTypeCSharp(null);
        }

        [TestMethod]
        public void DataTypeCSharpString()
        {
            Assert.AreEqual<string>("string", DataTypeMappings.DataTypeCSharp("varchar"));
            Assert.AreEqual<string>("string", DataTypeMappings.DataTypeCSharp("nvarchar"));
            Assert.AreEqual<string>("string", DataTypeMappings.DataTypeCSharp("ntext"));
            Assert.AreEqual<string>("string", DataTypeMappings.DataTypeCSharp("text"));
            Assert.AreEqual<string>("string", DataTypeMappings.DataTypeCSharp("string"));
        }

        [TestMethod]
        public void DataTypeCSharpByteArray()
        {
            Assert.AreEqual<string>("byte[]", DataTypeMappings.DataTypeCSharp("binary"));
            Assert.AreEqual<string>("byte[]", DataTypeMappings.DataTypeCSharp("image"));
        }

        [TestMethod]
        public void DataTypeCSharpChar()
        {
            Assert.AreEqual<string>("char", DataTypeMappings.DataTypeCSharp("char"));
            Assert.AreEqual<string>("char", DataTypeMappings.DataTypeCSharp("nchar"));
        }

        [TestMethod]
        public void DataTypeCSharpFloat()
        {
            Assert.AreEqual<string>("float?", DataTypeMappings.DataTypeCSharp("float"));
        }

        [TestMethod]
        public void DataTypeCSharpInt()
        {
            Assert.AreEqual<string>("int?", DataTypeMappings.DataTypeCSharp("int"));
        }

        [TestMethod]
        public void DataTypeCSharpLong()
        {
            Assert.AreEqual<string>("long?", DataTypeMappings.DataTypeCSharp("bigint"));
        }

        [TestMethod]
        public void DataTypeCSharpByte()
        {
            Assert.AreEqual<string>("byte?", DataTypeMappings.DataTypeCSharp("tinyint"));
        }

        [TestMethod]
        public void DataTypeCSharpShort()
        {
            Assert.AreEqual<string>("short?", DataTypeMappings.DataTypeCSharp("smallint"));
        }

        [TestMethod]
        public void DataTypeCSharpDecimal()
        {
            Assert.AreEqual<string>("decimal?", DataTypeMappings.DataTypeCSharp("money"));
            Assert.AreEqual<string>("decimal?", DataTypeMappings.DataTypeCSharp("decimal"));
        }

        [TestMethod]
        public void DataTypeCSharpBool()
        {
            Assert.AreEqual<string>("bool?", DataTypeMappings.DataTypeCSharp("bit"));
        }

        [TestMethod]
        public void DataTypeCSharpDateTime()
        {
            Assert.AreEqual<string>("DateTime?", DataTypeMappings.DataTypeCSharp("datetime"));
        }

        [TestMethod]
        public void DataTypeCSharpGuid()
        {
            Assert.AreEqual<string>("Guid?", DataTypeMappings.DataTypeCSharp("uniqueidentifier"));
        }

        [TestMethod]
        public void DataTypeCSharp()
        {
            Assert.AreEqual<string>("object", DataTypeMappings.DataTypeCSharp(Guid.NewGuid().ToString()));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTypeDbTypeDataTypeNull()
        {
            DataTypeMappings.DataTypeDbType(null);
        }

        [TestMethod]
        public void DataTypeDbTypeString()
        {
            Assert.AreEqual<string>("DbType.String", DataTypeMappings.DataTypeDbType("varchar"));
            Assert.AreEqual<string>("DbType.String", DataTypeMappings.DataTypeDbType("nvarchar"));
            Assert.AreEqual<string>("DbType.String", DataTypeMappings.DataTypeDbType("ntext"));
            Assert.AreEqual<string>("DbType.String", DataTypeMappings.DataTypeDbType("text"));
            Assert.AreEqual<string>("DbType.String", DataTypeMappings.DataTypeDbType("nchar"));
            Assert.AreEqual<string>("DbType.String", DataTypeMappings.DataTypeDbType("string"));
        }

        [TestMethod]
        public void DataTypeDbTypeDateTime2()
        {
            Assert.AreEqual<string>("DbType.DateTime2", DataTypeMappings.DataTypeDbType("datetime2"));
        }

        [TestMethod]
        public void DataTypeDbTypeDate()
        {
            Assert.AreEqual<string>("DbType.Date", DataTypeMappings.DataTypeDbType("date"));
        }

        [TestMethod]
        public void DataTypeDbTypeSingle()
        {
            Assert.AreEqual<string>("DbType.Single", DataTypeMappings.DataTypeDbType("float"));
        }

        [TestMethod]
        public void DataTypeDbTypeBinary()
        {
            Assert.AreEqual<string>("DbType.Binary", DataTypeMappings.DataTypeDbType("binary"));
            Assert.AreEqual<string>("DbType.Binary", DataTypeMappings.DataTypeDbType("image"));
        }

        [TestMethod]
        public void DataTypeDbTypeInt()
        {
            Assert.AreEqual<string>("DbType.Int32", DataTypeMappings.DataTypeDbType("int"));
        }

        [TestMethod]
        public void DataTypeDbTypeDateTime()
        {
            Assert.AreEqual<string>("DbType.DateTime", DataTypeMappings.DataTypeDbType("datetime"));
        }

        [TestMethod]
        public void DataTypeDbTypeBigInt()
        {
            Assert.AreEqual<string>("DbType.Int64", DataTypeMappings.DataTypeDbType("bigint"));
        }

        [TestMethod]
        public void DataTypeDbTypeTinyInt()
        {
            Assert.AreEqual<string>("DbType.Byte", DataTypeMappings.DataTypeDbType("tinyint"));
        }

        [TestMethod]
        public void DataTypeDbTypeSmallInt()
        {
            Assert.AreEqual<string>("DbType.Int16", DataTypeMappings.DataTypeDbType("smallint"));
        }

        [TestMethod]
        public void DataTypeDbTypeMoney()
        {
            Assert.AreEqual<string>("DbType.Currency", DataTypeMappings.DataTypeDbType("money"));
        }

        [TestMethod]
        public void DataTypeDbTypeDecimal()
        {
            Assert.AreEqual<string>("DbType.Decimal", DataTypeMappings.DataTypeDbType("decimal"));
        }

        [TestMethod]
        public void DataTypeDbTypeBit()
        {
            Assert.AreEqual<string>("DbType.Boolean", DataTypeMappings.DataTypeDbType("bit"));
        }

        [TestMethod]
        public void DataTypeDbTypeGuid()
        {
            Assert.AreEqual<string>("DbType.Guid", DataTypeMappings.DataTypeDbType("uniqueidentifier"));
        }

        [TestMethod]
        public void DataTypeDbType()
        {
            Assert.AreEqual<string>("DbType.Object", DataTypeMappings.DataTypeDbType(Guid.NewGuid().ToString()));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTypeCSharpShortenDataTypeNull()
        {
            DataTypeMappings.DataTypeCSharpShorten(null);
        }

        [TestMethod]
        public void DataTypeCSharpShortenString()
        {
            Assert.AreEqual<string>("string", DataTypeMappings.DataTypeCSharpShorten("System.String"));
        }

        [TestMethod]
        public void DataTypeCSharpShortenDouble()
        {
            Assert.AreEqual<string>("double", DataTypeMappings.DataTypeCSharpShorten("system.double"));
        }

        [TestMethod]
        public void DataTypeCSharpShortenInt32()
        {
            Assert.AreEqual<string>("int", DataTypeMappings.DataTypeCSharpShorten("System.Int32"));
        }

        [TestMethod]
        public void DataTypeCSharpShortenInt64()
        {
            Assert.AreEqual<string>("long", DataTypeMappings.DataTypeCSharpShorten("System.Int64"));
        }

        [TestMethod]
        public void DataTypeCSharpShortenByte()
        {
            Assert.AreEqual<string>("byte", DataTypeMappings.DataTypeCSharpShorten("System.Byte"));
        }

        [TestMethod]
        public void DataTypeCSharpShortenInt16()
        {
            Assert.AreEqual<string>("short", DataTypeMappings.DataTypeCSharpShorten("System.Int16"));
        }

        [TestMethod]
        public void DataTypeCSharpShortenDecimal()
        {
            Assert.AreEqual<string>("decimal", DataTypeMappings.DataTypeCSharpShorten("System.Decimal"));
        }

        [TestMethod]
        public void DataTypeCSharpShortenBool()
        {
            Assert.AreEqual<string>("bool", DataTypeMappings.DataTypeCSharpShorten("System.Boolean"));
        }

        [TestMethod]
        public void DataTypeCSharpShortenDateTime()
        {
            Assert.AreEqual<string>("DateTime", DataTypeMappings.DataTypeCSharpShorten("System.DateTime"));
            Assert.AreEqual<string>("DateTime?", DataTypeMappings.DataTypeCSharpShorten("System.Nullable`1[System.DateTime]"));
        }

        [TestMethod]
        public void DataTypeCSharpShortenGuid()
        {
            Assert.AreEqual<string>("Guid", DataTypeMappings.DataTypeCSharpShorten("System.Guid"));
            Assert.AreEqual<string>("Guid?", DataTypeMappings.DataTypeCSharpShorten("system.nullable`1[system.guid]"));
        }

        [TestMethod]
        public void DataTypeCSharpShortenNullableGuid()
        {
            Assert.AreEqual<string>("Guid?", DataTypeMappings.DataTypeCSharpShorten("System.Nullable`1[System.Guid]"));
        }

        [TestMethod]
        public void DataTypeCSharpShorten()
        {
            Assert.AreEqual<string>("object", DataTypeMappings.DataTypeCSharpShorten(Guid.NewGuid().ToString()));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTypeInitializeStringNull()
        {
            DataTypeMappings.DataTypeDbType(null);
        }

        [TestMethod]
        public void DataTypeInitializeString()
        {
            Assert.AreEqual<string>("Guid.NewGuid().ToString()", DataTypeMappings.DataTypeInitialize("string"));
            Assert.AreEqual<string>("Guid.NewGuid().ToString()", DataTypeMappings.DataTypeInitialize("System.String"));
        }

        [TestMethod]
        public void DataTypeInitializeChar()
        {
            Assert.AreEqual<string>("(char)new Random().Next()", DataTypeMappings.DataTypeInitialize("char"));
            Assert.AreEqual<string>("(char)new Random().Next()", DataTypeMappings.DataTypeInitialize("System.Char"));
            Assert.AreEqual<string>("(char)new Random().Next()", DataTypeMappings.DataTypeInitialize("char?"));
        }

        [TestMethod]
        public void DataTypeInitializeFloat()
        {
            Assert.AreEqual<string>("(float)new Random().Next()", DataTypeMappings.DataTypeInitialize("float"));
            Assert.AreEqual<string>("(float)new Random().Next()", DataTypeMappings.DataTypeInitialize("System.Single"));
            Assert.AreEqual<string>("(float)new Random().Next()", DataTypeMappings.DataTypeInitialize("float?"));
        }

        [TestMethod]
        public void DataTypeInitializeByteArray()
        {
            Assert.AreEqual<string>(string.Format(@"new byte[128];{0}new Random().NextBytes(expected)", Environment.NewLine), DataTypeMappings.DataTypeInitialize("byte[]"));
        }

        [TestMethod]
        public void DataTypeInitializeInt()
        {
            Assert.AreEqual<string>("new Random().Next()", DataTypeMappings.DataTypeInitialize("System.Int32"));
            Assert.AreEqual<string>("new Random().Next()", DataTypeMappings.DataTypeInitialize("int?"));
            Assert.AreEqual<string>("new Random().Next()", DataTypeMappings.DataTypeInitialize("int"));
        }

        [TestMethod]
        public void DataTypeInitializeLong()
        {
            Assert.AreEqual<string>("(long)new Random().Next()", DataTypeMappings.DataTypeInitialize("System.Int64"));
            Assert.AreEqual<string>("(long)new Random().Next()", DataTypeMappings.DataTypeInitialize("long?"));
            Assert.AreEqual<string>("(long)new Random().Next()", DataTypeMappings.DataTypeInitialize("long"));
        }

        [TestMethod]
        public void DataTypeInitializeDecimal()
        {
            Assert.AreEqual<string>("(decimal)new Random().NextDouble()", DataTypeMappings.DataTypeInitialize("decimal?"));
            Assert.AreEqual<string>("(decimal)new Random().NextDouble()", DataTypeMappings.DataTypeInitialize("decimal"));
            Assert.AreEqual<string>("(decimal)new Random().NextDouble()", DataTypeMappings.DataTypeInitialize("System.Decimal"));
        }

        [TestMethod]
        public void DataTypeInitializeByte()
        {
            Assert.AreEqual<string>("(byte)new Random().Next(byte.MinValue, byte.MaxValue)", DataTypeMappings.DataTypeInitialize("byte"));
            Assert.AreEqual<string>("(byte)new Random().Next(byte.MinValue, byte.MaxValue)", DataTypeMappings.DataTypeInitialize("byte?"));
        }

        [TestMethod]
        public void DataTypeInitializeShort()
        {
            Assert.AreEqual<string>("(short)new Random().Next(short.MinValue, short.MaxValue)", DataTypeMappings.DataTypeInitialize("short"));
            Assert.AreEqual<string>("(short)new Random().Next(short.MinValue, short.MaxValue)", DataTypeMappings.DataTypeInitialize("short?"));
        }

        [TestMethod]
        public void DataTypeInitializeDateTime()
        {
            Assert.AreEqual<string>("DateTime.UtcNow", DataTypeMappings.DataTypeInitialize("DateTime?"));
            Assert.AreEqual<string>("DateTime.UtcNow", DataTypeMappings.DataTypeInitialize("DateTime"));
            Assert.AreEqual<string>("DateTime.UtcNow", DataTypeMappings.DataTypeInitialize("System.Nullable`1[System.DateTime]"));
        }

        [TestMethod]
        public void DataTypeInitializeBool()
        {
            Assert.AreEqual<string>("true", DataTypeMappings.DataTypeInitialize("bool?"));
            Assert.AreEqual<string>("true", DataTypeMappings.DataTypeInitialize("bool"));
        }

        [TestMethod]
        public void DataTypeInitializeGuid()
        {
            Assert.AreEqual<string>("Guid.NewGuid()", DataTypeMappings.DataTypeInitialize("Guid?"));
            Assert.AreEqual<string>("Guid.NewGuid()", DataTypeMappings.DataTypeInitialize("Guid"));
            Assert.AreEqual<string>("Guid.NewGuid()", DataTypeMappings.DataTypeInitialize("System.Nullable`1[System.Guid]"));
            Assert.AreEqual<string>("Guid.NewGuid()", DataTypeMappings.DataTypeInitialize("System.Guid"));
        }

        [TestMethod]
        public void DataTypeInitializeObject()
        {
            Assert.AreEqual<string>("new object()", DataTypeMappings.DataTypeInitialize("object"));
        }

        [TestMethod]
        public void DataTypeInitialize()
        {
            Assert.AreEqual<string>("null", DataTypeMappings.DataTypeInitialize(Guid.NewGuid().ToString()));
        }
    }
}