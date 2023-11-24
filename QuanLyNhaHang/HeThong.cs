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
    public partial class HeThong : Form
    {
        private string userRole;
        private string tentk;
        private Timer timer;
        private DateTime time;
        private bool isPanelDonghoVisible = true;

        KetNoi kn = new KetNoi();
        public HeThong()
        {
            InitializeComponent();
            panelShow.ControlRemoved += panelDongho_ControlRemoved;
        }
        private void HienThiTenTaiKhoanLenLabel()
        {
            lbXinchao.Text = tentk;
        }
        public HeThong(string tentk, string chucVu)
        {
            this.tentk = tentk;
            InitializeComponent();
        }
        public void AnChucNangChoNhanVien()
        {
            btnTK.Enabled = false;
            btnQLNV.Enabled = false;
            btnQLHD.Enabled = false;
            btnQLTD.Enabled = false;
        }
        public void AnChucNangChoCaTruong()
        {
            btnQLNV.Enabled = false;
            btnQLTD.Enabled = false;
        }
        public HeThong(string role)
        {
            InitializeComponent();
            userRole = role;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQLNV_Click_1(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.TopLevel = false;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(nv);
            nv.Show();

            time = DateTime.Now;
            ShowHidePanelDongho(true);
        }

        private void btnQLDB_Click_1(object sender, EventArgs e)
        {
            DatBan db = new DatBan();
            db.TopLevel = false;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(db);
            db.Show();

            time = DateTime.Now;
            ShowHidePanelDongho(true);
        }

        private void btnQLTD_Click_1(object sender, EventArgs e)
        {
            ThucDon td = new ThucDon();
            td.TopLevel = false;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(td);
            td.Show();

            time = DateTime.Now;
            ShowHidePanelDongho(true);
        }

        private void btnQLHD_Click_1(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.TopLevel = false;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(hd);
            hd.Show();

            time = DateTime.Now;
            ShowHidePanelDongho(true);
        }

        private void btnTK_Click_1(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.TopLevel = false;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(tk);
            tk.Show();

            time = DateTime.Now;
            ShowHidePanelDongho(true);
        }

        private void HeThong_Load(object sender, EventArgs e)
        {
            HienThiTenTaiKhoanLenLabel();
            InitializeClock();

            string formattedDate = GetFormattedDate(time);
            lbDateOrTime.Text = formattedDate;
        }

        private void Timer_Tick_Tick(object sender, EventArgs e)
        {
            lbDongho.Text = DateTime.Now.ToString("HH:mm:ss");
            DateTime time = DateTime.Now;
            string formattedDate = GetFormattedDate(time);
            lbDateOrTime.Text = formattedDate;
        }

        private void InitializeClock()
        {

            // Khởi tạo Timer
            timer = new Timer();
            timer.Interval = 1000;  // Cập nhật mỗi giây
            timer.Tick += Timer_Tick_Tick;  // Gán sự kiện khi timer tick
            timer.Start();  // Khởi động Timer
        }
        private string GetFormattedDate(DateTime dateTime)
        {
            string dayOfWeek = GetNgay(dateTime.DayOfWeek);
            string day = dateTime.Day.ToString();
            string month = GetThang(dateTime.Month);// Tên tháng
            string year = dateTime.Year.ToString();

            return $"{dayOfWeek} ,ngày {day} tháng {month} năm {year}";
        }
        private string GetNgay(DayOfWeek ngay)
        {
            switch (ngay)
            {
                case DayOfWeek.Monday:
                    return "Thứ Hai";
                case DayOfWeek.Tuesday:
                    return "Thứ Ba";
                case DayOfWeek.Wednesday:
                    return "Thứ Tư";
                case DayOfWeek.Thursday:
                    return "Thứ Năm";
                case DayOfWeek.Friday:
                    return "Thứ Sáu";
                case DayOfWeek.Saturday:
                    return "Thứ Bảy";
                case DayOfWeek.Sunday:
                    return "Chủ Nhật";
                default:
                    return "";
            }
        }
        private string GetThang(int month)
        {
            switch (month)
            {
                case 1:
                    return "1";
                case 2:
                    return "2";
                case 3:
                    return "3";
                case 4:
                    return "4";
                case 5:
                    return "5";
                case 6:
                    return "6";
                case 7:
                    return "7";
                case 8:
                    return "8";
                case 9:
                    return "9";
                case 10:
                    return "10";
                case 11:
                    return "11";
                case 12:
                    return "12";
                default:
                    return "";
            }
        }

        private void ShowHidePanelDongho(bool isVisible)
        {
            panelShow.Visible = isVisible;
        }

        private void panelDongho_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (e.Control is Form Hethong)
            {
                // Check if the closed form is a management form
                if (Hethong is NhanVien || Hethong is DatBan
                    || Hethong is ThucDon || Hethong is HoaDon || Hethong is ThongKe)
                {
                    // Show the clock panel when a management page is closed
                    ShowHidePanelDongho(true);
                }
            }
        }

    }
}
