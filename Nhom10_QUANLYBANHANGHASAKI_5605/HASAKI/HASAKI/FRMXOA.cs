using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HASAKI
{
    public partial class FRMXOA : Form
    {
        public FRMXOA()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        BindingManagerBase MyBDS;
        private void GbADD_Enter(object sender, EventArgs e)
        {

        }

        private void FRMXOA_Load(object sender, EventArgs e)
        {
            string str = "select * from MATHANG";
            SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);

            ///liên kết các cột từ câu lệnh truy vấn vào các textbox
            txtmasp.DataBindings.Add("Text", dt, "MAMH");
            txttensp.DataBindings.Add("Text", dt, "TENMH");
            txtdvt.DataBindings.Add("Text", dt, "DVT");
            txtkho.DataBindings.Add("Text", dt, "SLTON");
            txtdgnhap.DataBindings.Add("Text", dt, "DGNHAP");
            txtdgxuat.DataBindings.Add("Text", dt, "DGBAN");
            txtmalh.DataBindings.Add("Text", dt, "MALH");
            txtTP.DataBindings.Add("Text", dt, "THANHPHAN");
            txtXuatxu.DataBindings.Add("Text", dt, "XUATXU");
            MyBDS = this.BindingContext[dt];
            //gán giá trị tổng số mẫu tin vào label

            //làm mở các nút lệnh
            btdau.Enabled = true;
            bttruoc.Enabled = true;
            btke.Enabled = true;
            btcuoi.Enabled = true;
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txtmasp.Text;
               
                string delete = @"delete from MATHANG
                        where MAMH='" + masp + "';";
                data.EXECUTENONQUERY(delete);
                MessageBox.Show("Xóa thành công " + masp , "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btdau_Click(object sender, EventArgs e)
        {
            MyBDS.Position = 0;

            btdau.Enabled = false;
            bttruoc.Enabled = false;
            btke.Enabled = true;
            btcuoi.Enabled = true;
        }

        private void bttruoc_Click(object sender, EventArgs e)
        {
            MyBDS.Position -= 1;

            if (MyBDS.Position == 0)
            {
                btdau.Enabled = false;
                bttruoc.Enabled = false;
            }
            btke.Enabled = true;
            btcuoi.Enabled = true;
        }

        private void btke_Click(object sender, EventArgs e)
        {
            MyBDS.Position += 1;

            if (MyBDS.Position == MyBDS.Count - 1)
            {
                btke.Enabled = false;
                btcuoi.Enabled = false;
            }
            btdau.Enabled = true;
            bttruoc.Enabled = true;
        }

        private void btcuoi_Click(object sender, EventArgs e)
        {
            MyBDS.Position = MyBDS.Count;

            btdau.Enabled = true;
            bttruoc.Enabled = true;
            btke.Enabled = false;
            btcuoi.Enabled = false;
        }
    }
}
