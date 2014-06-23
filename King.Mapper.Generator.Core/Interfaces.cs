namespace King.Mapper.Generator
{
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
}