namespace King.Mapper.Generator
{
    using King.Mapper.Generator.Models;
    using King.Mapper.Generator.Templates;
    using System.Collections.Generic;

    /// <summary>
    /// Stored Procedures Render
    /// </summary>
    public class StoredProceduresUnitTestsRender : Renderer
    {
        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public StoredProceduresUnitTestsRender(IDictionary<int, Definition> manifest)
            : base(new StoredProceduresUnitTests(), manifest, "StoredProcedures.Unit.Test.Generated.cs")
        {
        }
        #endregion
    }
}