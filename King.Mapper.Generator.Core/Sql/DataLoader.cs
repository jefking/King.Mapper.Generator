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
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="connectionString">Connection String</param>
        public DataLoader(string connectionString)
            :this(connectionString, new Loader<Schema>())
        {
        }

        /// <summary>
        /// Mockable Constructor
        /// </summary>
        /// <param name="connectionString">Connection String</param>
        /// <param name="loader">Loader</param>
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
        public async Task<IDictionary<int, Definition>> Load()
        {
            var schemas = await this.Schemas();

            var definitions = this.Minimize(schemas);

            return this.BuildManifest(definitions, schemas);
        }

        /// <summary>
        /// Load Schemas from data source
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Schema>> Schemas()
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

            return schemas;
        }

        /// <summary>
        /// Minimize Schemas, product definintions
        /// </summary>
        /// <param name="schemas"></param>
        /// <returns></returns>
        public IEnumerable<Definition> Minimize(IEnumerable<Schema> schemas)
        {
            if (null == schemas)
            {
                throw new ArgumentNullException("schemas");
            }

            var compare = new DefinitionComparer();
            return (from s in schemas
                    select s.Map<Definition>()).Distinct(compare);
        }

        /// <summary>
        /// Build Manifest, from definitions and schemas
        /// </summary>
        /// <param name="definitions">Definitions</param>
        /// <param name="schemas">Schemas</param>
        /// <returns></returns>
        public IDictionary<int, Definition> BuildManifest(IEnumerable<Definition> definitions, IEnumerable<Schema> schemas)
        {
            if (null == definitions)
            {
                throw new ArgumentNullException("definitions");
            }
            if (null == schemas)
            {
                throw new ArgumentNullException("schemas");
            }

            var manifest = new Dictionary<int, Definition>();
            var comparer = new DefinitionComparer();
            foreach (var d in definitions)
            {
                d.Variables = from s in schemas
                              where s.Name == d.Name
                                  && s.Preface == d.Preface
                                  && !string.IsNullOrWhiteSpace(s.Parameter)
                                  && !string.IsNullOrWhiteSpace(s.DataType)
                              select s.Map<Variable>();

                manifest.Add(comparer.GetHashCode(d), d);
            }

            return manifest;
        }
        #endregion
    }
}