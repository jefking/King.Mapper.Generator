namespace King.Mapper.Generator
{
    using System;

    /// <summary>
    /// Code Generator
    /// </summary>
    public class Code
    {
        #region Members
        /// <summary>
        /// Connection String
        /// </summary>
        private readonly string connectionString = null;

        /// <summary>
        /// Folder for code to be placed
        /// </summary>
        private readonly string folder = null;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="folder"></param>
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

        #region Methods
        #endregion
    }
}