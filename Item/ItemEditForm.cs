using BARMAN_STORE1._0.Include;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace BARMAN_STORE1._0.Items
{
    public partial class ItemEditForm : Form
    {
        double id;
        string item_name;
        string desc;
        float? mrp;
        string catagory;
        string brand;
        string comp;
        string weight;
        string color;
        string flavour;
        float? rate;
        float? gst;
        string unit;
        string dist1;
        string dist2;
        string dist3;
        SQLConfig config = new SQLConfig();

        public ItemEditForm(long item_id)
        {
            InitializeComponent();
            id = item_id;
        }

        internal void EditMode(bool ans)
        {

            item_namecb.Enabled = ans;
            desctb.ReadOnly = !ans;
            mrptb.ReadOnly = !ans;
            catagorycb.Enabled = ans;
            brandcb.Enabled = ans;
            compcb.Enabled = ans;
            weightcb.Enabled = ans;
            colorcb.Enabled = ans;
            flavourcb.Enabled = ans;
            ratetb.ReadOnly = !ans;
            gsttb.ReadOnly = !ans;
            unittb.ReadOnly = !ans;
            dist1cb.Enabled = ans;
            dist2cb.Enabled = ans;
            dist3cb.Enabled = ans;
            modifybtn.Visible = !ans;
            savebtn.Visible = ans;
            deletebtn.Visible = ans;
            cancelbtn.Visible = ans;

        }

        private void ItemEditForm_Load(object sender, EventArgs e)
        {
            LoadDetails();

        }
        private void LoadDetails()
        {
            config.fiil_CBO("select distinct(item_name) from items", item_namecb);
            config.fiil_CBO("select distinct(catagory) from items", catagorycb);
            config.fiil_CBO("select distinct(brand) from items", brandcb);
            config.fiil_CBO("select distinct(comp) from items", compcb);
            config.fiil_CBO("select distinct(flavour) from items", flavourcb);
            config.fiil_CBO("select distinct(weight) from items", weightcb);
            config.fiil_CBO("select distinct(color) from items", colorcb);
            config.fiil_CBO("select distinct(dist_name) from distributor", dist1cb);
            config.fiil_CBO("select distinct(dist_name) from distributor", dist2cb);
            config.fiil_CBO("select distinct(dist_name) from distributor", dist3cb);
            string sql = @"select  id,item_name,[desc],mrp,catagory,brand,comp,weight,color,flavour,rate,gst,unit,dist1,dist2,dist3 from items where id=" + id;
            config.singleResult(sql);
            if (config.datatable.Rows.Count > 0)
            {
                item_name = config.datatable.Rows[0].Field<string>("item_name");
                desc = config.datatable.Rows[0].Field<string>("desc");
                mrp = config.datatable.Rows[0].Field<float>("mrp");
                catagory = config.datatable.Rows[0].Field<string>("catagory");
                brand = config.datatable.Rows[0].Field<string>("brand");
                comp = config.datatable.Rows[0].Field<string>("comp");
                weight = config.datatable.Rows[0].Field<string>("weight");
                color = config.datatable.Rows[0].Field<string>("color");
                flavour = config.datatable.Rows[0].Field<string>("flavour");
                rate = config.datatable.Rows[0].Field<float>("rate");
                gst = config.datatable.Rows[0].Field<float>("gst");
                unit = config.datatable.Rows[0].Field<string>("unit");
                dist1 = config.datatable.Rows[0].Field<string>("dist1");
                dist2 = config.datatable.Rows[0].Field<string>("dist2");
                dist3 = config.datatable.Rows[0].Field<string>("dist3");
            }
            item_namecb.Text = item_name;
            desctb.Text = desc;
            mrptb.Text = mrp.ToString();
            catagorycb.Text = catagory;
            brandcb.Text = brand;
            compcb.Text = comp;
            weightcb.Text = weight;
            colorcb.Text = color;
            flavourcb.Text = flavour;
            ratetb.Text = rate.ToString();
            gsttb.Text = gst.ToString();
            unittb.Text = unit;
            dist1cb.Text = dist1;
            dist2cb.Text = dist2;
            dist3cb.Text = dist3;

        }

        private void modifybtn_Click(object sender, EventArgs e)
        {
            EditMode(true);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(item_namecb.Text)) { item_namecb.Focus(); return; }
            if (item_name != item_namecb.Text)
            {
                config.singleResult("select id from items where item_name='" + item_namecb.Text + "'");
                if (config.datatable.Rows.Count > 0) { item_namecb.Focus(); return; }
            }
            item_name = item_namecb.Text;
            desc = desctb.Text;
            float mrpx;
            if (float.TryParse(mrptb.Text, out mrpx)) this.mrp = mrpx;
            else this.mrp = 0;
            catagory = catagorycb.Text;
            brand = brandcb.Text;
            comp = compcb.Text;
            weight = weightcb.Text;
            color = colorcb.Text;
            flavour = flavourcb.Text;
            float ratex;
            if (float.TryParse(ratetb.Text, out ratex)) this.rate = ratex;
            else this.rate = 0;
            float gstx;
            if (float.TryParse(gsttb.Text, out gstx)) this.gst = gstx;
            else this.gst = 0;

            unit = unittb.Text;
            dist1 = dist1cb.Text;
            dist2 = dist2cb.Text;
            dist3 = dist3cb.Text;
            string sql = @"if exists (Select id from items where id=" + id + ") begin " +
                        "update items set item_name='" + item_name + "',[desc]='" + desc + "',mrp=" + mrp + "," +
                        "catagory='" + catagory + "',brand='" + brand + "',comp='" + comp + "',weight='" + weight + "'," +
                        "color='" + color + "',flavour='" + flavour + "',rate=" + rate + ",gst=" + gst + ",unit='" + unit + "'," +
                        "dist1='" + dist1 + "',dist2='" + dist2 + "',dist3='" + dist3 + "' where id=" + id + "; end " +
                        "else begin insert into items (item_name,[desc],mrp,catagory," +
                        "brand,comp,weight,color,flavour,rate,gst,unit,dist1,dist2,dist3)" +
                        " values ('" + item_name + "','" + desc + "'," + mrp + ",'" + catagory + "','" + brand + "','" + comp + "','" + weight + "','" + color + "'," +
                        "'" + flavour + "'," + rate + "," + gst + ",'" + unit + "','" + dist1 + "','" + dist2 + "','" + dist3 + "'); end;";
            config.CExecute_CUD(sql, "Unable to Update", "Data has been Updated in the database.");
            config.singleResult("select id from items where item_name='" + item_name + "'");
            id = config.datatable.Rows[0].Field<long>("id");
            EditMode(false);
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            EditMode(false);
            LoadDetails();
        }
    }
}
