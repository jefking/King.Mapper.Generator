namespace King.Mapper.Generator.Sql
{
    using King.Mapper.Data;
    using King.Mapper.Generator.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    /// <summary>
    /// Data Loader
    /// </summary>
    public class DataLoader : IDataLoader
    {
        #region Members
        /// <summary>
        /// Connection String
        /// </summary>
        private readonly string connectionString = null;

        /// <summary>
        /// Data Loader
        /// </summary>
        private readonly ILoader<Schema> loader = null;
        #endregion

        #region Constructors
        public DataLoader(string connectionString, ILoader<Schema> loader)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("connectionString");
            }
            if (null == loader)
            {
                throw new ArgumentNullException("loader");
            }

            this.loader = loader;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Load data from Database, and return the models.
        /// </summary>
        /// <returns>Schemas to process</returns>
        public async Task<IEnumerable<Schema>> Load()
        {
            IEnumerable<Schema> schemas = null;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var execute = new SqlCommand(Statement.sqlStatement, connection))
                {
                    await connection.OpenAsync();

                    schemas = loader.Models(execute);
                }
            }

            return schemas;
        }
        #endregion
    }
}