namespace King.Mapper.Generator.Templates
{
    using King.Data.Sql.Reflection.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Manifest interface
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
    /// Manifest Temlate interface
    /// </summary>
    public interface IManifestTemplate : IManifest
    {
        #region Methods
        /// <summary>
        /// Transform Text
        /// </summary>
        /// <returns>Text</returns>
        string TransformText();
        #endregion
    }
}