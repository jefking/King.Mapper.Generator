namespace King.Mapper.Generator.Templates
{
    using King.Data.Sql.Reflection.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Stored Procedures Tests Template Partial
    /// </summary>
    partial class StoredProceduresUnitTests : IManifestTemplate
    {
        #region Properties
        /// <summary>
        /// Test Suite
        /// </summary>
        private readonly TestSuite suite = TestSuite.MSTest;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="suite">Test Suite</param>
        public StoredProceduresUnitTests(TestSuite suite = TestSuite.MSTest)
        {
            this.suite = suite;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets Manifest
        /// </summary>
        public virtual IEnumerable<IDefinition> Manifest
        {
            get;
            set;
        }

        /// <summary>
        /// Test Class Attribute
        /// </summary>
        public virtual string TestingNamespace
        {
            get
            {
                return suite == TestSuite.MSTest ? "Microsoft.VisualStudio.TestTools.UnitTesting" : "NUnit.Framework";
            }
        }

        /// <summary>
        /// Test Class Attribute
        /// </summary>
        public virtual string TestClassAttribute
        {
            get
            {
                return suite == TestSuite.MSTest ? "TestClass" : "TestFixture";
            }
        }

        /// <summary>
        /// Test Method Attribute
        /// </summary>
        public virtual string TestMethodAttribute
        {
            get
            {
                return suite == TestSuite.MSTest ? "TestMethod" : "Test";
            }
        }

        /// <summary>
        /// AreEqual<X>
        /// </summary>
        public virtual bool AreEqualGeneric
        {
            get
            {
                return suite == TestSuite.MSTest;
            }
        }
        #endregion
    }
}