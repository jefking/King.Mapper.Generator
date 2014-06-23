namespace King.Mapper.Generator.Models
{
    public class Variable
    {
        #region Properties
        public string DataType
        {
            get;
            set;
        }

        [ActionName("Parameter")]
        public string ParameterName
        {
            get;
            set;
        }

        public int MaxLength
        {
            get;
            set;
        }
        #endregion
    }
}