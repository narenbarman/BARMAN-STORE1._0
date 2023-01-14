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

namespace BARMAN_STORE1._0.Users
{
    public partial class frmLogin : Form
    {
        Form1 frm;
        public frmLogin(Form1 frm)
        {
            InitializeComponent();

            this.frm = frm;
        }
        SQLConfig config = new SQLConfig();
        string sql;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Timer1.Start();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sql = " SELECT* FROM [user] WHERE user_name = '" + txtusername.Text + "' and password = HASHBYTES('sha1','" + txtpass.Text + "')";
            config.singleResult(sql);
            if (config.datatable.Rows.Count > 0)
            {
                frm.enabled_menu();
                this.Close();
            }
            else
            {
                MessageBox.Show("Account does not exist! Please contact administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            txtusername.Clear();
            txtusername.Focus();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void lbldate_Click(object sender, EventArgs e)
        {

        }
    }
}
