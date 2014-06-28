namespace King.Mapper.Generator.Sql
{
    using King.Mapper;
    using King.Mapper.Data;
    using King.Mapper.Generator.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;
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
        public async Task<IDictionary<string, Definition>> Load()
        {
            IEnumerable<Schema> schemas = null;
            using (var connection = new SqlConnection(connectionString))
            {
                using (var execute = new SqlCommand(Statement.SelectSchema, connection))
                {
                    await connection.OpenAsync();

                    schemas = loader.Models(execute);
                }
            }

            var definitions = (from s in schemas
                               select s.Map<Definition>()).Distinct(new DefinitionComparer());

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