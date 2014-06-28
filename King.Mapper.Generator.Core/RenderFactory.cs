namespace King.Mapper.Generator
{
    using King.Mapper.Generator.Models;
    using System;
    using System.Collections.Generic;

    public class RenderFactory : IRenderFactory
    {
        #region Methods
        public IEnumerable<IRender> Load(IDictionary<int, Definition> manifest)
        {
            if (null == manifest)
            {
                throw new ArgumentNullException("manifest");
            }

            var renderers = new List<IRender>();
            renderers.Add(new Code(manifest));
            return renderers;
        }
        #endregion
    }
}