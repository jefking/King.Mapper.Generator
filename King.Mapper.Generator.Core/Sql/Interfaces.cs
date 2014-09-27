namespace King.Mapper.Generator.Sql
{
    using King.Mapper.Generator.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #region IDataLoader
    /// <summary>
    /// Data Loader
    /// </summary>
    public interface IDataLoader
    {
        #region Methods
        /// <summary>
        /// Load
        /// </summary>
        /// <returns>Manifest</returns>
        Task<IDictionary<int, IDefinition>> Load();
        #endregion
    }
    #endregion
}