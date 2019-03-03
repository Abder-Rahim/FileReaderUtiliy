namespace FileReaderUtility.Helpers
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
        /// Get content of the file
        /// </summary>
        /// <returns>Return the content of the given file in a string</returns>
        public string GetFileContent(UFileReader file)
        {
            return file.Content();
        }
        
        #endregion

    }
}
