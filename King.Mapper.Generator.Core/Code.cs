namespace King.Mapper.Generator
{
    using King.Mapper.Generator.Models;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Code Generator
    /// </summary>
    public class Code
    {
        #region Members
        /// <summary>
        /// Connection String
        /// </summary>
        private readonly IEnumerable<Schema> schemas = null;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="folder"></param>
        public Code(IEnumerable<Schema> schemas)
        {
            if (null == schemas)
            {
                throw new ArgumentNullException("schemas");
            }

            this.schemas = schemas;
        }
        #endregion

        #region Methods
        #endregion
    }
}