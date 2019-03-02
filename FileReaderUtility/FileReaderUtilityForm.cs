using FileReaderUtility.Model;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Text;

#region Private Members

#endregion
#region Public Properties

#endregion

#region Constructors

#endregion
#region Public Methods

#endregion
namespace FileReaderUtility
{
    public partial class FileReaderUtilityForm : Form
    {
        public FileReaderUtilityForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load selected text file in a text box
        /// </summary>
        private void btnSelecTexFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                        lblFilePath.Text = filePath;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        // Load the text stream in a textbox
                        UFile uFile = new UFile();
                        UTextReader tr = new UTextReader(fileStream);
                        fileContent = uFile.GetFileContent(tr);
                        txtFileContent.Text = fileContent;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// Load selected xml file in a text box
        /// </summary>
        private void btnSelecXmlFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "All files (*.*)|*.*|xml files (*.xml)|*.xml";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                        lblFilePath.Text = filePath;

                        //Read the contents of the file into stream
                        var fileStream = openFileDialog.OpenFile();

                        // Load the XML stream in a textbox
                        UFile uFile = new UFile();
                        UXmlReader xmlReader = new UXmlReader(fileStream);
                        fileContent = uFile.GetFileContent(xmlReader);
                        txtFileContent.Text = fileContent;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
