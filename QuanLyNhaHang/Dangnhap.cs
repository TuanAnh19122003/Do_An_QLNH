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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
            /*panelLogin.BackColor = Color.FromArgb(100, 0, 0, 0);*/
        }

        public void getloainv()
        {
            string query = "Select * from LoaiChucVu";
            DataSet ds = kn.laydulieu(query);
            cb_quyen.DataSource = ds.Tables[0];
            cb_quyen.DisplayMember = "TenCV";
            cb_quyen.ValueMember = "MaCV";
        }
        KetNoi kn = new KetNoi();

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            getloainv();
        }

        private void check_mk_CheckedChanged(object sender, EventArgs e)
        {
            if (check_mk.Checked == true)
            {
                txt_Matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Matkhau.UseSystemPasswordChar = true;
            }
        }

        private void but_dangnhap_Click(object sender, EventArgs e)
        {
            if (txt_Taikhoan.Text == "" || txt_Matkhau.Text == "")
            {
                MessageBox.Show("Chưa có tài khoản hoặc mật khẩu");
                return;
            }

            string query = string.Format(
                "select * from Taikhoan where Taikhoan=N'{0}' and Matkhau=N'{1}'",
                txt_Taikhoan.Text,
                txt_Matkhau.Text
            );

            DataSet ds = kn.laydulieu(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                string tentk = ds.Tables[0].Rows[0]["Taikhoan"].ToString();
                // Lấy vai trò từ cơ sở dữ liệu
                string roleFromDatabase = ds.Tables[0].Rows[0]["ChucVu"].ToString();

                // Lấy vai trò từ ComboBox cmb_chucvu
                string selectedRole = cb_quyen.Text;

                // Kiểm tra cả tài khoản và chức vụ
                if (roleFromDatabase == selectedRole)
                {
                    switch (roleFromDatabase)
                    {
                        case "Quan Ly":
                            MessageBox.Show("Đăng nhập thành công - Quản lý");
                            HeThong htQuanLy = new HeThong(tentk, "Quan ly");
                            this.Hide();
                            htQuanLy.ShowDialog();
                            this.Show();
                            break;

                        case "Nhan Vien":
                            MessageBox.Show("Đăng nhập thành công - Nhân viên");
                            HeThong htNhanVien = new HeThong(tentk, "Nhan vien");
                            htNhanVien.AnChucNangChoNhanVien();  // Ẩn chức năng cho nhân viên
                            this.Hide();
                            htNhanVien.ShowDialog();
                            this.Show();
                            break;
                        case "Ca Truong":
                            MessageBox.Show("Đăng nhập thành công - Ca trưởng");
                            HeThong ht = new HeThong(tentk, "Ca Truong");
                            ht.AnChucNangChoCaTruong();  // Ẩn chức năng cho nhân viên
                            this.Hide();
                            ht.ShowDialog();
                            this.Show();
                            break;
                        default:
                            MessageBox.Show("Chọn chức vụ không hợp lệ");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản và chức vụ không khớp");
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void but_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void link_qmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sendcode sc = new sendcode();
            sc.Show();
        }
    }
}
