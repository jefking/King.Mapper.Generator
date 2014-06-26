namespace King.Mapper.Generator
{
    #region IRender
    public interface IRender
    {
        #region Properties
        string FileName
        {
            get;
        }
        #endregion

        #region Methods
        string Render();
        #endregion
    }
    #endregion
}