namespace King.Mapper.Generator
{
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
            switch (dataType)
            {
                case "varchar":
                case "nvarchar":
                case "ntext":
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
                    return "DateTime?";
                case "uniqueidentifier":
                    return "Guid?";
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
            switch (dataType)
            {
                case "varchar":
                case "nvarchar":
                case "ntext":
                case "string":
                    return "DbType.String";
                case "int":
                    return "DbType.Int32";
                case "bigint":
                    return "DbType.Int64";
                case "tinyint":
                    return "DbType.Byte";
                case "smallint":
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
                default:
                    return "DbType.Object";
            }
        }

        /// <summary>
        /// Data Type Initialize
        /// </summary>
        /// <param name="dataType">Data Type</param>
        /// <returns>Data Type Initialize String</returns>
        public static string DataTypeInitialize(string dataType)
        {
            switch (dataType)
            {
                case "string":
                case "System.String":
                    return "StringHelper.ValidString()";
                case "System.Int32":
                case "int":
                case "int?":
                    return "new Random().Next()";
                case "System.Int64":
                case "long":
                case "long?":
                    return "(long)new Random().Next()";
                case "System.Decimal":
                case "decimal":
                case "decimal?":
                    return "(decimal)new Random().NextDouble()";
                case "byte":
                case "byte?":
                    return "(byte)new Random().Next(byte.MinValue, byte.MaxValue)";
                case "short":
                case "short?":
                    return "(short)new Random().Next(short.MinValue, short.MaxValue)";
                case "DateTime":
                case "DateTime?":
                case "System.Nullable`1[System.DateTime]":
                    return "DateTime.UtcNow";
                case "bool":
                case "bool?":
                    return "true";
                case "Guid":
                case "Guid?":
                case "System.Nullable`1[System.Guid]":
                case "System.Guid":
                    return "Guid.NewGuid()";
                case "object":
                    return "new object()";
                default:
                    return "null";
            }
        }

        /// <summary>
        /// Data Type C# Shortened
        /// </summary>
        /// <param name="dataType">Data Type</param>
        /// <returns>Converted Data Type</returns>
        public static string DataTypeCSharpShorten(string dataType)
        {
            switch (dataType)
            {
                case "System.String":
                    return "string";
                case "System.Int32":
                    return "int";
                case "System.Int64":
                    return "long";
                case "System.Byte":
                    return "byte";
                case "System.Int16":
                    return "short";
                case "System.Decimal":
                    return "decimal";
                case "System.Boolean":
                    return "bool";
                case "System.DateTime":
                case "System.Nullable`1[System.DateTime]":
                    return "DateTime";
                case "System.Guid":
                    return "Guid";
                case "System.Nullable`1[System.Guid]":
                    return "Guid?";
                default:
                    return "object";
            }
        }

        /// <summary>
        /// String Too Long
        /// </summary>
        /// <param name="size">Size</param>
        /// <returns>Testing</returns>
        public static string StringTooLong(int size)
        {
            if (-2 == size)
            {
                size = 1024;
            }

            return string.Format(@"var data = StringHelper.ValidString({1}, {0})", size + 1, size * 2);
        }

        /// <summary>
        /// String Too Long
        /// </summary>
        /// <param name="size">Size</param>
        /// <returns>Testing</returns>
        public static string StringValid(int size)
        {
            if (size > 1024)
            {
                size = 1024;
            }

            return string.Format(@"var random = new Random();
            var data = StringHelper.ValidString(random.Next({0}))", size);
        }
        #endregion
    }
}
