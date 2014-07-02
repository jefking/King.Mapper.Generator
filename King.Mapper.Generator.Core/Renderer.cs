namespace King.Mapper.Generator
{
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Templates;
    using System;
    using System.Collections.Generic;

    public class Renderer : IRender
    {
        #region Members
        private readonly string fileName = null;
        private readonly IManifestTemplate template = null;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="folder"></param>
        public Renderer(IManifestTemplate template, IDictionary<int, Definition> manifest, string fileName)
        {
            if (null == template)
            {
                throw new ArgumentNullException("template");
            }
            if (null == manifest)
            {
                throw new ArgumentNullException("manifest");
            }

            this.template = template;
            this.template.Manifest = manifest;
            this.fileName = fileName;
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
                return fileName;
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
            return template.TransformText();
        }
        #endregion
    }
}
