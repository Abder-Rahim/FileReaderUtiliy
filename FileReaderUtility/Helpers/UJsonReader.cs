/* 
 Date : 03/03/2019
 Author : developpeur-csharp.com
 Project : FileReaderUtility
*/

using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace FileReaderUtility.Helpers
{

    /// <summary>
    /// Specialized class in reading json files
    /// </summary>
    class UJsonReader : UFileReader
    {
        #region Private Members
        #endregion

        #region Public Properties
        #endregion

        #region Constructors

        public UJsonReader(Stream fs, Boolean encoded) : base(fs, encoded)
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get the content of the json file 
        /// </summary>
        /// <returns>Return the complete contents of the json file in a string format</returns>
        public override string Content()
        {
            StringBuilder sb = new StringBuilder();
            if (fileStream.Length == 0)
            {
                throw new Exception("File is empty!");
            }
            StreamReader reader = new StreamReader(fileStream);
            dynamic json = JsonConvert.DeserializeObject(reader.ReadToEnd());
            if (json.HasValues == false)
            {
                throw new Exception("Json has no values!");
            }
            sb.Append("<<  " + json.planete.name + "  >>  ");
            sb.Append(DecodeText(json.planete.type.ToString()) + "\r\n");

            sb.Append("<<  " + json.planete.titre1.name + "  >>  " + DecodeText(json.planete.titre1.description.ToString()) + "\r\n");
            sb.Append("<<  " + json.planete.titre2.name + "  >>  " + DecodeText(json.planete.titre2.description.ToString()) + "\r\n");
            sb.Append("<<  " + json.planete.titre3.name + "  >>  " + DecodeText(json.planete.titre3.description.ToString()) + "\r\n");
            sb.Append("<<  " + json.planete.titre4.name + "  >>  " + DecodeText(json.planete.titre4.description.ToString()) + "\r\n");
            sb.Append("<<  " + json.planete.titre5.name + "  >>  " + DecodeText(json.planete.titre5.description.ToString()) + "\r\n");

            sb.Append("<<  " + json.planete.section.name + "  >>  " + DecodeText(json.planete.section.description.ToString()) + "\r\n");

            fileStream.Close();
            return sb.ToString();
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
