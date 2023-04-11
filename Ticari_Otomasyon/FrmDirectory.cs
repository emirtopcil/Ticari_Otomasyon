using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    public partial class FrmDirectory : Form
    {
        public FrmDirectory()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();
        void directory()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select Name,Surname,Phone1,Phone2,Mail from TBL_CUSTOMERS", bgl.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select Name,AuthorizedName,AuthorizedStatus,AuthorizedTC,Sector,Phone1,Phone2,Phone3,Mail,Fax,City,Town,VergiDairesi,Address from TBL_COMPANYS", bgl.connection());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;
        }
        private void FrmDirectory_Load(object sender, EventArgs e)
        {
            directory();
        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmMail frm = new FrmMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                frm.mail = dr["Mail"].ToString();
            }
            frm.Show();
        }
    }
}
