namespace King.Mapper.Generator.Sql
{
    using King.Mapper.Generator.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDataLoader
    {
        #region Methods
        Task<IEnumerable<Schema>> Load();
        #endregion
    }
}