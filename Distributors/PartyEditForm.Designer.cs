namespace BARMAN_STORE1._0.Distributors
{
    partial class PartyEditForm
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
            System.Windows.Forms.Label party_nameLabel;
            System.Windows.Forms.Label distributorLabel;
            System.Windows.Forms.Label salesman_nameLabel;
            System.Windows.Forms.Label salesman_contLabel;
            System.Windows.Forms.Label salesman_emailLabel;
            System.Windows.Forms.Label visiting_dayLabel;
            System.Windows.Forms.Label delivery_dayLabel;
            System.Windows.Forms.Label credit_durationLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.party_nameTextBox = new System.Windows.Forms.TextBox();
            this.distributorComboBox = new System.Windows.Forms.ComboBox();
            this.salesman_nameTextBox = new System.Windows.Forms.TextBox();
            this.salesman_contTextBox = new System.Windows.Forms.TextBox();
            this.salesman_emailTextBox = new System.Windows.Forms.TextBox();
            this.visiting_dayComboBox = new System.Windows.Forms.ComboBox();
            this.delivery_dayComboBox = new System.Windows.Forms.ComboBox();
            this.credit_durationComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            party_nameLabel = new System.Windows.Forms.Label();
            distributorLabel = new System.Windows.Forms.Label();
            salesman_nameLabel = new System.Windows.Forms.Label();
            salesman_contLabel = new System.Windows.Forms.Label();
            salesman_emailLabel = new System.Windows.Forms.Label();
            visiting_dayLabel = new System.Windows.Forms.Label();
            delivery_dayLabel = new System.Windows.Forms.Label();
            credit_durationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // party_nameLabel
            // 
            party_nameLabel.AutoSize = true;
            party_nameLabel.Location = new System.Drawing.Point(28, 37);
            party_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            party_nameLabel.Name = "party_nameLabel";
            party_nameLabel.Size = new System.Drawing.Size(97, 17);
            party_nameLabel.TabIndex = 2;
            party_nameLabel.Text = "PARTY NAME";
            // 
            // distributorLabel
            // 
            distributorLabel.AutoSize = true;
            distributorLabel.Location = new System.Drawing.Point(28, 98);
            distributorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            distributorLabel.Name = "distributorLabel";
            distributorLabel.Size = new System.Drawing.Size(144, 17);
            distributorLabel.TabIndex = 4;
            distributorLabel.Text = "DISTRIBUTOR NAME";
            // 
            // salesman_nameLabel
            // 
            salesman_nameLabel.AutoSize = true;
            salesman_nameLabel.Location = new System.Drawing.Point(28, 158);
            salesman_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            salesman_nameLabel.Name = "salesman_nameLabel";
            salesman_nameLabel.Size = new System.Drawing.Size(129, 17);
            salesman_nameLabel.TabIndex = 6;
            salesman_nameLabel.Text = "SALES MAN NAME";
            // 
            // salesman_contLabel
            // 
            salesman_contLabel.AutoSize = true;
            salesman_contLabel.Location = new System.Drawing.Point(28, 217);
            salesman_contLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            salesman_contLabel.Name = "salesman_contLabel";
            salesman_contLabel.Size = new System.Drawing.Size(181, 17);
            salesman_contLabel.TabIndex = 8;
            salesman_contLabel.Text = "SALES MAN CONTACT NO";
            // 
            // salesman_emailLabel
            // 
            salesman_emailLabel.AutoSize = true;
            salesman_emailLabel.Location = new System.Drawing.Point(359, 37);
            salesman_emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            salesman_emailLabel.Name = "salesman_emailLabel";
            salesman_emailLabel.Size = new System.Drawing.Size(126, 17);
            salesman_emailLabel.TabIndex = 10;
            salesman_emailLabel.Text = "SALESMAN EMAIL";
            // 
            // visiting_dayLabel
            // 
            visiting_dayLabel.AutoSize = true;
            visiting_dayLabel.Location = new System.Drawing.Point(359, 98);
            visiting_dayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            visiting_dayLabel.Name = "visiting_dayLabel";
            visiting_dayLabel.Size = new System.Drawing.Size(97, 17);
            visiting_dayLabel.TabIndex = 12;
            visiting_dayLabel.Text = "VISITING DAY";
            // 
            // delivery_dayLabel
            // 
            delivery_dayLabel.AutoSize = true;
            delivery_dayLabel.Location = new System.Drawing.Point(356, 158);
            delivery_dayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            delivery_dayLabel.Name = "delivery_dayLabel";
            delivery_dayLabel.Size = new System.Drawing.Size(107, 17);
            delivery_dayLabel.TabIndex = 14;
            delivery_dayLabel.Text = "DELIVERY DAY";
            // 
            // credit_durationLabel
            // 
            credit_durationLabel.AutoSize = true;
            credit_durationLabel.Location = new System.Drawing.Point(356, 217);
            credit_durationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            credit_durationLabel.Name = "credit_durationLabel";
            credit_durationLabel.Size = new System.Drawing.Size(134, 17);
            credit_durationLabel.TabIndex = 16;
            credit_durationLabel.Text = "CREDIT DURATION";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 354);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(party_nameLabel);
            this.groupBox1.Controls.Add(this.party_nameTextBox);
            this.groupBox1.Controls.Add(distributorLabel);
            this.groupBox1.Controls.Add(this.distributorComboBox);
            this.groupBox1.Controls.Add(salesman_nameLabel);
            this.groupBox1.Controls.Add(this.salesman_nameTextBox);
            this.groupBox1.Controls.Add(salesman_contLabel);
            this.groupBox1.Controls.Add(this.salesman_contTextBox);
            this.groupBox1.Controls.Add(salesman_emailLabel);
            this.groupBox1.Controls.Add(this.salesman_emailTextBox);
            this.groupBox1.Controls.Add(visiting_dayLabel);
            this.groupBox1.Controls.Add(this.visiting_dayComboBox);
            this.groupBox1.Controls.Add(delivery_dayLabel);
            this.groupBox1.Controls.Add(this.delivery_dayComboBox);
            this.groupBox1.Controls.Add(credit_durationLabel);
            this.groupBox1.Controls.Add(this.credit_durationComboBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(656, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // party_nameTextBox
            // 
            this.party_nameTextBox.Location = new System.Drawing.Point(31, 63);
            this.party_nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.party_nameTextBox.Name = "party_nameTextBox";
            this.party_nameTextBox.Size = new System.Drawing.Size(281, 23);
            this.party_nameTextBox.TabIndex = 3;
            // 
            // distributorComboBox
            // 
            this.distributorComboBox.FormattingEnabled = true;
            this.distributorComboBox.Location = new System.Drawing.Point(31, 121);
            this.distributorComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.distributorComboBox.Name = "distributorComboBox";
            this.distributorComboBox.Size = new System.Drawing.Size(281, 24);
            this.distributorComboBox.TabIndex = 5;
            // 
            // salesman_nameTextBox
            // 
            this.salesman_nameTextBox.Location = new System.Drawing.Point(31, 179);
            this.salesman_nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.salesman_nameTextBox.Name = "salesman_nameTextBox";
            this.salesman_nameTextBox.Size = new System.Drawing.Size(281, 23);
            this.salesman_nameTextBox.TabIndex = 7;
            // 
            // salesman_contTextBox
            // 
            this.salesman_contTextBox.Location = new System.Drawing.Point(31, 238);
            this.salesman_contTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.salesman_contTextBox.Name = "salesman_contTextBox";
            this.salesman_contTextBox.Size = new System.Drawing.Size(281, 23);
            this.salesman_contTextBox.TabIndex = 9;
            // 
            // salesman_emailTextBox
            // 
            this.salesman_emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesman_emailTextBox.Location = new System.Drawing.Point(362, 63);
            this.salesman_emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.salesman_emailTextBox.Name = "salesman_emailTextBox";
            this.salesman_emailTextBox.Size = new System.Drawing.Size(258, 23);
            this.salesman_emailTextBox.TabIndex = 11;
            // 
            // visiting_dayComboBox
            // 
            this.visiting_dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visiting_dayComboBox.FormattingEnabled = true;
            this.visiting_dayComboBox.Items.AddRange(new object[] {
            "SUNDAY",
            "MONDAY",
            "TUESDAY",
            "WEDNESSDAY",
            "THURSDAY",
            "FRIDAY",
            "SATURDAY"});
            this.visiting_dayComboBox.Location = new System.Drawing.Point(359, 121);
            this.visiting_dayComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.visiting_dayComboBox.Name = "visiting_dayComboBox";
            this.visiting_dayComboBox.Size = new System.Drawing.Size(258, 24);
            this.visiting_dayComboBox.TabIndex = 13;
            // 
            // delivery_dayComboBox
            // 
            this.delivery_dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delivery_dayComboBox.FormattingEnabled = true;
            this.delivery_dayComboBox.Items.AddRange(new object[] {
            "SUNDAY",
            "MONDAY",
            "TUESDAY",
            "WEDNESSDAY",
            "THURSDAY",
            "FRIDAY",
            "SATURDAY"});
            this.delivery_dayComboBox.Location = new System.Drawing.Point(359, 178);
            this.delivery_dayComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.delivery_dayComboBox.Name = "delivery_dayComboBox";
            this.delivery_dayComboBox.Size = new System.Drawing.Size(258, 24);
            this.delivery_dayComboBox.TabIndex = 15;
            // 
            // credit_durationComboBox
            // 
            this.credit_durationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.credit_durationComboBox.FormattingEnabled = true;
            this.credit_durationComboBox.Items.AddRange(new object[] {
            "CASH ONLY",
            "LESS THAN A WEEK",
            "MORE THAN A WEEK"});
            this.credit_durationComboBox.Location = new System.Drawing.Point(359, 238);
            this.credit_durationComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.credit_durationComboBox.Name = "credit_durationComboBox";
            this.credit_durationComboBox.Size = new System.Drawing.Size(258, 24);
            this.credit_durationComboBox.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.modifyButton);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 321);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(656, 29);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(545, 3);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 1;
            this.modifyButton.Text = "MODIFY";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(455, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PartyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 354);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartyEditForm";
            this.Text = "PartyEditForm";
            this.Load += new System.EventHandler(this.PartyEditForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox party_nameTextBox;
        private System.Windows.Forms.ComboBox distributorComboBox;
        private System.Windows.Forms.TextBox salesman_nameTextBox;
        private System.Windows.Forms.TextBox salesman_contTextBox;
        private System.Windows.Forms.TextBox salesman_emailTextBox;
        private System.Windows.Forms.ComboBox visiting_dayComboBox;
        private System.Windows.Forms.ComboBox delivery_dayComboBox;
        private System.Windows.Forms.ComboBox credit_durationComboBox;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button saveButton;
    }
}