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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }
        sqlConnection bgl = new sqlConnection();
        void list()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_PRODUCT", bgl.connection());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        private void FrmProducts_Load(object sender, EventArgs e)
        {
            list();
            TxtID.Text = "";
            TxtName.Text = "";
            TxtBrand.Text = "";
            TxtModel.Text = "";
            TxtYear.Text = "";
            NumPiece.Text = "";
            BuyTxt.Text = "";
            SellTxt.Text = "";
            DescRchTxt.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand query = new SqlCommand("Insert into TBL_PRODUCT (ProductName,Brand,Model,Year,Piece,BuyPrice,SellPrice,Detail) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.connection());
                query.Parameters.AddWithValue("@p1", TxtName.Text);
                query.Parameters.AddWithValue("@p2", TxtBrand.Text);
                query.Parameters.AddWithValue("@p3", TxtModel.Text);
                query.Parameters.AddWithValue("@p4", TxtYear.Text);
                query.Parameters.AddWithValue("@p5", int.Parse(NumPiece.Text));
                query.Parameters.AddWithValue("@p6", decimal.Parse(BuyTxt.Text));
                query.Parameters.AddWithValue("@p7", decimal.Parse(SellTxt.Text));
                query.Parameters.AddWithValue("@p8", DescRchTxt.Text);
                query.ExecuteNonQuery();
                bgl.connection().Close();
                MessageBox.Show("Kayıt Eklenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                list();
                TxtName.Text = "";
                TxtBrand.Text = "";
                TxtModel.Text = "";
                TxtYear.Text = "";
                NumPiece.Text = "";
                BuyTxt.Text = "";
                SellTxt.Text = "";
                DescRchTxt.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Değerler boş geçilemez", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtID.Text = dr["ID"].ToString();
            TxtName.Text = dr["ProductName"].ToString();
            TxtBrand.Text = dr["Brand"].ToString();
            TxtModel.Text = dr["Model"].ToString();
            TxtYear.Text = dr["Year"].ToString();
            NumPiece.Text = dr["Piece"].ToString();
            BuyTxt.Text = dr["BuyPrice"].ToString();
            SellTxt.Text = dr["SellPrice"].ToString();
            DescRchTxt.Text = dr["Detail"].ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand deleteQuery = new SqlCommand("Delete from TBL_PRODUCT where ID=@p1", bgl.connection());
            deleteQuery.Parameters.AddWithValue("@p1", TxtID.Text);
            deleteQuery.ExecuteNonQuery();
            bgl.connection().Close();
            MessageBox.Show("Kayıt Silidi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            list();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("update TBL_PRODUCT set ProductName=@p1,Brand=@p2,Model=@p3,Year=@p4,Piece=@p5,BuyPrice=@p6,SellPrice=@p7,Detail=@p8 where ID=@p9", bgl.connection());
            query.Parameters.AddWithValue("@p1", TxtName.Text);
            query.Parameters.AddWithValue("@p2", TxtBrand.Text);
            query.Parameters.AddWithValue("@p3", TxtModel.Text);
            query.Parameters.AddWithValue("@p4", TxtYear.Text);
            query.Parameters.AddWithValue("@p5", int.Parse(NumPiece.Text));
            query.Parameters.AddWithValue("@p6", decimal.Parse(BuyTxt.Text));
            query.Parameters.AddWithValue("@p7", decimal.Parse(SellTxt.Text));
            query.Parameters.AddWithValue("@p8", DescRchTxt.Text);
            query.Parameters.AddWithValue("@p9", TxtID.Text);
            query.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi", "Bikgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            list();
        }

        private void LblClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TxtID.Text = "";
            TxtName.Text = "";
            TxtBrand.Text = "";
            TxtModel.Text = "";
            TxtYear.Text = "";
            NumPiece.Text = "";
            BuyTxt.Text = "";
            SellTxt.Text = "";
            DescRchTxt.Text = "";
        }
    }
}
