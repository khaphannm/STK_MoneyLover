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
    public partial class FrmRut1Phan : Form
    {
        public FrmRut1Phan()
        {
            InitializeComponent();
        }

        private void FrmRut1Phan_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            
        }
        private void txtTienRut_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public SqlConnection Kn()
        {
            return Utilities.getConnect();
        }
        public string GKey { get; set; }


        int t;
        int soTienGui;
        float laiKhongKyHan;
        float laiSuat;
        public bool compareMoney()
        {
            try
            {
                t = int.Parse(txtTienRut.Text);
                SqlConnection cnn = Kn();
                string sql = "SELECT SoTienGui, LaiKhongKyHan, LaiSuat, Email FROM TheTietKiem WHERE ID = '" + GKey + "'";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    soTienGui = int.Parse(dr[0].ToString());
                    laiKhongKyHan = float.Parse(dr[1].ToString());
                    laiSuat = float.Parse(dr[2].ToString());
                    if (t > soTienGui)
                    {
                        return false;
                    }
                }               
            } catch(Exception)
            {
                lblMessage.Text = string.Empty;
                lblMessage.Visible = true;
                lblMessage.ForeColor = Color.Maroon;
                lblMessage.Text = "Vui lòng nhập số tiền cần rút.";
            }
            return true;
        }
        public int getDays()
        {
            DateTime Time1, Time2;
            TimeSpan time;
            SqlConnection cnn = Kn();
            cnn.Open();
            string sql = "SELECT NgayGui FROM TheTietKiem WHERE ID = '" + GKey + "'";
            SqlCommand cm = new SqlCommand(sql, cnn);
            SqlDataReader dr = cm.ExecuteReader(); ;
            int day = 0;
            if (dr.Read())
            {
                Time1 = Convert.ToDateTime(dr[0].ToString());
                int a = Time1.Month;
                Time2 = Convert.ToDateTime(DateTime.Now.ToString());
                time = Time2.Subtract(Time1);
                day = time.Days;
            }
            cnn.Close();
            return day;
        }
        public int gMonth()
        {
            DateTime Time1, Time2;
            TimeSpan time;
            SqlConnection cnn = Kn();
            cnn.Open();
            string sql = "SELECT NgayGui FROM TheTietKiem WHERE ID = '" + GKey + "'";
            SqlCommand cm = new SqlCommand(sql, cnn);
            SqlDataReader dr = cm.ExecuteReader(); ;

            if (dr.Read())
            {
                Time1 = Convert.ToDateTime(dr[0].ToString());
                int a = Time1.Month;
                Time2 = Convert.ToDateTime(DateTime.Now.ToString());
                time = Time2.Subtract(Time1);
                int day = time.Days;
                int thang = day / 30;
                {
                    return thang;
                }
            }
            cnn.Close();
            return 0;
        }
        public string getKyHan()
        {
            string s;
            SqlConnection cnn = Kn();
            string sql = "SELECT KyHan FROM TheTietKiem WHERE ID = '" + GKey + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return s = dr[0].ToString();
            }
            return "";
        }
        public bool true0KyHan()
        {
            if (getKyHan() == "Không kỳ hạn")
                return true;
            return false;
        }
        public int kiemTraKyHan()
        {
            SqlConnection cnn = Kn();
            string sql = "SELECT KyHan FROM TheTietKiem WHERE ID = '" + GKey + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (dr[0].ToString() == "1 tháng")
                {
                    return 1;
                }
                else if (dr[0].ToString() == "3 tháng")
                {
                    return 3;
                }
                else if (dr[0].ToString() == "6 tháng")
                {
                    return 6;
                }
                else if (dr[0].ToString() == "12 tháng")
                {
                    return 12;
                }
            }
            return 0;
        }
        public void Rut(float laiSuat)
        {
            try
            {
                SqlConnection cnn = Kn();
                
                double tienLai = soTienGui * laiSuat / 100 * getDays() / 360;
                string sql2 = "UPDATE TheTietKiem SET SoTienGui=@soTienGui Where ID ='" + GKey + "'";
                string sql3 = "UPDATE TheTietKiem SET TienLai=@tienLai Where ID ='" + GKey + "'";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql2, cnn);
                cmd.Parameters.AddWithValue("@soTienGui", (float)(soTienGui - t));
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(sql3, cnn);
                cmd.Parameters.AddWithValue("@tienLai", (float)tienLai);
                cmd.ExecuteNonQuery();
                cnn.Close();

                DialogResult T;
                T = MessageBox.Show("Rút tiền thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (T == DialogResult.OK)
                {
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Rút tiền không thành công !");
            }
        }
        public void denHan()
        {
            DateTime Time1, Time2;
            TimeSpan time;
            SqlConnection cnn = Kn();
            cnn.Open();
            string sql = "SELECT NgayGui FROM TheTietKiem WHERE ID = '" + GKey + "'";
            SqlCommand cm = new SqlCommand(sql, cnn);
            SqlDataReader dr = cm.ExecuteReader(); ;

            if (dr.Read())
            {
                Time1 = Convert.ToDateTime(dr[0].ToString());
                int a = Time1.Month;
                Time2 = Convert.ToDateTime(DateTime.Now.ToString());
                time = Time2.Subtract(Time1);
                int day = time.Days;

            }
            cnn.Close();
        }
        private void txtTienRut_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FrmRut1Phan_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmDSSTK frm = new FrmDSSTK();
            frm.GEmail = LoginInfo.UserID;
            frm.Show();
        }

        private void FrmRut1Phan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                Owner.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (compareMoney() == true)
            {
                int ngayThucGui = getDays();
                if (true0KyHan() == true)
                {
                    if (ngayThucGui <= 15)
                    {
                        MessageBox.Show("Vui lòng thực hiện sau 15 ngày kể từ ngày gửi !");
                    }
                    else
                    {
                        Rut(laiKhongKyHan);
                    }
                }
                else
                {
                    if (gMonth() < kiemTraKyHan())
                    {
                        var fx = GKey;
                        fmrXN f = new fmrXN() {xKey = fx.ToString(),
                            tienRut = t,
                            ngayThucGui = ngayThucGui,
                            soTienGui = soTienGui,
                            laiKhongKyHan = laiKhongKyHan
                        };
                        f.Show();
                    }
                    else
                    {
                        Rut(laiSuat);
                    }
                }

            }
            else
            {
                MessageBox.Show("Số dư hiện không đủ để thực hiện giao dịch này !");
            }
            Close();
        }
    }
}
