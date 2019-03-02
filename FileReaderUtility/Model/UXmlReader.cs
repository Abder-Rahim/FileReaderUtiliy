using System.IO;
using System.Text;
using System.Xml;

namespace FileReaderUtility.Model
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

        public UXmlReader(Stream fs) : base(fs)
        {
        }

        #endregion
        
        #region Public Methods

        /// <summary>
        /// Get the content of the xml file
        /// </summary>
        /// <returns>Return the complete contents of the xml stream in a string format</returns>
        public override string Content()
        {
            StringBuilder sb = new StringBuilder();
            XmlDocument doc = new XmlDocument();
            doc.Load(fileStream);
            
            sb.Append("<<  " + doc.DocumentElement.Attributes["name"].Value + "  >>  ");
            sb.Append(doc.DocumentElement.Attributes["type"].Value + "\r\n");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string text = node.InnerText;
                string name = node.Attributes["name"].InnerText;
                sb.Append("<<  " + name + "  >>  " + text + "\r\n");
            }

            fileStream.Close();
            return sb.ToString();
        }

        #endregion
    }
}
