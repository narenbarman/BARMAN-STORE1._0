using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BARMAN_STORE1._0.Include
{
    
    class Design
    {
        public static System.Windows.Forms.Form ParentForm = new System.Windows.Forms.Form();
        public Design( Form Parent) 
        { 
        ParentForm= Parent;
            ParentForm.IsMdiContainer = true;
        }
        public void ShowMdiChild(Form Child)
        {
            MdiReset();
            Child.MdiParent = ParentForm;
            Child.FormBorderStyle = FormBorderStyle.None;
            Child.Dock = DockStyle.Fill;
            Child.Show();
        }

        private void MdiReset()
        {
            foreach (Form form in ParentForm.MdiChildren)
            {
                form.Close();
            }

        }
    }
}
