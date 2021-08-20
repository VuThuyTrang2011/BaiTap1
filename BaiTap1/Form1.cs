using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtDayVuaNhap.ResetText();
            txtTongCacPTTrongDay.ResetText();
            txtNhapSo.ResetText();
            txtTongChan.ResetText();
            txtTongLe.ResetText();
            x = "";
        }
        int tongday = 0;
        int tongchan = 0;
        int tongle = 0;
        string x = " ";

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtNhapSo.Text);
            txtDayVuaNhap.Text += x.ToString().Trim() + " ";

            tongday += x;
            txtTongCacPTTrongDay.Text = tongday.ToString();

            if (x % 2 == 0)
            {
                tongchan += x;
                txtTongChan.Text = tongchan.ToString();
            }
            else
            {
                tongle += x;
                txtTongLe.Text = tongle.ToString();
            }
        }
    }
}
