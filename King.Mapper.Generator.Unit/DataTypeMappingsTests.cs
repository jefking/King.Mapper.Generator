namespace King.Mapper.Generator.Unit
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class DataTypeMappingsTests
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTypeCSharpDataTypeNull()
        {
            DataTypeMappings.DataTypeCSharp(null);
        }
        
        [TestCase("string", "varchar")]
        [TestCase("string", "nvarchar")]
        [TestCase("string", "ntext")]
        [TestCase("string", "text")]
        [TestCase("string", "string")]
        [TestCase("byte[]", "binary")]
        [TestCase("byte[]", "image")]
        [TestCase("char", "char")]
        [TestCase("char", "nchar")]
        [TestCase("float?", "float")]
        [TestCase("int?", "int")]
        [TestCase("long?", "bigint")]
        [TestCase("byte?", "tinyint")]
        [TestCase("short?", "smallint")]
        [TestCase("decimal?", "money")]
        [TestCase("decimal?", "decimal")]
        [TestCase("bool?", "bit")]
        [TestCase("DateTime?", "datetime")]
        [TestCase("Guid?", "uniqueidentifier")]
        [TestCase("object", "HAHAH,BLAHBLAH,nothinghere")]
        public void DataTypeCSharp(string expected, string value)
        {
            Assert.AreEqual(expected, DataTypeMappings.DataTypeCSharp(value));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTypeDbTypeDataTypeNull()
        {
            DataTypeMappings.DataTypeDbType(null);
        }
        [TestCase("DbType.String", "varchar")]
        [TestCase("DbType.String", "nvarchar")]
        [TestCase("DbType.String", "ntext")]
        [TestCase("DbType.String", "text")]
        [TestCase("DbType.String", "nchar")]
        [TestCase("DbType.String", "string")]
        [TestCase("DbType.DateTime2", "datetime2")]
        [TestCase("DbType.Date", "date")]
        [TestCase("DbType.Single", "float")]
        [TestCase("DbType.Binary", "binary")]
        [TestCase("DbType.Binary", "image")]
        [TestCase("DbType.Int32", "int")]
        [TestCase("DbType.DateTime", "datetime")]
        [TestCase("DbType.Int64", "bigint")]
        [TestCase("DbType.Byte", "tinyint")]
        [TestCase("DbType.Int16", "smallint")]
        [TestCase("DbType.Currency", "money")]
        [TestCase("DbType.Decimal", "decimal")]
        [TestCase("DbType.Boolean", "bit")]
        [TestCase("DbType.Guid", "uniqueidentifier")]
        [TestCase("DbType.Object", "I don't know what this is")]
        public void DataTypeDbType(string expected, string value)
        {
            Assert.AreEqual(expected, DataTypeMappings.DataTypeDbType(value));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTypeCSharpShortenDataTypeNull()
        {
            DataTypeMappings.DataTypeCSharpShorten(null);
        }

        [TestCase("string", "System.String")]
        [TestCase("double", "system.double")]
        [TestCase("int", "System.Int32")]
        [TestCase("long", "System.Int64")]
        [TestCase("byte", "System.Byte")]
        [TestCase("short", "System.Int16")]
        [TestCase("decimal", "System.Decimal")]
        [TestCase("bool", "System.Boolean")]
        [TestCase("DateTime", "System.DateTime")]
        [TestCase("DateTime?", "System.Nullable`1[System.DateTime]")]
        [TestCase("Guid", "System.Guid")]
        [TestCase("Guid?", "system.nullable`1[system.guid]")]
        [TestCase("Guid?", "System.Nullable`1[System.Guid]")]
        [TestCase("object", "System.WhatIsThis")]
        public void DataTypeCSharpShorten(string expected, string value)
        {
            Assert.AreEqual(expected, DataTypeMappings.DataTypeCSharpShorten(value));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void DataTypeInitializeStringNull()
        {
            DataTypeMappings.DataTypeDbType(null);
        }

        [TestCase("Guid.NewGuid().ToString()", "string")]
        [TestCase("Guid.NewGuid().ToString()", "System.String")]
        [TestCase("(char)new Random().Next()", "char")]
        [TestCase("(char)new Random().Next()", "System.Char")]
        [TestCase("(char)new Random().Next()", "char?")]
        [TestCase("(float)new Random().Next()", "float")]
        [TestCase("(float)new Random().Next()", "System.Single")]
        [TestCase("(float)new Random().Next()", "float?")]
        [TestCase("new byte[128]; new Random().NextBytes(expected)", "byte[]")]
        [TestCase("new Random().Next()", "System.Int32")]
        [TestCase("new Random().Next()", "int?")]
        [TestCase("new Random().Next()", "int")]
        [TestCase("(long)new Random().Next()", "System.Int64")]
        [TestCase("(long)new Random().Next()", "long?")]
        [TestCase("(long)new Random().Next()", "long")]
        [TestCase("(decimal)new Random().NextDouble()", "decimal?")]
        [TestCase("(decimal)new Random().NextDouble()", "decimal")]
        [TestCase("(decimal)new Random().NextDouble()", "System.Decimal")]
        [TestCase("(byte)new Random().Next(byte.MinValue, byte.MaxValue)", "byte")]
        [TestCase("(byte)new Random().Next(byte.MinValue, byte.MaxValue)", "byte?")]
        [TestCase("(short)new Random().Next(short.MinValue, short.MaxValue)", "short")]
        [TestCase("(short)new Random().Next(short.MinValue, short.MaxValue)", "short?")]
        [TestCase("DateTime.UtcNow", "DateTime?")]
        [TestCase("DateTime.UtcNow", "DateTime")]
        [TestCase("DateTime.UtcNow", "System.Nullable`1[System.DateTime]")]
        [TestCase("true", "bool?")]
        [TestCase("true", "bool")]
        [TestCase("Guid.NewGuid()", "Guid?")]
        [TestCase("Guid.NewGuid()", "Guid")]
        [TestCase("Guid.NewGuid()", "System.Nullable`1[System.Guid]")]
        [TestCase("Guid.NewGuid()", "System.Guid")]
        [TestCase("new object()", "object")]
        [TestCase("null", "this is huh?")]
        public void DataTypeInitialize(string expected, string value)
        {
            Assert.AreEqual(expected, DataTypeMappings.DataTypeInitialize(value));
        }
    }
}