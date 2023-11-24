using Bunifu.Framework.UI;
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
    public partial class Manhinhcho : Form
    {
        public Manhinhcho()
        {
            InitializeComponent();
        }
        int start = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            cho.Value = start;
            if (cho.Value == 100)
            {
                cho.Value = 0;
                timer1.Stop();
                Dangnhap dn = new Dangnhap();
                this.Hide();
                dn.Show();
            }
        }

        private void Manhinhcho_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
