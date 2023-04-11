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
    public partial class FrmCompanys : Form
    {
        public FrmCompanys()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();
        void liste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_COMPANYS", bgl.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
            bgl.connection().Close();

        }
        void city()
        {
            SqlCommand query = new SqlCommand("Select CityName from TBL_CITYS", bgl.connection());
            SqlDataReader dr = query.ExecuteReader();
            while (dr.Read())
            {
                CmbCity.Properties.Items.Add(dr[0]);
            }
            bgl.connection().Close();
        }
        void clean()
        {
            TxtID.Text = "";
            TxtName.Text = "";
            TxtSector.Text = "";
            TxtAuthorized.Text = "";
            TxtAuthorizedJob.Text = "";
            TxtAuthorizedTC.Text = "";
            TxtPhone1.Text = "";
            TxtPhone2.Text = "";
            TxtPhone3.Text = "";
            TxtFax.Text = "";
            TxtMail.Text = "";
            CmbCity.Text = "";
            CmbTown.Text = "";
        }
        private void FrmCompanys_Load(object sender, EventArgs e)
        {
            liste();
            city();
            clean();
        }

        private void CmbCity_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbTown.Properties.Items.Clear();
            SqlCommand query = new SqlCommand("Select TownName from TBL_TOWNS where CityID=@p1", bgl.connection());
            query.Parameters.AddWithValue("@p1", CmbCity.SelectedIndex + 1);
            SqlDataReader dr = query.ExecuteReader();
            while (dr.Read())
            {
                CmbTown.Properties.Items.Add(dr[0]);
            }
            bgl.connection().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dt = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtID.Text = dt[0].ToString();
            TxtName.Text = dt[1].ToString();
            TxtAuthorized.Text = dt[3].ToString();
            TxtAuthorizedJob.Text = dt[2].ToString();
            TxtAuthorizedTC.Text = dt[12].ToString();
            TxtPhone1.Text = dt[4].ToString();
            TxtPhone2.Text = dt[5].ToString();
            TxtPhone3.Text = dt[6].ToString();
            TxtFax.Text = dt[8].ToString();
            TxtMail.Text = dt[7].ToString();
            CmbCity.Text = dt[9].ToString();
            CmbTown.Text = dt[10].ToString();
            RchTxtAddress.Text = dt[11].ToString();
            TxtCode1.Text = dt[13].ToString();
            TxtCode2.Text = dt[14].ToString();
            TxtCode3.Text = dt[15].ToString();
            TxtSector.Text = dt[16].ToString();
            TxtVergiDaire.Text = dt[17].ToString();
        }

        private void LblClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clean();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Insert into TBL_COMPANYS (Name,AuthorizedStatus,AuthorizedName,Phone1,Phone2,Phone3,Mail,Fax,City,Town,Address,AuthorizedTC,SpecialCode1,SpecialCode2,SpecialCode3,Sector,VergiDairesi) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.connection());
            query.Parameters.AddWithValue("@p1", TxtName.Text);
            query.Parameters.AddWithValue("@p2", TxtAuthorizedJob.Text); ;
            query.Parameters.AddWithValue("@p3", TxtAuthorized.Text) ;
            query.Parameters.AddWithValue("@p4",TxtPhone1.Text);
            query.Parameters.AddWithValue("@p5",TxtPhone2.Text);
            query.Parameters.AddWithValue("@p6",TxtPhone3.Text);
            query.Parameters.AddWithValue("@p7",TxtMail.Text);
            query.Parameters.AddWithValue("@p8",TxtFax.Text);
            query.Parameters.AddWithValue("@p9",CmbCity.Text);
            query.Parameters.AddWithValue("@p10",CmbTown.Text);
            query.Parameters.AddWithValue("@p11",RchTxtAddress.Text);
            query.Parameters.AddWithValue("@p12",TxtAuthorizedTC.Text);
            query.Parameters.AddWithValue("@p13",TxtCode1.Text);
            query.Parameters.AddWithValue("@p14",TxtCode2.Text);
            query.Parameters.AddWithValue("@p15",TxtCode3.Text);
            query.Parameters.AddWithValue("@p16",TxtSector.Text);
            query.Parameters.AddWithValue("@p17",TxtVergiDaire.Text);
            query.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt Ekendi");
            liste();
            clean();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Delete from TBL_COMPANYS where ID=@p1", bgl.connection());
            query.Parameters.AddWithValue("@p1", TxtID.Text);
            query.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt silindi...");
            liste();
            clean();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Update TBL_COMPANYS set Name=@p1,AuthorizedStatus=@p2,AuthorizedName=@p3,Phone1=@p4,Phone2=@p5,Phone3=@p6,Mail=@p7,Fax=@p8,City=@p9,Town=@p10,Address=@p11,AuthorizedTC=@p12,SpecialCode1=@p13,SpecialCode2=@p14,SpecialCode3=@p15,Sector=@p16,VergiDairesi=@p17 where ID=@id", bgl.connection());
            query.Parameters.AddWithValue("@p1", TxtName.Text);
            query.Parameters.AddWithValue("@p2", TxtAuthorizedJob.Text); ;
            query.Parameters.AddWithValue("@p3", TxtAuthorized.Text);
            query.Parameters.AddWithValue("@p4", TxtPhone1.Text);
            query.Parameters.AddWithValue("@p5", TxtPhone2.Text);
            query.Parameters.AddWithValue("@p6", TxtPhone3.Text);
            query.Parameters.AddWithValue("@p7", TxtMail.Text);
            query.Parameters.AddWithValue("@p8", TxtFax.Text);
            query.Parameters.AddWithValue("@p9", CmbCity.Text);
            query.Parameters.AddWithValue("@p10", CmbTown.Text);
            query.Parameters.AddWithValue("@p11", RchTxtAddress.Text);
            query.Parameters.AddWithValue("@p12", TxtAuthorizedTC.Text);
            query.Parameters.AddWithValue("@p13", TxtCode1.Text);
            query.Parameters.AddWithValue("@p14", TxtCode2.Text);
            query.Parameters.AddWithValue("@p15", TxtCode3.Text);
            query.Parameters.AddWithValue("@p16", TxtSector.Text);
            query.Parameters.AddWithValue("@p17", TxtVergiDaire.Text);
            query.Parameters.AddWithValue("@id", TxtID.Text);
            query.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt Güncellenedi");
            liste();
        }
    }
}
