using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace SQL_DOTNET
{
    public partial class loai : Form
    {
        public loai()
        {
            InitializeComponent();
        }

        private void loai_Load(object sender, EventArgs e)
        {
            ketnoi conn = new ketnoi();
            string show_data = "select * from loai";
            DataTable dt = conn.LoadDuLieu(show_data);
            data_loai.DataSource = dt;
        }
    }
}
