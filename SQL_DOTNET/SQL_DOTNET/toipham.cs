using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_DOTNET
{
    public partial class toipham : Form
    {
        public toipham()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toipham_Load(object sender, EventArgs e)
        {

            ketnoi conn = new ketnoi();

            // load data gitview
            string show_data = "select matoipham,tentoipham,tenloai,ns  from toipham,loai where loai.maloai = toipham.maloai";
            DataTable dt = conn.LoadDuLieu(show_data);
            data_toipham.DataSource = dt;


            // load combobox nam sinh
            string t = DateTime.Now.ToString("yyyy");
            tb_ns.Items.Clear();
            for(int i= 1990; i< Convert.ToInt32(t); i++)
            {
                tb_ns.Items.Add(i);
            }
            tb_ns.SelectedIndex = 0;


            // load combobox ma toi pham
            string load_ma = "select DISTINCT(tenloai) from loai";
            DataTable dt_ml = conn.LoadDuLieu(load_ma);
            cb_ml.Items.Clear();
            if (dt_ml != null)
            {
                foreach (DataRow dr in dt_ml.Rows)
                {

                    cb_ml.Items.Add(dr["tenloai"].ToString());

                }
            }
            cb_ml.SelectedIndex = 0;
        }

        private void data_toipham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_mtp.Text = data_toipham.Rows[numrow].Cells[0].Value.ToString();
            txt_ttp.Text = data_toipham.Rows[numrow].Cells[1].Value.ToString();
            tb_ns.Text = data_toipham.Rows[numrow].Cells[3].Value.ToString();
            cb_ml.Text = data_toipham.Rows[numrow].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi conn = new ketnoi();
                string mtp = txt_mtp.Text.ToString();
                string ttp = txt_ttp.Text.ToString();
                string ns = tb_ns.Text.ToString();
                // lay ma loai tu ten loai
                string ml = "";
                string tl = cb_ml.Text.ToString();
                string select_ma = "select DISTINCT(maloai) from loai where tenloai = '" + tl + "'";
                DataTable dt_ml = conn.LoadDuLieu(select_ma);
                if (dt_ml != null)
                {
                    foreach (DataRow dr in dt_ml.Rows)
                    {

                        ml = dr["maloai"].ToString();

                    }
                }

                // kiem tra matoipham
                int dem = 0;
                string kt_matp = "select matoipham from toipham where matoipham = N'" + mtp + "'";
                DataTable kq = conn.LoadDuLieu(kt_matp);
                if (kq != null)
                {
                    foreach (DataRow dr in kq.Rows)
                    {

                        dem++;

                    }
                }
                if (dem == 0)
                {
                    // MessageBox.Show("Thêm thành công");
                    string create_data = "insert into toipham values ('" + mtp + "','" + ttp + "','" + ml + "','" + ns + "')";
                    int ketqua = conn.ThemSuaXoa(create_data);
                    if (ketqua >= 1)
                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Thêm thất bai");
                }
                else
                {
                    MessageBox.Show("Ma toi pham " + mtp + " da toi tai");
                }
                  


                // load lai form
                txt_mtp.Text = "";
                txt_ttp.Text = "";
                toipham_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Them dữ liệu không thành công");
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog;
                dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    ketnoi conn = new ketnoi();
                    string mtp = txt_mtp.Text;
                    string xoa_data = "delete toipham where matoipham=N'" + mtp + "'";
                    int ketqua = conn.ThemSuaXoa(xoa_data);
                    if (ketqua >= 1)
                        MessageBox.Show("Xoa thành công");
                    else
                        MessageBox.Show("Xoa thất bai");
                }
                txt_mtp.Text = "";
                txt_ttp.Text = "";
                toipham_Load(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Xóa dữ liệu không thành công");

            }

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                ketnoi conn = new ketnoi();
                string mtp = txt_mtp.Text.ToString();
                string ttp = txt_ttp.Text.ToString();
                string ns = tb_ns.Text.ToString();
                // lay ma loai tu ten loai
                string ml = "";
                string tl = cb_ml.Text.ToString();
                string select_ma = "select DISTINCT(maloai) from loai where tenloai = '" + tl + "'";
                DataTable dt_ml = conn.LoadDuLieu(select_ma);
                if (dt_ml != null)
                {
                    foreach (DataRow dr in dt_ml.Rows)
                    {

                        ml = dr["maloai"].ToString();

                    }
                }

                string sua_data = "Update toipham set tentoipham= N'" + ttp + "', ns = '"+ ns + "', maloai = '" + ml + "' where matoipham = N'" + mtp + "'";
                int ketqua = conn.ThemSuaXoa(sua_data);
                if (ketqua >= 1)
                    MessageBox.Show("Sua thành công");
                else
                    MessageBox.Show("Sua thất bai");

                // load lai form

            }
            txt_mtp.Text = "";
            txt_ttp.Text = "";
            toipham_Load(sender, e);
        }
    }
}
