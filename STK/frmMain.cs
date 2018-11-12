using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STK
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Green;
            frmSigUp f1 = new frmSigUp();
            f1.Show();
            this.Hide();

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
   
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button2.ForeColor = Color.Green;
            FrmLog fs = new FrmLog();
            fs.Show();
            this.Hide();
 

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
    
        }
        
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
 
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult TL;
            TL = MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (TL == DialogResult.Yes)
            {
                Application.Exit();
                //Application.ExitThread();
            }
            
        }
    }
}
