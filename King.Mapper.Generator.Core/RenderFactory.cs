namespace King.Mapper.Generator
{
    using King.Mapper.Generator.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RenderFactory : IRenderFactory
    {
        public RenderFactory()
        {
        }

        public IEnumerable<IRender> Load(IDictionary<string, Definition> manifest)
        {
            var renderers = new List<IRender>();
            renderers.Add(new Code(manifest));
            return renderers;
        }
    }
}