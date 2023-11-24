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
    public partial class Dangki : Form
    {
        KetNoi kn = new KetNoi();
        private string maxacnhan_hien;
        public Dangki()
        {
            InitializeComponent();
        }
        public void getChucvu()
        {
            string query = "Select * from LoaiChucVu";
            DataSet ds = kn.laydulieu(query);
            cmbChucvu.DataSource = ds.Tables[0];
            cmbChucvu.DisplayMember = "TenCV";
            cmbChucvu.ValueMember = "TenCV";
        }
        public void clear()
        {
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            txtRe_pass.Text = "";
            txtNgDung.Text = "";
        }
        private void MaXacnhan_Random()
        {
            // Tạo mã xác nhận ngẫu nhiên (ở đây là 6 chữ số)
            Random random = new Random();
            maxacnhan_hien = random.Next(100000, 999999).ToString();
        }
        private void btnDangki_Click(object sender, EventArgs e)
        {
            string Code = txtMaXacnhan.Text.Trim();
            if (txtTaikhoan.Text==""||txtMatkhau.Text==""||txtRe_pass.Text==""|| txtNgDung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else if(txtMatkhau.Text != txtRe_pass.Text)
            {
                MessageBox.Show("Mật khẩu không giống nhau");
            }
            else if(Code == maxacnhan_hien)
            {
                string checkQuery = string.Format("SELECT COUNT(*) FROM Taikhoan WHERE Taikhoan = N'{0}'", txtTaikhoan.Text);
                int existingRecords = (int)kn.laydulieu(checkQuery).Tables[0].Rows[0][0];
                string query = string.Format("insert into Taikhoan values ('{0}','{1}','{2}','{3}')",
                    txtTaikhoan.Text,
                    txtMatkhau.Text,
                    txtNgDung.Text,
                    cmbChucvu.SelectedValue
                        );
                if (existingRecords > 0)
                {
                    // Tài khoản đã tồn tại, hiển thị thông báo lỗi
                    MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn tài khoản khác.");
                }
                else
                {
                    DataSet ds = kn.laydulieu(query);
                    bool kt = kn.thucthi(query);
                    if (kt == true)
                    {
                        MessageBox.Show("Đăng kí thành công");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng.Vui lòng nhập lại");
                MaXacnhan_Random();
                lbGatcha.Text = "Mã xác nhận của bạn là " + maxacnhan_hien;
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát form đăng kí ? ","Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Dangki_Load(object sender, EventArgs e)
        {
            getChucvu();
            MaXacnhan_Random();
            lbGatcha.Text = "Mã xác nhận của bạn là " + maxacnhan_hien;
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
