namespace King.Mapper.Generator.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// Definition
    /// </summary>
    public class Definition
    {
        #region Properties
        /// <summary>
        /// Preface
        /// </summary>
        public virtual string Preface
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// </summary>
        public virtual string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Variables
        /// </summary>
        public virtual IEnumerable<Variable> Variables
        {
            get;
            set;
        }
        #endregion
    }
}