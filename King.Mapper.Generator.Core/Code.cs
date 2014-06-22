namespace King.Mapper.Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Code
    {
        #region Members
        private readonly string connectionString = null;
        private readonly string folder = null;
        #endregion

        #region Constructors
        public Code(string connectionString, string folder)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("connectionString");
            }
            if (string.IsNullOrWhiteSpace(folder))
            {
                throw new ArgumentException("folder");
            }

            this.connectionString = connectionString;
            this.folder = folder;
        }
        #endregion
    }
}