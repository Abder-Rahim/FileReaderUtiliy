namespace FileReaderUtility
{
    partial class FileReaderUtilityForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFileContent = new System.Windows.Forms.TextBox();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnSelecTexFile = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnSelecXmlFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFileContent
            // 
            this.txtFileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileContent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileContent.Location = new System.Drawing.Point(3, 131);
            this.txtFileContent.Multiline = true;
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFileContent.Size = new System.Drawing.Size(794, 317);
            this.txtFileContent.TabIndex = 0;
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "openFileDialog1";
            // 
            // btnSelecTexFile
            // 
            this.btnSelecTexFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelecTexFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecTexFile.Location = new System.Drawing.Point(0, 0);
            this.btnSelecTexFile.Name = "btnSelecTexFile";
            this.btnSelecTexFile.Size = new System.Drawing.Size(800, 36);
            this.btnSelecTexFile.TabIndex = 1;
            this.btnSelecTexFile.Text = "Select your Text file";
            this.btnSelecTexFile.UseVisualStyleBackColor = true;
            this.btnSelecTexFile.Click += new System.EventHandler(this.btnSelecTexFile_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(12, 111);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(0, 13);
            this.lblFilePath.TabIndex = 2;
            // 
            // btnSelecXmlFile
            // 
            this.btnSelecXmlFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSelecXmlFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecXmlFile.Location = new System.Drawing.Point(0, 36);
            this.btnSelecXmlFile.Name = "btnSelecXmlFile";
            this.btnSelecXmlFile.Size = new System.Drawing.Size(800, 36);
            this.btnSelecXmlFile.TabIndex = 3;
            this.btnSelecXmlFile.Text = "Select your Xml file";
            this.btnSelecXmlFile.UseVisualStyleBackColor = true;
            this.btnSelecXmlFile.Click += new System.EventHandler(this.btnSelecXmlFile_Click);
            // 
            // FileReaderUtilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelecXmlFile);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.btnSelecTexFile);
            this.Controls.Add(this.txtFileContent);
            this.Name = "FileReaderUtilityForm";
            this.Text = "FileReaderUtility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileContent;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
        private System.Windows.Forms.Button btnSelecTexFile;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnSelecXmlFile;
    }
}

