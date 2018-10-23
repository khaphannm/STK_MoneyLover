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
    public partial class fmrXN : Form
    {
        public fmrXN()
        {
            InitializeComponent();
        }
        public SqlConnection Kn()
        {
            return Utilities.getConnect();
        }
        public string xKey { get; set; }
        public int tienRut { get; set; }
        public int ngayThucGui { get; set; }
        public int soTienGui { get; set; }
        public float laiKhongKyHan { get; set; }

        public int kiemTraKyHan()
        {
            SqlConnection cnn = Kn();
            string sql = "SELECT KyHan FROM TheTietKiem WHERE ID = '" + xKey + "'";
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
        private void fmrXN_Load(object sender, EventArgs e)
        {         
            lbnMaSo.Text = xKey.ToString();
            SqlConnection cnn = Kn();
            cnn.Open();
            string s = "SELECT NgayGui,KyHan,MaSo From TheTietKiem WHERE ID = '" + lbnMaSo.Text + "'";
            SqlCommand cmd = new SqlCommand(s, cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblSoTK.Text = dr[2].ToString();
                lblKoKyHan.Text = laiKhongKyHan.ToString();
                DateTime t1 = Convert.ToDateTime(dr[0].ToString());
                int ngaydh = int.Parse(t1.Day.ToString());
                int thangdh = int.Parse(t1.Month.ToString());
                int namdh = int.Parse(t1.Year.ToString());


                int kh = kiemTraKyHan();
                int thangToiHan = thangdh + kh;
                if (thangToiHan > 12)
                {
                    thangdh = thangToiHan - 12;
                    namdh += 1;

                    txtNgay.Text = ngaydh.ToString();
                    txtThang.Text = thangdh.ToString();
                    txtNam.Text = namdh.ToString();
                }
                else
                {
                    thangdh = thangToiHan;

                    txtNgay.Text = ngaydh.ToString();
                    txtThang.Text = thangToiHan.ToString();
                    txtNam.Text = namdh.ToString();

                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }
        void RutTruocKyHan()
        {
            try
            {
                SqlConnection cnn = Kn();
                //double tienNhan = Math.Round(tienRut + (soTienGui * laiKhongKyHan / 100 * ngayThucGui / 360),1);
                string sql2 = "UPDATE TheTietKiem SET SoTienGui=@tienSauKhiRut Where ID ='" + lbnMaSo.Text + "'";
                cnn.Open();
                SqlCommand cmd = new SqlCommand(sql2, cnn);
                cmd.Parameters.AddWithValue("@tienSauKhiRut", (float)tienRut);
                cmd.ExecuteNonQuery();
                cnn.Close();

                DialogResult T;
                T = MessageBox.Show("Rút tiền thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (T == DialogResult.OK)
                {
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lblAccept_Click(object sender, EventArgs e)
        {
            RutTruocKyHan();
        }
    }
}
