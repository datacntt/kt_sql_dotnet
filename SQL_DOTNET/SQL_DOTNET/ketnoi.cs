using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SQL_DOTNET
{
    class ketnoi
    {
        string strcon = @"Data Source=mc;Initial Catalog=toipham;Integrated Security=True";
        // string sql = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLTV;User ID=sa;Password=system";
        // Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanAn;Integrated Security=True
        public SqlConnection conn;
      //  public SqlCommand cmd { get; set; }
       // public SqlDataReader dra { get; set; }
       // public SqlDataAdapter da { get; set; }
        public ketnoi()
        {
            conn = new SqlConnection(strcon);
           // cmd = null;
            //dra = null;
           // da = null;
        }
        public bool Mo()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
        public bool Dong()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public DataTable LoadDuLieu(string sql)
        { 
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int ThemSuaXoa(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            Mo();
            int ketqua = comm.ExecuteNonQuery();
            Dong();
            return ketqua;

        }

        /*
        using System.Text.RegularExpressions;

        public bool IsNumber(String txt)
        {
            Regex re = new Regex(@"^[+-]?[0-9]*\.?[0-9]+$");
            return re.IsMatch(txt);
        }
        */
    }
}
