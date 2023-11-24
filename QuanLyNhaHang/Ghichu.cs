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
    public partial class Ghichu : Form
    {
        public Ghichu()
        {
            InitializeComponent();
        }
        public string GhiChu { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            GhiChu = rtxtghichu.Text;
            this.Close();
        }
    }
}
