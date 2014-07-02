namespace King.Mapper.Generator
{
    using System;

    /// <summary>
    /// Data Type Mappings
    /// </summary>
    public static class DataTypeMappings
    {
        #region Methods
        /// <summary>
        /// Data Type C#
        /// </summary>
        /// <param name="dataType">Data Type</param>
        /// <returns>Converted Data Type</returns>
        public static string DataTypeCSharp(string dataType)
        {
            if (string.IsNullOrWhiteSpace(dataType))
            {
                throw new ArgumentException("dataType");
            }

            switch (dataType.ToLowerInvariant())
            {
                case "varchar":
                case "nvarchar":
                case "ntext":
                case "text":
                case "string":
                    return "string";
                case "int":
                    return "int?";
                case "bigint":
                    return "long?";
                case "tinyint":
                    return "byte?";
                case "smallint":
                    return "short?";
                case "money":
                case "decimal":
                    return "decimal?";
                case "bit":
                    return "bool?";
                case "datetime":
                case "date":
                case "datetime2":
                    return "DateTime?";
                case "uniqueidentifier":
                    return "Guid?";
                case "float":
                    return "float?";
                case "char":
                case "nchar":
                    return "char";
                case "binary":
                case "image":
                    return "byte[]";
                default:
                    return "object";
            }
        }

        /// <summary>
        /// Data Type Sql Server
        /// </summary>
        /// <param name="dataType">Data Type</param>
        /// <returns>Converted Data Type</returns>
        public static string DataTypeDbType(string dataType)
        {
            if (string.IsNullOrWhiteSpace(dataType))
            {
                throw new ArgumentException("dataType");
            }

            switch (dataType.ToLowerInvariant())
            {
                case "varchar":
                case "nvarchar":
                case "ntext":
                case "text":
                case "string":
                case "nchar":
                    return "DbType.String";
                case "int":
                    return "DbType.Int32";
                case "bigint":
                    return "DbType.Int64";
                case "tinyint":
                    return "DbType.Byte";
                case "smallint":
                case "char":
                    return "DbType.Int16";
                case "money":
                    return "DbType.Currency";
                case "decimal":
                    return "DbType.Decimal";
                case "bit":
                    return "DbType.Boolean";
                case "datetime":
                    return "DbType.DateTime";
                case "uniqueidentifier":
                    return "DbType.Guid";
                case "float":
                    return "DbType.Single";
                case "image":
                case "binary":
                    return "DbType.Binary";
                case "datetime2":
                    return "DbType.DateTime2";
                case "date":
                    return "DbType.Date";
                default:
                    return "DbType.Object";
            }
        }

        /// <summary>
        /// Data Type C# Shortened
        /// </summary>
        /// <param name="dataType">Data Type</param>
        /// <returns>Converted Data Type</returns>
        public static string DataTypeCSharpShorten(string dataType)
        {
            if (string.IsNullOrWhiteSpace(dataType))
            {
                throw new ArgumentException("dataType");
            }

            switch (dataType.ToLowerInvariant())
            {
                case "system.string":
                    return "string";
                case "system.double":
                    return "double";
                case "system.int32":
                    return "int";
                case "system.int64":
                    return "long";
                case "system.byte":
                    return "byte";
                case "system.int16":
                    return "short";
                case "system.decimal":
                    return "decimal";
                case "system.boolean":
                    return "bool";
                case "system.datetime":
                    return "DateTime";
                case "system.nullable`1[system.datetime]":
                    return "DateTime?";
                case "system.guid":
                    return "Guid";
                case "system.nullable`1[system.guid]":
                    return "Guid?";
                default:
                    return "object";
            }
        }

        /// <summary>
        /// Data Type Initialize
        /// </summary>
        /// <param name="dataType">Data Type</param>
        /// <returns>Data Type Initialize String</returns>
        public static string DataTypeInitialize(string dataType)
        {
            if (string.IsNullOrWhiteSpace(dataType))
            {
                throw new ArgumentException("dataType");
            }

            switch (dataType.ToLowerInvariant())
            {
                case "string":
                case "system.string":
                    return "Guid.NewGuid().ToString()";
                case "system.int32":
                case "int":
                case "int?":
                    return "new Random().Next()";
                case "system.int64":
                case "long":
                case "long?":
                    return "(long)new Random().Next()";
                case "system.decimal":
                case "decimal":
                case "decimal?":
                    return "(decimal)new Random().NextDouble()";
                case "byte":
                case "byte?":
                    return "(byte)new Random().Next(byte.MinValue, byte.MaxValue)";
                case "short":
                case "short?":
                    return "(short)new Random().Next(short.MinValue, short.MaxValue)";
                case "datetime":
                case "datetime?":
                case "system.nullable`1[system.datetime]":
                    return "DateTime.UtcNow";
                case "bool":
                case "bool?":
                    return "true";
                case "guid":
                case "guid?":
                case "system.nullable`1[system.guid]":
                case "system.guid":
                    return "Guid.NewGuid()";
                case "object":
                    return "new object()";
                default:
                    return "null";
            }
        }
        #endregion
    }
}
