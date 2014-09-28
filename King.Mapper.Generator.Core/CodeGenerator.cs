namespace King.Mapper.Generator
{
    using King.Data.Sql.Reflection;
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    /// <summary>
    /// Code Generaetor
    /// </summary>
    public class CodeGenerator
    {
        #region Members
        /// <summary>
        /// Schema Reader
        /// </summary>
        private readonly ISchemaReader reader = null;

        /// <summary>
        /// File Writer
        /// </summary>
        private readonly IFileWriter writer = null;

        /// <summary>
        /// Render Factory
        /// </summary>
        private readonly IRenderFactory renderFactory = null;
        #endregion

        #region Constructors
        /// <summary>
        /// Mockable Constructor
        /// </summary>
        public CodeGenerator(ISchemaReader reader, IRenderFactory renderFactory, IFileWriter writer)
        {
            if (null == reader)
            {
                throw new ArgumentNullException("reader");
            }
            if (null == renderFactory)
            {
                throw new ArgumentNullException("renderFactory");
            }
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            this.reader = reader;
            this.renderFactory = renderFactory;
            this.writer = writer;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Generate Code
        /// </summary>
        /// <returns>Threading Task</returns>
        public virtual async Task Generate()
        {
            Trace.TraceInformation("Loading schema from data source.");

            var manifest = await reader.Load(SchemaTypes.StoredProcedure);

            Trace.TraceInformation("Loading renderers.");

            var renderers = this.renderFactory.Load(manifest);

            Trace.TraceInformation("Writing files.");

            this.writer.WriteAll(renderers);
        }
        #endregion
    }
}