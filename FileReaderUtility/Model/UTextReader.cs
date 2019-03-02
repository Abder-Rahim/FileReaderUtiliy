using System.IO;

namespace FileReaderUtility.Model
{
    /// <summary>
    /// Specialized class in reading text files
    /// </summary>
    class UTextReader : UFileReader
    {
        #region Private Members
        #endregion

        #region Public Properties
        #endregion

        #region Constructors

        public UTextReader(Stream fs) : base(fs)
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get the content of the text file
        /// </summary>
        /// <returns>Return the complete contents of the stream in a string format</returns>
        public override string Content()
        {
            StreamReader reader = new StreamReader(fileStream);
            return reader.ReadToEnd();
        }

        #endregion

    }
}
