﻿using System;
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



        /*
          public object ExcuteScalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            Mo();
            object ketqua = comm.ExecuteScalar();
            Dong();
            return ketqua;

        }
         int kq = (int)lopchung.ExcuteScalar(sql);
            if (kq >= 1)
            {
                GUI.Main main = new GUI.Main();
                main.bt_close.Text = "Xin chao, " + ten_nv;
                if (loai_quyen != "ADMIN")
                {
                    main.bt_quantrivien.Visible = false;
                }
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                dem++;
                MessageBox.Show("Đăng nhập thất bại,mời bạn nhập lại");
                if (dem == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần");
                    Application.Exit();
                }
            }
         */

    }
}
