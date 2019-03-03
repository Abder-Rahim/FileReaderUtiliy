using System;
using System.IO;
using System.Text;
using System.Xml;

namespace FileReaderUtility.Helpers
{
    /// <summary>
    /// Specialized class in reading xml files
    /// </summary>
    class UXmlReader : UFileReader
    {
        #region Private Members
        #endregion

        #region Public Properties
        #endregion

        #region Constructors

        public UXmlReader(Stream fs, Boolean encoded) : base(fs, encoded)
        {
        }

        #endregion
        
        #region Public Methods

        /// <summary>
        /// Get the content of the xml file 
        /// </summary>
        /// <returns>Return the complete contents of the xml file in a string format</returns>
        public override string Content()
        {
            StringBuilder sb = new StringBuilder();
            XmlDocument doc = new XmlDocument();
            doc.Load(fileStream);
            
            if (doc.DocumentElement.ChildNodes.Count == 0)
            {
                throw new Exception("File is empty!");
            }
            sb.Append("<<  " + doc.DocumentElement.Attributes["name"].Value + "  >>  ");
            sb.Append(DecodeText(doc.DocumentElement.Attributes["type"].Value) + "\r\n");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string text = node.InnerText;
                string name = node.Attributes["name"].InnerText;
                sb.Append("<<  " + name + "  >>  " + DecodeText(text) + "\r\n");
            }

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
