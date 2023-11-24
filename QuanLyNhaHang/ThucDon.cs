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
    public partial class ThucDon : Form
    {
        KetNoi kn = new KetNoi();
        public ThucDon()
        {
            InitializeComponent();
        }
        public void getdataTD()
        {
            string query = "select *from MonAn";
            DataSet ds = kn.laydulieu(query);
            dgvThucDon.DataSource = ds.Tables[0];
        }
        public void getdataBan()
        {
            string query = "select * from Ban";
            DataSet ds = kn.laydulieu(query);
            dgvBan.DataSource = ds.Tables[0];
        }
        public void clearBan()
        {
            btnThemBan.Enabled = true;
            btnSuaBan.Enabled = false;
            btnXoaBan.Enabled = false;

            txtIDBan.Text = "";
            txtTenban.Text = "";
            txtTrangthai.Text = "";
        }
        public void clearTD()
        {
            btnThemTD.Enabled = true;
            btnSuaTD.Enabled = false;
            btnXoaTD.Enabled = false;

            txtID.Text = "";
            txtTenMon.Text = "";
            txtDVT.Text = "";
            txtGiaTien.Text = "";
        }
        private void ThucDon_Load(object sender, EventArgs e)
        {
            getdataTD();
            txtID.Enabled = false;
            getdataBan();
            txtIDBan.Enabled = false;
        }

        private void btnThemTD_Click(object sender, EventArgs e)
        {
            string checkQuery = string.Format("SELECT COUNT(*) FROM MonAn WHERE TenMonan = N'{0}'", txtTenMon.Text);
            int existingRecords = (int)kn.laydulieu(checkQuery).Tables[0].Rows[0][0];
            string query = string.Format("insert into MonAn values (N'{0}','{1}','{2}')",
                txtTenMon.Text,
                txtDVT.Text,
                txtGiaTien.Text
                );
            if (existingRecords > 0)
            {
                MessageBox.Show("Món ăn đã tồn tại. Vui lòng nhập món ăn khác.");
            }
            else
            {
                DataSet ds = kn.laydulieu(query);
                bool kt = kn.thucthi(query);
                if (kt == true)
                {
                    MessageBox.Show("Thêm thành công");
                    btnResetTD.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnResetTD_Click(object sender, EventArgs e)
        {
            clearTD();
            getdataTD();
        }

        private void dgvThucDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                btnThemTD.Enabled = false;
                btnXoaTD.Enabled = true;
                btnSuaTD.Enabled = true;

                txtID.Text = dgvThucDon.Rows[r].Cells["IDMonAn"].Value.ToString();
                txtTenMon.Text = dgvThucDon.Rows[r].Cells["TenMonan"].Value.ToString();
                txtDVT.Text = dgvThucDon.Rows[r].Cells["Donvitinh"].Value.ToString();
                txtGiaTien.Text = dgvThucDon.Rows[r].Cells["Giatien"].Value.ToString();
            }
        }

        private void btnSuaTD_Click(object sender, EventArgs e)
        {
            string query = string.Format("update MonAn set TenMonan=N'{1}' , Donvitinh=N'{2}',Giatien=N'{3}' where IDMonAn=N'{0}'",
                txtID.Text,
                txtTenMon.Text,
                txtDVT.Text,
                txtGiaTien.Text
                );
            DataSet ds = kn.laydulieu(query);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Sửa thành công");
                btnResetTD.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoaTD_Click(object sender, EventArgs e)
        {
            string query = string.Format("Delete From MonAn where IDMonAn='{0}'",
                txtID.Text,
                txtTenMon.Text,
                txtDVT.Text,
                txtGiaTien.Text
                );
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataSet ds = kn.laydulieu(query);
                bool kt = kn.thucthi(query);
                if (kt==true)
                {
                    MessageBox.Show("Xóa thành công");
                    btnResetTD.PerformClick();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnTimTD_Click(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM MonAn WHERE IDMonAn LIKE '%{0}%' OR TenMonan LIKE '%{0}%' OR Donvitinh LIKE '%{0}%' OR Giatien LIKE '%{0}%'",
                txtTim.Text
            );
            DataSet ds = kn.laydulieu(query);
            dgvThucDon.DataSource = ds.Tables[0];
        }

        private void tabChinh_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnTimTD_Click(sender, e);
                btnTim_Click(sender, e);
            }
        }

        private void txtTim_Enter(object sender, EventArgs e)
        {
            string query = string.Format("SELECT * FROM MonAn WHERE IDMonAn LIKE '%{0}%' OR TenMonan LIKE '%{0}%' OR Donvitinh LIKE '%{0}%' OR Giatien LIKE '%{0}%'",
                    txtTim.Text
                );
            DataSet ds = kn.laydulieu(query);
            dgvThucDon.DataSource = ds.Tables[0];
        }


        //----------------------CHỨC NĂNG CỦA QUẢN LÝ BÀN----------------------
        private void btnResetBan_Click(object sender, EventArgs e)
        {
            getdataBan();
            clearBan();
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                btnThemBan.Enabled = false;
                btnXoaBan.Enabled = true;
                btnSuaBan.Enabled = true;

                txtIDBan.Text = dgvBan.Rows[r].Cells["IDBan"].Value.ToString();
                txtTenban.Text = dgvBan.Rows[r].Cells["TenBan"].Value.ToString();
                txtTrangthai.Text = dgvBan.Rows[r].Cells["TrangThai"].Value.ToString();
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            string checkQuery = string.Format("select count (*) from Ban where TenBan = N'{0}'", txtTenban.Text);
            int existingRecords = (int)kn.laydulieu(checkQuery).Tables[0].Rows[0][0];
            string query = string.Format("insert into Ban values('{0}','{1}')",
                txtTenban.Text,
                txtTrangthai.Text
                );
            if (existingRecords > 0)
            {
                MessageBox.Show("Bàn đã tồn tại. Vui lòng nhập tên bàn khác.");
            }
            else
            {
                DataSet ds = kn.laydulieu(query);
                bool kt = kn.thucthi(query);
                if (kt == true)
                {
                    MessageBox.Show("Thêm thành công");
                    btnResetBan.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            string query = string.Format("update Ban set TenBan = N'{1}',TrangThai = N'{2}' where IDBan = N'{0}'",
                txtIDBan.Text,
                txtTenban.Text,
                txtTrangthai.Text
                );
            DataSet ds = kn.laydulieu(query);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Sửa thành công");
                btnResetBan.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            string query = string.Format("Delete Ban where IDBan = N'{0}'",
                txtIDBan.Text,
                txtTenban.Text,
                txtTrangthai.Text
                );
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataSet ds = kn.laydulieu(query);
                bool kt = kn.thucthi(query);
                if (kt == true)
                {
                    MessageBox.Show("Xóa thành công");
                    btnResetBan.PerformClick();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from Ban where IDBan like N'%{0}%' or TenBan like N'%{0}%' or TrangThai like N'%{0}%'",
                txtTimban.Text
            );
            DataSet ds = kn.laydulieu(query);
            dgvBan.DataSource = ds.Tables[0];
        }
    }
}
