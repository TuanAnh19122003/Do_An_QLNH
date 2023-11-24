using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyNhaHang
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        public void getdata()
        {
            string query = "Select * from HoaDon";
            DataSet ds = kn.laydulieu(query);
            dgvHoaDon.DataSource = ds.Tables[0];
        }
        private void ThongKe_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void btnthongke_Click(object sender, EventArgs e)
        {
            // Xác định loại thống kê (theo năm hoặc tháng)
            string loaiThongKe = radThang.Checked ? "Thang" : "Nam";

            try
            {
                int thang = 0;
                int nam = 0;
                string query = "";
                // Lấy giá trị tháng hoặc năm từ TextBox tương ứng
                if (loaiThongKe == "Thang")
                {
                    thang = Convert.ToInt32(txtThang.Text);
                }
                else if (loaiThongKe == "Nam")
                {
                    nam = Convert.ToInt32(txtYear.Text);
                }

                // Tạo truy vấn SQL dựa trên loại thống kê và giá trị tháng hoặc năm
                if (loaiThongKe == "Thang")
                {
                     query = $@"
                        SELECT YEAR(ngaythanhtoan) AS nam,
                               MONTH(ngaythanhtoan) AS thang,
                               SUM(tongtien) AS doanh_thu 
                        FROM HoaDon
                        WHERE MONTH(ngaythanhtoan) = {thang}
                        GROUP BY YEAR(ngaythanhtoan), MONTH(ngaythanhtoan)
                        ORDER BY nam DESC, thang DESC;";
                }
                else if (loaiThongKe == "Nam")
                {
                    query = $@"
                        SELECT YEAR(ngaythanhtoan) AS nam,
                               MONTH(ngaythanhtoan) AS thang,
                               SUM(tongtien) AS doanh_thu
                        FROM HoaDon
                        WHERE YEAR(ngaythanhtoan) = {nam}
                        GROUP BY YEAR(ngaythanhtoan), MONTH(ngaythanhtoan)
                        ORDER BY nam DESC, thang DESC;";
                }


                // Thực hiện thống kê và hiển thị dữ liệu
                DataSet ds = kn.laydulieu(query);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvHoaDon.DataSource = ds.Tables[0];
                    DisplayDataOnChart(ds);
                }
                else
                {
                    MessageBox.Show("Thống kê thất bại hoặc không có dữ liệu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi thực hiện thống kê: " + ex.Message);
            }
        }
        private void DisplayDataOnChart(DataSet dataset)
        {
            // Kiểm tra xem DataSet có dữ liệu không
            if (dataset == null || dataset.Tables.Count == 0 || dataset.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để hiển thị trên biểu đồ.");
                return;
            }

            // Xóa dữ liệu cũ trên biểu đồ (nếu có)
            chartDoanhThu.Series.Clear();

            // Tạo một loại biểu đồ cột (Column Chart)
            Series series = new Series("Doanh thu");
            series.ChartType = SeriesChartType.Column;

            // Lấy dữ liệu từ DataSet
            foreach (DataRow row in dataset.Tables[0].Rows)
            {
                string label = $"Tháng {row["thang"]}";
                int doanhThu = Convert.ToInt32(row["doanh_thu"]);
                series.Points.AddXY(label, doanhThu);
            }

            // Thêm loại biểu đồ vào Chart
            chartDoanhThu.Series.Add(series);

            // Cập nhật lại giao diện
            chartDoanhThu.Update();
        }

        private void radThang_CheckedChanged(object sender, EventArgs e)
        {
            txtYear.Enabled = false;
            txtThang.Enabled = true;
            txtThang.Text = "";
            txtYear.Text = "";
        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {
            txtYear.Enabled = true;
            txtThang.Enabled = false;
            txtThang.Text = "";
            txtYear.Text = "";
        }
    }
}
