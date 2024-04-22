using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Manager
{
    public partial class OTP : Form
    {
        private New_Users parentForm;
        private string userName;
        private string passWord;
        private string gmail;
        public OTP(New_Users form, string userName, string passWord, string gmail)
        {
            InitializeComponent();
            this.parentForm = form;
            this.userName = userName;
            this.passWord = passWord;
            this.gmail = gmail;
        }

        public string GenarateOTP()
        {
            Random rd = new Random();
            string otp = rd.Next(0, 999999).ToString("D6");
            return otp;
        }
        private void btnOTP_Click(object sender, EventArgs e)
        {
            New_Users form = new New_Users();
            string code_otp = parentForm.code_otp;
            string otp = txtOTP.Text;
            if (code_otp.Equals(otp))
            {
                form.AddUserAccount(userName, passWord, gmail);
                MessageBox.Show("User registered successfully");
                this.Close();
                parentForm.Hide();
                Form1 loginForm = new Form1();
                loginForm.Hide();
            }
            else
            {
                MessageBox.Show("Mã OTP không chính xác", "OTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
