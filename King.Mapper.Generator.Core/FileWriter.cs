namespace King.Mapper.Generator
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class FileWriter
    {
        #region Members
        /// <summary>
        /// Renderers
        /// </summary>
        private readonly IEnumerable<IRender> renderers = null;

        /// <summary>
        /// Folder
        /// </summary>
        private readonly string folder = null;
        #endregion

        #region Constructor
        public FileWriter(IEnumerable<IRender> renderers, string folder)
        {
            if (null == renderers)
            {
                throw new ArgumentNullException("renderers");
            }
            if (string.IsNullOrWhiteSpace(folder))
            {
                throw new ArgumentException("folder");
            }
            this.renderers = renderers;
            this.folder = folder;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Write All Renderers
        /// </summary>
        public void WriteAll()
        {
            foreach (var renderer in this.renderers)
            {
                File.WriteAllText(string.Format("{0}{1}", folder, renderer.FileName), renderer.Render());
            }
        }
        #endregion
    }
}