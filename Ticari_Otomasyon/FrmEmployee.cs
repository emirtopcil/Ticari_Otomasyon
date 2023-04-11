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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();
        void list()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_EMPLOYEE", bgl.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void clean()
        {
            TxtID.Text = "";
            TxtID.Text = "";
            TxtName.Text = "";
            TxtLastname.Text = "";
            MskTxtPhone.Text = "";
            MskTxtTC.Text = "";
            TxtMail.Text = "";
            CmbCity.Text = "";
            CmbTown.Text = "";
            RchTxtAddress.Text = "";
            TaskRchTxt.Text = "";
        }
        void city()
        {
            SqlCommand city = new SqlCommand("Select CityName From TBL_CITYS", bgl.connection());
            SqlDataReader dr = city.ExecuteReader();
            while (dr.Read())
            {
                CmbCity.Properties.Items.Add(dr[0]);
            }
        }
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            list();
            city();
            clean();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dt = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtID.Text = dt[0].ToString();
            TxtName.Text = dt[1].ToString();
            TxtLastname.Text = dt[2].ToString();
            MskTxtPhone.Text = dt[3].ToString();
            MskTxtTC.Text = dt[4].ToString();
            TxtMail.Text = dt[5].ToString();
            CmbCity.Text = dt[6].ToString();
            CmbTown.Text = dt[7].ToString();
            RchTxtAddress.Text = dt[8].ToString();
            TaskRchTxt.Text = dt[9].ToString();
        }

        private void CmbCity_Properties_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbTown.Properties.Items.Clear();
            SqlCommand town = new SqlCommand("Select TownName from TBL_TOWNS where CityID=@p1", bgl.connection());
            town.Parameters.AddWithValue("@p1", CmbCity.SelectedIndex + 1);
            SqlDataReader dr = town.ExecuteReader();
            while (dr.Read())
            {
                CmbTown.Properties.Items.Add(dr[0]);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Insert into TBL_EMPLOYEE (Name,LastName,Phone,TC,Mail,City,Town,Address,Task) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.connection());
            query.Parameters.AddWithValue("@p1", TxtName.Text);
            query.Parameters.AddWithValue("@p2", TxtLastname.Text);
            query.Parameters.AddWithValue("@p3", MskTxtPhone.Text);
            query.Parameters.AddWithValue("@p4", MskTxtTC.Text);
            query.Parameters.AddWithValue("@p5", TxtMail.Text);
            query.Parameters.AddWithValue("@p6", CmbCity.Text);
            query.Parameters.AddWithValue("@p7", CmbTown.Text);
            query.Parameters.AddWithValue("@p8", RchTxtAddress.Text);
            query.Parameters.AddWithValue("@p9", TaskRchTxt.Text);
            query.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt Eklendi");
            list();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Delete from TBL_EMPLOYEE where ID=@p1", bgl.connection());
            query.Parameters.AddWithValue("@p1", TxtID.Text);
            query.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt Silindi");
            list();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Update TBL_EMPLOYEE set Name=@p1,LastName=@p2,Phone=@p3,TC=@p4,Mail=@p5,City=@p6,Town=@p7,Address=@p8,Task=@p9 where ID=@p10", bgl.connection());
            query.Parameters.AddWithValue("@p1", TxtName.Text);
            query.Parameters.AddWithValue("@p2", TxtLastname.Text);
            query.Parameters.AddWithValue("@p3", MskTxtPhone.Text);
            query.Parameters.AddWithValue("@p4",MskTxtTC.Text);
            query.Parameters.AddWithValue("@p5",TxtMail.Text);
            query.Parameters.AddWithValue("@p6",CmbCity.Text);
            query.Parameters.AddWithValue("@p7",CmbTown.Text);
            query.Parameters.AddWithValue("@p8",RchTxtAddress.Text);
            query.Parameters.AddWithValue("@p9",TaskRchTxt.Text);
            query.Parameters.AddWithValue("@p10", TxtID.Text);
            query.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt Güncellendi");
            list();
        }
    }
}
