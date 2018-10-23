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
    public partial class FrmAddEditSTK : Form
    {
        public string Key { get; set; }

        public FrmAddEditSTK()
        {
            InitializeComponent();
        }

        private void FrmAddEditSTK_Load(object sender, EventArgs e)
        {
            FrmDSSTK f = new FrmDSSTK();
            KetNoiCSDL();
        }
        public SqlConnection Kn()
        {
            return Utilities.getConnect();
        }
        public void KetNoiCSDL()
        {

            SqlConnection cnn = Kn();
            string sql1 = "SELECT t.ID , t.MaSo , t.NgayGui ,t.SoTienGui, t.LaiSuat,t.KhiDenHan,t.TraLai ,t.KyHan, n.TenNganHang," +
                "t.LaiKhongKyHan,t.MaNganHang FROM TheTietKiem t, NganHang n Where ID = '" + Key + "' and t.MaNganHang = n.MaNganHang";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql1, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtMaSo.Text = dr[1].ToString();
                dateTimePicker1.Value = DateTime.Parse(dr[2].ToString());
                txtSoTienGui.Text = dr[3].ToString();
                txtLaiSuat.Text = dr[4].ToString();
                //cbbKhiDenHan.SelectedText = dr["KhiDenHan"].ToString();
                //cbbTraLai.SelectedText = dr["TraLai"].ToString();
                //cbbKyHan.SelectedText = dr[7].ToString();*/
                txtLKKH.Text = dr[9].ToString();
                txtNganHang.Text = dr["TenNganHang"].ToString();

            }
            cnn.Close();

        }

        private void bthHoanThanh_Click(object sender, EventArgs e)
        {

            //var prm = new SqlParameter[] {
            //    new SqlParameter("@ngaynGui", dateTimePicker1.Value),
            //    new SqlParameter("@soTienGui",txtSoTienGui.Text),
            //    new SqlParameter("@laiSuat",txtLaiSuat.Text),
            //    new SqlParameter("@khiDenHan",cbbKhiDenHan.SelectedText),
            //    new SqlParameter("@traLai",cbbTraLai.SelectedText),
            //    new SqlParameter("@kyHan",cbbKyHan.SelectedText),
            //    new SqlParameter("@laiKhongKyHan",txtLKKH)
            //};
            if (string.IsNullOrEmpty(cbbKhiDenHan.Text) || string.IsNullOrEmpty(cbbKyHan.Text) || string.IsNullOrEmpty(cbbTraLai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
            else
            {
                try
                {

                    SqlConnection cnn = Kn();
                    string sql2 = "UPDATE TheTietKiem SET NgayGui=@ngayGui, SoTienGui=@soTienGui, LaiSuat=@laiSuat,KhiDenHan=@khiDenHan,TraLai=@traLai,KyHan=@kyHan,LaiKhongKyHan=@laiKhongKyHan,TatToan=@tatToan Where ID ='" + Key + "'";
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sql2, cnn);
                    cmd.Parameters.AddWithValue("@ngayGui", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@soTienGui", txtSoTienGui.Text);
                    cmd.Parameters.AddWithValue("@laiSuat", txtLaiSuat.Text);
                    cmd.Parameters.AddWithValue("@khiDenHan", cbbKhiDenHan.SelectedItem);
                    cmd.Parameters.AddWithValue("@traLai", cbbTraLai.SelectedItem);
                    cmd.Parameters.AddWithValue("@kyHan", cbbKyHan.SelectedItem);
                    cmd.Parameters.AddWithValue("@laiKhongKyHan", txtLKKH.Text);
                    cmd.Parameters.AddWithValue("@tatToan", labTatToan.Text);
                    cmd.ExecuteNonQuery();
                    cnn.Close();

                    DialogResult T;
                    T = MessageBox.Show("Sửa thông tin sổ thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (T == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa thông tin thất bại !");
                }

            }

        }

        private void cbbKhiDenHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhiDenHan.SelectedItem.ToString() == "Tái tục gốc và lãi")
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
    }
}
