namespace King.Mapper.Generator.Models
{
    using King.Mapper.Data;
    using System;

    /// <summary>
    /// Schema
    /// </summary>
    public class Schema
    {
        #region Properties
        /// <summary>
        /// Parameter
        /// </summary>
        public string Parameter
        {
            get;
            set;
        }

        /// <summary>
        /// Data Type
        /// </summary>
        public string DataType
        {
            get;
            set;
        }

        /// <summary>
        /// Preface
        /// </summary>
        [ActionName("Schema")]
        public string Preface
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// </summary>
        [ActionName("StoredProcedure")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Maximum Length
        /// </summary>
        public string MaxLength
        {
            get;
            set;
        }
        #endregion
    }
}