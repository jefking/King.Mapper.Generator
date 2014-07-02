namespace King.Mapper.Generator.Templates
{
    using King.Mapper.Generator.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Stored Procedures Tests Template Partial
    /// </summary>
    partial class StoredProceduresUnitTests : IManifestTemplate
    {
        #region Properties
        /// <summary>
        /// Gets or sets Manifest
        /// </summary>
        public IDictionary<int, Definition> Manifest
        {
            get;
            set;
        }
        #endregion
    }
}