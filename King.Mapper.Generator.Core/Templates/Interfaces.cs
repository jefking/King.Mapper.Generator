namespace King.Mapper.Generator.Templates
{
    using King.Data.Sql.Reflection.Models;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public interface IManifest
    {
        #region Properties
        /// <summary>
        /// Gets or sets Manifest
        /// </summary>
        IEnumerable<IDefinition> Manifest
        {
            get;
            set;
        }
        #endregion
    }
    
    /// <summary>
    /// 
    /// </summary>
    public interface IManifestTemplate : IManifest
    {
        #region Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string TransformText();
        #endregion
    }
}