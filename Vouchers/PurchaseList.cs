using BARMAN_STORE1._0.Include;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BARMAN_STORE1._0.Vouchers
{
    public partial class PurchaseList : Form
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        public PurchaseList()
        {
            InitializeComponent();
        }

        private void PurchaseList_Load(object sender, EventArgs e)
        {

            //textBox1.DataBindings.Add("Text", config.bindingSource, "AMOUNT PENDING");
            timer1.Start();
            button1_Click(sender, e);
            //config.dataView.RowFilter = "[PARTY NAME] like '%" + "BISK" + "%'";
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //VoucherForm voucherForm = new VoucherForm((int)dataGridView1.CurrentRow.Cells[0].Value);
            VoucherForm voucherForm = new VoucherForm(-500);

            voucherForm.EditMode(true);
            
            voucherForm.Show();
        }

       

        
        int time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
          if ((time++)==1000)
            {
                button1_Click(sender, e);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = @"Select id as 'ID',voucher_no as 'BILL NO',
            party_name as 'PARTY NAME',FORMAT(voucher_amount, '0.00') as 'BILL AMOUNT'
            ,VOUCHER_DATE AS 'BILL DATE',VOUCHER_DUEDATE AS 'DUE DATE'
            ,FORMAT(voucher_amount-COALESCE((SELECT sum(trans_amount) from 
            [transaction] where voucher_no=[voucher].voucher_no),0), '0.00') 
            as 'AMOUNT PENDING',voucher_type as 'TYPE' From VOUCHER ";
            //config.Load_DTG("Select id as 'ID',voucher_no as 'BILL NO',party_name as 'PARTY NAME',voucher_amount as 'BILL AMOUNT',VOUCHER_DATE AS 'BILL DATE',VOUCHER_DUEDATE AS 'DUE DATE',voucher_amount-COALESCE((SELECT sum(trans_amount) from [transaction] where voucher_no=[voucher].voucher_no),0) as 'AMOUNT PENDING' From VOUCHER where voucher_type='payment'", dataGridView1);

            config.Load_DTG(sql, dataGridView1);
            dataGridView1.Columns[0].Visible = false;
            time = 0;
            
        }

        private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 0) //sort by the first column
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
            }
            else
            {
                e.SortResult = e.CellValue1.ToString().CompareTo(e.CellValue2.ToString());
            }

            e.Handled = true;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[e.ColumnIndex], ListSortDirection.Ascending);
        }

    }
}
