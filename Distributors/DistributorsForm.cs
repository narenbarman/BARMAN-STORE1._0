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

namespace BARMAN_STORE1._0.Distributors
{
    public partial class DistributorsForm : Form
    {
        SQLConfig config = new SQLConfig();
        double time;
        public DistributorsForm()
        {
            InitializeComponent();
        }

        private void DistributorsForm_Load(object sender, EventArgs e)
        {
            RefreshRecord();
        }
        private void RefreshRecord()
        {
            string sql = @"select Id as 'DISTRIBUTOR ID', 
            dist_name as 'DISTRIBUTOR NAME', 
            gstn as 'GSTN', 
            fssai as 'FSSAI', 
            address as 'ADDRESS', 
            contact as 'PHONE NO', 
            email as 'EMAIL', 
            bank_name as 'BANK NAME', 
            bank_no as 'A/C NO', 
            bank_ifsc as 'IFSC NO'
            from distributor";
            config.Load_DTG(sql,dataGridView1);
            dataGridView1.Columns[0].Visible = false;
            
            timer1.Start();
            time = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if((time++)==100)
            {
                RefreshRecord();
                            }
        }

        

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            DistributorEditForm form = new DistributorEditForm((int)dataGridView1.CurrentRow.Cells[0].Value);
            form.EditMode(false);
            form.Show();
        }
    }
}
