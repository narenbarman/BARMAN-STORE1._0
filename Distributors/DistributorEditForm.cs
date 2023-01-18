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
    public partial class DistributorEditForm : Form
    {
        int Id;
        string dist_name;
        string gstn ;
        string fssai;
        string address;
        string contact;
        string email;
        string bank_name;
        string bank_no;
        string bank_ifsc;
        SQLConfig config=new SQLConfig();
        public DistributorEditForm(int dist_id)
        {
            InitializeComponent();
            Id= dist_id;
        }
        private void LoadRecord()
        {
             dist_name="";
             gstn = "";
             fssai = "";
             address = "";
             contact = "";
             email = "";
             bank_name = "";
             bank_no = "";
             bank_ifsc = "";
            string sql = @"select * from distributor where Id=" + Id;
            config.singleResult(sql);
            if (config.datatable.Rows.Count > 0 )
            {
                dist_name = config.datatable.Rows[0].Field<string>("dist_name");
                gstn = config.datatable.Rows[0].Field<string>("gstn");
                fssai = config.datatable.Rows[0].Field<string>("fssai");
                address = config.datatable.Rows[0].Field<string>("address");
                contact = config.datatable.Rows[0].Field<string>("contact");
                email = config.datatable.Rows[0].Field<string>("email");
                bank_name = config.datatable.Rows[0].Field<string>("bank_name");
                bank_no = config.datatable.Rows[0].Field<string>("bank_no");
                bank_ifsc = config.datatable.Rows[0].Field<string>("bank_ifsc");
            }
            dist_nameTextBox.Text = dist_name;
            gstnTextBox.Text = gstn;
            fssaiTextBox.Text = fssai;
            addressTextBox.Text = address;
            contactTextBox.Text = contact;
            emailTextBox.Text = email;
            bank_nameTextBox.Text = bank_name;
            bank_noTextBox.Text = bank_no;
            bank_ifscTextBox.Text = bank_ifsc;

        }

        private void DistributorEditForm_Load(object sender, EventArgs e)
        {
            LoadRecord();
        }

        internal void EditMode(bool ans)
        {
            dist_nameTextBox.ReadOnly = !ans;
            gstnTextBox.ReadOnly = !ans;
            fssaiTextBox.ReadOnly = !ans;
            addressTextBox.ReadOnly = !ans;
            contactTextBox.ReadOnly = !ans;
            emailTextBox.ReadOnly = !ans;
            bank_nameTextBox.ReadOnly = !ans;
            bank_noTextBox.ReadOnly = !ans;
            bank_ifscTextBox.ReadOnly = !ans;
            saveButton.Visible= ans;
            modifyButton.Visible = !ans;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dist_nameTextBox.Text))
            {
                dist_nameTextBox.Focus();
                return;
            }    
            if (dist_name!=dist_nameTextBox.Text)
            {
                config.singleResult("select * from distributor where dist_name='" + dist_nameTextBox.Text + "'");
                if (config.datatable.Rows.Count>0)
                {
                    MessageBox.Show("DISTRIBUTOR NAME ALREADY EXIST");
                    dist_nameTextBox.Focus();
                    return;
                }
            }
            dist_name=dist_nameTextBox.Text;
            gstn=gstnTextBox.Text;
            fssai=fssaiTextBox.Text ;
            address=addressTextBox.Text;
            contact=contactTextBox.Text;
            email=emailTextBox.Text;
            bank_name=bank_nameTextBox.Text ;
            bank_no=bank_noTextBox.Text ;
            bank_ifsc = bank_ifscTextBox.Text;
            SaveRecord();
            LoadRecord();
            EditMode(false);
        }

        private void SaveRecord()
        {
            string sql;
            if (Id==-500)
            {
                sql = @"insert into distributor (dist_name,gstn,fssai,address,contact,email,bank_name,bank_no,bank_ifsc) values
                                                 ('"+dist_name+"','"+gstn + "','" + fssai + "','" + address + "','" + contact + "','" + email + "','" + bank_name + "','" + bank_no + "','" + bank_ifsc + "')";
            
            }
            else
            {
                sql = "update distributor set dist_name='"+dist_name+ "',gstn='"+gstn+ "',fssai='"+fssai+ "',address='"+address+"',contact='"+contact+"',email='"+email+"',bank_name='"+bank_name+"',bank_no='"+bank_no +"',bank_ifsc='"+bank_ifsc+"' where Id="+Id;
            }
            config.CExecute_CUD(sql, "Unable to Update", "Data has been Updated in the database.");
            config.singleResult("select Id from distributor where dist_name='" + dist_nameTextBox.Text + "'");
            if (config.datatable.Rows.Count>0)
            {
                Id = config.datatable.Rows[0].Field<int>("Id");
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            EditMode(true);
        }
    }

}
