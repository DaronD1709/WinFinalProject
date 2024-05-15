using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtusername.Text = "User Name";
            txtpassword.Text = "Password";
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if ( txtusername.Text == "User Name")
            {
                txtusername.Text = "";
                txtusername.ForeColor = Color.Black;
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "User Name";
                txtusername.ForeColor = Color.LightGray;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "Password")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Black;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "Password";
                txtpassword.ForeColor = Color.LightGray;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }
    }
}
