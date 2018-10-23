using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace STK
{
    public partial class FrmSig : Form
    {
        public FrmSig()
        {
            InitializeComponent();
        }
        public SqlConnection Kn()
        {
            return Utilities.getConnect();
        }
        private void hide_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            view.Visible = true;
            hide.Visible = false;
        }

        private void view_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
            view.Visible = false;
            hide.Visible = true;
        }

        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        int lp;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            string t = textBox1.ToString();
            if (isEmail(t) == false)
            {
                DialogResult X;
                X = MessageBox.Show("Nhập sai định dạng email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string pass = textBox2.Text;

                for (int i = 0; i <= pass.Length; i++)
                {
                    lp = i;
                }
                if (lp < 8)
                {
                    DialogResult X;
                    X = MessageBox.Show("Mật khẩu tối thiểu có 8 ký tự !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection cnn = Kn();
                    string sql1 = "SELECT ID , MK FROM TaiKhoan WHERE ID ='" + textBox1.Text + "' and MK = '" + textBox2.Text + "' ";
                    cnn.Open();
                    SqlCommand com = new SqlCommand(sql1, cnn);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        cnn.Close();
                        Hide();
                        FrmDSSTK ds = new FrmDSSTK();
                        LoginInfo.UserID = textBox1.Text;
                        ds.GEmail = LoginInfo.UserID;
                        ds.Show();
                    }
                    else
                    {
                        cnn.Close();
                        MessageBox.Show("Tài khoản không tồn tại");
                    }
                }
            }
        
        }

        private void FrmSig_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void FrmSig_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void FrmSig_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
            Hide();
        }
    }
}
