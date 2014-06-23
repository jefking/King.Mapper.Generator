namespace King.Mapper.Generator.Models
{
    using System;
    using System.Collections.Generic;

    public class Definition
    {
        #region Properties
        /// <summary>
        /// Preface
        /// </summary>
        public string Preface
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Variables
        /// </summary>
        public IEnumerable<Variable> Variables
        {
            get;
            set;
        }
        #endregion
    }
}