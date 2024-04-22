using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Net.WebRequestMethods;

namespace Hotel_Manager
{

    public partial class New_Users : Form
    {

        private int rowsAffected = 0;
        public string code_otp;
        public New_Users()
        {
            InitializeComponent();
        }

        public void SendOtpEmail(string recipientEmail, string otp)
        {
            string send_from = "huudanhnguyen1709@gmail.com";
            string send_password = "Danhnguyenoneforall";
            MailMessage mail = new MailMessage();
            mail.To.Add(recipientEmail);
            mail.From = new MailAddress(send_from);
            mail.Subject = "Mã Xác Thực OTP";
            mail.Body = $"Mã OTP của bạn là: {otp}. Vui lòng sử dụng mã này để hoàn tất quá trình đăng ký.";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true; // Bật mã hóa SSL
            smtp.Port = 587; // Sử dụng cổng cho TLS/STARTTLS
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(send_from, send_password);

            try
            {
                MessageBox.Show("Vui lòng xác thực mã OTP gửi tới gmail của bạn");
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi email: " + ex.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string userName = txtnewusername.Text;
            string gmail = txtnewmail.Text;
            string passWord = txtnewpass.Text;
            if (userName.Length == 0)
            {
                MessageBox.Show("Bạn vui lòng nhập tên tài khoản");
                return;
            }

            if (check_LengthUser(userName) == false)
            {
                MessageBox.Show("Tên User tối đa có 6 kí tự!");
                return;
            }


            if (passWord.Length == 0)
            {
                MessageBox.Show("Bạn vui lòng nhập mật khẩu!");
                return;
            }

            if (CheckPasswordValidity(passWord) == false)
            {
                MessageBox.Show("Password bao gồm ít 1 kí tự đặc biệt, 1 kí tự số, 1 kí tự viết hoa, 1 kí tự viết thường và không được 2 kí tự liền kề giống nhau!!!");
                return;
            }
            string confirmPassword = txtnewrepass.Text;
            if (confirmPassword.Length == 0)
            {
                MessageBox.Show("Bạn vui lòng nhập mật khẩu nhập lại!");
                return;
            }
            if (CheckUserNameExists(userName))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại!");
                return;
            }

            if (passWord != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp!");
                return;
            }

            // Kiểm tra xem truy vấn có thành công không
            OTP Otp = new OTP(this, userName, passWord, gmail);
            code_otp = Otp.GenarateOTP();
            SendOtpEmail(gmail, code_otp);
            Otp.Show();
        }


        private bool check_LengthUser(String nameUser)
        {
            if (nameUser.Length >= 6)
            {
                return true;
            }
            return false;
        }


        private bool CheckPasswordValidity(string password)
        {
            bool hasSpecial = false;
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;
            char previousChar = '\0'; // Sử dụng ký tự null để đảm bảo so sánh đầu tiên không bị sai

            foreach (char currentChar in password)
            {
                // Kiểm tra xem có ký tự trùng lặp liên tiếp không
                if (currentChar == previousChar)
                {
                    return false;
                }
                previousChar = currentChar;

                if (char.IsUpper(currentChar))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(currentChar))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(currentChar))
                {
                    hasDigit = true;
                }
                else if (!char.IsLetterOrDigit(currentChar))
                {
                    hasSpecial = true;
                }
            }
            // Kiểm tra xem mật khẩu có đáp ứng tất cả các yêu cầu không
            return hasSpecial && hasDigit && hasLower && hasUpper;
        }


        private bool CheckUserNameExists(string username)
        {
            bool exists = false; // Biến để lưu trạng thái kiểm tra

            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo truy vấn SQL để kiểm tra tên người dùng
                    string query = "SELECT COUNT(*) FROM log_in WHERE username = @UserName";

                    // Tạo đối tượng SqlCommand để thực thi truy vấn
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho truy vấn
                        command.Parameters.AddWithValue("@UserName", username);

                        // Thực thi truy vấn và kiểm tra kết quả
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        if (count > 0)
                        {
                            // Tên người dùng đã tồn tại trong cơ sở dữ liệu
                            exists = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi xảy ra
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            // Trả về kết quả kiểm tra
            return exists;
        }



        public void AddUserAccount(string username, string password, string mail)
        {
            // Chuỗi kết nối tới cơ sở dữ liệu
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hotel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo truy vấn SQL để kiểm tra tên người dùng
                    string query = "INSERT INTO log_in (username, password, mail) VALUES  (@UserName, @Pass, @gmail)";

                    // Tạo đối tượng SqlCommand để thực thi truy vấn
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số
                        command.Parameters.AddWithValue("@UserName", username);
                        command.Parameters.AddWithValue("@Pass", password);
                        command.Parameters.AddWithValue("@gmail", mail);

                        rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // MessageBox.Show("Register add succseccfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Register add uncuessfully", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi xảy ra
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }
        }


    }
}
