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
    public partial class FrmAddBank : Form
    {
        public FrmAddBank()
        {
            InitializeComponent();
        }
        public SqlConnection Kn()
        {
            return Utilities.getConnect();
        }
        public bool kiemTraMaTrung()
        {
            SqlConnection cnn = Kn();
            bool kq = false;
            string chuoi = txtMaNganHang.Text;
            string sql1 = "SELECT MaNganHang FROM NganHang ";
            cnn.Open();
            SqlCommand com = new SqlCommand(sql1, cnn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (chuoi == dr.GetString(0))
                {
                    kq = true;
                    break;
                }
            }
            cnn.Close();
            return kq;
        }
        public bool kiemTraTenTrung()
        {
            SqlConnection cnn = Kn();
            bool kq = false;
            string chuoi = txtTenNganHang.Text;
            string sql1 = "SELECT TenNganHang FROM NganHang ";
            cnn.Open();
            SqlCommand com = new SqlCommand(sql1, cnn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (chuoi == dr.GetString(0))
                {
                    kq = true;
                    break;
                }
            }
            cnn.Close();
            return kq;
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            DialogResult TL;
            TL = MessageBox.Show("Bạn đã chắc chắn chưa ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TL == DialogResult.Yes)
            { 
                if(txtMaNganHang.TextLength > 5)
                {
                    TL = MessageBox.Show("Mã ngân hàng không quá 5 ký tự !");
                }
                else if (txtMaNganHang.TextLength == 0)
                {
                    TL = MessageBox.Show("Mã ngân hàng không được để trống !");
                }
                else if(kiemTraMaTrung()==true)
                {
                    TL = MessageBox.Show("Mã ngân hàng bị trùng !");
                }
                else if (kiemTraTenTrung() == true)
                {
                    TL = MessageBox.Show("Tên ngân hàng đã tồn tại !");
                }
                else if (txtTenNganHang.TextLength == 0)
                {
                    TL = MessageBox.Show("Tên ngân hàng không được để trống !");
                }
                else if (txtTenNganHang.TextLength > 20)
                {
                    TL = MessageBox.Show("Tên ngân hàng không quá 20 ký tự !");
                }
                else
                {
                    SqlConnection cnn = Kn();
                    SqlCommand cmd;
                    cmd = new SqlCommand("Insert Into NganHang(MaNganHang,TenNganHang) values(@MaNganHang,@TenNganHang)", cnn);
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@MaNganHang", txtMaNganHang.Text);
                    cmd.Parameters.AddWithValue("@TenNganHang", txtTenNganHang.Text);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Thêm ngân hàng của bạn thành công !", "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                
            }
        }
        private void FrmAddBank_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

        }

        private void txtMaNganHang_TextChanged(object sender, EventArgs e)
        {
            txtMaNganHang.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtTenNganHang_TextChanged(object sender, EventArgs e)
        {
            txtTenNganHang.CharacterCasing = CharacterCasing.Upper;
        }

        private void FrmAddBank_TextChanged(object sender, EventArgs e)
        {
           
          
        }
    }
}
