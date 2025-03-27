using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_Mềm_Dinh_Dưỡng
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "Nam" && txtPassword.Text == "123")
            {
                labelError.Visible = false;
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
            /*if (txtUserName.Text == "your_user_name" && txtPassword.Text == "your_password")
            {
                new Form_Quản_Lý_Chung.FormTrangChu().Show();
                this.Hide();


            }

            else
            {
                MessageBox.Show(" Tên đăng nhập hoặc mật khẩu không đúng, thử lại !");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
