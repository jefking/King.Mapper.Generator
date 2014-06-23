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
        public string Parameter
        {
            get;
            set;
        }

        public string DataType
        {
            get;
            set;
        }

        [ActionName("Schema")]
        /// <summary>
        /// Preface
        /// </summary>
        public string Preface
        {
            get;
            set;
        }

        [ActionName("StoredProcedure")]
        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        public string MaxLength
        {
            get;
            set;
        }
        #endregion
    }
}