﻿namespace King.Mapper.Generator.Templates
{
    using King.Mapper.Generator.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Stored Procedures Template Partial
    /// </summary>
    partial class StoredProcedures
    {
        #region Properties
        /// <summary>
        /// Gets or sets Manifest
        /// </summary>
        public IDictionary<string, Definition> Manifest
        {
            get;
            set;
        }
        #endregion
    }
}