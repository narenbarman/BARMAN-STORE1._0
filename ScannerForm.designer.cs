namespace BARMAN_STORE1._0
{
    partial class ScannerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.Color_mode_Label = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.textColorMode = new System.Windows.Forms.TextBox();
            this.Resolution_Label = new System.Windows.Forms.Label();
            this.textResolution = new System.Windows.Forms.TextBox();
            this.Contrast_Label = new System.Windows.Forms.Label();
            this.textContrast = new System.Windows.Forms.TextBox();
            this.Brightness_Label = new System.Windows.Forms.Label();
            this.textBrightness = new System.Windows.Forms.TextBox();
            this.Height_Label = new System.Windows.Forms.Label();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.Width_Label = new System.Windows.Forms.Label();
            this.textWidth = new System.Windows.Forms.TextBox();
            this.Select_a_scanner_Label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Folder_label = new System.Windows.Forms.Label();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.Image_Format_Label = new System.Windows.Forms.Label();
            this.textFolder = new System.Windows.Forms.TextBox();
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Filename_label = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.propertiesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.imagePanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.propertiesGroupBox.SuspendLayout();
            this.propertiesPanel.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Controls.Add(this.Color_mode_Label);
            this.propertiesGroupBox.Controls.Add(this.scanButton);
            this.propertiesGroupBox.Controls.Add(this.textColorMode);
            this.propertiesGroupBox.Controls.Add(this.Resolution_Label);
            this.propertiesGroupBox.Controls.Add(this.textResolution);
            this.propertiesGroupBox.Controls.Add(this.Contrast_Label);
            this.propertiesGroupBox.Controls.Add(this.textContrast);
            this.propertiesGroupBox.Controls.Add(this.Brightness_Label);
            this.propertiesGroupBox.Controls.Add(this.textBrightness);
            this.propertiesGroupBox.Controls.Add(this.Height_Label);
            this.propertiesGroupBox.Controls.Add(this.textHeight);
            this.propertiesGroupBox.Controls.Add(this.Width_Label);
            this.propertiesGroupBox.Controls.Add(this.textWidth);
            this.propertiesGroupBox.Controls.Add(this.Select_a_scanner_Label);
            this.propertiesGroupBox.Controls.Add(this.comboBox1);
            this.propertiesGroupBox.Controls.Add(this.Folder_label);
            this.propertiesGroupBox.Controls.Add(this.textFileName);
            this.propertiesGroupBox.Controls.Add(this.Image_Format_Label);
            this.propertiesGroupBox.Controls.Add(this.textFolder);
            this.propertiesGroupBox.Controls.Add(this.selectFolderButton);
            this.propertiesGroupBox.Controls.Add(this.listBox1);
            this.propertiesGroupBox.Controls.Add(this.Filename_label);
            this.propertiesGroupBox.Controls.Add(this.saveButton);
            this.propertiesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesGroupBox.Location = new System.Drawing.Point(3, 3);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(382, 504);
            this.propertiesGroupBox.TabIndex = 0;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Properties";
            // 
            // Color_mode_Label
            // 
            this.Color_mode_Label.AutoSize = true;
            this.Color_mode_Label.Location = new System.Drawing.Point(200, 154);
            this.Color_mode_Label.Name = "Color_mode_Label";
            this.Color_mode_Label.Size = new System.Drawing.Size(60, 13);
            this.Color_mode_Label.TabIndex = 0;
            this.Color_mode_Label.Text = "Color mode";
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(50, 254);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(300, 35);
            this.scanButton.TabIndex = 0;
            this.scanButton.Text = "Start scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // textColorMode
            // 
            this.textColorMode.Location = new System.Drawing.Point(288, 154);
            this.textColorMode.Name = "textColorMode";
            this.textColorMode.Size = new System.Drawing.Size(90, 20);
            this.textColorMode.TabIndex = 20;
            this.textColorMode.Text = "1";
            this.textColorMode.Validating += new System.ComponentModel.CancelEventHandler(this.textColorMode_Validating);
            // 
            // Resolution_Label
            // 
            this.Resolution_Label.AutoSize = true;
            this.Resolution_Label.Location = new System.Drawing.Point(10, 154);
            this.Resolution_Label.Name = "Resolution_Label";
            this.Resolution_Label.Size = new System.Drawing.Size(57, 13);
            this.Resolution_Label.TabIndex = 0;
            this.Resolution_Label.Text = "Resolution";
            // 
            // textResolution
            // 
            this.textResolution.Location = new System.Drawing.Point(100, 154);
            this.textResolution.Name = "textResolution";
            this.textResolution.Size = new System.Drawing.Size(90, 20);
            this.textResolution.TabIndex = 1;
            this.textResolution.Text = "300";
            this.textResolution.Validating += new System.ComponentModel.CancelEventHandler(this.textResolution_Validating);
            // 
            // Contrast_Label
            // 
            this.Contrast_Label.AutoSize = true;
            this.Contrast_Label.Location = new System.Drawing.Point(200, 214);
            this.Contrast_Label.Name = "Contrast_Label";
            this.Contrast_Label.Size = new System.Drawing.Size(63, 13);
            this.Contrast_Label.TabIndex = 17;
            this.Contrast_Label.Text = "Contrast (%)";
            // 
            // textContrast
            // 
            this.textContrast.Location = new System.Drawing.Point(288, 214);
            this.textContrast.Name = "textContrast";
            this.textContrast.Size = new System.Drawing.Size(90, 20);
            this.textContrast.TabIndex = 16;
            this.textContrast.Text = "0";
            this.textContrast.Validating += new System.ComponentModel.CancelEventHandler(this.textContrast_Validating);
            // 
            // Brightness_Label
            // 
            this.Brightness_Label.AutoSize = true;
            this.Brightness_Label.Location = new System.Drawing.Point(10, 214);
            this.Brightness_Label.Name = "Brightness_Label";
            this.Brightness_Label.Size = new System.Drawing.Size(73, 13);
            this.Brightness_Label.TabIndex = 15;
            this.Brightness_Label.Text = "Brightness (%)";
            // 
            // textBrightness
            // 
            this.textBrightness.Location = new System.Drawing.Point(100, 214);
            this.textBrightness.Name = "textBrightness";
            this.textBrightness.Size = new System.Drawing.Size(90, 20);
            this.textBrightness.TabIndex = 14;
            this.textBrightness.Text = "0";
            this.textBrightness.Validating += new System.ComponentModel.CancelEventHandler(this.textBrightness_Validating);
            // 
            // Height_Label
            // 
            this.Height_Label.AutoSize = true;
            this.Height_Label.Location = new System.Drawing.Point(200, 184);
            this.Height_Label.Name = "Height_Label";
            this.Height_Label.Size = new System.Drawing.Size(68, 13);
            this.Height_Label.TabIndex = 0;
            this.Height_Label.Text = "Height (pixel)";
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(288, 184);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(90, 20);
            this.textHeight.TabIndex = 2;
            this.textHeight.Text = "3500";
            this.textHeight.Validating += new System.ComponentModel.CancelEventHandler(this.textWidth_Validating);
            // 
            // Width_Label
            // 
            this.Width_Label.AutoSize = true;
            this.Width_Label.Location = new System.Drawing.Point(10, 184);
            this.Width_Label.Name = "Width_Label";
            this.Width_Label.Size = new System.Drawing.Size(65, 13);
            this.Width_Label.TabIndex = 0;
            this.Width_Label.Text = "Width (pixel)";
            // 
            // textWidth
            // 
            this.textWidth.Location = new System.Drawing.Point(100, 184);
            this.textWidth.Name = "textWidth";
            this.textWidth.Size = new System.Drawing.Size(90, 20);
            this.textWidth.TabIndex = 2;
            this.textWidth.Text = "2480";
            this.textWidth.Validating += new System.ComponentModel.CancelEventHandler(this.textWidth_Validating);
            // 
            // Select_a_scanner_Label
            // 
            this.Select_a_scanner_Label.AutoSize = true;
            this.Select_a_scanner_Label.Location = new System.Drawing.Point(16, 54);
            this.Select_a_scanner_Label.Name = "Select_a_scanner_Label";
            this.Select_a_scanner_Label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Select_a_scanner_Label.Size = new System.Drawing.Size(80, 13);
            this.Select_a_scanner_Label.TabIndex = 21;
            this.Select_a_scanner_Label.Text = "Select Scanner";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PNG",
            "JPEG",
            "TIF",
            "BMP",
            "GIF"});
            this.comboBox1.Location = new System.Drawing.Point(100, 365);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Folder_label
            // 
            this.Folder_label.AutoSize = true;
            this.Folder_label.Location = new System.Drawing.Point(13, 331);
            this.Folder_label.Name = "Folder_label";
            this.Folder_label.Size = new System.Drawing.Size(69, 13);
            this.Folder_label.TabIndex = 5;
            this.Folder_label.Text = "Select Folder";
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(100, 405);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(186, 20);
            this.textFileName.TabIndex = 4;
            this.textFileName.Text = "myscan";
            // 
            // Image_Format_Label
            // 
            this.Image_Format_Label.AutoSize = true;
            this.Image_Format_Label.Location = new System.Drawing.Point(13, 365);
            this.Image_Format_Label.Name = "Image_Format_Label";
            this.Image_Format_Label.Size = new System.Drawing.Size(71, 13);
            this.Image_Format_Label.TabIndex = 0;
            this.Image_Format_Label.Text = "Image Format";
            // 
            // textFolder
            // 
            this.textFolder.Enabled = false;
            this.textFolder.Location = new System.Drawing.Point(100, 328);
            this.textFolder.Name = "textFolder";
            this.textFolder.Size = new System.Drawing.Size(186, 20);
            this.textFolder.TabIndex = 2;
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Location = new System.Drawing.Point(291, 327);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(90, 20);
            this.selectFolderButton.TabIndex = 1;
            this.selectFolderButton.Text = "Browse";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(117, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 95);
            this.listBox1.TabIndex = 0;
            // 
            // Filename_label
            // 
            this.Filename_label.AutoSize = true;
            this.Filename_label.Location = new System.Drawing.Point(13, 408);
            this.Filename_label.Name = "Filename_label";
            this.Filename_label.Size = new System.Drawing.Size(54, 13);
            this.Filename_label.TabIndex = 22;
            this.Filename_label.Text = "File Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(223, 452);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 40);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.ColumnCount = 2;
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.propertiesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.propertiesPanel.Controls.Add(this.propertiesGroupBox, 0, 0);
            this.propertiesPanel.Controls.Add(this.imagePanel, 1, 0);
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesPanel.Location = new System.Drawing.Point(0, 0);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 510F));
            this.propertiesPanel.Size = new System.Drawing.Size(1110, 510);
            this.propertiesPanel.TabIndex = 0;
            // 
            // imagePanel
            // 
            this.imagePanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.imagePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 660F));
            this.imagePanel.Controls.Add(this.pictureBox1);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePanel.Location = new System.Drawing.Point(391, 3);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 504F));
            this.imagePanel.Size = new System.Drawing.Size(716, 504);
            this.imagePanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ScannerForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 510);
            this.Controls.Add(this.propertiesPanel);
            this.Name = "ScannerForm1";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertiesGroupBox.PerformLayout();
            this.propertiesPanel.ResumeLayout(false);
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.TableLayoutPanel propertiesPanel;
        private System.Windows.Forms.TableLayoutPanel imagePanel;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Label Image_Format_Label;
        private System.Windows.Forms.Label Folder_label;
        private System.Windows.Forms.Label Filename_label;
        private System.Windows.Forms.Label Select_a_scanner_Label;
        private System.Windows.Forms.Label Width_Label;
        private System.Windows.Forms.Label Height_Label;
        private System.Windows.Forms.Label Brightness_Label;
        private System.Windows.Forms.Label Contrast_Label;
        private System.Windows.Forms.Label Resolution_Label;
        private System.Windows.Forms.Label Color_mode_Label;
        


        private System.Windows.Forms.TextBox textFolder;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.TextBox textColorMode;
        private System.Windows.Forms.TextBox textResolution;
        private System.Windows.Forms.TextBox textContrast;
        private System.Windows.Forms.TextBox textBrightness;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWidth;

        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.Button saveButton;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.ComboBox comboBox1;
    }
}