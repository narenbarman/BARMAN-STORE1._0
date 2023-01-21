using BARMAN_STORE1._0.Include;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BARMAN_STORE1._0.Vouchers
{
    public partial class PurchaseList : Form
    {
        SQLConfig config = new SQLConfig();
        string selectallsql;
        public PurchaseList()
        {
            InitializeComponent();
        }

        private void PurchaseList_Load(object sender, EventArgs e)
        {


            button1_Click(sender, e);

            config.fiil_CBOX("select distinct(voucher_no) from voucher", billnoComboBox);
            
            config.fiil_CBOX("select distinct(party_name) from voucher", partynameComboBox);
            
            config.fiil_CBOX("select distinct (FORMAT(voucher_amount, '0.00')) from voucher", billamountComboBox);
            
            config.fiil_CBOX("select distinct(FORMAT(voucher_date, 'dd-MM-yyyy')) from voucher", billdateComboBox);
            
            config.fiil_CBOX("select distinct(FORMAT(voucher_duedate, 'dd-MM-yyyy')) from voucher", duedateComboBox);
            
            config.fiil_CBOX("select distinct(voucher_type) from voucher", typeComboBox);
            
            config.fiil_CBOX(@"select distinct(FORMAT(voucher_amount-COALESCE((SELECT sum(trans_amount) from 
            [transaction] where voucher_no=[voucher].voucher_no),0), '0.00')) 
            From VOUCHER ", pendingComboBox);
            billnoComboBox.SelectedItem = partynameComboBox.SelectedItem = billamountComboBox.SelectedItem = billdateComboBox.SelectedItem = duedateComboBox.SelectedItem = pendingComboBox.SelectedItem = typeComboBox.SelectedItem = "*ALL";
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            VoucherForm voucherForm = new VoucherForm((int)dataGridView1.CurrentRow.Cells[0].Value);
            
            voucherForm.EditMode(false);

            voucherForm.ShowDialog();
        }




        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((time++) == 1000)
            {
                button1_Click(sender, e);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectallsql = @"Select id as 'ID',voucher_no as 'BILL NO',
            party_name as 'PARTY NAME',FORMAT(voucher_amount, '0.00') as 'BILL AMOUNT'
            ,VOUCHER_DATE AS 'BILL DATE',VOUCHER_DUEDATE AS 'DUE DATE'
            ,FORMAT(voucher_amount-COALESCE((SELECT sum(trans_amount) from 
            [transaction] where voucher_no=[voucher].voucher_no),0), '0.00') 
            as 'AMOUNT PENDING',voucher_type as 'TYPE' From VOUCHER ";
            

            config.Load_DTG(selectallsql, dataGridView1);
            dataGridView1.Columns[0].Visible = false;
            time = 0;
        }

        
        private void billnoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            config.dataView.RowFilter = @"" + string.Format("[BILL NO] LIKE '%{0}%'", billnoComboBox.Text) + " and "
                                            + string.Format("[PARTY NAME] LIKE '%{0}%'", partynameComboBox.Text) + " and "
                                            + string.Format("[BILL AMOUNT] LIKE '%{0}%'", billamountComboBox.Text) + " and "
                                            + "[BILL DATE] = " + DateTime.Parse(billdateComboBox.Text) + " and "
                                            + "[DUE DATE] = " + DateTime.Parse(duedateComboBox.Text) + " and "
                                            + string.Format("[AMOUNT PENDING] LIKE '%{0}%'", pendingComboBox.Text) + " and "
                                            + string.Format("[TYPE] LIKE '%{0}%'", typeComboBox.Text);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string billnoFilter,partynameFilter, billamountFilter, billdateFilter, duedateFilter, amountpendingFilter, typeFilter;
            if (string.IsNullOrEmpty(billnoComboBox.Text))
            {
                billnoFilter = string.Format("[BILL NO] IS {0}", "NULL");
            }
            else if (billnoComboBox.Text == "*ALL")
            {
                billnoFilter = "1=1";
            }
            else
            {
                billnoFilter = string.Format("[BILL NO] = '{0}'", billnoComboBox.Text);
            }
            if (string.IsNullOrEmpty(partynameComboBox.Text))
            {
                partynameFilter = "[PARTY NAME] IS NULL";
            }
            else if (partynameComboBox.Text == "*ALL")
            {
                partynameFilter = "1=1";
            }
            else
            {
                partynameFilter = string.Format("[PARTY NAME] = '{0}'", partynameComboBox.Text);
            }
            if (string.IsNullOrEmpty(billamountComboBox.Text))
            {
                billamountFilter = "[BILL AMOUNT] IS NULL";
            }
            else if (billamountComboBox.Text == "*ALL")
            {
                billamountFilter = "1=1";
            }
            else
            {
                billamountFilter = string.Format("[BILL AMOUNT] = '{0}'", billamountComboBox.Text);
            }
            

            if (string.IsNullOrEmpty(billdateComboBox.Text))
            {
                billdateFilter = string.Format("[BILL DATE] IS {0}", "NULL"); 
            }
            else if(billdateComboBox.Text=="*ALL")
            {

                billdateFilter = "1=1";
            }
            else {
                billdateFilter = string.Format("[BILL DATE] = '{0}'", DateTime.Parse(billdateComboBox.Text));
            }
            
            if (string.IsNullOrEmpty(duedateComboBox.Text))
               duedateFilter= string.Format("[DUE DATE] IS {0}", "NULL");
            else if (duedateComboBox.Text=="*ALL")
            {
                duedateFilter = "1=1";
            }
            else
                duedateFilter = string.Format("[DUE DATE] = '{0}'", DateTime.Parse(duedateComboBox.Text));

            if (string.IsNullOrEmpty(billamountComboBox.Text))
            {
                amountpendingFilter = "[AMOUNT PENDING] IS NULL";
            }
            else if (pendingComboBox.Text == "*ALL")
            {
                amountpendingFilter = "1=1";
            }
            else
            {
                amountpendingFilter = string.Format("[AMOUNT PENDING] = '{0}'", pendingComboBox.Text);
            }
            if (string.IsNullOrEmpty(typeComboBox.Text))
            {
                typeFilter = "[TYPE] IS NULL";
            }
            else if (pendingComboBox.Text == "*ALL")
            {
                typeFilter = "1=1";
            }
            else
            {
                typeFilter = string.Format("[TYPE] LIKE '%{0}%'", typeComboBox.Text);
            }


            config.dataView.RowFilter = @"" + billnoFilter + " AND "
                                            + partynameFilter + " AND "
                                            + billamountFilter + " AND "
                                            + billdateFilter + " AND "
                                            + duedateFilter + " AND "
                                            + amountpendingFilter + " AND " 
                                            + typeFilter;
        }
    }
}
