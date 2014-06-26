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
            switch (dataType)
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
            switch (dataType)
            {
                case "System.String":
                    return "string";
                case "System.Double":
                    return "double";
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
        #endregion
    }
}
