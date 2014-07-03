namespace King.Mapper.Generator
{
    using King.Mapper.Generator.Models;
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
        private readonly bool test = false;
        #endregion

        #region Constructors
        /// <summary>
        /// Render Factory
        /// </summary>
        /// <param name="test">Test</param>
        public RenderFactory(bool test = false)
        {
            this.test = test;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Load Renderers
        /// </summary>
        /// <param name="manifest">Manifest</param>
        /// <returns>Renderers</returns>
        public IEnumerable<IRender> Load(IDictionary<int, Definition> manifest)
        {
            if (null == manifest)
            {
                throw new ArgumentNullException("manifest");
            }

            var renderers = new List<IRender>();
            renderers.Add(new StoredProceduresRender(manifest));
            if (this.test)
            {
                renderers.Add(new StoredProceduresUnitTestsRender(manifest));
            }

            return renderers;
        }
        #endregion
    }
}