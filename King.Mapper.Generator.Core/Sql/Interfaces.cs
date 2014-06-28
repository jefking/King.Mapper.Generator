namespace King.Mapper.Generator.Sql
{
    using King.Mapper.Generator.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    #region IDataLoader
    public interface IDataLoader
    {
        #region Methods
        Task<IDictionary<int, Definition>> Load();
        #endregion
    }
    #endregion
}