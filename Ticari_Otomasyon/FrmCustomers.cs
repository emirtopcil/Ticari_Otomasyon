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
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();
        void List()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_CUSTOMERS", bgl.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void Citys()
        {
            SqlCommand city = new SqlCommand("select CityName from TBL_CITYS", bgl.connection());
            SqlDataReader dr = city.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit4.Properties.Items.Add(dr[0]);
            }
            bgl.connection().Close();
        }

        void Clean()
        {
            TxtID.Text = "";
            TxtMail.Text = "";
            TxtName.Text = "";
            TxtSurname.Text = "";
            TxtVergiDaire.Text = "";
            MskTxtPhone.Text = "";
            MskTxtPhone2.Text = "";
            MskTxtTC.Text = "";
            RchTxtAddress.Text = "";
            comboBoxEdit4.Text = "";
            comboBoxEdit2.Text = "";
        }
        private void FrmCustomers_Load(object sender, EventArgs e)
        {
            List();
            Clean();
            Citys();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dt = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtID.Text = dt[0].ToString();
            TxtName.Text = dt[1].ToString();
            TxtSurname.Text = dt[2].ToString();
            MskTxtPhone.Text = dt[3].ToString();
            MskTxtPhone2.Text = dt[4].ToString();
            MskTxtTC.Text = dt[5].ToString();
            TxtMail.Text = dt[6].ToString();
            comboBoxEdit4.Text = dt[7].ToString();
            comboBoxEdit2.Text = dt[8].ToString();
            TxtVergiDaire.Text = dt[10].ToString();
            RchTxtAddress.Text = dt[9].ToString();
        }

        private void LblClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clean();
        }

        private void comboBoxEdit4_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxEdit2.Properties.Items.Clear();
            SqlCommand query = new SqlCommand("Select TownName from TBL_TOWNS where CityID=@p1", bgl.connection());
            query.Parameters.AddWithValue("@p1", comboBoxEdit4.SelectedIndex + 1);
            SqlDataReader dr = query.ExecuteReader();
            while (dr.Read())
            {
                comboBoxEdit2.Properties.Items.Add(dr[0]);
            }
            bgl.connection().Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Insert into TBL_CUSTOMERS (Name,Surname,Phone1,Phone2,TC,Mail,City,Town,Address,VergiDaire) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.connection());
            query.Parameters.AddWithValue("@p1", TxtName.Text);
            query.Parameters.AddWithValue("@p2", TxtSurname.Text);
            query.Parameters.AddWithValue("@p3", MskTxtPhone.Text);
            query.Parameters.AddWithValue("@p4", MskTxtPhone2.Text);
            query.Parameters.AddWithValue("@p5", MskTxtTC.Text);
            query.Parameters.AddWithValue("@p6", TxtMail.Text);
            query.Parameters.AddWithValue("@p7", comboBoxEdit4.Text.ToString());
            query.Parameters.AddWithValue("@p8", comboBoxEdit2.Text.ToString());
            query.Parameters.AddWithValue("@p9", RchTxtAddress.Text);
            query.Parameters.AddWithValue("@p10", TxtVergiDaire.Text);
            query.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt Eklendi");
            List();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Delete from TBL_CUSTOMERS where ID=@p1", bgl.connection());
            query.Parameters.AddWithValue("@p1", TxtID.Text);
            query.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt Silindi");
            List();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Update TBL_CUSTOMERS set Name=@p1,Surname=@p2,Phone1=@p3,Phone2=@p4,TC=@p5,Mail=@p6,City=@p7,Town=@p8,Address=@p9,VergiDaire=@p10 where ID=@p11", bgl.connection());
            query.Parameters.AddWithValue("@p1", TxtName.Text);
            query.Parameters.AddWithValue("@p2", TxtSurname.Text);
            query.Parameters.AddWithValue("@p3", MskTxtPhone.Text);
            query.Parameters.AddWithValue("@p4", MskTxtPhone2.Text);
            query.Parameters.AddWithValue("@p5", MskTxtTC.Text);
            query.Parameters.AddWithValue("@p6", TxtMail.Text);
            query.Parameters.AddWithValue("@p7", comboBoxEdit4.Text);
            query.Parameters.AddWithValue("@p8", comboBoxEdit2.Text);
            query.Parameters.AddWithValue("@p9", RchTxtAddress.Text);
            query.Parameters.AddWithValue("@p10", TxtVergiDaire.Text);
            query.Parameters.AddWithValue("@p11", TxtID.Text);
            query.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt Güncellendi");
            List();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
