namespace BARMAN_STORE1._0.Vouchers
{
    partial class VoucherForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label voucher_noLabel;
            System.Windows.Forms.Label party_nameLabel;
            System.Windows.Forms.Label voucher_amountLabel;
            System.Windows.Forms.Label voucher_dateLabel;
            System.Windows.Forms.Label voucher_duedateLabel;
            System.Windows.Forms.Label voucher_typeLabel;
            System.Windows.Forms.Label label1;
            this.transactionTab = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.imageTab = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detailTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.voucher_duedateTextBox = new System.Windows.Forms.TextBox();
            this.voucher_dateTextBox = new System.Windows.Forms.TextBox();
            this.voucher_typeTextBox = new System.Windows.Forms.ComboBox();
            this.voucher_duedateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.voucher_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.party_nameTextBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.modifyButton = new System.Windows.Forms.Button();
            this.amount_pendingTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.voucher_noTextBox = new System.Windows.Forms.TextBox();
            this.voucher_amountTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.userDatabaseDataSet = new BARMAN_STORE1._0.UserDatabaseDataSet();
            this.voucherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voucherTableAdapter = new BARMAN_STORE1._0.UserDatabaseDataSetTableAdapters.voucherTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            voucher_noLabel = new System.Windows.Forms.Label();
            party_nameLabel = new System.Windows.Forms.Label();
            voucher_amountLabel = new System.Windows.Forms.Label();
            voucher_dateLabel = new System.Windows.Forms.Label();
            voucher_duedateLabel = new System.Windows.Forms.Label();
            voucher_typeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.transactionTab.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.imageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.detailTab.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(34, 126);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            idLabel.Visible = false;
            // 
            // voucher_noLabel
            // 
            voucher_noLabel.AutoSize = true;
            voucher_noLabel.Location = new System.Drawing.Point(33, 24);
            voucher_noLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            voucher_noLabel.Name = "voucher_noLabel";
            voucher_noLabel.Size = new System.Drawing.Size(61, 17);
            voucher_noLabel.TabIndex = 2;
            voucher_noLabel.Text = "BILL NO";
            // 
            // party_nameLabel
            // 
            party_nameLabel.AutoSize = true;
            party_nameLabel.Location = new System.Drawing.Point(33, 56);
            party_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            party_nameLabel.Name = "party_nameLabel";
            party_nameLabel.Size = new System.Drawing.Size(97, 17);
            party_nameLabel.TabIndex = 4;
            party_nameLabel.Text = "PARTY NAME";
            // 
            // voucher_amountLabel
            // 
            voucher_amountLabel.AutoSize = true;
            voucher_amountLabel.Location = new System.Drawing.Point(33, 88);
            voucher_amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            voucher_amountLabel.Name = "voucher_amountLabel";
            voucher_amountLabel.Size = new System.Drawing.Size(118, 17);
            voucher_amountLabel.TabIndex = 6;
            voucher_amountLabel.Text = "BILL AMOUNT(₹)";
            // 
            // voucher_dateLabel
            // 
            voucher_dateLabel.AutoSize = true;
            voucher_dateLabel.Location = new System.Drawing.Point(401, 24);
            voucher_dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            voucher_dateLabel.Name = "voucher_dateLabel";
            voucher_dateLabel.Size = new System.Drawing.Size(77, 17);
            voucher_dateLabel.TabIndex = 8;
            voucher_dateLabel.Text = "BILL DATE";
            // 
            // voucher_duedateLabel
            // 
            voucher_duedateLabel.AutoSize = true;
            voucher_duedateLabel.Location = new System.Drawing.Point(401, 56);
            voucher_duedateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            voucher_duedateLabel.Name = "voucher_duedateLabel";
            voucher_duedateLabel.Size = new System.Drawing.Size(78, 17);
            voucher_duedateLabel.TabIndex = 10;
            voucher_duedateLabel.Text = "DUE DATE";
            // 
            // voucher_typeLabel
            // 
            voucher_typeLabel.AutoSize = true;
            voucher_typeLabel.Location = new System.Drawing.Point(401, 88);
            voucher_typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            voucher_typeLabel.Name = "voucher_typeLabel";
            voucher_typeLabel.Size = new System.Drawing.Size(44, 17);
            voucher_typeLabel.TabIndex = 12;
            voucher_typeLabel.Text = "TYPE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(401, 123);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 17);
            label1.TabIndex = 14;
            label1.Text = "AMOUNT PENDING";
            // 
            // transactionTab
            // 
            this.transactionTab.Controls.Add(this.panel4);
            this.transactionTab.Controls.Add(this.panel3);
            this.transactionTab.Location = new System.Drawing.Point(4, 25);
            this.transactionTab.Margin = new System.Windows.Forms.Padding(4);
            this.transactionTab.Name = "transactionTab";
            this.transactionTab.Padding = new System.Windows.Forms.Padding(4);
            this.transactionTab.Size = new System.Drawing.Size(783, 417);
            this.transactionTab.TabIndex = 2;
            this.transactionTab.Text = "Transaction";
            this.transactionTab.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(775, 257);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(775, 152);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(775, 152);
            this.dataGridView2.TabIndex = 1;
            // 
            // imageTab
            // 
            this.imageTab.Controls.Add(this.pictureBox1);
            this.imageTab.Location = new System.Drawing.Point(4, 25);
            this.imageTab.Margin = new System.Windows.Forms.Padding(4);
            this.imageTab.Name = "imageTab";
            this.imageTab.Padding = new System.Windows.Forms.Padding(4);
            this.imageTab.Size = new System.Drawing.Size(783, 417);
            this.imageTab.TabIndex = 1;
            this.imageTab.Text = "Image";
            this.imageTab.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(153, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 411);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // detailTab
            // 
            this.detailTab.Controls.Add(this.panel2);
            this.detailTab.Controls.Add(this.panel1);
            this.detailTab.Location = new System.Drawing.Point(4, 25);
            this.detailTab.Margin = new System.Windows.Forms.Padding(4);
            this.detailTab.Name = "detailTab";
            this.detailTab.Padding = new System.Windows.Forms.Padding(4);
            this.detailTab.Size = new System.Drawing.Size(783, 417);
            this.detailTab.TabIndex = 0;
            this.detailTab.Text = "Details";
            this.detailTab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 184);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 229);
            this.panel2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.voucher_duedateTextBox);
            this.panel1.Controls.Add(this.voucher_dateTextBox);
            this.panel1.Controls.Add(this.voucher_typeTextBox);
            this.panel1.Controls.Add(this.voucher_duedateDateTimePicker);
            this.panel1.Controls.Add(this.voucher_dateDateTimePicker);
            this.panel1.Controls.Add(this.party_nameTextBox);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.modifyButton);
            this.panel1.Controls.Add(this.amount_pendingTextBox);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(voucher_typeLabel);
            this.panel1.Controls.Add(voucher_noLabel);
            this.panel1.Controls.Add(this.voucher_noTextBox);
            this.panel1.Controls.Add(voucher_duedateLabel);
            this.panel1.Controls.Add(party_nameLabel);
            this.panel1.Controls.Add(voucher_dateLabel);
            this.panel1.Controls.Add(this.voucher_amountTextBox);
            this.panel1.Controls.Add(voucher_amountLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 180);
            this.panel1.TabIndex = 14;
            // 
            // voucher_duedateTextBox
            // 
            this.voucher_duedateTextBox.Location = new System.Drawing.Point(539, 55);
            this.voucher_duedateTextBox.Name = "voucher_duedateTextBox";
            this.voucher_duedateTextBox.ReadOnly = true;
            this.voucher_duedateTextBox.Size = new System.Drawing.Size(155, 23);
            this.voucher_duedateTextBox.TabIndex = 23;
            this.voucher_duedateTextBox.TextChanged += new System.EventHandler(this.voucher_duedateTextBox_TextChanged);
            // 
            // voucher_dateTextBox
            // 
            this.voucher_dateTextBox.Location = new System.Drawing.Point(539, 21);
            this.voucher_dateTextBox.Name = "voucher_dateTextBox";
            this.voucher_dateTextBox.ReadOnly = true;
            this.voucher_dateTextBox.Size = new System.Drawing.Size(155, 23);
            this.voucher_dateTextBox.TabIndex = 22;
            this.voucher_dateTextBox.TextChanged += new System.EventHandler(this.voucher_dateTextBox_TextChanged);
            // 
            // voucher_typeTextBox
            // 
            this.voucher_typeTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voucher_typeTextBox.Enabled = false;
            this.voucher_typeTextBox.FormattingEnabled = true;
            this.voucher_typeTextBox.Items.AddRange(new object[] {
            "Payment",
            "Recieved"});
            this.voucher_typeTextBox.Location = new System.Drawing.Point(539, 85);
            this.voucher_typeTextBox.Name = "voucher_typeTextBox";
            this.voucher_typeTextBox.Size = new System.Drawing.Size(178, 24);
            this.voucher_typeTextBox.TabIndex = 21;
            // 
            // voucher_duedateDateTimePicker
            // 
            this.voucher_duedateDateTimePicker.Enabled = false;
            this.voucher_duedateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.voucher_duedateDateTimePicker.Location = new System.Drawing.Point(700, 54);
            this.voucher_duedateDateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.voucher_duedateDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.voucher_duedateDateTimePicker.Name = "voucher_duedateDateTimePicker";
            this.voucher_duedateDateTimePicker.Size = new System.Drawing.Size(17, 23);
            this.voucher_duedateDateTimePicker.TabIndex = 20;
            this.voucher_duedateDateTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // voucher_dateDateTimePicker
            // 
            this.voucher_dateDateTimePicker.Enabled = false;
            this.voucher_dateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.voucher_dateDateTimePicker.Location = new System.Drawing.Point(700, 20);
            this.voucher_dateDateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.voucher_dateDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.voucher_dateDateTimePicker.Name = "voucher_dateDateTimePicker";
            this.voucher_dateDateTimePicker.Size = new System.Drawing.Size(17, 23);
            this.voucher_dateDateTimePicker.TabIndex = 19;
            // 
            // party_nameTextBox
            // 
            this.party_nameTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.party_nameTextBox.Enabled = false;
            this.party_nameTextBox.FormattingEnabled = true;
            this.party_nameTextBox.Location = new System.Drawing.Point(162, 53);
            this.party_nameTextBox.Name = "party_nameTextBox";
            this.party_nameTextBox.Size = new System.Drawing.Size(174, 24);
            this.party_nameTextBox.TabIndex = 18;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(491, 150);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(108, 27);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(613, 150);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(108, 27);
            this.modifyButton.TabIndex = 16;
            this.modifyButton.Text = "MODIFY";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // amount_pendingTextBox
            // 
            this.amount_pendingTextBox.Location = new System.Drawing.Point(539, 120);
            this.amount_pendingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.amount_pendingTextBox.Name = "amount_pendingTextBox";
            this.amount_pendingTextBox.ReadOnly = true;
            this.amount_pendingTextBox.Size = new System.Drawing.Size(182, 23);
            this.amount_pendingTextBox.TabIndex = 15;
            this.amount_pendingTextBox.TextChanged += new System.EventHandler(this.amount_pendingTextBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(163, 123);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(173, 23);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.Visible = false;
            // 
            // voucher_noTextBox
            // 
            this.voucher_noTextBox.Location = new System.Drawing.Point(162, 20);
            this.voucher_noTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.voucher_noTextBox.Name = "voucher_noTextBox";
            this.voucher_noTextBox.ReadOnly = true;
            this.voucher_noTextBox.Size = new System.Drawing.Size(174, 23);
            this.voucher_noTextBox.TabIndex = 3;
            // 
            // voucher_amountTextBox
            // 
            this.voucher_amountTextBox.Location = new System.Drawing.Point(162, 84);
            this.voucher_amountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.voucher_amountTextBox.Name = "voucher_amountTextBox";
            this.voucher_amountTextBox.ReadOnly = true;
            this.voucher_amountTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.voucher_amountTextBox.Size = new System.Drawing.Size(174, 23);
            this.voucher_amountTextBox.TabIndex = 7;
            this.voucher_amountTextBox.Text = "0.00";
            this.voucher_amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.voucher_amountTextBox.TextChanged += new System.EventHandler(this.voucher_amountTextBox_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.detailTab);
            this.tabControl1.Controls.Add(this.imageTab);
            this.tabControl1.Controls.Add(this.transactionTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 446);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // userDatabaseDataSet
            // 
            this.userDatabaseDataSet.DataSetName = "UserDatabaseDataSet";
            this.userDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voucherBindingSource
            // 
            this.voucherBindingSource.DataMember = "voucher";
            this.voucherBindingSource.DataSource = this.userDatabaseDataSet;
            // 
            // voucherTableAdapter
            // 
            this.voucherTableAdapter.ClearBeforeFill = true;
            // 
            // VoucherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 446);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VoucherForm";
            this.Text = "Voucher";
            this.Load += new System.EventHandler(this.Voucher_Load);
            this.transactionTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.imageTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.detailTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voucherBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage transactionTab;
        private System.Windows.Forms.TabPage imageTab;
        private System.Windows.Forms.TabPage detailTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox voucher_noTextBox;
        private System.Windows.Forms.TextBox voucher_amountTextBox;
        private System.Windows.Forms.TextBox amount_pendingTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button saveButton;
        internal System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.ComboBox party_nameTextBox;
        private System.Windows.Forms.DateTimePicker voucher_duedateDateTimePicker;
        private System.Windows.Forms.DateTimePicker voucher_dateDateTimePicker;
        private System.Windows.Forms.ComboBox voucher_typeTextBox;
        private System.Windows.Forms.TextBox voucher_duedateTextBox;
        private System.Windows.Forms.TextBox voucher_dateTextBox;
        private UserDatabaseDataSet userDatabaseDataSet;
        private System.Windows.Forms.BindingSource voucherBindingSource;
        private UserDatabaseDataSetTableAdapters.voucherTableAdapter voucherTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}