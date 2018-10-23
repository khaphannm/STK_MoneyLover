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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public SqlConnection Kn()
        {
            return Utilities.getConnect();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
          
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
            this.Hide();           
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmSig f = new FrmSig();
            f.Show();
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

        bool ValidatePassword(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (hasNumber.IsMatch(password) && hasLowerChar.IsMatch(password) && hasSymbols.IsMatch(password))
                return true;

            return false;
        }
        public bool kiemTraTrung()
        {
            SqlConnection cnn = Kn();
            bool kq = false;
            string chuoi = textBox1.Text;
            string sql1 = "SELECT ID FROM TaiKhoan ";
            cnn.Open();
            SqlCommand com = new SqlCommand(sql1, cnn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (chuoi==dr.GetString(0))
                {
                    kq = true;
                    break;
                }
            }
            cnn.Close();
            return kq;
        }
        int lp;
        private void button1_Click(object sender, EventArgs e)
        {
            string t = textBox1.ToString();
            if (isEmail(t) == false)
            {
                DialogResult X;
                X = MessageBox.Show("Nhập sai định dạng email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (kiemTraTrung()==true)
            {
                DialogResult X;
                X = MessageBox.Show("Email đã tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else if (!ValidatePassword(pass))
                {
                    MessageBox.Show("Nhập sai định dạng mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                { 
                    SqlConnection cnn = Kn();
                    SqlCommand cmd;
                    cmd = new SqlCommand("Insert Into TaiKhoan(ID,MK) values(@ID,@MK)", cnn);
                    cnn.Open();
                    cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@MK", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Tạo tài khoản thành công !","Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();

                    FrmDSSTK ds = new FrmDSSTK();
                    ds.GEmail = textBox1.Text;
                    ds.Show();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
            view.Visible = false;
            hide.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            view.Visible = true;
            hide.Visible = false;
        }


    }
}
