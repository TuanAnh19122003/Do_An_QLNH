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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        private int maBan;
        private string tinhTrang;
        private DateTime ngayThanhToan;
        private double tongTien;
        /*private string maNhanVien;*/

        public HoaDon(string tenBanHienTai, int maBan ,string tinhTrang, DateTime ngayThanhToan, double tongTien /*string maNhanVien*/)
        {
            InitializeComponent();
            this.maBan = maBan;
            this.tinhTrang = tinhTrang;
            this.ngayThanhToan = ngayThanhToan;
            this.tongTien = tongTien;
            /*this.maNhanVien = maNhanVien;*/

            // Update controls with passed values
            /*txtMaNV.Text = maNhanVien.ToString();*/
            txtMaBan.Text = maBan.ToString();
            txtTinhtrang.Text = tinhTrang;
            dtpNgThanhtoan.Value = ngayThanhToan;
            txtTongtien.Text = tongTien.ToString();

        }
        KetNoi kn = new KetNoi();
        public void gethoadon()
        {
            string query = "Select * from HoaDon";
            DataSet ds = kn.laydulieu(query);
            dgvHoaDon.DataSource = ds.Tables[0];
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            gethoadon();
            txtMaHD.Enabled = false;
        }
        public void clear()
        {
            txtMaHD.Enabled = false;
            btnSua.Enabled = false;
            btnLammoi.Enabled = true;
            btnXoa.Enabled = false;

            txtMaHD.Text = "";
            txtMaNV.Text = "";
            txtMaBan.Text = "";
            txtTinhtrang.Text = "";
            txtTongtien.Text = "";
        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            clear();
            gethoadon();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format("update HoaDon set MaNV=N'{1}' , IDBan=N'{2}', TinhTrang=N'{3}', ngaythanhtoan=N'{4}' , tongtien=N'{5}' where IDHoaDon='{0}'",
                txtMaHD.Text,
                txtMaNV.Text,
                txtMaBan.Text,
                txtTinhtrang.Text,
                dtpNgThanhtoan.Value.ToString("yyyy/MM/dd"),
                txtTongtien.Text
                );
            DataSet ds = kn.laydulieu(query);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Sửa thành công");
                btnLammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = string.Format("delete from HoaDon where IDHoaDon='{0}'", txtMaHD.Text);
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataSet ds = kn.laydulieu(query);
                bool kt = kn.thucthi(query);
                if (kt==true)
                {
                    MessageBox.Show("Xóa thành công");
                    btnLammoi.PerformClick();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaHD.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                

                txtMaHD.Text = dgvHoaDon.Rows[r].Cells["IDHoaDon"].Value.ToString();
                txtMaNV.Text = dgvHoaDon.Rows[r].Cells["MaNV"].Value.ToString();
                txtMaBan.Text = dgvHoaDon.Rows[r].Cells["IDBan"].Value.ToString();
                txtTinhtrang.Text = dgvHoaDon.Rows[r].Cells["TinhTrang"].Value.ToString();
                dtpNgThanhtoan.Text = dgvHoaDon.Rows[r].Cells["ngaythanhtoan"].Value.ToString();
                txtTongtien.Text = dgvHoaDon.Rows[r].Cells["tongtien"].Value.ToString();
                

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into HoaDon values (N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
                txtMaHD.Text,
                txtMaNV.Text,
                txtMaBan.Text,
                txtTinhtrang.Text,
                dtpNgThanhtoan.Value.ToString("yyyy/MM/dd HH:mm:ss"),
                txtTongtien.Text
                );
            DataSet ds = kn.laydulieu(query);
            bool kt = kn.thucthi(query);
            if (kt == true)
            {
                MessageBox.Show("Thêm thành công");
                btnLammoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string query = string.Format("Select * from HoaDon where IDHoaDon like '%{0}%' or " +
                "MaNV like '%{0}%' or " +
                "TinhTrang like '%{0}%'  or " +
                "ngaythanhtoan like '%{0}%' or " +
                "tongtien like '%{0}%'",
                txtTim.Text
                );
            DataSet ds = kn.laydulieu(query);
            dgvHoaDon.DataSource = ds.Tables[0];
        }
    }
}
