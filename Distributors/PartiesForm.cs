using BARMAN_STORE1._0.Include;
using BARMAN_STORE1._0.Vouchers;
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
    public partial class PartiesForm : Form
    {
        SQLConfig config = new SQLConfig();
        public PartiesForm()
        {
            InitializeComponent();
        }

        private void PartiesForm_Load(object sender, EventArgs e)
        {
            Refresh(sender, e);
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
            PartyEditForm form = new PartyEditForm((int)dataGridView1.CurrentRow.Cells[0].Value);
            form.EditMode(false);
            form.Show();
        }

        internal void Refresh(object sender, EventArgs e)
        {
            string sql = @"select Id as 'ID',
                        party_name as 'PARTY NAME',
                        distributor as 'DISTRIBUTOR NAME', 
                        salesman_name as 'SALESMAN NAME', 
                        salesman_cont as 'SALESMAN CONTACT NO', 
                        salesman_email as 'SALESMAN EMAIL', 
                        visiting_day as 'VISITING DAY', 
                        delivery_day as 'DELIVERY DAY', 
                        credit_duration as 'CREDIT DURATION'
                        FROM [party]";
            config.Load_DTG(sql, dataGridView1);
            dataGridView1.Columns[0].Visible = false;
            time = 0;
            timer1.Start();
        }
        double time;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if((time++)==100)
            {
                Refresh(sender, e);
            }
        }
    }
}
