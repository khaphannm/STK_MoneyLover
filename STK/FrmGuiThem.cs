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
    public partial class FrmGuiThem : Form
    {
        public FrmGuiThem()
        {
            InitializeComponent();
        }
        public SqlConnection Kn()
        {
            return Utilities.getConnect();
        }
        public string Key { get; set; }

        private void FrmGuiThem_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }
        int a,b;
        
        private void bthDongY_Click(object sender, EventArgs e)
        {
            int t = int.Parse(textBox1.Text.ToString());
            if(t < 100000)
            {
                MessageBox.Show("Số tiền tối thiểu phải trên 100.000 VND.");
            }
            else
            { 
                try
                {
                    SqlConnection cnn = Kn();
                    string sql1 = "SELECT SoTienGui FROM TheTietKiem WHERE ID ='" + Key + "'";
                    cnn.Open();
                    SqlCommand com = new SqlCommand(sql1, cnn);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        a = int.Parse(dr[0].ToString());
                        b = a + int.Parse(textBox1.Text);                     
                    }
                    cnn.Close();
                        
                    string sql2 = "UPDATE TheTietKiem SET SoTienGui=@soTienGui Where ID ='" + Key + "'";
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand(sql2, cnn);
                    cmd.Parameters.AddWithValue("@soTienGui", float.Parse(b.ToString()));

                    cmd.ExecuteNonQuery();
                    cnn.Close();

                    DialogResult T;
                    T = MessageBox.Show("Thêm tiền thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (T == DialogResult.OK)
                    {
                        Close();
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa thông tin thất bại !");
                }

            }

        }

        private void FrmGuiThem_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                Owner.Hide();
        }

        private void FrmGuiThem_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmDSSTK frm = new FrmDSSTK();
            frm.GEmail = LoginInfo.UserID;
            frm.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
