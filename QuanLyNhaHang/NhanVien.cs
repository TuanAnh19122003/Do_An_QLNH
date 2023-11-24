using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QuanLyNhaHang
{
    public partial class NhanVien : Form
    {
        KetNoi kn = new KetNoi();
        public NhanVien()
        {
            InitializeComponent();
        }
        public void getdataNV()
        {
            string query = "select * from NhanVien ";
            DataSet ds = kn.laydulieu(query);
            dgvNhanVien.DataSource = ds.Tables[0];
        }
        public void getdataTK()
        {
            string query = "select * from Taikhoan";
            DataSet ds = kn.laydulieu(query);
            dgvTK.DataSource = ds.Tables[0];
        }
        public void getChucVu()
        {
            string query = "Select * from LoaiChucVu";
            DataSet ds = kn.laydulieu(query);
            cmbChucVu.DataSource = ds.Tables[0];
            cmbChucVu.DisplayMember = "TenCV";
            cmbChucVu.ValueMember = "TenCV";
        }
        public void getChucVuNV()
        {
            string query = "Select * from LoaiChucVu";
            DataSet ds = kn.laydulieu(query);
            cmbCV.DataSource = ds.Tables[0];
            cmbCV.DisplayMember = "TenCV"; 
            cmbCV.ValueMember = "MaCV";  
        }
        public void getUser()
        {
            string query = "Select * from NhanVien";
            DataSet ds = kn.laydulieu(query);
            cmbChuSoHuu.DataSource = ds.Tables[0];
            cmbChuSoHuu.DisplayMember = "TenNV";
            cmbChuSoHuu.ValueMember = "TenNV";
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            getdataNV();
            getdataTK();
            getChucVu();
            getChucVuNV();
            getUser();
            txtID.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string checkQuery = string.Format("SELECT COUNT(*) FROM NhanVien WHERE MaNV = N'{0}'", txtMaNV.Text);
            int existingRecords = (int)kn.laydulieu(checkQuery).Tables[0].Rows[0][0];
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
                cmbCV.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                (Nam.Checked == false && Nu.Checked == false) ||
                string.IsNullOrWhiteSpace(txtSDT.Text) ||
                string.IsNullOrWhiteSpace(rtbDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtCCCD.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return; // Dừng thực hiện khi chưa nhập đủ thông tin
            }
            
            string GioiTinh = Nam.Checked ? "Nam" : (Nu.Checked ? "Nữ" : "");
            string query = string.Format("insert into NhanVien values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}')",
                txtMaNV.Text,
                cmbCV.SelectedValue,
                txtTenNV.Text,
                GioiTinh,
                dtpNgSinh.Value.ToString("yyyy/MM/dd"),
                txtSDT.Text,
                rtbDiaChi.Text,
                txtCCCD.Text,
                txtEmail.Text
                    );
            if (existingRecords > 0)
            {
                // Mã nhân viên đã tồn tại, hiển thị thông báo lỗi
                MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã nhân viên khác.");
            }
            else
            {
                DataSet ds = kn.laydulieu(query);
                bool kt = kn.thucthi(query);
                if (kt == true)
                {
                    MessageBox.Show("Thêm thành công");
                    btn_reset.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
        public void clearNV()
        {
            txtMaNV.Enabled = true;
            btn_them.Enabled = true;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;

            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtCCCD.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            rtbDiaChi.Text = "";
            dtpNgSinh.Value = DateTime.Now;
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            clearNV();
            getdataNV();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaNV.Enabled = false;
                btn_them.Enabled = false;
                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;

                txtMaNV.Text = dgvNhanVien.Rows[r].Cells["MaNV"].Value.ToString();
                cmbCV.SelectedValue = dgvNhanVien.Rows[r].Cells["MaCV"].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[r].Cells["TenNV"].Value.ToString();
                txtSDT.Text = dgvNhanVien.Rows[r].Cells["SDT"].Value.ToString();
                txtEmail.Text = dgvNhanVien.Rows[r].Cells["Email"].Value.ToString();
                txtCCCD.Text = dgvNhanVien.Rows[r].Cells["CCCD"].Value.ToString();
                dtpNgSinh.Text = dgvNhanVien.Rows[r].Cells["NgaySinh"].Value.ToString();
                rtbDiaChi.Text = dgvNhanVien.Rows[r].Cells["Diachi"].Value.ToString();
                string gioiTinhValue = dgvNhanVien.Rows[r].Cells["GioiTinh"].Value.ToString();
                if (gioiTinhValue == "Nam")
                {
                    // Đặt RadioButton "Nam" (assumed radio button name)
                    Nam.Checked = true;
                    Nu.Checked = false;
                }
                else if (gioiTinhValue == "Nữ")
                {
                    // Đặt RadioButton "Nữ" (assumed radio button name)
                    Nam.Checked = false;
                    Nu.Checked = true;
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string GioiTinh = Nam.Checked ? "Nam" : (Nu.Checked ? "Nữ" : "");
            string query = string.Format("update NhanVien set TenNV=N'{2}',MaCV=N'{1}',GioiTinh=N'{3}',NgaySinh=N'{4}',SDT=N'{5}',DiaChi=N'{6}',CCCD=N'{7}',Email=N'{8}' where MaNV=N'{0}'",
                txtMaNV.Text,
                cmbCV.SelectedValue,
                txtTenNV.Text,
                GioiTinh,
                dtpNgSinh.Value.ToString("yyyy/MM/dd"),
                txtSDT.Text,
                rtbDiaChi.Text,
                txtCCCD.Text,
                txtEmail.Text
                );
            DataSet ds = kn.laydulieu(query);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Sửa thành công");
                btn_reset.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string GioiTinh = Nam.Checked ? "Nam" : (Nu.Checked ? "Nữ" : "");
            string query = string.Format("delete from NhanVien where MaNV=N'{0}'",
                txtMaNV.Text,
                cmbCV.SelectedValue,
                txtTenNV.Text,
                GioiTinh,
                dtpNgSinh.Value.ToString("yyyy/MM/dd"),
                txtSDT.Text,
                rtbDiaChi.Text,
                txtCCCD.Text,
                txtEmail.Text
                );
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataSet ds = kn.laydulieu(query);
                bool kt = kn.thucthi(query);

                if (kt==true)
                {
                    MessageBox.Show("Xóa thành công");
                    btn_reset.PerformClick();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM NhanVien WHERE " +
                "MaNV LIKE N'%{0}%' OR " +
                "MaCV LIKE N'%{0}%' OR " +
                "TenNV LIKE N'%{0}%' OR " +
                "GioiTinh LIKE N'%{0}%' OR " +
                "NgaySinh LIKE N'%{0}%' OR " +
                "SDT LIKE N'%{0}%' OR " +
                "DiaChi LIKE N'%{0}%' OR " +
                "CCCD LIKE N'%{0}%' OR " +
                "Email LIKE N'%{0}%'",
                txtTimKiem.Text
                );
            DataSet ds = kn.laydulieu(query);
            dgvNhanVien.DataSource = ds.Tables[0];
        }

        //Quản lý tài khoản
        public void clearTK()
        {
            txtID.Enabled = false;
            btnThemTK.Enabled = true;
            btnSuaTK.Enabled = false;
            btnXoaTK.Enabled = false;

            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            txtID.Text = "";
        }

        private void btnResetTK_Click(object sender, EventArgs e)
        {
            clearTK();
            getdataTK();
        }

        private void dgvTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                btnThemTK.Enabled = false;
                btnXoaTK.Enabled = true;
                btnSuaTK.Enabled = true;

                txtID.Text = dgvTK.Rows[r].Cells["ID"].Value.ToString();
                txtTaikhoan.Text = dgvTK.Rows[r].Cells["Taikhoan"].Value.ToString();
                txtMatkhau.Text = dgvTK.Rows[r].Cells["Matkhau"].Value.ToString();
                cmbChuSoHuu.SelectedValue = dgvTK.Rows[r].Cells["ChuSoHuu"].Value.ToString();
                cmbChucVu.SelectedValue = dgvTK.Rows[r].Cells["ChucVu"].Value.ToString();
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            string checkQuery = string.Format("SELECT COUNT(*) FROM Taikhoan WHERE Taikhoan = N'{0}'", txtTaikhoan.Text);
            int existingRecords = (int)kn.laydulieu(checkQuery).Tables[0].Rows[0][0];
            string query = string.Format("insert into Taikhoan values ('{0}','{1}','{2}','{3}')",
                txtTaikhoan.Text,
                txtMatkhau.Text,
                cmbChuSoHuu.SelectedValue,
                cmbChucVu.SelectedValue
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
                    MessageBox.Show("Thêm thành công");
                    btnResetTK.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            string query = string.Format("UPDATE Taikhoan SET Taikhoan=N'{1}', Matkhau=N'{2}', ChuSoHuu=N'{3}', ChucVu=N'{4}' WHERE ID=N'{0}'",
                txtID.Text,
                txtTaikhoan.Text,
                txtMatkhau.Text,
                cmbChuSoHuu.SelectedValue,
                cmbChucVu.SelectedValue
                ) ;
            DataSet ds = kn.laydulieu(query);
            bool kt = kn.thucthi(query);

            if (kt == true)
            {
                MessageBox.Show("Sửa thành công");
                btnResetTK.PerformClick();
            }
            else 
            {
                MessageBox.Show("Sửa thất bại");
            }

        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            string query = string.Format("Delete from Taikhoan where ID=N'{0}'",
                txtID.Text,
                txtTaikhoan.Text,
                txtMatkhau.Text,
                cmbChuSoHuu.SelectedValue,
                cmbChucVu.SelectedValue
                );
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataSet ds = kn.laydulieu(query);
                bool kt = kn.thucthi(query);
                if (kt==true)
                {
                    MessageBox.Show("Xóa thành công");
                    btnResetTK.PerformClick();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }

        }

        private void btnTimkiemTK_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from Taikhoan where ID Like N'%{0}%' or Taikhoan like N'%{0}%' or Matkhau like N'%{0}%' or ChuSoHuu like '%{0}%' or ChucVu like '%{0}%'",
                txttimkiemTK.Text
                );
            DataSet ds = kn.laydulieu(query);
            dgvTK.DataSource = ds.Tables[0];
        }
    }
}
