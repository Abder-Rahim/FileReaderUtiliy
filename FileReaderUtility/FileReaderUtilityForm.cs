/* 
 Date : 03/03/2019
 Author : developpeur-csharp.com
 Project : FileReaderUtility
*/

using FileReaderUtility.Helpers;
using System;
using System.IO;
using System.Windows.Forms;

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
                        // Check if the user has selected a text file
                        string extension = new FileInfo(openFileDialog.FileName).Extension.ToLower();
                        if (extension != ".txt")
                        {
                            throw new Exception("You need to select an text file");
                        }

                        // Get the path of specified file
                        filePath = openFileDialog.FileName;
                        this.Text = filePath;

                        // Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        // Load the text stream in a textbox
                        UFile uFile = new UFile();
                        UTextReader tr = new UTextReader(fileStream, chkDecode.Checked);
                        fileContent = uFile.GetFileContent(tr);
                        txtFileContent.Text = fileContent;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        // Check if the user has selected a xml file
                        string extension = new FileInfo(openFileDialog.FileName).Extension.ToLower();
                        if (extension != ".xml")
                        {
                            throw new Exception("You need to select an xml file");
                        }

                        // Get the path of specified file
                        filePath = openFileDialog.FileName;
                        this.Text = filePath;

                        // Read the contents of the file into stream
                        var fileStream = openFileDialog.OpenFile();

                        // Load the XML stream in a textbox
                        UFile uFile = new UFile();
                        UXmlReader xmlReader = new UXmlReader(fileStream, chkDecode.Checked);
                        fileContent = uFile.GetFileContent(xmlReader);
                        txtFileContent.Text = fileContent;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Load selected json file in a text box
        /// </summary>
        private void btnSelecJsonFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "All files (*.*)|*.*|json files (*.json)|*.json";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Check if the user has selected a json file
                        string extension = new FileInfo(openFileDialog.FileName).Extension.ToLower();
                        if (extension != ".json")
                        {
                            throw new Exception("You need to select an json file");
                        }

                        //Get the path of specified file
                        filePath = openFileDialog.FileName;
                        this.Text = filePath;

                        //Read the contents of the file into stream
                        var fileStream = openFileDialog.OpenFile();

                        // Load the XML stream in a textbox
                        UFile uFile = new UFile();
                        UJsonReader jsonReader = new UJsonReader(fileStream, chkDecode.Checked);
                        fileContent = uFile.GetFileContent(jsonReader);
                        txtFileContent.Text = fileContent;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
