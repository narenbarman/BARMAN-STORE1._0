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
        private double? voucher_amount;
        private double? amount_pending;
        SQLConfig config = new SQLConfig();
        
        public VoucherForm(int voucherid)
        {
            InitializeComponent();
            voucher_id = voucherid;
            config.fiil_CBO("select party_name from party", party_nameTextBox);
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
            party_nameTextBox.Enabled = ans;
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

            if (string.IsNullOrEmpty(voucher_dateTextBox.Text))
            {
                voucher_dateTextBox.Focus(); return;
            }
            if (string.IsNullOrEmpty(voucher_noTextBox.Text))
            {
                voucher_noTextBox.Focus(); return;
            }
            if (string.IsNullOrEmpty(party_nameTextBox.Text))
            {
                party_nameTextBox.Focus(); return;
            }
            if (string.IsNullOrEmpty(voucher_dateTextBox.Text))
            {
                voucher_dateTextBox.Focus(); return;
            }
            if (DateTime.Parse(voucher_duedateTextBox.Text) >= DateTime.Parse(voucher_duedateTextBox.Text))
            {
                voucher_duedateTextBox.Focus();
                return;
            }
            double outval;
            if (string.IsNullOrEmpty(voucher_amountTextBox.Text)||!double.TryParse(voucher_amountTextBox.Text,out outval))
            {
                voucher_amountTextBox.Focus(); return;
            }
            if (string.IsNullOrEmpty(voucher_typeTextBox.Text))
            {
                voucher_typeTextBox.Focus(); return;
            }
            if (voucher_noTextBox.Text != voucher_no)
            {
                config.singleResult("select voucher_no from voucher where voucher_no='" + voucher_noTextBox.Text + "'");
                if (config.datatable.Rows.Count > 0)
                {
                    voucher_noTextBox.Focus();
                    MessageBox.Show("BILL NO ALREADY EXIST");
                    return;
                }
            }
            try
            {
                DateTime x = DateTime.Today;
                string voucher_no_old = voucher_no;
                voucher_no = voucher_noTextBox.Text;
                party_name = party_nameTextBox.Text;
                voucher_amount = double.Parse(voucher_amountTextBox.Text);
                if (DateTime.TryParse(voucher_dateTextBox.Text, out x))
                {
                    voucher_date = DateTime.Parse(voucher_dateTextBox.Text);

                }
                else
                {
                    voucher_date = null;
                }
               
                if (DateTime.TryParse(voucher_duedateTextBox.Text, out x)) 
                {
                    voucher_duedate = DateTime.Parse(voucher_duedateTextBox.Text); 
                } else 
                    voucher_duedate = null;

                
                voucher_type = voucher_typeTextBox.Text;
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
                    sql = @"update [voucher] set voucher_no='"+ voucher_no 
                          + "',party_name='" + party_name + "',voucher_amount=" +  voucher_amount.ToString() 
                          + ",voucher_date= CONVERT(date, '"+voucher_date+"', 103) " 
                          + ",voucher_duedate= CONVERT(date, '" + voucher_duedate + "', 103) "
                          + ",voucher_type='" + voucher_type + "' where id=" + voucher_id + "; " +
                          "update [transaction] set voucher_no='" + voucher_no + "' where voucher_no='" + voucher_no_old + "';";
                    
                    config.CExecute_CUD(sql, "Unable to Update", "Data has been Updated in the database.");
                }
                EditMode(false);
                sql = @"select id from voucher where voucher_no='" + voucher_no+"'";
                config.singleResult(sql);
                voucher_id=config.datatable.Rows[0].Field<int>(0);
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
                        voucher_amount-COALESCE((SELECT sum(trans_amount) 
                        from [transaction] where voucher_no=[voucher].voucher_no),0) 
                        as 'AMOUNT PENDING',voucher_type as 'Type' From VOUCHER 
                        WHERE id=" + voucher_id;
            config.singleResult(sql);


            if (config.datatable.Rows.Count > 0)
            {
                voucher_no = config.datatable.Rows[0].Field<string>(1);
                party_name = config.datatable.Rows[0].Field<string>(2);
                voucher_amount = config.datatable.Rows[0].Field<double>(3);
                voucher_date = config.datatable.Rows[0][4] as DateTime?;
                voucher_duedate = config.datatable.Rows[0][5] as DateTime?;
                amount_pending = config.datatable.Rows[0].Field<double>(6);
                voucher_type = config.datatable.Rows[0].Field<string>(7);
            }

            idTextBox.Text = voucher_id.ToString();
            voucher_noTextBox.Text = voucher_no;
            party_nameTextBox.Text = party_name;
            voucher_amountTextBox.Text = voucher_amount.ToString();
            voucher_dateTextBox.Text = voucher_date.ToString();
            voucher_duedateTextBox.Text = voucher_duedate.ToString();
            voucher_typeTextBox.Text = voucher_type;
            amount_pendingTextBox.Text = amount_pending.ToString();
            double number;
            if (double.TryParse(voucher_amountTextBox.Text, out number))
            {
                voucher_amountTextBox.ForeColor = Color.Black;
                voucher_amountTextBox.Text = number.ToString("0.00");
            }
            else
            {
                voucher_amountTextBox.ForeColor = Color.Red;
            }

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
            pictureBox1.DataBindings.Add("Image", config.datatable, "voucher_img", true,DataSourceUpdateMode.Never);
        }
        private void LoadTransaction()
        {
            string sql = @"select RIGHT('0000000' + CAST(id AS VARCHAR), 7) as 'TRANSACTION ID',voucher_no AS 'BILL NO',
                        FORMAT(trans_amount, '0.00') AS 'AMOUNT(RS)',trans_date as 'TRANSACTION DATE' 
                        from [transaction]
                        WHERE voucher_no='" + voucher_no+"'";
            config.Load_DTG(sql,dataGridView2);
            amountTextBox.Text = amount_pending.ToString();
            if (!string.IsNullOrEmpty(amountTextBox.Text)) amountTextBox.Text =double.Parse(amountTextBox.Text).ToString("0.00");
            billnoTextBox.Text = voucher_no;
            partynameTextBox.Text= party_name;
            cashCheckBox.Checked=true;
        }
            

        private void amount_pendingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amount_pendingTextBox.ForeColor = Color.Black;
                amount_pendingTextBox.Text = String.Format("{0:0.00}", double.Parse(amount_pendingTextBox.Text));
            }
            catch (Exception ex)
            {
                voucher_amountTextBox.ForeColor = Color.Red;
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == detailTab) LoadDetails();
            if (tabControl1.SelectedTab == transactionTab) LoadTransaction();
            if (tabControl1.SelectedTab == imageTab) LoadImage();

        }

        private void voucher_amountTextBox_Validating(object sender, CancelEventArgs e)
        {
            double number;
            if (double.TryParse(voucher_amountTextBox.Text, out number))
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
            double val;
            if(double.TryParse(amountTextBox.Text,out val))
            {
                amountTextBox.Text = val.ToString("0.00");
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(billnoTextBox.Text))
                return;
            double val;
            if (!double.TryParse(amountTextBox.Text, out val))
            {
                amountTextBox.Focus();
                return;
            }
            string paymentmode;
            if (cashCheckBox.Checked) paymentmode = "cash";
            else if (chqCheckBox.Checked) paymentmode = "cheque";
            else if (upiCheckBox.Checked) paymentmode = "upi";
            else paymentmode = "none";
            TransactionDialogForm frm = new TransactionDialogForm(billnoTextBox.Text, party_nameTextBox.Text, voucher_type, amountTextBox.Text,dateTextBox.Text, chqpartyTextBox.Text, chqbankTextBox.Text, chqnoTextBox.Text, chqdateTextBox.Text, upiphonenoTextBox.Text, upiidTextBox.Text, upitrnoTextBox.Text, upidateTextBox.Text,paymentmode);
                                                               
            frm.Show();
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
                    result=cmd.ExecuteNonQuery();
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
            try
            {
                // Create a new WIA device manager
                var deviceManager = new DeviceManager();
                int i;
                for (i=1;i<=deviceManager.DeviceInfos.Count;i++)
                {
                    if (deviceManager.DeviceInfos[i].Type == WiaDeviceType.ScannerDeviceType)
                    {
                        break;
                    }
                    else
                        continue;
                }
                if (i==deviceManager.DeviceInfos.Count+1)
                {
                    MessageBox.Show("Scanner device not found");
                    return;
                }
                // Select the scanner device
                var device = deviceManager.DeviceInfos[i].Connect();

                // Scan the image
                CommonDialogClass dlg = new CommonDialogClass();
                var item = device.Items[1];
                AdjustScannerSettings(item, 70, 0, 0, 590, 800, -50, 70, 1);
                var scanitem=dlg.ShowTransfer(device.Items[1], WIA.FormatID.wiaFormatJPEG, true);
                
                // Display the image in the PictureBox
                var imageFile = (ImageFile)scanitem;
                var imageBytes = (byte[])imageFile.FileData.get_BinaryData();
                //var pictureBox = new PictureBox();
                
                pictureBox1.Image = Image.FromStream(new MemoryStream(imageBytes));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static void AdjustScannerSettings(IItem scannnerItem, int scanResolutionDPI, int scanStartLeftPixel, int scanStartTopPixel, int scanWidthPixels, int scanHeightPixels, int brightnessPercents, int contrastPercents, int colorMode)
        {
            const string WIA_SCAN_COLOR_MODE = "6146";
            const string WIA_HORIZONTAL_SCAN_RESOLUTION_DPI = "6147";
            const string WIA_VERTICAL_SCAN_RESOLUTION_DPI = "6148";
            const string WIA_HORIZONTAL_SCAN_START_PIXEL = "6149";
            const string WIA_VERTICAL_SCAN_START_PIXEL = "6150";
            const string WIA_HORIZONTAL_SCAN_SIZE_PIXELS = "6151";
            const string WIA_VERTICAL_SCAN_SIZE_PIXELS = "6152";
            const string WIA_SCAN_BRIGHTNESS_PERCENTS = "6154";
            const string WIA_SCAN_CONTRAST_PERCENTS = "6155";
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel);
            SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents);
            SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="properties"></param>
        /// <param name="propName"></param>
        /// <param name="propValue"></param>
        private static void SetWIAProperty(IProperties properties, object propName, object propValue)
        {
            Property prop = properties.get_Item(ref propName);
            prop.set_Value(ref propValue);
        }

        /// <summary>
        /// Declare the ToString method
        /// </summary>
        /// <returns></returns>
       /* public override string ToString()
        {
            return (string)this._deviceInfo.Properties["Name"].get_Value();
        }
       */
    }
    
    
}
