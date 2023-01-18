﻿using BARMAN_STORE1._0.Properties;
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
            ts_ManageUsers.Enabled = true;
            ts_Report.Enabled = false;
            ts_Return.Enabled = true;
            ts_StockOut.Enabled = true;
            ts_stocks.Enabled = true;
            ts_Login.Text = "Logout";
            ts_Login.Image = Resources.log_close;
            ts_settings.Enabled = true;

        }
        public void disabled_menu()
        {
            ts_ManageUsers.Enabled = false;
            ts_Report.Enabled = false;
            ts_Return.Enabled = false;
            ts_StockOut.Enabled = false;
            ts_stocks.Enabled = false;
            ts_Login.Image = Resources.log_open;
            ts_settings.Enabled = false;
        }
        public void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void ts_stocks_Click(object sender, EventArgs e)
        {
            closeForm();
            //showFrm(new frmItems());
        }

        private void ts_StockOut_Click(object sender, EventArgs e)
        {
            closeForm();
            //showFrm(new frmStockOut(""));
        }

        private void ts_Return_Click(object sender, EventArgs e)
        {
            closeForm();
            //showFrm(new frmReturn());
        }

        private void ts_ManageUsers_Click(object sender, EventArgs e)
        {
            closeForm();
            //showFrm(new frmUsers());
        }

        private void ts_Report_Click(object sender, EventArgs e)
        {
            closeForm();
            //showFrm(new frmReport());

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

        private void ts_settings_Click(object sender, EventArgs e)
        {
            closeForm();
            //showFrm(new frmSettings());
        }

        private void voucherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForm();
            //showFrm(new VoucherForm());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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
            form.Show();
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
            form.Show();
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
            form.Show();
        }
    }
}
