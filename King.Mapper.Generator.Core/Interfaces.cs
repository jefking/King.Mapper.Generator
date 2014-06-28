namespace King.Mapper.Generator
{
    using King.Mapper.Generator.Models;
    using System.Collections.Generic;

    #region IRender
    public interface IRender
    {
        #region Properties
        string FileName
        {
            get;
        }
        #endregion

        #region Methods
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
        void WriteAll(IEnumerable<IRender> renderers);
    }
    #endregion

    #region IRenderFactory
    /// <summary>
    /// Render Factory
    /// </summary>
    public interface IRenderFactory
    {
        IEnumerable<IRender> Load(IDictionary<int, Definition> manifest);
    }
    #endregion
}