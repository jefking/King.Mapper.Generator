namespace King.Mapper.Generator
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Threading.Tasks;

    /// <summary>
    /// Writes Files to Disk
    /// </summary>
    public class FileWriter : IFileWriter
    {
        #region Members
        /// <summary>
        /// Folder
        /// </summary>
        private readonly string folder = null;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="renderers">Renderers</param>
        /// <param name="folder">Output Folder</param>
        public FileWriter(string folder)
        {
            if (string.IsNullOrWhiteSpace(folder))
            {
                throw new ArgumentException("folder");
            }

            this.folder = folder;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Write All Renderers
        /// </summary>
        public virtual void WriteAll(IEnumerable<IRender> renderers)
        {
            if (null == renderers)
            {
                throw new ArgumentNullException("renderers");
            }
            
            Parallel.ForEach(renderers, renderer =>
                {
                    Trace.TraceInformation("Writing file '{0}' in folder: '{1}'.", renderer.FileName, folder);

                    File.WriteAllText(string.Format("{0}{1}", folder, renderer.FileName), renderer.Render());
                }
            );
        }
        #endregion
    }
}