/* 
 Date : 03/03/2019
 Author : developpeur-csharp.com
 Project : FileReaderUtility
*/

using System;
using System.Text;

namespace FileReaderUtility.Helpers
{
    /// <summary>
    /// Class for encoding work
    /// </summary>
    public static class Base64
    {
        /// <summary>
        /// Encode text in base 64
        /// </summary>
        /// <returns>Return encoded string</returns>
        public static string ToBase64(this Encoding encoding, string text)
        {
            if (text == null)
            {
                return null;
            }

            byte[] textAsBytes = encoding.GetBytes(text);
            return Convert.ToBase64String(textAsBytes);
        }

        /// <summary>
        /// Try parse a base 64 text
        /// </summary>
        /// <returns>Return True if successful</returns>
        public static bool TryParseBase64(this Encoding encoding, string encodedText, out string decodedText)
        {
            if (encodedText == null)
            {
                decodedText = null;
                return false;
            }

            try
            {
                byte[] textAsBytes = Convert.FromBase64String(encodedText);
                decodedText = encoding.GetString(textAsBytes);
                return true;
            }
            catch (Exception)
            {
                decodedText = null;
                return false;
            }
        }
    }

}
