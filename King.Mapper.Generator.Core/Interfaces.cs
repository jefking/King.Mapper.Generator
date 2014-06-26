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
    public interface IFileWriter
    {
        void WriteAll(IEnumerable<IRender> renderers);
    }
    #endregion

    #region IRenderFactory
    public interface IRenderFactory
    {
        IEnumerable<IRender> Load(IDictionary<string, Definition> manifest);
    }
    #endregion
}