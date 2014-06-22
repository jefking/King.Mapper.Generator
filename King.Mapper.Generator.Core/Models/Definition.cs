namespace King.Mapper.Generator.Models
{
    using System;
    using System.Collections.Generic;

    public class Definition : IComparable
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

        #region Methods
        /// <summary>
        /// Compare To
        /// </summary>
        /// <param name="other">Other</param>
        /// <returns>Comparison</returns>
        public int CompareTo(object other)
        {
            var otherProcInfo = other as Definition;
            return this.Preface.CompareTo(otherProcInfo.Preface) + this.Name.CompareTo(otherProcInfo.Name);
        }
        #endregion
    }
}