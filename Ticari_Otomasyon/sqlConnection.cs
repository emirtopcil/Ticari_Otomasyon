using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    class sqlConnection
    {
        public SqlConnection connection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S9LL1D4\SQLEXPRESS;Initial Catalog=Dbo_TicariOtomasyon;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
