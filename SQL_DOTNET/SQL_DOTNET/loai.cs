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

        private void data_loai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_ml.Text = data_loai.Rows[numrow].Cells[0].Value.ToString();
            txt_tl.Text = data_loai.Rows[numrow].Cells[1].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            ketnoi conn = new ketnoi();
            string ml = txt_ml.Text.ToString();
            string tl = txt_tl.Text.ToString();
            string create_data = "insert into loai values ('"+ml+"','"+tl+"')";
            int ketqua = conn.ThemSuaXoa(create_data);
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");

            // load lai form
            txt_ml.Text = "";
            txt_tl.Text = "";
            loai_Load(sender, e);
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                ketnoi conn = new ketnoi();
                string ml = txt_ml.Text;
                string tl = txt_tl.Text;
                string sua_data = "Update loai set tenloai= N'" + tl + "' where maloai = N'" + ml + "'";
                int ketqua = conn.ThemSuaXoa(sua_data);
                if (ketqua >= 1)
                    MessageBox.Show("Sua thành công");
                else
                    MessageBox.Show("Sua thất bai");

                // load lai form
               
            }
            txt_ml.Text = "";
            txt_tl.Text = "";
            loai_Load(sender, e);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                ketnoi conn = new ketnoi();
                string ml = txt_ml.Text;
                string tl = txt_tl.Text;
                string xoa_data = "delete loai where maloai=N'" + ml + "'";
                int ketqua = conn.ThemSuaXoa(xoa_data);
                if (ketqua >= 1)
                    MessageBox.Show("Xoa thành công");
                else
                    MessageBox.Show("Xoa thất bai");
            }
            loai_Load(sender, e);
            txt_ml.Text = "";
            txt_tl.Text = "";
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
