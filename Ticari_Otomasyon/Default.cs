using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon
{
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
        }
        FrmProducts fr = null;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new FrmProducts();
                fr.MdiParent = this;
                fr.Show();
            }
        }
        FrmCustomers cs = null;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cs == null)
            {
                cs = new FrmCustomers();
                cs.MdiParent = this;
                cs.Show();
            }
        }
        FrmCompanys Comp = null;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Comp == null)
                Comp = new FrmCompanys();Comp.MdiParent = this;Comp.Show();
        }
        FrmEmployee emp = null;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(emp==null)
            {
                emp = new FrmEmployee();
                emp.MdiParent = this;
                emp.Show();
            }
        }
        FrmDirectory dr = null;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(dr==null)
            {
                dr = new FrmDirectory();
                dr.MdiParent = this;
                dr.Show();
            }
        }
    }
}
