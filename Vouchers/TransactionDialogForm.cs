using BARMAN_STORE1._0.Include;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARMAN_STORE1._0.Vouchers
{
    public partial class TransactionDialogForm : Form
    {
        string billno;
        string partyname;
        string transtype;
        double transamount;
        string chqparty;
        string chqbank;
        string chqno;
        DateTime? chqdate;
        string upiphone;
        string upiid;
        string upitrno;
        DateTime? upidate;
        string paymentmode;
        DateTime? transdate;

        public TransactionDialogForm(string bill_no, string party_name, string trans_type, string trans_amount,string trans_date, string chq_party, string chq_bank, string chq_no, string chq_date, string upi_phone, string upi_id, string upi_trno, string upi_date,string payment_mode)
        {
            InitializeComponent();
            billno = bill_no;
            partyname = party_name;
            transtype = trans_type;
            transamount =double.Parse(trans_amount);
            chqparty = chq_party;
            chqbank = chq_bank;
            chqno = chq_no;
            DateTime val1,val2,val3;
            if (DateTime.TryParse(chq_date, out val1))
            {
                chqdate = val1;
            }
            else
            {
                chqdate = null;
            }
            upiphone = upi_phone;
            upiid = upi_id;
            upitrno = upi_trno;
            if (DateTime.TryParse(upi_date, out val2))
            {
                upidate = val2;
            }
            else
            {
                upidate = null;
            }
            
            paymentmode = payment_mode;
            if (DateTime.TryParse(trans_date, out val3))
            {
                transdate = val3;
            }
            else
            {
                transdate = null;
            }
            
        }

        

        private void TransactionDialogForm_Load(object sender, EventArgs e)
        {
            string tr_info;
            if (paymentmode == "cash")
            {
                tr_info = Environment.NewLine + Environment.NewLine
                            + " TRANSACTION ID =        " + "" + Environment.NewLine
                            + "--------------------------------------------------------------------------------------" + Environment.NewLine
                            + " BILL NO =               " + billno + Environment.NewLine
                            + " PARTY NAME =            " + partyname + Environment.NewLine
                            + " TRANSACTION AMOUNT(RS) =" + transamount + Environment.NewLine
                            + " TRANSACTION TYPE =      " + transtype + Environment.NewLine
                            + " TRANSACTION DATE =      " + transdate + Environment.NewLine
                            + "--------------------------------------------------------------------------------------" + Environment.NewLine
                            + " PAYMENT MODE =          " + paymentmode + Environment.NewLine
                            + "--------------------------------------------------------------------------------------" + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + "--------------------------------------------------------------------------------------"
                            ;
            }
            else if (paymentmode == "cheque")
            {
                tr_info = Environment.NewLine + Environment.NewLine
                            + " TRANSACTION ID =        " + "" + Environment.NewLine
                            + "--------------------------------------------------------------------------------------" + Environment.NewLine
                            + " BILL NO =               " + billno + Environment.NewLine
                            + " PARTY NAME =            " + partyname + Environment.NewLine
                            + " TRANSACTION AMOUNT(RS) =" + transamount + Environment.NewLine
                            + " TRANSACTION TYPE =      " + transtype + Environment.NewLine
                            + " TRANSACTION DATE =      " + transdate + Environment.NewLine
                            + "--------------------------------------------------------------------------------------" + Environment.NewLine
                            + " PAYMENT MODE =          " + paymentmode + Environment.NewLine
                            + "--------------------------------------------------------------------------------------" + Environment.NewLine
                            + " CHEQUE NO =             " + chqno + Environment.NewLine
                            + " CHEQUE PARTY NAME =     " + chqparty + Environment.NewLine
                            + " CHEQUE DATE =           " + chqdate + Environment.NewLine
                            + " CHEQUE BANK NAME =      " + chqbank + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + "--------------------------------------------------------------------------------------"
                            ;
            }
            else if (paymentmode == "upi")
            {
                tr_info = Environment.NewLine + Environment.NewLine
                            + " TRANSACTION ID =        " + "" + Environment.NewLine
                            + "--------------------------------------------------------------------------------------" + Environment.NewLine
                            + " BILL NO =               " + billno + Environment.NewLine
                            + " PARTY NAME =            " + partyname + Environment.NewLine
                            + " TRANSACTION AMOUNT(RS) =" + transamount + Environment.NewLine
                            + " TRANSACTION TYPE =      " + transtype + Environment.NewLine
                            + " TRANSACTION DATE =      " + transdate + Environment.NewLine
                            + "--------------------------------------------------------------------------------------" + Environment.NewLine
                            + " PAYMENT MODE =          " + paymentmode + Environment.NewLine
                            + "--------------------------------------------------------------------------------------" + Environment.NewLine
                            + " UPI PHONE NO =          " + upiphone + Environment.NewLine
                            + " UPI TRANSACTION NO =    " + upitrno + Environment.NewLine
                            + " UPI ID =                " + upiid + Environment.NewLine
                            + " UPI DATE =              " + upidate + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + " " + Environment.NewLine
                            + "--------------------------------------------------------------------------------------"
                            ;
            }
            else
            {
                tr_info = "";
            }
            label1.Text = tr_info;
           // MessageBox.Show(tr_info);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = @"insert into [transaction] (voucher_no ,"     +
                                                    "party_name ,"      +
                                                    "trans_type ,"      +
                                                    "trans_amount ,"    +
                                                    "trans_date ,"      +
                                                    "chq_party ,"       +
                                                    "chq_bank ,"        +
                                                    "chq_no ,"          +
                                                    "chq_date ,"        +
                                                    "upi_phone ,"       +
                                                    "upi_id ,"          +
                                                    "upi_trno ,"        +
                                                    "upi_date ,"        +
                                                    "trans_mode "     +
                                                    ")"                 +
                                                    " values"           +
                                                    "('"+ billno        + "'," +
                                                    "'" + partyname     + "'," +
                                                    "'" + transtype     + "'," +
                                                    ""  + transamount   + ","  +
                                                    "" + "CONVERT(date, '"+transdate+"', 103)" + "," +
                                                    "'" + chqparty      + "'," +
                                                    "'" + chqbank       + "'," +
                                                    "'" + chqno         + "'," +
                                                    "" + "CONVERT(date, '" + chqdate + "', 103)" + "," +
                                                    "'" + upiphone      + "'," +
                                                    "'" + upiid         + "'," +
                                                    "'" + upitrno       + "'," +
                                                    "" + "CONVERT(date, '" + upidate + "', 103)" + "," +
                                                    "'" + paymentmode   + "'"  +
                                                    ")"; 
            SQLConfig config = new SQLConfig();
            config.CExecute_CUD(sql, "Unable to Update", "Transaction has been recorded in the database.");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
