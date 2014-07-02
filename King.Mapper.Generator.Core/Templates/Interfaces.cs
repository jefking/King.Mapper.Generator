namespace King.Mapper.Generator.Templates
{
    using King.Mapper.Generator.Models;
    using System.Collections.Generic;

    public interface IManifest
    {
        #region Properties
        /// <summary>
        /// Gets or sets Manifest
        /// </summary>
        IDictionary<int, Definition> Manifest
        {
            get;
            set;
        }
        #endregion
    }
    public interface IManifestTemplate : IManifest
    {
        string TransformText();
    }
}