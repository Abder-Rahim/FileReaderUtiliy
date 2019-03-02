using System;
using System.IO;

namespace FileReaderUtility.Model
{
    /// <summary>
    /// Base class for specialized reading files classes
    /// </summary>
    class UFileReader
    {
        #region Private Members

        protected Stream fileStream;

        #endregion

        #region Public Properties
        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for the base class
        /// </summary>
        /// <param name=fs>File stream to read</param>
        public UFileReader(Stream fs)
        {
            if (fs == null || fs.Length == 0)
            {
                throw new Exception("The file is empty");
            }
            fileStream = fs;
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
