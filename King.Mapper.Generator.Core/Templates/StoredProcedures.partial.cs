namespace King.Mapper.Generator.Templates
{
    using King.Data.Sql.Reflection.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Stored Procedures Template Partial
    /// </summary>
    partial class StoredProcedures : IManifestTemplate
    {
        #region Properties
        /// <summary>
        /// Gets or sets Manifest
        /// </summary>
        public virtual IDictionary<int, IDefinition> Manifest
        {
            get;
            set;
        }
        #endregion
    }
}