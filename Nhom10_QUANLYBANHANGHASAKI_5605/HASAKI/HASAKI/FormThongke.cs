using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASAKI
{
    public partial class FormThongke : Form
    {
        public FormThongke()
        {
            InitializeComponent();
        }

        private void FormThongke_Load(object sender, EventArgs e)
        {
         
        }

        private void btnBCNhanvien_Click(object sender, EventArgs e)
        {
            FrmBCNhanVien f = new FrmBCNhanVien();
            f.Show();
        }

        private void btnBCSP_Click(object sender, EventArgs e)
        {
            FrmBCSanPham f = new FrmBCSanPham();
            f.Show();
        }

        private void btnBCNCC_Click(object sender, EventArgs e)
        {
            FrmBCNhacungcap f = new FrmBCNhacungcap();
            f.Show();
        }

        private void btnBDHD_Click(object sender, EventArgs e)
        {
            FrmBCHoaDon f = new FrmBCHoaDon();
            f.Show();
        }

        private void btnBCKhachhang_Click(object sender, EventArgs e)
        {
            FrmBCKhachhang f = new FrmBCKhachhang();
            f.Show();
        }
    }
}
