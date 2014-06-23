namespace King.Mapper.Generator.Models
{
    using System.Collections.Generic;

    public class DefinitionComparer : EqualityComparer<Definition>
    {
        #region Methods
        public override bool Equals(Definition x, Definition y)
        {
            return x.Preface.CompareTo(y.Preface) + x.Name.CompareTo(y.Name) == 0;
        }

        public override int GetHashCode(Definition obj)
        {
            var toHash = string.Format("{0}{1}", obj.Preface, obj.Name);
            return toHash.GetHashCode();
        }
        #endregion
    }
}