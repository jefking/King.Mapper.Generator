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
        private readonly TestSuite suite = TestSuite.MSTest;
        #endregion

        #region Constructors
        public StoredProceduresUnitTests(TestSuite suite = TestSuite.MSTest)
        {
            this.suite = suite;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets Manifest
        /// </summary>
        public IDictionary<int, Definition> Manifest
        {
            get;
            set;
        }

        public string TestClassAttribute
        {
            get
            {
                return suite == TestSuite.MSTest ? "TestClass" : "TestFixture";
            }
        }
        public string TestMethodAttribute
        {
            get
            {
                return suite == TestSuite.MSTest ? "TestMethod" : "Test";
            }
        }
        #endregion
    }
}