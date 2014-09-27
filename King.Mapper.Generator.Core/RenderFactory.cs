namespace King.Mapper.Generator
{
    using King.Data.Sql.Reflection.Models;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Render Factory
    /// </summary>
    public class RenderFactory : IRenderFactory
    {
        #region Members
        /// <summary>
        /// Test Code
        /// </summary>
        private readonly TestSuite suite = TestSuite.None;

        /// <summary>
        /// Generate Code
        /// </summary>
        private readonly bool generateCode = true;
        #endregion

        #region Constructors
        /// <summary>
        /// Render Factory
        /// </summary>
        /// <param name="test">Test</param>
        public RenderFactory(bool generateCode = true, TestSuite suite = TestSuite.None)
        {
            this.generateCode = generateCode;
            this.suite = suite;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Load Renderers
        /// </summary>
        /// <param name="manifest">Manifest</param>
        /// <returns>Renderers</returns>
        public virtual IEnumerable<IRender> Load(IDictionary<int, IDefinition> manifest)
        {
            if (null == manifest)
            {
                throw new ArgumentNullException("manifest");
            }

            var renderers = new List<IRender>();
            if (this.generateCode)
            {
                renderers.Add(new StoredProceduresRender(manifest));
            }
            if (this.suite != TestSuite.None)
            {
                renderers.Add(new StoredProceduresUnitTestsRender(manifest, suite));
            }

            return renderers;
        }
        #endregion
    }
}