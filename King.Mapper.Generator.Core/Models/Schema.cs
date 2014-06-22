namespace King.Mapper.Generator.Models
{
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
        public string Name
        {
            get;
            set;
        }

        public string StoredProcedure
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