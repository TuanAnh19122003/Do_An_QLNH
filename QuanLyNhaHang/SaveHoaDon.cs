using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    internal class SaveHoaDon
    {
        public string TenBan { get; set; }
        public int MaBan { get; set; }
        public string TrangThai { get; set; }
        public DateTime ThoiGian { get; set; }
        public double TongTien { get; set; }
        public int MaNhanVien { get; set; }

        // Khởi tạo hàm tạo để nhận thông tin hóa đơn
        public SaveHoaDon(string tenBan, int maBan, string trangThai, DateTime ngayThanhToan, double tongTien, int maNV)
        {
            TenBan = tenBan;
            MaBan = maBan;
            TrangThai = trangThai;
            ThoiGian = ngayThanhToan;
            TongTien = tongTien;
            MaNhanVien = maNV;

        }
    }
}
