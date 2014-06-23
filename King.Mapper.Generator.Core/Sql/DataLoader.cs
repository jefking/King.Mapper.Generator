namespace King.Mapper.Generator.Sql
{
    using King.Mapper.Data;
    using King.Mapper.Generator.Models;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    using King.Mapper;

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
        public DataLoader(string connectionString)
            :this(connectionString, new Loader<Schema>())
        {
        }

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

            this.connectionString = connectionString;
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

        public IEnumerable<Definition> Definitions(IEnumerable<Schema> schemas)
        {
            return (from s in schemas
                    select s.Map<Definition>()).Distinct();
        }

        public IDictionary<string, Definition> Manifest(IEnumerable<Definition> definitions, IEnumerable<Schema> schemas)
        {
            var manifest = new Dictionary<string, Definition>();
            foreach (var d in definitions)
            {
                d.Variables = from s in schemas
                              where s.Name == d.Name
                                  && s.Preface == d.Preface
                                  && !string.IsNullOrWhiteSpace(s.Parameter)
                                  && !string.IsNullOrWhiteSpace(s.DataType)
                              select s.Map<Variable>();

                manifest.Add(string.Format("{0}{1}", d.Preface, d.Name), d);
            }

            return manifest;
        }
        #endregion
    }
}