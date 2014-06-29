namespace King.Mapper.Generator.Models
{
    /// <summary>
    /// Variable
    /// </summary>
    public class Variable
    {
        #region Properties
        /// <summary>
        /// Data Type
        /// </summary>
        public string DataType
        {
            get;
            set;
        }

        /// <summary>
        /// Parameter Name
        /// </summary>
        [ActionName("Parameter")]
        public string ParameterName
        {
            get;
            set;
        }

        /// <summary>
        /// Maximum Length
        /// </summary>
        public int MaxLength
        {
            get;
            set;
        }
        #endregion
    }
}