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
    
    public partial class PartyEditForm : Form
    {
        int partyid;
        string party_name;
        string distributor;
        string salesman_name;
        string salesman_cont;
        string salesman_email;
        string visiting_day;
        string delivery_day;
        string credit_duration;
        SQLConfig config = new SQLConfig();
        public PartyEditForm(int party_id)
        {
            InitializeComponent();
            partyid = party_id;
        }

        internal void EditMode(bool ans)
        {
            party_nameTextBox.ReadOnly = !ans;
            distributorComboBox.Enabled = ans;
            salesman_nameTextBox.ReadOnly = !ans;
            salesman_contTextBox.ReadOnly = !ans;
            salesman_emailTextBox.ReadOnly = !ans;
            visiting_dayComboBox.Enabled = ans;
            delivery_dayComboBox.Enabled = ans;
            credit_durationComboBox.Enabled = ans;
            saveButton.Visible= ans;
            modifyButton.Visible = !ans;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EditMode(true);
        }

        private void PartyEditForm_Load(object sender, EventArgs e)
        {
            
            string sql = @"select id,
                          party_name,
                          distributor,
                          salesman_name,
                          salesman_cont,
                          salesman_email,
                          visiting_day,
                          delivery_day,
                          credit_duration
                          from party where id=" + partyid;
            config.singleResult(sql);
            if (config.datatable.Rows.Count > 0) 
            {
                party_name = config.datatable.Rows[0].Field<string>("party_name");
                distributor = config.datatable.Rows[0].Field<string>("distributor");
                salesman_name = config.datatable.Rows[0].Field<string>("salesman_name");
                salesman_cont = config.datatable.Rows[0].Field<string>("salesman_cont");
                salesman_email = config.datatable.Rows[0].Field<string>("salesman_email");
                visiting_day = config.datatable.Rows[0].Field<string>("visiting_day");
                delivery_day = config.datatable.Rows[0].Field<string>("delivery_day");
                credit_duration = config.datatable.Rows[0].Field<string>("credit_duration");
            }
            party_nameTextBox.Text = party_name;
            distributorComboBox.Text = distributor;
            salesman_nameTextBox.Text = salesman_name;
            salesman_contTextBox.Text = salesman_cont;
            salesman_emailTextBox.Text = salesman_email;
            visiting_dayComboBox.Text = visiting_day;
            delivery_dayComboBox.Text = delivery_day;
            credit_durationComboBox.Text = credit_duration;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(party_nameTextBox.Text))
            {
                party_nameTextBox.Focus();
                return;
            }
            if(party_name!=party_nameTextBox.Text)
            {
                config.singleResult("select * from party where party_name='"+party_nameTextBox.Text+"'");
                if (config.datatable.Rows.Count>0)
                {
                    MessageBox.Show("PARTY NAME ALREADY EXIST");
                    party_nameTextBox.Focus();
                    return;
                }
            }
            
            party_name=party_nameTextBox.Text ;
            distributor=distributorComboBox.Text ;
            salesman_name=salesman_nameTextBox.Text ;
            salesman_cont=salesman_contTextBox.Text ;
            salesman_email=salesman_emailTextBox.Text ;
            visiting_day=visiting_dayComboBox.Text ;
            delivery_day=delivery_dayComboBox.Text ;
            credit_duration=credit_durationComboBox.Text ;
            if (partyid == -500)
            {
                string sql = @"insert into party (party_name,distributor,salesman_name,salesman_cont,salesman_email,visiting_day,delivery_day,credit_duration)
                          values ('" + party_name + "','" + distributor + "','" + salesman_name + "','" + salesman_cont + "','" + salesman_email + "','" + visiting_day + "','" + delivery_day + "','" + credit_duration + "')" ;
                config.CExecute_CUD(sql, "Unable to Update", "Data has been Updated in the database.");
            }
            else
            {
                string sql = @"update party set party_name='" + party_name + "',distributor='"+distributor+"',salesman_name='"+salesman_name + "',salesman_cont='" + salesman_cont + "',salesman_email='" + salesman_email + "',visiting_day='" + visiting_day + "',delivery_day='" + delivery_day + "',credit_duration='" + credit_duration+"' where id=" + partyid;
                config.CExecute_CUD(sql, "Unable to Update", "Data has been Updated in the database.");

            }
            config.singleResult("select id from party where party_name='" + party_nameTextBox.Text + "'");
            partyid = config.datatable.Rows[0].Field<int>("id");
            PartyEditForm_Load(sender, e);
            EditMode(false);
        }
    }
}
