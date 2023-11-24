namespace QuanLyNhaHang
{
    partial class ThucDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabChinh = new System.Windows.Forms.TabControl();
            this.tabThucDon = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimTD = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabBan = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtSobanhientai = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtTimban = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenban = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelChucnang = new System.Windows.Forms.Panel();
            this.btnResetTD = new System.Windows.Forms.Button();
            this.btnXoaTD = new System.Windows.Forms.Button();
            this.btnSuaTD = new System.Windows.Forms.Button();
            this.btnThemTD = new System.Windows.Forms.Button();
            this.btnResetBan = new System.Windows.Forms.Button();
            this.btnXoaBan = new System.Windows.Forms.Button();
            this.btnSuaBan = new System.Windows.Forms.Button();
            this.btnThemBan = new System.Windows.Forms.Button();
            this.tabChinh.SuspendLayout();
            this.tabThucDon.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabBan.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panelChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChinh
            // 
            this.tabChinh.Controls.Add(this.tabThucDon);
            this.tabChinh.Controls.Add(this.tabBan);
            this.tabChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChinh.Location = new System.Drawing.Point(0, 0);
            this.tabChinh.Name = "tabChinh";
            this.tabChinh.SelectedIndex = 0;
            this.tabChinh.Size = new System.Drawing.Size(995, 518);
            this.tabChinh.TabIndex = 0;
            this.tabChinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabChinh_KeyDown);
            // 
            // tabThucDon
            // 
            this.tabThucDon.Controls.Add(this.tableLayoutPanel1);
            this.tabThucDon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabThucDon.Location = new System.Drawing.Point(4, 28);
            this.tabThucDon.Name = "tabThucDon";
            this.tabThucDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabThucDon.Size = new System.Drawing.Size(987, 486);
            this.tabThucDon.TabIndex = 1;
            this.tabThucDon.Text = "Quản lý thực đơn";
            this.tabThucDon.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Orange;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.71984F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.28016F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvThucDon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.375F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.625F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 480);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimTD);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 111);
            this.panel1.TabIndex = 0;
            // 
            // btnTimTD
            // 
            this.btnTimTD.Location = new System.Drawing.Point(353, 70);
            this.btnTimTD.Name = "btnTimTD";
            this.btnTimTD.Size = new System.Drawing.Size(75, 23);
            this.btnTimTD.TabIndex = 3;
            this.btnTimTD.Text = "Tìm";
            this.btnTimTD.UseVisualStyleBackColor = true;
            this.btnTimTD.Click += new System.EventHandler(this.btnTimTD_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(74, 67);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(260, 26);
            this.txtTim.TabIndex = 2;
            this.txtTim.Enter += new System.EventHandler(this.txtTim_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 55);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "THỰC ĐƠN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThucDon.Location = new System.Drawing.Point(3, 120);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.Size = new System.Drawing.Size(442, 357);
            this.dgvThucDon.TabIndex = 1;
            this.dgvThucDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucDon_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(451, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 357);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnResetTD);
            this.panel4.Controls.Add(this.btnXoaTD);
            this.panel4.Controls.Add(this.btnSuaTD);
            this.panel4.Controls.Add(this.btnThemTD);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 249);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 108);
            this.panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDVT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin món ăn";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(181, 192);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(272, 26);
            this.txtGiaTien.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giá tiền";
            // 
            // txtDVT
            // 
            this.txtDVT.Location = new System.Drawing.Point(181, 138);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(272, 26);
            this.txtDVT.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn vị tính";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(181, 83);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(272, 26);
            this.txtTenMon.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên món ăn";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(181, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(272, 26);
            this.txtID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID món ăn";
            // 
            // tabBan
            // 
            this.tabBan.BackColor = System.Drawing.Color.Orange;
            this.tabBan.Controls.Add(this.panel6);
            this.tabBan.Controls.Add(this.panel5);
            this.tabBan.Location = new System.Drawing.Point(4, 28);
            this.tabBan.Name = "tabBan";
            this.tabBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabBan.Size = new System.Drawing.Size(987, 486);
            this.tabBan.TabIndex = 2;
            this.tabBan.Text = "Quản lý bàn ăn";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 216);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(981, 267);
            this.panel6.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvBan);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(336, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(645, 267);
            this.panel8.TabIndex = 1;
            // 
            // dgvBan
            // 
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBan.Location = new System.Drawing.Point(0, 0);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.Size = new System.Drawing.Size(645, 267);
            this.dgvBan.TabIndex = 0;
            this.dgvBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBan_CellClick);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnTim);
            this.panel7.Controls.Add(this.txtSobanhientai);
            this.panel7.Controls.Add(this.label);
            this.panel7.Controls.Add(this.txtTimban);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(336, 267);
            this.panel7.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(144, 62);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtSobanhientai
            // 
            this.txtSobanhientai.Location = new System.Drawing.Point(119, 129);
            this.txtSobanhientai.Name = "txtSobanhientai";
            this.txtSobanhientai.Size = new System.Drawing.Size(100, 26);
            this.txtSobanhientai.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(18, 132);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 19);
            this.label.TabIndex = 3;
            this.label.Text = "Số bàn hiện tại";
            // 
            // txtTimban
            // 
            this.txtTimban.Location = new System.Drawing.Point(119, 20);
            this.txtTimban.Name = "txtTimban";
            this.txtTimban.Size = new System.Drawing.Size(195, 26);
            this.txtTimban.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nhập từ khóa";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panelChucnang);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(981, 213);
            this.panel5.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtTrangthai);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.txtTenban);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.txtIDBan);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(271, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(439, 213);
            this.panel10.TabIndex = 2;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(120, 131);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(270, 26);
            this.txtTrangthai.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Trạng thái";
            // 
            // txtTenban
            // 
            this.txtTenban.Location = new System.Drawing.Point(120, 77);
            this.txtTenban.Name = "txtTenban";
            this.txtTenban.Size = new System.Drawing.Size(270, 26);
            this.txtTenban.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên bàn";
            // 
            // txtIDBan
            // 
            this.txtIDBan.Location = new System.Drawing.Point(120, 25);
            this.txtIDBan.Name = "txtIDBan";
            this.txtIDBan.Size = new System.Drawing.Size(270, 26);
            this.txtIDBan.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "ID bàn";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnResetBan);
            this.panel9.Controls.Add(this.btnXoaBan);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(710, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(271, 213);
            this.panel9.TabIndex = 1;
            // 
            // panelChucnang
            // 
            this.panelChucnang.Controls.Add(this.btnSuaBan);
            this.panelChucnang.Controls.Add(this.btnThemBan);
            this.panelChucnang.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChucnang.Location = new System.Drawing.Point(0, 0);
            this.panelChucnang.Name = "panelChucnang";
            this.panelChucnang.Size = new System.Drawing.Size(271, 213);
            this.panelChucnang.TabIndex = 0;
            // 
            // btnResetTD
            // 
            this.btnResetTD.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.reset;
            this.btnResetTD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetTD.Location = new System.Drawing.Point(423, 3);
            this.btnResetTD.Name = "btnResetTD";
            this.btnResetTD.Size = new System.Drawing.Size(101, 101);
            this.btnResetTD.TabIndex = 3;
            this.btnResetTD.UseVisualStyleBackColor = true;
            this.btnResetTD.Click += new System.EventHandler(this.btnResetTD_Click);
            // 
            // btnXoaTD
            // 
            this.btnXoaTD.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.menu_remove;
            this.btnXoaTD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTD.Location = new System.Drawing.Point(283, 3);
            this.btnXoaTD.Name = "btnXoaTD";
            this.btnXoaTD.Size = new System.Drawing.Size(101, 101);
            this.btnXoaTD.TabIndex = 2;
            this.btnXoaTD.UseVisualStyleBackColor = true;
            this.btnXoaTD.Click += new System.EventHandler(this.btnXoaTD_Click);
            // 
            // btnSuaTD
            // 
            this.btnSuaTD.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.menu_update;
            this.btnSuaTD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTD.Location = new System.Drawing.Point(144, 4);
            this.btnSuaTD.Name = "btnSuaTD";
            this.btnSuaTD.Size = new System.Drawing.Size(101, 101);
            this.btnSuaTD.TabIndex = 1;
            this.btnSuaTD.UseVisualStyleBackColor = true;
            this.btnSuaTD.Click += new System.EventHandler(this.btnSuaTD_Click);
            // 
            // btnThemTD
            // 
            this.btnThemTD.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.menu_add;
            this.btnThemTD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTD.Location = new System.Drawing.Point(4, 4);
            this.btnThemTD.Name = "btnThemTD";
            this.btnThemTD.Size = new System.Drawing.Size(101, 101);
            this.btnThemTD.TabIndex = 0;
            this.btnThemTD.UseVisualStyleBackColor = true;
            this.btnThemTD.Click += new System.EventHandler(this.btnThemTD_Click);
            // 
            // btnResetBan
            // 
            this.btnResetBan.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.table_undo_icon;
            this.btnResetBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetBan.Location = new System.Drawing.Point(168, 58);
            this.btnResetBan.Name = "btnResetBan";
            this.btnResetBan.Size = new System.Drawing.Size(80, 84);
            this.btnResetBan.TabIndex = 1;
            this.btnResetBan.UseVisualStyleBackColor = true;
            this.btnResetBan.Click += new System.EventHandler(this.btnResetBan_Click);
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.table_remove_icon;
            this.btnXoaBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaBan.Location = new System.Drawing.Point(25, 58);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.Size = new System.Drawing.Size(80, 84);
            this.btnXoaBan.TabIndex = 0;
            this.btnXoaBan.UseVisualStyleBackColor = true;
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // btnSuaBan
            // 
            this.btnSuaBan.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.table_edit_icon;
            this.btnSuaBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaBan.Location = new System.Drawing.Point(159, 58);
            this.btnSuaBan.Name = "btnSuaBan";
            this.btnSuaBan.Size = new System.Drawing.Size(80, 84);
            this.btnSuaBan.TabIndex = 0;
            this.btnSuaBan.UseVisualStyleBackColor = true;
            this.btnSuaBan.Click += new System.EventHandler(this.btnSuaBan_Click);
            // 
            // btnThemBan
            // 
            this.btnThemBan.BackgroundImage = global::QuanLyNhaHang.Properties.Resources.table_add_icon_48;
            this.btnThemBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemBan.Location = new System.Drawing.Point(22, 58);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.Size = new System.Drawing.Size(80, 84);
            this.btnThemBan.TabIndex = 2;
            this.btnThemBan.UseVisualStyleBackColor = true;
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(995, 518);
            this.Controls.Add(this.tabChinh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThucDon";
            this.Text = "ThucDon";
            this.Load += new System.EventHandler(this.ThucDon_Load);
            this.tabChinh.ResumeLayout(false);
            this.tabThucDon.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabBan.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panelChucnang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabChinh;
        private System.Windows.Forms.TabPage tabThucDon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimTD;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXoaTD;
        private System.Windows.Forms.Button btnSuaTD;
        private System.Windows.Forms.Button btnThemTD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetTD;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabBan;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtSobanhientai;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtTimban;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenban;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnResetBan;
        private System.Windows.Forms.Button btnXoaBan;
        private System.Windows.Forms.Panel panelChucnang;
        private System.Windows.Forms.Button btnSuaBan;
        private System.Windows.Forms.Button btnThemBan;
    }
}