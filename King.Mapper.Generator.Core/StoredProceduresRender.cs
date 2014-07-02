namespace King.Mapper.Generator
{
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Templates;
    using System.Collections.Generic;

    /// <summary>
    /// Stored Procedures Render
    /// </summary>
    public class StoredProceduresRender : Renderer
    {
        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public StoredProceduresRender(IDictionary<int, Definition> manifest)
            : base(new StoredProcedures(), manifest, "StoredProcedures.Generated.cs")
        {
        }
        #endregion
    }
}