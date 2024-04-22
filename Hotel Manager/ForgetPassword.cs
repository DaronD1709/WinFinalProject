using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Manager
{
    public partial class ForgetPassword : Form
    {
        private string codeOtp1;
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private string GenarateOTP()
        {
            Random rd = new Random();
            string otp = rd.Next(0, 999999).ToString("D6");
            return otp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textMail = txtmail.Text;
            if (checkEmail(textMail))
            {
                New_Users form = new New_Users();
                codeOtp1 = GenarateOTP();
                form.SendOtpEmail(textMail, codeOtp1);
            }
            else
            {
                MessageBox.Show("Email chưa được đăng kí!", "OTP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private bool checkEmail(string email)
        {


            int rowCounts = 0;
            try
            {
                // Sử dụng SqlParameter để tránh SQL Injection
                string query = "SELECT * FROM log_in WHERE mail = @email";
                using (SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Thiết lập tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@email", email);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    con.Open();
                    adapter.Fill(table); // Điền dữ liệu vào table

                    rowCounts = table.Rows.Count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowCounts > 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string codeOtp = txtcode.Text;
            if (codeOtp.Equals(codeOtp1))
            {
                ChangePassWord changePassWord = new ChangePassWord(txtmail.Text);
                changePassWord.Show();
            }
            else
            {
                MessageBox.Show("Mã OTP không chính xác", "OTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
