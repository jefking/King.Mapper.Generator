namespace King.Mapper.Generator
{
    using King.Mapper.Generator.Sql;
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
        /// Data Loader
        /// </summary>
        private readonly IDataLoader loader = null;

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
        /// <param name="loader">Data Loader</param>
        /// <param name="renderFactory">Render Factory</param>
        /// <param name="writer">File Writer</param>
        public CodeGenerator(IDataLoader loader, IRenderFactory renderFactory, IFileWriter writer)
        {
            if (null == loader)
            {
                throw new ArgumentNullException("loader");
            }
            if (null == renderFactory)
            {
                throw new ArgumentNullException("renderFactory");
            }
            if (null == writer)
            {
                throw new ArgumentNullException("writer");
            }

            this.loader = loader;
            this.renderFactory = renderFactory;
            this.writer = writer;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Generate Code
        /// </summary>
        /// <returns>Threading Task</returns>
        public async Task Generate()
        {
            Trace.TraceInformation("Loading schema from data source.");

            var manifest = await loader.Load();

            Trace.TraceInformation("Loading renderers.");

            var renderers = this.renderFactory.Load(manifest);

            Trace.TraceInformation("Writing files.");

            this.writer.WriteAll(renderers);
        }
        #endregion
    }
}