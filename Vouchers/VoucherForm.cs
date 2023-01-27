using BARMAN_STORE1._0.Include;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BARMAN_STORE1._0.Vouchers
{
    public partial class VoucherForm : Form
    {
        private int? voucher_id;
        private string voucher_no;
        private DateTime? voucher_date;
        private DateTime? voucher_duedate;
        private string party_name;
        private string voucher_type;
        private float voucher_amount;
        private string amount_pending;
        SQLConfig config = new SQLConfig();

        public VoucherForm(int voucherid)
        {
            InitializeComponent();
            voucher_id = voucherid;
            config.fiil_CBO("select party_name from party", party_nameComboBox);
            voucher_dateDateTimePicker.DataBindings.Add("Value", voucher_dateTextBox, "Text", true, DataSourceUpdateMode.OnPropertyChanged, "null", string.Format("dd-MM-yyyy"));
            voucher_duedateDateTimePicker.DataBindings.Add("Value", voucher_duedateTextBox, "Text", true, DataSourceUpdateMode.OnPropertyChanged, "null", string.Format("dd-MM-yyyy"));
            dateTextBox.DataBindings.Add("Text", dateTimePicker1, "Text");
            chqdateTextBox.DataBindings.Add("Text", dateTimePicker2, "Text");
            upidateTextBox.DataBindings.Add("Text", dateTimePicker3, "Text");
        }

        private void Voucher_Load(object sender, EventArgs e)
        {

            LoadDetails();

        }

        internal void modifyButton_Click(object sender, EventArgs e)
        {
            EditMode(true);


        }
        internal void EditMode(bool ans)
        {
            voucher_noTextBox.ReadOnly = !ans;
            party_nameComboBox.Enabled = ans;
            voucher_amountTextBox.ReadOnly = !ans;
            voucher_dateDateTimePicker.Enabled = ans;
            voucher_duedateDateTimePicker.Enabled = ans;
            voucher_typeTextBox.Enabled = ans;
            saveButton.Visible = ans;
            modifyButton.Visible = !ans;
            amount_pendingTextBox.Visible = !ans;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text="";
            if (string.IsNullOrEmpty(voucher_noTextBox.Text)) { voucher_noTextBox.Focus();errorLabel.Text="BILL NO CANNOT BE BLANK";return; }
            if (voucher_noTextBox.Text != voucher_no)
            {
                config.singleResult("select voucher_no from voucher where voucher_no='" + voucher_noTextBox.Text + "'");
                if (config.datatable.Rows.Count > 0){voucher_noTextBox.Focus();errorLabel.Text= "BILL NO ALREADY EXIST"; return;}
            }
            string voucher_no_old = voucher_no;
            voucher_no = voucher_noTextBox.Text;
            MessageBox.Show(party_nameComboBox.Text);
            if (string.IsNullOrEmpty(party_nameComboBox.Text)) { party_nameComboBox.Focus(); errorLabel.Text="PARTY NAME CANNOT BE BLANK"; return; }
            party_name = party_nameComboBox.Text;
            
            float val1;
            if (float.TryParse(voucher_amountTextBox.Text,out val1)) { voucher_amount=val1; }
            else { voucher_amountTextBox.Focus(); errorLabel.Text = "Invalid Bill Amount"; return; }
            
            DateTime dat1;
            if (DateTime.TryParse(voucher_dateTextBox.Text,out dat1)) { voucher_date = dat1; }
            else { voucher_dateTextBox.Focus();errorLabel.Text = "Invalid Bill Date"; return; }

            DateTime dat2;
            if (DateTime.TryParse(voucher_duedateTextBox.Text, out dat2)) { voucher_duedate = dat2; }
            else { voucher_duedateTextBox.Focus(); errorLabel.Text = "Invalid Due Date"; return; }
            
            if (string.IsNullOrEmpty(voucher_typeTextBox.Text)) { voucher_typeTextBox.Focus(); errorLabel.Text = "Invalid Bill Type"; return; }    
            voucher_type= voucher_typeTextBox.Text;
            try
            {
                string sql;
                if (voucher_id == -500)
                {
                    sql = @"insert into [voucher] 
                          (voucher_no,party_name,voucher_amount,voucher_date,voucher_duedate,voucher_type) 
                          values ('" + voucher_no + "','" + party_name + "'," + voucher_amount + ","
                          + "CONVERT(date, '" + voucher_date + "', 103) ,"
                          + "CONVERT(date, '" + voucher_date + "', 103) ,'" + voucher_type + "')";
                    config.CExecute_CUD(sql, "Unable to saved", "Data has been saved in the database.");

                }

                else
                {
                    sql = @"update [voucher] set voucher_no='" + voucher_no
                          + "',party_name='" + party_name + "',voucher_amount=" + voucher_amount.ToString()
                          + ",voucher_date= CONVERT(date, '" + voucher_date + "', 103) "
                          + ",voucher_duedate= CONVERT(date, '" + voucher_duedate + "', 103) "
                          + ",voucher_type='" + voucher_type + "' where id=" + voucher_id + "; " +
                          "update [transaction] set voucher_no='" + voucher_no + "' where voucher_no='" + voucher_no_old + "';";

                    config.CExecute_CUD(sql, "Unable to Update", "Data has been Updated in the database.");
                }
                EditMode(false);
                sql = @"select id from voucher where voucher_no='" + voucher_no + "'";
                config.singleResult(sql);
                voucher_id = config.datatable.Rows[0].Field<int>(0);
                Voucher_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }



        private void voucher_duedateTextBox_TextChanged(object sender, EventArgs e)
        {
            DateTime val;
            if (DateTime.TryParse(voucher_duedateTextBox.Text, out val)) voucher_duedateTextBox.Text = val.ToString("dd-MM-yyyy");
        }

        private void voucher_dateTextBox_TextChanged(object sender, EventArgs e)
        {
            DateTime val;
            if (DateTime.TryParse(voucher_dateTextBox.Text, out val)) voucher_dateTextBox.Text = val.ToString("dd-MM-yyyy");
        }


        private void LoadDetails()
        {
            string sql = @"Select id as 'ID',voucher_no as 'BILL NO',
                        party_name as 'PARTY NAME',voucher_amount as 
                        'BILL AMOUNT',VOUCHER_DATE AS 'BILL DATE',
                        VOUCHER_DUEDATE AS 'DUE DATE',
                        FORMAT(voucher_amount-COALESCE((SELECT sum(trans_amount) 
                        from [transaction] where voucher_no=[voucher].voucher_no),0), '0.00') 
                        as 'AMOUNT PENDING',voucher_type as 'Type' From VOUCHER 
                        WHERE id=" + voucher_id;
            config.singleResult(sql);


            if (config.datatable.Rows.Count > 0)
            {
                voucher_no = config.datatable.Rows[0].Field<string>(1);
                party_name = config.datatable.Rows[0].Field<string>(2);
                voucher_amount = config.datatable.Rows[0].Field<Single>(3);
                voucher_date = config.datatable.Rows[0][4] as DateTime?;
                voucher_duedate = config.datatable.Rows[0][5] as DateTime?;
                amount_pending = config.datatable.Rows[0].Field<string>(6);
                voucher_type = config.datatable.Rows[0].Field<string>(7);
            }

            idTextBox.Text = voucher_id.ToString();
            voucher_noTextBox.Text = voucher_no;
            party_nameComboBox.Text = party_name;
            voucher_amountTextBox.Text = voucher_amount.ToString("0.00");
            voucher_dateTextBox.Text = voucher_date.ToString();
            voucher_duedateTextBox.Text = voucher_duedate.ToString();
            voucher_typeTextBox.Text = voucher_type;
            amount_pendingTextBox.Text = string.Format(amount_pending,"0.00");
            float number;
            if (float.TryParse(voucher_amountTextBox.Text, out number))
            {
                voucher_amountTextBox.ForeColor = Color.Black;
                voucher_amountTextBox.Text = number.ToString("0.00");
            }
            else
            {
                voucher_amountTextBox.ForeColor = Color.Red;
            }
            if (voucher_id > 0)
            {
                LoadBill();
            }
            panel4.Visible = (voucher_id > 0);
            
        }



        private void LoadImage()
        {
            if (voucher_id == null || voucher_id == -500) return;
            pictureBox1.Visible = true;
            browseButton.Visible = true;
            saveimgButton.Visible = true;
            string sql = "select voucher_img from voucher where id=" + voucher_id;
            pictureBox1.DataBindings.Clear();
            config.singleResult(sql);
            pictureBox1.DataBindings.Add("Image", config.datatable, "voucher_img", true, DataSourceUpdateMode.Never);
        }
        private void LoadTransaction()
        {
            string sql = @"select RIGHT('0000000' + CAST(id AS VARCHAR), 7) as 'TRANSACTION ID',voucher_no AS 'BILL NO',
                        FORMAT(trans_amount, '0.00') AS 'AMOUNT(RS)',trans_date as 'TRANSACTION DATE' 
                        from [transaction]
                        WHERE voucher_no='" + voucher_no + "'";
            config.Load_DTG(sql, dataGridView2);
            amountTextBox.Text = amount_pending.ToString();
            if (!string.IsNullOrEmpty(amountTextBox.Text)) amountTextBox.Text = float.Parse(amountTextBox.Text).ToString("0.00");
            billnoTextBox.Text = voucher_no;
            partynameTextBox.Text = party_name;
            cashCheckBox.Checked = true;
        }


        private void amount_pendingTextBox_TextChanged(object sender, EventArgs e)
        {
            float val;
             float.TryParse(amount_pendingTextBox.Text, out val);
            amount_pendingTextBox.Text = val.ToString("0.00");
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == detailTab) LoadDetails();
            if (tabControl1.SelectedTab == transactionTab) LoadTransaction();
            if (tabControl1.SelectedTab == imageTab) LoadImage();

        }

        private void voucher_amountTextBox_Validating(object sender, CancelEventArgs e)
        {
            float number;
            if (float.TryParse(voucher_amountTextBox.Text, out number))
            {
                voucher_amountTextBox.ForeColor = Color.Black;
                voucher_amountTextBox.Text = number.ToString("0.00");
            }
            else
            {
                voucher_amountTextBox.ForeColor = Color.Red;
            }
        }



        private void cashCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked)
            {
                chqCheckBox.Checked = false;
                upiCheckBox.Checked = false;
                chqPanel.Visible = false;
                upiPanel.Visible = false;
                chqbankTextBox.Text = "";
                chqdateTextBox.Text = "";
                chqnoTextBox.Text = "";
                chqpartyTextBox.Text = "";
                upidateTextBox.Text = "";
                upiidTextBox.Text = "";
                upiphonenoTextBox.Text = "";
                upitrnoTextBox.Text = "";
            }
        }

        private void chqCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked)
            {
                cashCheckBox.Checked = false;
                upiCheckBox.Checked = false;
                chqPanel.Visible = true;
                upiPanel.Visible = false;
                chqbankTextBox.Text = "";
                chqdateTextBox.Text = "";
                chqnoTextBox.Text = "";
                chqpartyTextBox.Text = "";
                upidateTextBox.Text = "";
                upiidTextBox.Text = "";
                upiphonenoTextBox.Text = "";
                upitrnoTextBox.Text = "";
            }
        }

        private void upiCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            if (checkbox.Checked)
            {
                chqCheckBox.Checked = false;
                cashCheckBox.Checked = false;
                chqPanel.Visible = false;
                upiPanel.Visible = true;
                chqbankTextBox.Text = "";
                chqdateTextBox.Text = "";
                chqnoTextBox.Text = "";
                chqpartyTextBox.Text = "";
                upidateTextBox.Text = "";
                upiidTextBox.Text = "";
                upiphonenoTextBox.Text = "";
                upitrnoTextBox.Text = "";
            }
        }

        private void amountTextBox_Validating(object sender, CancelEventArgs e)
        {
            float val;
            if (float.TryParse(amountTextBox.Text, out val))
            {
                amountTextBox.Text = val.ToString("0.00");
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            errLabel.Text = "";
            if (string.IsNullOrEmpty(billnoTextBox.Text))
            {
                errLabel.Text = "Invalid Bill no";
                return;
            }
            float trans_amount,val;
            if (float.TryParse(amountTextBox.Text, out val)) { trans_amount = val; }
            else
            {
                amountTextBox.Focus();
                errLabel.Text = "Invalid Transaction Amount";
                return;
            }
            
            string paymentmode;
            if (cashCheckBox.Checked) paymentmode = "cash";
            else if (chqCheckBox.Checked) paymentmode = "cheque";
            else if (upiCheckBox.Checked) paymentmode = "upi";
            else paymentmode = "none";
            TransactionDialogForm frm = new TransactionDialogForm(billnoTextBox.Text, party_nameComboBox.Text, voucher_type, trans_amount, dateTextBox.Text, chqpartyTextBox.Text, chqbankTextBox.Text, chqnoTextBox.Text, chqdateTextBox.Text, upiphonenoTextBox.Text, upiidTextBox.Text, upitrnoTextBox.Text, upidateTextBox.Text, paymentmode);
            frm.ShowDialog();
            LoadTransaction();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();
            OpenFileDialog1.Filter = "Picture Files (*)|*.bmp;*.gif;*.jpg";
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int result;
                byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    imageData = ms.ToArray();
                }

                using (SqlConnection connection = new SqlConnection(config.MyConnectionString()))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("update voucher set voucher_img=@Image where id=@id", connection);
                    cmd.Parameters.AddWithValue("@Image", imageData);
                    cmd.Parameters.AddWithValue("@id", voucher_id);
                    result = cmd.ExecuteNonQuery();
                    connection.Close();
                }
                if (result > 0)
                {
                    MessageBox.Show("Data has been Updated in the database.");
                }
                else
                {
                    MessageBox.Show("Unable to Update");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            scanItem scanItem = new scanItem(ref pictureBox1);
        }
        private void BillEditMode(bool ans)
        {
            label6.Visible = label7.Visible = label8.Visible = label9.Visible = label10.Visible = label11.Visible = label12.Visible = ans;
            idcb.Visible = item_namecb.Visible =mrptb.Visible= ratetb.Visible = qtytb.Visible =  gsttb.Visible = disctb.Visible = ans;
            label13.Location = new System.Drawing.Point(3, 0);
            label13.Size = new System.Drawing.Size(660, 52);
            label13.Text = "BILL DETAILS";
            addButton.Visible = ans;
            label13.Visible = !ans;
            if (ans == true)
            {
                LoadIdCombo();
                config.fiil_CBO("select item_name from items", item_namecb);
                string[] unititems = { "PC", "DOZ", "KG", "G" };
                unitcb.Items.AddRange(unititems);
            }
        }

        string dboname;// = "voucher_" + voucher_id;
        private void LoadBill()
        {
            editButton.Text = "EDIT ITEMS";
            BillEditMode(false);
            dboname = "voucher_" + voucher_id;
            string sql = @"if not exists (SELECT * FROM sys.objects  WHERE name = '" + dboname + "')" +
                        "CREATE TABLE [dbo].[" + dboname + "] " +
                        "([id] INT IDENTITY (1, 1) NOT NULL," +
                        "[item_name] NVARCHAR (50) not NULL," +
                        "[mrp] REAL   NULL," +
                        "[rate] REAL  not NULL," +
                        "[qty] REAL   not NULL," +
                        "[unit] nvarchar(20)    null," +
                        "[gst] REAL        null," +
                        "[disc] REAL        null," +
                        " PRIMARY KEY CLUSTERED ([id] ASC)); ";
            config.Execute_Query(sql);
            LoadRecord(dboname);
        }

        private void LoadRecord(string dboname)
        {

            string sql = @"select * from " + dboname;
            config.singleResult(sql);

            float total = 0;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < config.datatable.Rows.Count; i++)
            {
                int id = config.datatable.Rows[i].Field<int>("id");
                string item_name = config.datatable.Rows[i].Field<string>("item_name");
                float mrp = config.datatable.Rows[i].Field<float>("mrp");
                float rate =config.datatable.Rows[i].Field<float>("rate");
                float gst = config.datatable.Rows[i].Field<float>("gst");
                float qty = config.datatable.Rows[i].Field<float>("qty");
                string unit = config.datatable.Rows[i].Field<string>("unit");
                float disc = config.datatable.Rows[i].Field<float>("disc");
                float value = (rate * qty- (rate * qty * disc / 100))+ ((rate * qty - (rate * qty * disc / 100)) * gst / 100);
                total += value;
                dataGridView1.Rows.Add(id, item_name,mrp.ToString("0.00"), rate.ToString("0.00"), qty+" "+unit,  gst,disc, value);

            }
            dataGridView1.Rows.Add("", "TOTAL", "", "", "", "","","", total);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (editButton.Text == "EDIT ITEMS")
            {
                editButton.Text = "CONFIRM";
                BillEditMode(true);
            }
            else
            {
                editButton.Text = "EDIT ITEMS";
                BillEditMode(false);
            }
        }

        

        private void LoadIdCombo()
        {
            config.singleResult("select id from voucher_" + voucher_id);
            idcb.Items.Clear();
            for (int i = 0; i <= config.datatable.Rows.Count; i++)
            {
                if (i == config.datatable.Rows.Count)
                {
                    idcb.Items.Add((config.datatable.Rows.Count + 1).ToString());
                }
                else
                {
                    idcb.Items.Add(config.datatable.Rows[i].Field<int>("id").ToString());
                }
            }
            idcb.SelectedItem = "1";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            /*
            int id;
            
            if (!(int.TryParse(ratetb.Text, out id)))
            {     
                idcb.Focus(); MessageBox.Show((int.TryParse(ratetb.Text, out id)) + "");              
                return;
            }
            */
            string item_name = "";
            if (string.IsNullOrEmpty(item_namecb.Text))
            {
                item_namecb.Focus();

                return;
            }
            if (string.IsNullOrEmpty(mrptb.Text))
            {
                mrptb.Focus();
                return;
            }
            float mrp;
            if (!(float.TryParse(mrptb.Text, out mrp)))
            {
                mrptb.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ratetb.Text))
            {
                ratetb.Focus();
                return;
            }
            float rate;
            if (!(float.TryParse(ratetb.Text, out rate)))
            {
                ratetb.Focus();
                return;
            }
            if (string.IsNullOrEmpty(qtytb.Text))
            {
                qtytb.Focus();
                return;
            }
            float qty;
            if (!(float.TryParse(qtytb.Text, out qty)))
            {
                qtytb.Focus();
                return;
            }
            string unit = unitcb.Text;
            
            if (string.IsNullOrEmpty(gsttb.Text))
            {
                gsttb.Focus();
                return;
            }
            float gst;
            if (!(float.TryParse(gsttb.Text, out gst)))
            {
                gsttb.Focus();
                return;
            }
            if (string.IsNullOrEmpty(disctb.Text))
            {
                disctb.Focus();
                return;
            }
            float disc;
            if (!(float.TryParse(disctb.Text, out disc)))
            {
                disctb.Focus();
                return;
            }
            int id = int.Parse(idcb.Text);
            mrp= float.Parse(mrptb.Text);
            rate = float.Parse(ratetb.Text);
            qty = float.Parse(qtytb.Text);
            gst = float.Parse(gsttb.Text);
            disc = float.Parse(disctb.Text);
            item_name = item_namecb.Text;
            unit = "U";
            float value = rate * qty + (rate * qty / 100);
            string sql = @"if exists (select * from " + dboname + " where id=" + id + ") " +
                        "begin " +
                        "update " + dboname + " set " +
                        "item_name='" + item_name + "'," +
                        "mrp=" + mrp + "," +
                        "rate=" + rate + "," +
                        "qty=" + qty + "," +
                        "unit='" + unit + "'," +
                        "gst=" + gst +","+
                        "disc=" + disc + " " +
                        "where id=" + id + "; " +
                        "end " +
                        "else " +
                        "begin " +
                        "SET IDENTITY_INSERT " + dboname + " ON; "+
                        "insert into " + dboname + " (id,item_name,mrp,rate,qty,unit,gst,disc) values ("+id+",'" + item_name + "'," + mrp + "," + rate + "," + qty + ",'" + unit + "'," + gst+"," +disc+ ") ;" +
                        "SET IDENTITY_INSERT " + dboname + " OFF;"+
                        "end;";
            config.singleResult("select id from items where item_name='" + item_name + "'");
            if (config.datatable.Rows.Count == 0)
            {
                sql = sql + "insert into items (item_name,mrp,rate,gst,unit) values ('" + item_name + "',"+mrp+"," + rate + "," + gst + ",'" + unit + "');";
            }
            config.CExecute_CUD(sql, "Record unable save", "Record updated successfully");
            LoadIdCombo();
            LoadRecord(dboname);


        }

        private void idcb_Validating(object sender, CancelEventArgs e)
        {
            string sql = @"select * from " + dboname + " where id=" + idcb.Text;
            config.singleResult(sql);
            if (config.datatable.Rows.Count > 0)
            {
                
                item_namecb.Text = config.datatable.Rows[0].Field<string>("item_name");
                mrptb.Text= config.datatable.Rows[0].Field<float>("mrp").ToString("0.00");
                ratetb.Text = config.datatable.Rows[0].Field<float>("rate").ToString("0.00");
                gsttb.Text = config.datatable.Rows[0].Field<float>("gst").ToString();              
                qtytb.Text = config.datatable.Rows[0].Field<Single>("qty").ToString();
                disctb.Text = config.datatable.Rows[0].Field<Single>("disc").ToString();
            }
            else
            {
                item_namecb.Text = "";
                mrptb.Text = "";
                ratetb.Text = "";
                gsttb.Text = "";
                qtytb.Text = "";
                disctb.Text = "";
            }
        }

        private void item_namecb_Validating(object sender, CancelEventArgs e)
        {
            string sql = @"select * from items where item_name='" + item_namecb.Text + "'";
            config.singleResult(sql);
            if (config.datatable.Rows.Count > 0)
            {
                mrptb.Text= config.datatable.Rows[0].Field<string>("rate");
                ratetb.Text = config.datatable.Rows[0].Field<string>("rate");
                gsttb.Text = config.datatable.Rows[0].Field<string>("gst");
                
            }
        }
    }
}
    
    
    

