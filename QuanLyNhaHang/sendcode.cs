using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
namespace QuanLyNhaHang
{
    public partial class sendcode : Form
    {
        string OTPCode;
        public static string to;
        public sendcode()
        {
            InitializeComponent();
        }

        private void but_sendotp_Click(object sender, EventArgs e)
        {
            string accountSid = "AC8b8e1ce996f55bc6d728015225c0d3af";
            string authToken = "0c013ca37bcfd22ecccd139873fa791a";
            string twilioPhoneNumber = "+12565734856"; // Số điện thoại Twilio

            string phoneNumber = "+840963965942"; // Số điện thoại người nhận

            Random random = new Random();
            OTPCode = (random.Next(999999)).ToString();

            TwilioClient.Init(accountSid, authToken);

            try
            {
                // Gửi mã OTP qua SMS
                var message = MessageResource.Create(
                    body: "Your Reset OTP code is " + OTPCode,
                    from: new PhoneNumber(twilioPhoneNumber),
                    to: new PhoneNumber(phoneNumber)
                );

                MessageBox.Show("Mã OTP đã được gửi thành công qua SMS!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void but_xacminh_Click(object sender, EventArgs e)
        {
            if (OTPCode == txt_otp.Text)
            {
                to = txt_sdt.Text;

                // Tạo thể hiện của form đổi mật khẩu
                Forgot_Password changePasswordForm = new Forgot_Password();

                // Hiển thị form đổi mật khẩu
                changePasswordForm.Show();

                // Ẩn form hiện tại (form xác minh mã OTP)
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mã OTP không chính xác.");
            }
        }
    }
}
