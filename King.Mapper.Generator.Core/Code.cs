namespace King.Mapper.Generator
{
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Templates;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Code Generator
    /// </summary>
    public class Code : IRender
    {
        #region Members
        /// <summary>
        /// Connection String
        /// </summary>
        private readonly IDictionary<string, Definition> manifest = null;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="folder"></param>
        public Code(IDictionary<string, Definition> manifest)
        {
            if (null == manifest)
            {
                throw new ArgumentNullException("manifest");
            }

            this.manifest = manifest;
        }
        #endregion

        #region Methods
        public string Render()
        {
            var procs = new StoredProcedures()
            {
                Manifest = this.manifest,
            };

            return procs.TransformText();
        }
        #endregion
    }
}