namespace King.Mapper.Generator
{
    using King.Data.Sql.Reflection.Models;
    using System.Collections.Generic;

    #region IRender
    /// <summary>
    /// Render
    /// </summary>
    public interface IRender
    {
        #region Properties
        /// <summary>
        /// File Name
        /// </summary>
        string FileName
        {
            get;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Render
        /// </summary>
        /// <returns>Output</returns>
        string Render();
        #endregion
    }
    #endregion

    #region IFileWriter
    /// <summary>
    /// File Writer
    /// </summary>
    public interface IFileWriter
    {
        #region Methods
        /// <summary>
        /// Write All
        /// </summary>
        /// <param name="renderers">Renderers</param>
        void WriteAll(IEnumerable<IRender> renderers);
        #endregion
    }
    #endregion

    #region IRenderFactory
    /// <summary>
    /// Render Factory
    /// </summary>
    public interface IRenderFactory
    {
        #region Methods
        /// <summary>
        /// Load Renderers with Manifest
        /// </summary>
        /// <param name="manifest">Manifest</param>
        /// <returns>Renderers</returns>
        IEnumerable<IRender> Load(IEnumerable<IDefinition> manifest);
        #endregion
    }
    #endregion
}