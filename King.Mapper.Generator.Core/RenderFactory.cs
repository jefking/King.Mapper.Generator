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
            return renderers;
        }
        #endregion
    }
}