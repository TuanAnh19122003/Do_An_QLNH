using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyNhaHang
{
    public partial class DatBan : Form
    {
        public DatBan()
        {
            InitializeComponent();
            getmonan();
        }
        public class OrderItem
        {
            public string TenMonAn { get; set; }
            public int SoLuong { get; set; }
            public double DonGia { get; set; }
            public string GhiChu { get; set; }
        }
        Dictionary<string, ListView> listViewDictionary = new Dictionary<string, ListView>();
        private Dictionary<string, Color> defaultButtonColors = new Dictionary<string, Color>();
        private Dictionary<string, List<OrderItem>> ordersByTable = new Dictionary<string, List<OrderItem>>();
        private Dictionary<int, List<string>> tableFoodItems = new Dictionary<int, List<string>>();
        private int maBan;
        private int currentTableNumber = -1;
        private void but_tbl1_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 1");
            ListViewItem item = new ListViewItem("Ban 1");
            listDatban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cb_monan.Enabled = true;
            number_SoLuong.Enabled = true;

        }

        private void but_tbl2_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 2");
            ListViewItem item = new ListViewItem("Ban 2");
            listDatban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cb_monan.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void but_tbl3_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 3");
            ListViewItem item = new ListViewItem("Ban 3");
            listDatban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cb_monan.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void but_tbl4_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 4");
            ListViewItem item = new ListViewItem("Ban 4");
            listDatban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cb_monan.Enabled = true;
            number_SoLuong.Enabled = true;

        }

        private void but_tbl5_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 5");
            ListViewItem item = new ListViewItem("Ban 5");
            listDatban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cb_monan.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void but_tbl6_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 6");
            ListViewItem item = new ListViewItem("Ban 6");
            listDatban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cb_monan.Enabled = true;
            number_SoLuong.Enabled = true;

        }

        private void but_tbl7_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 7");
            ListViewItem item = new ListViewItem("Ban 7");
            listDatban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cb_monan.Enabled = true;
            number_SoLuong.Enabled = true;

        }

        private void but_tbl8_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 8");
            ListViewItem item = new ListViewItem("Ban 8");
            listDatban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cb_monan.Enabled = true;
            number_SoLuong.Enabled = true;


        }

        private void but_tbl9_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 9");
            ListViewItem item = new ListViewItem("Ban 9");
            listDatban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cb_monan.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void but_tbl10_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 10");
            ListViewItem item = new ListViewItem("Ban 10");
            listDatban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cb_monan.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        KetNoi kn = new KetNoi();

        public void getmonan()
        {

            DataSet dsMonAn = kn.LayDuLieuMonAn();
            if (dsMonAn != null && dsMonAn.Tables.Count > 0)
            {
                // Đặt nguồn dữ liệu cho ComboBox cb_monan
                cb_monan.DataSource = dsMonAn.Tables[0];
                cb_monan.ValueMember = "TenMonan"; // Cột chứa giá trị thực sự của mỗi mục trong ComboBox
                cb_monan.DisplayMember = "TenMonan"; // Cột chứa dữ liệu để hiển thị trong ComboBox

                // Đặt nguồn dữ liệu cho TextBox để hiển thị đơn giá
                txtDongia.DataBindings.Clear();
                txtDongia.DataBindings.Add("Text", dsMonAn.Tables[0], "Giatien");
            }
            else
            {
                // Xử lý trường hợp không có dữ liệu hoặc có lỗi xảy ra
                MessageBox.Show("Không thể lấy dữ liệu món ăn.");
            }

        }

        private void but_themmon_Click(object sender, EventArgs e)
        {
            string tenBanHienTai = listViewDictionary.Keys.FirstOrDefault(key => listViewDictionary[key].Visible);

            if (string.IsNullOrEmpty(tenBanHienTai))
            {
                // Nếu không có bàn hiện tại, không thể thêm món
                MessageBox.Show("Vui lòng chọn một bàn trước khi thêm món.");
                return;
            }

            // Lấy thông tin món ăn và số lượng từ ComboBox và NumberUpDown
            string tenMonAn = cb_monan.Text;
            int soLuong = (int)number_SoLuong.Value;
            double donGia = Convert.ToDouble(txtDongia.Text); // Điền giá trị đơn giá ở đây nếu cần

            // Lấy ListView tương ứng với bàn hiện tại và thêm thông tin món vào đó
            ListView listView = listViewDictionary[tenBanHienTai];

            // Hiển thị thông tin món vào ListView
            ListViewItem item = new ListViewItem(tenBanHienTai);
            item.SubItems.Add(tenMonAn);
            item.SubItems.Add(soLuong.ToString());
            item.SubItems.Add(donGia.ToString());

            // Kiểm tra xem có dữ liệu "Ghi chú" từ RichTextBox không
            string ghiChu = rtxtGhichu.Text;
            if (!string.IsNullOrEmpty(ghiChu))
            {
                item.SubItems.Add(ghiChu);
            }

            // Thêm item vào ListView
            listView.Items.Add(item);

            // Xóa nội dung ComboBox và thiết lập lại giá trị mặc định cho NumberUpDown
            cb_monan.Text = "";
            number_SoLuong.Value = 1;
            rtxtGhichu.Clear();


        }


        private void SwitchToTable(string tenBan)
        {
            // Kiểm tra xem ListView cho bàn này đã tồn tại chưa
            if (!listViewDictionary.ContainsKey(tenBan))
            {
                // Nếu chưa tồn tại, tạo một ListView mới
                ListView listView = new ListView();
                listView.Columns.Add("Bàn");
                listView.Columns.Add("Tên món");
                listView.Columns.Add("Số lượng");
                listView.Columns.Add("Đơn giá");
                listView.Columns.Add("Ghi chú");

                // Thêm ListView vào danh sách
                listViewDictionary[tenBan] = listView;

                // Đặt layout và hiển thị ListView
                listView.Dock = DockStyle.Fill;
                listView.View = View.Details;
                listDatban.Controls.Add(listView);
            }

            // Ẩn tất cả các ListView và chỉ hiển thị ListView cho bàn hiện tại
            foreach (var listViewPair in listViewDictionary)
            {
                if (listViewPair.Key == tenBan)
                {
                    listViewPair.Value.Visible = true;
                }
                else
                {
                    listViewPair.Value.Visible = false;
                }
            }
        }
        private void DatBan_Load(object sender, EventArgs e)
        {
            txtThanhtien.Enabled = false;
        }

        private (int, string) PromptForNewQuantityAndGhiChu(int currentQuantity, string currentGhiChu)
        {
            // Hiển thị hộp thoại nhập số lượng và ghi chú mới
            Form prompt = new Form();
            prompt.Width = 400;
            prompt.Height = 200;
            prompt.Text = "Sửa số lượng và ghi chú";

            Label lblQuantity = new Label() { Left = 50, Top = 20, Text = "Nhập số lượng mới:" };
            NumericUpDown numericUpDown = new NumericUpDown() { Left = 50, Top = 40, Width = 300 };
            numericUpDown.Minimum = 0;
            numericUpDown.Value = currentQuantity;

            Label lblGhiChu = new Label() { Left = 50, Top = 70, Text = "Nhập ghi chú mới:" };
            TextBox textBoxGhiChu = new TextBox() { Left = 50, Top = 90, Width = 300 };
            textBoxGhiChu.Text = currentGhiChu;


            Button confirmation = new Button() { Text = "OK", Left = 250, Width = 100, Top = 130, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(lblQuantity);
            prompt.Controls.Add(numericUpDown);
            prompt.Controls.Add(lblGhiChu);
            prompt.Controls.Add(textBoxGhiChu);
            prompt.Controls.Add(confirmation);

            DialogResult dialogResult = prompt.ShowDialog();

            int newQuantity = (int)numericUpDown.Value;
            string newGhiChu = textBoxGhiChu.Text;

            return (newQuantity, newGhiChu);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenBanHienTai = listViewDictionary.Keys.FirstOrDefault(key => listViewDictionary[key].Visible);
            if (!string.IsNullOrEmpty(tenBanHienTai))
            {
                ListView listView = listViewDictionary[tenBanHienTai];

                if (listView.SelectedItems.Count >= 0)
                {
                    ListViewItem selectedItem = listView.SelectedItems[0];

                    if (selectedItem.SubItems.Count >= 5)
                    {
                        int soLuongHienTai = int.Parse(selectedItem.SubItems[2].Text);
                        string ghiChuHienTai = selectedItem.SubItems[4].Text;

                        // Hiển thị hộp thoại để người dùng chỉnh sửa số lượng và ghi chú
                        var result = PromptForNewQuantityAndGhiChu(soLuongHienTai, ghiChuHienTai);

                        int soLuongMoi = result.Item1;
                        string ghiChuMoi = result.Item2;

                        // Kiểm tra nếu cả hai ghi chú cũ và mới đều rỗng
                        if (string.IsNullOrEmpty(ghiChuHienTai) && string.IsNullOrEmpty(ghiChuMoi))
                        {
                            // Ghi chú mới được nhập, cập nhật vào mục đã chọn
                            selectedItem.SubItems[4].Text = ghiChuMoi;
                        }

                        // Nếu ghi chú mới không rỗng, cập nhật ghi chú
                        if (!string.IsNullOrEmpty(ghiChuMoi))
                        {
                            selectedItem.SubItems[4].Text = ghiChuMoi;
                        }

                        selectedItem.SubItems[2].Text = soLuongMoi.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Mục này không có đủ thông tin để sửa số lượng và ghi chú.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một mục để sửa số lượng và ghi chú.");
                }
            }
        }

        private void listDatban_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn ít nhất một mục trong listDatban
            if (listDatban.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn
                ListViewItem selectedItem = listDatban.SelectedItems[0];

                // Hiển thị thông tin món và ghi chú được chọn trong các điều khiển
                string tenMonAn = selectedItem.SubItems[1].Text;

                // Tìm và đặt giá trị của ComboBox dựa trên tên món ăn
                cb_monan.SelectedItem = tenMonAn;

                // Hiển thị thông tin ghi chú
                string ghiChu = selectedItem.SubItems[4].Text;
                rtxtGhichu.Text = ghiChu;
            }
        }

        private void but_Xoa_Click(object sender, EventArgs e)
        {
            string tenBanHienTai = listViewDictionary.Keys.FirstOrDefault(key => listViewDictionary[key].Visible);

            if (!string.IsNullOrEmpty(tenBanHienTai))
            {
                // Lấy ListView tương ứng với bàn hiện tại
                ListView listView = listViewDictionary[tenBanHienTai];

                // Duyệt qua tất cả các mục được chọn trong ListView
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    listView.Items.Remove(item); // Xóa mục được chọn
                }
            }
        }
        private double TinhTongTien(string tenBan)
        {
            double tongTien = 0;

            if (listViewDictionary.ContainsKey(tenBan))
            {
                ListView listView = listViewDictionary[tenBan];

                foreach (ListViewItem item in listView.Items)
                {
                    double donGia = double.Parse(item.SubItems[3].Text);
                    int soLuong = int.Parse(item.SubItems[2].Text);
                    tongTien += donGia * soLuong;
                }
            }

            return tongTien;
        }
        private void HandlePayment(string tenBanHienTai)
        {
            double tongTien = TinhTongTien(tenBanHienTai);

            // Hiển thị tổng tiền
            txtThanhtien.Text = tongTien.ToString();

            // Tạo hóa đơn cho bàn hiện tại
            List<OrderItem> orderForTable = new List<OrderItem>();
            foreach (ListViewItem item in listViewDictionary[tenBanHienTai].Items)
            {
                OrderItem orderItem = new OrderItem
                {
                    TenMonAn = item.SubItems[1].Text,
                    SoLuong = int.Parse(item.SubItems[2].Text),
                    DonGia = double.Parse(item.SubItems[3].Text),
                    GhiChu = item.SubItems.Count > 5 ? item.SubItems[5].Text : string.Empty
                };
                orderForTable.Add(orderItem);
            }

            // Lưu hóa đơn vào danh sách
            ordersByTable[tenBanHienTai] = orderForTable;

            // Xóa danh sách món
            if (listViewDictionary.ContainsKey(tenBanHienTai))
            {
                ListView listView = listViewDictionary[tenBanHienTai];
                listView.Items.Clear();
            }

            // Reset button color
            string buttonName = "but_tbl" + tenBanHienTai.Replace("Ban", "").Replace(" ", "");
            Button button = Controls.Find(buttonName, true).FirstOrDefault() as Button;

            if (button != null)
            {
                button.BackColor = Color.White;
            }
        }

        private int LayMaBanTuTenBan(string tenBan)
        {
            // Loại bỏ "Bàn " và chuyển phần còn lại thành số
            string maBanStr = tenBan.Replace("Ban ", "").Trim();

            // Chuyển đổi thành số nguyên
            if (int.TryParse(maBanStr, out int maBan))
            {
                return maBan;
            }
            else
            {
                // Trường hợp không chuyển đổi được, trả về -1 hoặc giá trị phù hợp
                return -1;
            }
        }


        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            string tenBanHienTai = listViewDictionary.Keys.FirstOrDefault(key => listViewDictionary[key].Visible);

            if (!string.IsNullOrEmpty(tenBanHienTai))
            {
                // Create a new order list if it doesn't exist for this table
                if (!ordersByTable.ContainsKey(tenBanHienTai))
                {
                    ordersByTable[tenBanHienTai] = new List<OrderItem>();
                }

                // Add items to the order for this table
                ListView listView = listViewDictionary[tenBanHienTai];
                double tongTien = 0;

                foreach (ListViewItem item in listView.Items)
                {
                    OrderItem orderItem = new OrderItem
                    {
                        TenMonAn = item.SubItems[1].Text,
                        SoLuong = int.Parse(item.SubItems[2].Text),
                        DonGia = double.Parse(item.SubItems[3].Text),
                        GhiChu = item.SubItems.Count > 5 ? item.SubItems[5].Text : string.Empty
                    };

                    ordersByTable[tenBanHienTai].Add(orderItem);

                    // Calculate total amount for the order
                    tongTien += orderItem.DonGia * orderItem.SoLuong;
                }

                // Handle the payment and clear the list view (as previously implemented)
                HandlePayment(tenBanHienTai);

                // Retrieve the table number
                int maBan = LayMaBanTuTenBan(tenBanHienTai);

                // Show the HoaDon form and pass the order details
                HoaDon hoaDonForm = new HoaDon(tenBanHienTai, maBan, "Da thanh toan", DateTime.Now, tongTien);
                hoaDonForm.Show();
            }
        }
        private void but_tbl11_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 11");
            ListViewItem item = new ListViewItem("Ban 11");
            listDatban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cb_monan.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void but_tbl12_Click(object sender, EventArgs e)
        {
            SwitchToTable("Ban 12");
            ListViewItem item = new ListViewItem("Ban 12");
            listDatban.Items.Add(item);

            // Đổi màu của Button but_tbl1 thành màu xanh
            Button clickedButton = (Button)sender;
            clickedButton.BackColor = Color.Green;

            // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
            cb_monan.Enabled = true;
            number_SoLuong.Enabled = true;
        }

        private void btnDoiban_Click(object sender, EventArgs e)
        {
            /*string tenBanHienTai = listViewDictionary.Keys.FirstOrDefault(key => listViewDictionary[key].Visible);

            if (!string.IsNullOrEmpty(tenBanHienTai))
            {
                string tenBanMoi = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên bàn mới:", "Đổi bàn", "");

                if (!string.IsNullOrEmpty(tenBanMoi))
                {
                    SwitchToTable(tenBanMoi);  // Chuyển đổi sang bàn mới

                    // Xóa màu đặt bàn và trả về màu ban đầu cho bàn hiện tại
                    Button clickedButton = Controls.Find("but_tbl" + tenBanHienTai.Replace("Ban", "").Replace(" ", ""), true).FirstOrDefault() as Button;
                    if (clickedButton != null)
                        clickedButton.BackColor = Color.White;

                    ListViewItem item = new ListViewItem(tenBanMoi);
                    listDatban.Items.Add(item);

                    // Đổi màu của Button but_tbl1 thành màu xanh
                    Button newButton = Controls.Find("but_tbl" + tenBanMoi.Replace("Ban", "").Replace(" ", ""), true).FirstOrDefault() as Button;
                    if (newButton != null)
                        newButton.BackColor = Color.Green;

                    // Bật ComboBox và NumberUpDown để chọn món ăn và số lượng
                    cb_monan.Enabled = true;
                    number_SoLuong.Enabled = true;
                }
            }*/

        }

        private void btnInHoaDon_new_Click(object sender, EventArgs e)
        {
            string tenBanHienTai = listViewDictionary.Keys.FirstOrDefault(key => listViewDictionary[key].Visible);
            string startLine = new string('=', 35);
            if (!string.IsNullOrEmpty(tenBanHienTai) && ordersByTable.ContainsKey(tenBanHienTai))
            {
                StringBuilder receiptContent = new StringBuilder();
                receiptContent.AppendLine($"{"HÓA ĐƠN NHÀ HÀNG YUNXI",42}");
                receiptContent.AppendLine($"{" "}");
                receiptContent.AppendLine($"{" "}");
                receiptContent.AppendLine($"{"Ngày lập hóa đơn:"} {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),-42}");
                receiptContent.AppendLine(startLine);

                double totalAmount = 0;
                int stt = 1;

                // Add items to receipt content
                foreach (var item in ordersByTable[tenBanHienTai])
                {
                    double itemTotal = item.DonGia * item.SoLuong;
                    receiptContent.AppendLine($"{stt,-15} {item.TenMonAn,-30} {item.SoLuong,-15} {item.DonGia,-15:C}");

                    // Cân chỉnh khoảng trống dưới mỗi món ăn
                    int padding = 65 - item.TenMonAn.Length;
                    string paddingSpaces = new string(' ', padding);

                    totalAmount += itemTotal;
                    stt++;
                }

                string totalAmountFormatted = $"{totalAmount:C}";

                receiptContent.AppendLine(startLine);
                receiptContent.AppendLine($"{new string(' ', 70)}{totalAmountFormatted}");

                // Print the receipt (you can replace this with your own printing logic)
                PrintReceipt(receiptContent.ToString());
                PrintReceiptNotepad(receiptContent.ToString());
            }
        }
        private void PrintReceipt(string content)
        {
            // For demonstration purposes, we'll just display the content in a message box
            MessageBox.Show(content, "Hóa Đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void PrintReceiptNotepad(string content)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Tệp văn bản|*.txt";
                saveFileDialog.Title = "Lưu hóa đơn";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Ghi nội dung vào tệp đã chọn
                    File.WriteAllText(filePath, content);

                    MessageBox.Show("Hóa đơn đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu hóa đơn hoặc xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}
