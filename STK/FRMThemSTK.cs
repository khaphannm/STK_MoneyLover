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

namespace STK
{
    public partial class FRMThemSTK : Form
    {
        public FRMThemSTK()
        {
            InitializeComponent();
        }
        public SqlConnection Kn()
        {
            return Utilities.getConnect();
        }

        private string g_Email;
        public string G_Email
        {
            get { return g_Email; }
            set { g_Email = value; }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmAddBank a = new FrmAddBank();
            a.Show();
        }

        private void FRMThemSTK_Load(object sender, EventArgs e)
        {
            lab_Get_Email.Text = g_Email;
            DateTime date = DateTime.Now;
            string.Format("{0:dd/MM/yyyy}", date); // 10/07/2018
            MaximizeBox = false;
            MinimizeBox = false;

            SqlConnection cnn = Kn();
            DataTable dt = new DataTable();
            cnn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select TenNganHang From NganHang", cnn);
                da.Fill(dt);
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            try
            {
                cbbNganHang.DataSource = dt;
                cbbNganHang.DisplayMember = "TenNganHang";
                cbbNganHang.ValueMember = "TenNganHang";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
            var id = Guid.NewGuid();
            txtMaSo.Text = id.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = Kn();
            DataTable dt = new DataTable();
            cnn.Open();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select TenNganHang From NganHang", cnn);
                da.Fill(dt);
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.ToString());
            }

            try
            {
                cbbNganHang.DataSource = dt;
                cbbNganHang.DisplayMember = "TenNganHang";
                cbbNganHang.ValueMember = "TenNganHang";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }

        }

        private void bthThem_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày không hợp lệ!");
            }
            else if (string.IsNullOrEmpty(txtLaiSuat.Text)==true)
            {
                txtLaiSuat.Text = "0";
            }
            else
            {
                if(string.IsNullOrEmpty(txtLKKH.Text)==true)
                {
                    labLKKH.Text = "0.05";
                }
                else
                {
                    labLKKH.Text = txtLKKH.Text;
                }
                SqlConnection cnn = Kn();
                SqlCommand cmd;
                cmd = new SqlCommand("Insert Into TheTietKiem(MaSo,Email,MaNganHang,NgayGui,SoTienGui,LaiSuat,KhiDenHan,TraLai,KyHan,LaiKhongKyHan,TatToan) values(@MaSo,@Email,@MaNganHang,@NgayGui,@SoTienGui,@LaiSuat,@KhiDenHan,@TraLai,@KyHan,@LaiKhongKyHan,@TatToan)", cnn);
                cnn.Open();
                cmd.Parameters.AddWithValue("@MaSo", (labMaNganHang.Text +"_"+txtMaSo.Text));
                cmd.Parameters.AddWithValue("@Email", lab_Get_Email.Text);
                cmd.Parameters.AddWithValue("@MaNganHang", labMaNganHang.Text);
                cmd.Parameters.AddWithValue("@NgayGui", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@SoTienGui", txtSoTienGui.Text);
                cmd.Parameters.AddWithValue("@LaiSuat", txtLaiSuat.Text);
                cmd.Parameters.AddWithValue("@KhiDenHan", labkhidenhan.Text);
                cmd.Parameters.AddWithValue("@TraLai", labTraLai.Text);
                cmd.Parameters.AddWithValue("@KyHan", labKyHan.Text);
                cmd.Parameters.AddWithValue("@LaiKhongKyHan", labLKKH.Text);
                cmd.Parameters.AddWithValue("@TatToan", labTatToan.Text);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Thêm sổ tiết kiệmm của bạn thành công !", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void cbbNganHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = Kn();
            
            string sql1 = "SELECT MaNganHang FROM NganHang WHERE TenNganHang ='" + this.cbbNganHang.SelectedValue.ToString() + "'";
            cnn.Open();
            SqlCommand com = new SqlCommand(sql1, cnn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                labMaNganHang.Text = dr.GetString(0).ToString();
                textBox1.Text = labMaNganHang.Text+"_";
                break;
            }
        }

        private void cbbKhiDenHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbbKhiDenHan.SelectedItem.ToString()== "Tái tục gốc và lãi")
            {
                labkhidenhan.Text = "Tái tục gốc và lãi";
                labTatToan.Text = "false";
            }
            else if (cbbKhiDenHan.SelectedItem.ToString() == "Tái tục gốc")
            {
                labkhidenhan.Text = "Tái tục gốc";
                labTatToan.Text = "false";
            }
            else if (cbbKhiDenHan.SelectedItem.ToString() == "Tất toán sổ")
            {
                labkhidenhan.Text = "Tất toán sổ";
                labTatToan.Text = "true";
            }
        }

        private void cbbTraLai_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(cbbTraLai.SelectedItem.ToString()== "Đầu kỳ")
            {
                labTraLai.Text = "Đầu kỳ";
            }
            else if (cbbTraLai.SelectedItem.ToString() == "Cuối Kỳ")
            {
                labTraLai.Text = "Cuối Kỳ";
            }
            else if (cbbTraLai.SelectedItem.ToString() == "Định kỳ hàng tháng")
            {
                labTraLai.Text = "Định kỳ hàng tháng";
            }
        }

        private void cbbKyHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbbKyHan.SelectedItem.ToString()== "Không kỳ hạn")
            {
                labKyHan.Text = "Không kỳ hạn";
            }
            else if (cbbKyHan.SelectedItem.ToString() == "1 tháng")
            {
                labKyHan.Text = "1 tháng";
            }
            else if (cbbKyHan.SelectedItem.ToString() == "3 tháng")
            {
                labKyHan.Text = "3 tháng";
            }
            else if (cbbKyHan.SelectedItem.ToString() == "6 tháng")
            {
                labKyHan.Text = "6 tháng";
            }
            else if (cbbKyHan.SelectedItem.ToString() == "12 tháng")
            {
                labKyHan.Text = "12 tháng";
            }

        }

        private void FRMThemSTK_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
