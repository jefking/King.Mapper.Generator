namespace King.Mapper.Generator.Unit
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [TestFixture]
    public class DataTypeMappingsTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTypeCSharpDataTypeNull()
        {
            DataTypeMappings.DataTypeCSharp(null);
        }

        [Test]
        public void DataTypeCSharpString()
        {
            Assert.AreEqual("string", DataTypeMappings.DataTypeCSharp("varchar"));
            Assert.AreEqual("string", DataTypeMappings.DataTypeCSharp("nvarchar"));
            Assert.AreEqual("string", DataTypeMappings.DataTypeCSharp("ntext"));
            Assert.AreEqual("string", DataTypeMappings.DataTypeCSharp("text"));
            Assert.AreEqual("string", DataTypeMappings.DataTypeCSharp("string"));
        }

        [Test]
        public void DataTypeCSharpByteArray()
        {
            Assert.AreEqual("byte[]", DataTypeMappings.DataTypeCSharp("binary"));
            Assert.AreEqual("byte[]", DataTypeMappings.DataTypeCSharp("image"));
        }

        [Test]
        public void DataTypeCSharpChar()
        {
            Assert.AreEqual("char", DataTypeMappings.DataTypeCSharp("char"));
            Assert.AreEqual("char", DataTypeMappings.DataTypeCSharp("nchar"));
        }

        [Test]
        public void DataTypeCSharpFloat()
        {
            Assert.AreEqual("float?", DataTypeMappings.DataTypeCSharp("float"));
        }

        [Test]
        public void DataTypeCSharpInt()
        {
            Assert.AreEqual("int?", DataTypeMappings.DataTypeCSharp("int"));
        }

        [Test]
        public void DataTypeCSharpLong()
        {
            Assert.AreEqual("long?", DataTypeMappings.DataTypeCSharp("bigint"));
        }

        [Test]
        public void DataTypeCSharpByte()
        {
            Assert.AreEqual("byte?", DataTypeMappings.DataTypeCSharp("tinyint"));
        }

        [Test]
        public void DataTypeCSharpShort()
        {
            Assert.AreEqual("short?", DataTypeMappings.DataTypeCSharp("smallint"));
        }

        [Test]
        public void DataTypeCSharpDecimal()
        {
            Assert.AreEqual("decimal?", DataTypeMappings.DataTypeCSharp("money"));
            Assert.AreEqual("decimal?", DataTypeMappings.DataTypeCSharp("decimal"));
        }

        [Test]
        public void DataTypeCSharpBool()
        {
            Assert.AreEqual("bool?", DataTypeMappings.DataTypeCSharp("bit"));
        }

        [Test]
        public void DataTypeCSharpDateTime()
        {
            Assert.AreEqual("DateTime?", DataTypeMappings.DataTypeCSharp("datetime"));
        }

        [Test]
        public void DataTypeCSharpGuid()
        {
            Assert.AreEqual("Guid?", DataTypeMappings.DataTypeCSharp("uniqueidentifier"));
        }

        [Test]
        public void DataTypeCSharp()
        {
            Assert.AreEqual("object", DataTypeMappings.DataTypeCSharp(Guid.NewGuid().ToString()));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTypeDbTypeDataTypeNull()
        {
            DataTypeMappings.DataTypeDbType(null);
        }

        [Test]
        public void DataTypeDbTypeString()
        {
            Assert.AreEqual("DbType.String", DataTypeMappings.DataTypeDbType("varchar"));
            Assert.AreEqual("DbType.String", DataTypeMappings.DataTypeDbType("nvarchar"));
            Assert.AreEqual("DbType.String", DataTypeMappings.DataTypeDbType("ntext"));
            Assert.AreEqual("DbType.String", DataTypeMappings.DataTypeDbType("text"));
            Assert.AreEqual("DbType.String", DataTypeMappings.DataTypeDbType("nchar"));
            Assert.AreEqual("DbType.String", DataTypeMappings.DataTypeDbType("string"));
        }

        [Test]
        public void DataTypeDbTypeDateTime2()
        {
            Assert.AreEqual("DbType.DateTime2", DataTypeMappings.DataTypeDbType("datetime2"));
        }

        [Test]
        public void DataTypeDbTypeDate()
        {
            Assert.AreEqual("DbType.Date", DataTypeMappings.DataTypeDbType("date"));
        }

        [Test]
        public void DataTypeDbTypeSingle()
        {
            Assert.AreEqual("DbType.Single", DataTypeMappings.DataTypeDbType("float"));
        }

        [Test]
        public void DataTypeDbTypeBinary()
        {
            Assert.AreEqual("DbType.Binary", DataTypeMappings.DataTypeDbType("binary"));
            Assert.AreEqual("DbType.Binary", DataTypeMappings.DataTypeDbType("image"));
        }

        [Test]
        public void DataTypeDbTypeInt()
        {
            Assert.AreEqual("DbType.Int32", DataTypeMappings.DataTypeDbType("int"));
        }

        [Test]
        public void DataTypeDbTypeDateTime()
        {
            Assert.AreEqual("DbType.DateTime", DataTypeMappings.DataTypeDbType("datetime"));
        }

        [Test]
        public void DataTypeDbTypeBigInt()
        {
            Assert.AreEqual("DbType.Int64", DataTypeMappings.DataTypeDbType("bigint"));
        }

        [Test]
        public void DataTypeDbTypeTinyInt()
        {
            Assert.AreEqual("DbType.Byte", DataTypeMappings.DataTypeDbType("tinyint"));
        }

        [Test]
        public void DataTypeDbTypeSmallInt()
        {
            Assert.AreEqual("DbType.Int16", DataTypeMappings.DataTypeDbType("smallint"));
        }

        [Test]
        public void DataTypeDbTypeMoney()
        {
            Assert.AreEqual("DbType.Currency", DataTypeMappings.DataTypeDbType("money"));
        }

        [Test]
        public void DataTypeDbTypeDecimal()
        {
            Assert.AreEqual("DbType.Decimal", DataTypeMappings.DataTypeDbType("decimal"));
        }

        [Test]
        public void DataTypeDbTypeBit()
        {
            Assert.AreEqual("DbType.Boolean", DataTypeMappings.DataTypeDbType("bit"));
        }

        [Test]
        public void DataTypeDbTypeGuid()
        {
            Assert.AreEqual("DbType.Guid", DataTypeMappings.DataTypeDbType("uniqueidentifier"));
        }

        [Test]
        public void DataTypeDbType()
        {
            Assert.AreEqual("DbType.Object", DataTypeMappings.DataTypeDbType(Guid.NewGuid().ToString()));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTypeCSharpShortenDataTypeNull()
        {
            DataTypeMappings.DataTypeCSharpShorten(null);
        }

        [Test]
        public void DataTypeCSharpShortenString()
        {
            Assert.AreEqual("string", DataTypeMappings.DataTypeCSharpShorten("System.String"));
        }

        [Test]
        public void DataTypeCSharpShortenDouble()
        {
            Assert.AreEqual("double", DataTypeMappings.DataTypeCSharpShorten("system.double"));
        }

        [Test]
        public void DataTypeCSharpShortenInt32()
        {
            Assert.AreEqual("int", DataTypeMappings.DataTypeCSharpShorten("System.Int32"));
        }

        [Test]
        public void DataTypeCSharpShortenInt64()
        {
            Assert.AreEqual("long", DataTypeMappings.DataTypeCSharpShorten("System.Int64"));
        }

        [Test]
        public void DataTypeCSharpShortenByte()
        {
            Assert.AreEqual("byte", DataTypeMappings.DataTypeCSharpShorten("System.Byte"));
        }

        [Test]
        public void DataTypeCSharpShortenInt16()
        {
            Assert.AreEqual("short", DataTypeMappings.DataTypeCSharpShorten("System.Int16"));
        }

        [Test]
        public void DataTypeCSharpShortenDecimal()
        {
            Assert.AreEqual("decimal", DataTypeMappings.DataTypeCSharpShorten("System.Decimal"));
        }

        [Test]
        public void DataTypeCSharpShortenBool()
        {
            Assert.AreEqual("bool", DataTypeMappings.DataTypeCSharpShorten("System.Boolean"));
        }

        [Test]
        public void DataTypeCSharpShortenDateTime()
        {
            Assert.AreEqual("DateTime", DataTypeMappings.DataTypeCSharpShorten("System.DateTime"));
            Assert.AreEqual("DateTime?", DataTypeMappings.DataTypeCSharpShorten("System.Nullable`1[System.DateTime]"));
        }

        [Test]
        public void DataTypeCSharpShortenGuid()
        {
            Assert.AreEqual("Guid", DataTypeMappings.DataTypeCSharpShorten("System.Guid"));
            Assert.AreEqual("Guid?", DataTypeMappings.DataTypeCSharpShorten("system.nullable`1[system.guid]"));
        }

        [Test]
        public void DataTypeCSharpShortenNullableGuid()
        {
            Assert.AreEqual("Guid?", DataTypeMappings.DataTypeCSharpShorten("System.Nullable`1[System.Guid]"));
        }

        [Test]
        public void DataTypeCSharpShorten()
        {
            Assert.AreEqual("object", DataTypeMappings.DataTypeCSharpShorten(Guid.NewGuid().ToString()));
        }


        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTypeInitializeStringNull()
        {
            DataTypeMappings.DataTypeDbType(null);
        }

        [Test]
        public void DataTypeInitializeString()
        {
            Assert.AreEqual("Guid.NewGuid().ToString()", DataTypeMappings.DataTypeInitialize("string"));
            Assert.AreEqual("Guid.NewGuid().ToString()", DataTypeMappings.DataTypeInitialize("System.String"));
        }

        [Test]
        public void DataTypeInitializeChar()
        {
            Assert.AreEqual("(char)new Random().Next()", DataTypeMappings.DataTypeInitialize("char"));
            Assert.AreEqual("(char)new Random().Next()", DataTypeMappings.DataTypeInitialize("System.Char"));
            Assert.AreEqual("(char)new Random().Next()", DataTypeMappings.DataTypeInitialize("char?"));
        }

        [Test]
        public void DataTypeInitializeFloat()
        {
            Assert.AreEqual("(float)new Random().Next()", DataTypeMappings.DataTypeInitialize("float"));
            Assert.AreEqual("(float)new Random().Next()", DataTypeMappings.DataTypeInitialize("System.Single"));
            Assert.AreEqual("(float)new Random().Next()", DataTypeMappings.DataTypeInitialize("float?"));
        }

        [Test]
        public void DataTypeInitializeByteArray()
        {
            Assert.AreEqual("new byte[128]; new Random().NextBytes(expected)", DataTypeMappings.DataTypeInitialize("byte[]"));
        }

        [Test]
        public void DataTypeInitializeInt()
        {
            Assert.AreEqual("new Random().Next()", DataTypeMappings.DataTypeInitialize("System.Int32"));
            Assert.AreEqual("new Random().Next()", DataTypeMappings.DataTypeInitialize("int?"));
            Assert.AreEqual("new Random().Next()", DataTypeMappings.DataTypeInitialize("int"));
        }

        [Test]
        public void DataTypeInitializeLong()
        {
            Assert.AreEqual("(long)new Random().Next()", DataTypeMappings.DataTypeInitialize("System.Int64"));
            Assert.AreEqual("(long)new Random().Next()", DataTypeMappings.DataTypeInitialize("long?"));
            Assert.AreEqual("(long)new Random().Next()", DataTypeMappings.DataTypeInitialize("long"));
        }

        [Test]
        public void DataTypeInitializeDecimal()
        {
            Assert.AreEqual("(decimal)new Random().NextDouble()", DataTypeMappings.DataTypeInitialize("decimal?"));
            Assert.AreEqual("(decimal)new Random().NextDouble()", DataTypeMappings.DataTypeInitialize("decimal"));
            Assert.AreEqual("(decimal)new Random().NextDouble()", DataTypeMappings.DataTypeInitialize("System.Decimal"));
        }

        [Test]
        public void DataTypeInitializeByte()
        {
            Assert.AreEqual("(byte)new Random().Next(byte.MinValue, byte.MaxValue)", DataTypeMappings.DataTypeInitialize("byte"));
            Assert.AreEqual("(byte)new Random().Next(byte.MinValue, byte.MaxValue)", DataTypeMappings.DataTypeInitialize("byte?"));
        }

        [Test]
        public void DataTypeInitializeShort()
        {
            Assert.AreEqual("(short)new Random().Next(short.MinValue, short.MaxValue)", DataTypeMappings.DataTypeInitialize("short"));
            Assert.AreEqual("(short)new Random().Next(short.MinValue, short.MaxValue)", DataTypeMappings.DataTypeInitialize("short?"));
        }

        [Test]
        public void DataTypeInitializeDateTime()
        {
            Assert.AreEqual("DateTime.UtcNow", DataTypeMappings.DataTypeInitialize("DateTime?"));
            Assert.AreEqual("DateTime.UtcNow", DataTypeMappings.DataTypeInitialize("DateTime"));
            Assert.AreEqual("DateTime.UtcNow", DataTypeMappings.DataTypeInitialize("System.Nullable`1[System.DateTime]"));
        }

        [Test]
        public void DataTypeInitializeBool()
        {
            Assert.AreEqual("true", DataTypeMappings.DataTypeInitialize("bool?"));
            Assert.AreEqual("true", DataTypeMappings.DataTypeInitialize("bool"));
        }

        [Test]
        public void DataTypeInitializeGuid()
        {
            Assert.AreEqual("Guid.NewGuid()", DataTypeMappings.DataTypeInitialize("Guid?"));
            Assert.AreEqual("Guid.NewGuid()", DataTypeMappings.DataTypeInitialize("Guid"));
            Assert.AreEqual("Guid.NewGuid()", DataTypeMappings.DataTypeInitialize("System.Nullable`1[System.Guid]"));
            Assert.AreEqual("Guid.NewGuid()", DataTypeMappings.DataTypeInitialize("System.Guid"));
        }

        [Test]
        public void DataTypeInitializeObject()
        {
            Assert.AreEqual("new object()", DataTypeMappings.DataTypeInitialize("object"));
        }

        [Test]
        public void DataTypeInitialize()
        {
            Assert.AreEqual("null", DataTypeMappings.DataTypeInitialize(Guid.NewGuid().ToString()));
        }
    }
}