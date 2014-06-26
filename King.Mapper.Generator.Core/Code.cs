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

        #region Properties
        /// <summary>
        /// File Name for output
        /// </summary>
        public string FileName
        {
            get
            {
                return "StoredProcedures.Generated.cs";
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Render
        /// </summary>
        /// <returns></returns>
        public string Render()
        {
            var template = new StoredProcedures()
            {
                Manifest = this.manifest,
            };

            return template.TransformText();
        }
        #endregion
    }
}