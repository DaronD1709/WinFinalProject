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
        private string userName;
        private string passWord;
        private string gmail;
        public OTP( string userName, string passWord, string gmail)
        {
            InitializeComponent();
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

           
        }
    }
}
