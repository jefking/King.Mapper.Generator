namespace King.Mapper.Generator
{
    using King.Data.Sql.Reflection.Models;
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
        public StoredProceduresUnitTestsRender(IEnumerable<IDefinition> manifest, TestSuite suite = TestSuite.MSTest)
            : base(new StoredProceduresUnitTests(suite), manifest, "StoredProcedures.Unit.Test.Generated.cs")
        {
        }
        #endregion
    }
}