namespace FileReaderUtility.Model
{
    class UFile
    {
        #region Private Members
        #endregion

        #region Public Properties
        #endregion

        #region Constructors
        #endregion

        #region Public Methods

        /// <summary>
        /// Get the content of the file
        /// </summary>
        /// <returns>Return the content of the stream</returns>
        public string GetFileContent(UFileReader file)
        {
            return file.Content();
        }
        
        #endregion

    }
}
