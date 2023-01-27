using BARMAN_STORE1._0.Properties;
using BARMAN_STORE1._0.Users;
using BARMAN_STORE1._0.Vouchers;

using BARMAN_STORE1._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BARMAN_STORE1._0.Distributors;
using BARMAN_STORE1._0.Include;
using BARMAN_STORE1._0.Items;

namespace BARMAN_STORE1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void closeForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

        }
        public void enabled_menu()
        {
            menuStrip1.Visible = true;
            ts_Login.Text = "Logout";
            ts_Login.Image = Resources.log_close;
            

        }
        public void disabled_menu()
        {
            menuStrip1.Visible = false;
            ts_Login.Image = Resources.log_open;
            
        }
        public void showFrm(Form frm)
        {
            closeForm();
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        

        private void ts_Login_Click(object sender, EventArgs e)
        {
            if (ts_Login.Text == "Login")
            {
                closeForm();
                showFrm(new frmLogin(this));
            }
            else
            {
                closeForm();
                disabled_menu();
                ts_Login.Text = "Login";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disabled_menu();
            
        }

        private void purchaseRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new PurchaseList());
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoucherForm form = new VoucherForm(-500);
            form.EditMode(true);
            form.ShowDialog();
        }

        private void pARTYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PartiesForm form = new PartiesForm();
            showFrm(form);
        }

        private void nEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PartyEditForm form = new PartyEditForm(-500);
            form.EditMode(true);
            form.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Refresh();
        }

        private void dISTRIBUTORSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DistributorsForm form=new DistributorsForm();
            showFrm(form);
        }

        private void nEWToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DistributorEditForm form = new DistributorEditForm(-500);
            form.EditMode(true);
            form.ShowDialog();
        }

        private void iTEMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm form=new ItemForm();
            showFrm(form);  
        }

        private void nEWToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ItemEditForm form=new ItemEditForm(-500);
            form.EditMode(true);
            form.ShowDialog();
        }

        private void vOUCHERLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseList form =new PurchaseList();
            showFrm(form);
        }

        private void aDDNEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoucherForm form = new VoucherForm(-500);
            form.EditMode(true);
            form.ShowDialog();
        }

        private void pRODUCTLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm form=new ItemForm();
            showFrm(form);
        }

        private void aDDNEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ItemEditForm itemEditFormform=new ItemEditForm(-500);
            itemEditFormform.EditMode(true);
            itemEditFormform.ShowDialog();
        }
    }
}
