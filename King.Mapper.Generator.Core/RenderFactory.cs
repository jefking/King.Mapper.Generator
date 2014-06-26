namespace King.Mapper.Generator
{
    using King.Mapper.Generator.Models;
    using System.Collections.Generic;

    public class RenderFactory : IRenderFactory
    {
        #region Constructors
        public RenderFactory()
        {
        }
        #endregion

        #region Methods
        public IEnumerable<IRender> Load(IDictionary<string, Definition> manifest)
        {
            var renderers = new List<IRender>();
            renderers.Add(new Code(manifest));
            return renderers;
        }
        #endregion
    }
}