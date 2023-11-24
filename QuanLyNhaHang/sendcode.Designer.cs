namespace QuanLyNhaHang
{
    partial class sendcode
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
            this.but_xacminh = new System.Windows.Forms.Button();
            this.but_sendotp = new System.Windows.Forms.Button();
            this.txt_otp = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_xacminh
            // 
            this.but_xacminh.Location = new System.Drawing.Point(354, 133);
            this.but_xacminh.Margin = new System.Windows.Forms.Padding(2);
            this.but_xacminh.Name = "but_xacminh";
            this.but_xacminh.Size = new System.Drawing.Size(87, 27);
            this.but_xacminh.TabIndex = 17;
            this.but_xacminh.Text = "Xác minh";
            this.but_xacminh.UseVisualStyleBackColor = true;
            this.but_xacminh.Click += new System.EventHandler(this.but_xacminh_Click);
            // 
            // but_sendotp
            // 
            this.but_sendotp.Location = new System.Drawing.Point(362, 65);
            this.but_sendotp.Margin = new System.Windows.Forms.Padding(2);
            this.but_sendotp.Name = "but_sendotp";
            this.but_sendotp.Size = new System.Drawing.Size(87, 24);
            this.but_sendotp.TabIndex = 16;
            this.but_sendotp.Text = "Gửi mã OTP";
            this.but_sendotp.UseVisualStyleBackColor = true;
            this.but_sendotp.Click += new System.EventHandler(this.but_sendotp_Click);
            // 
            // txt_otp
            // 
            this.txt_otp.Location = new System.Drawing.Point(129, 134);
            this.txt_otp.Margin = new System.Windows.Forms.Padding(2);
            this.txt_otp.Name = "txt_otp";
            this.txt_otp.Size = new System.Drawing.Size(201, 26);
            this.txt_otp.TabIndex = 15;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(140, 63);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(201, 26);
            this.txt_sdt.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã OTP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập Số điện thoại";
            // 
            // sendcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 233);
            this.Controls.Add(this.but_xacminh);
            this.Controls.Add(this.but_sendotp);
            this.Controls.Add(this.txt_otp);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "sendcode";
            this.Text = "sendcode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_xacminh;
        private System.Windows.Forms.Button but_sendotp;
        private System.Windows.Forms.TextBox txt_otp;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}