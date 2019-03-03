using System;
using System.IO;

namespace FileReaderUtility.Helpers
{
    /// <summary>
    /// Base class for specialized reading files classes
    /// </summary>
    class UFileReader
    {
        #region Private Members

        protected Stream fileStream;
        protected Boolean fileEncoded;

        #endregion

        #region Public Properties
        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for the base class
        /// </summary>
        /// <param name=fs>Specifies the file stream to read</param>
        /// <param name=encoded>Specifies whether the file is encoded or not</param>
        public UFileReader(Stream fs, Boolean encoded)
        {
            if (fs == null || fs.Length == 0)
            {
                throw new Exception("File is empty!");
            }
            fileStream = fs;
            fileEncoded = encoded;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Return Parent class content
        /// </summary>
        public virtual string Content()
        {
            return string.Empty;
        }

        #endregion

    }
}
