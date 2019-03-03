using System;
using System.IO;
using System.Text;

namespace FileReaderUtility.Helpers
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

        public UTextReader(Stream fs, Boolean encoded) : base(fs, encoded)
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get the content of the text file
        /// </summary>
        /// <returns>Return the complete contents of the text file in a string format</returns>
        public override string Content()
        {
            StreamReader reader = new StreamReader(fileStream);
            return DecodeText(reader.ReadToEnd());
        }

        #endregion

        #region Private Functions

        private string DecodeText(string text)
        {
            if (fileEncoded == true)
            {
                if (Base64.TryParseBase64(Encoding.UTF8, text, out string textDecoded))
                    return textDecoded;
                else
                    return text;
            }
            else
            {
                return text;
            }
        }

        #endregion

    }
}
