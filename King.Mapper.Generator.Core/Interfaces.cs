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

    public interface IFileWriter
    {
        void WriteAll(IEnumerable<IRender> renderers);
    }

    public interface IRenderFactory
    {
        IEnumerable<IRender> Load(IDictionary<string, Definition> manifest);
    }
}