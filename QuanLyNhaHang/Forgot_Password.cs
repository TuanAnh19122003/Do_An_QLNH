using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void clear()
        {
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            txtRe_pass.Text = "";
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "" || txtMatkhau.Text == "" || txtRe_pass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản hoặc mật khẩu");
            }else if (txtMatkhau.Text == txtRe_pass.Text)
            {
                string query = string.Format("update Taikhoan set Matkhau=N'{1}' where Taikhoan=N'{0}'",
                txtTaikhoan.Text,
                txtMatkhau.Text
                );
                DataSet ds = kn.laydulieu(query);
                bool kt = kn.thucthi(query);
                if (kt == true)
                {
                    MessageBox.Show("Lấy lại mật khẩu thành công");
                    clear();
                }
                else
                {
                    MessageBox.Show("Lấy mật khẩu thất bại");
                }

            }
        }

        private void check_mk_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mk.Checked == true)
            {
                txtMatkhau.UseSystemPasswordChar = false;
                txtRe_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatkhau.UseSystemPasswordChar = true;
                txtRe_pass.UseSystemPasswordChar = true;
            }
        }
    }
}
