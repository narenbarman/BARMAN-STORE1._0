using BARMAN_STORE1._0.Distributors;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BARMAN_STORE1._0.Items
{
    public partial class ItemForm : Form
    {
        SQLConfig config = new SQLConfig();
        double time;
        public ItemForm()
        {
            InitializeComponent();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            RefreshRecord();
        }
        private void RefreshRecord()
        {
            string sql = @"select  id as 'id',
                                    item_name as 'ITEM NAME',
                                    [desc] as 'DESCRIPTION',                                   
                                    mrp as 'MRP',
                                    catagory as 'CATAGORY',
                                    brand as 'BRAND',
                                    comp as 'COMPANY',
                                    weight as 'WEIGHT',
                                    color as 'COLOR',
                                    flavour as 'FLAVOUR',
                                    rate as 'RATE',
                                    gst as 'GST',
                                    unit as 'UNIT',
                                    dist1 as 'DISTRIBUTOR1',
                                    dist2 as 'DISTRIBUTOR2',
                                    dist3 as 'DISTRIBUTOR3',
                                    image1 as 'IMAGE1',
                                    image2 as 'IMAGE2',
                                    image3 as 'IMAGE3' 
                                    from [items]";
            config.Load_DTG(sql, dataGridView1);
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ItemEditForm form = new ItemEditForm((long)dataGridView1.CurrentRow.Cells[0].Value);
            form.EditMode(false);
            form.ShowDialog();
        }

        

        private void ItemForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
