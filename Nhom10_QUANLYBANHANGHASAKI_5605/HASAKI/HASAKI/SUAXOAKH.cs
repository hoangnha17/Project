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
    public partial class SUAXOAKH : Form
    {
        KetNoi data = new KetNoi();
        BindingManagerBase MyBDS;
        public SUAXOAKH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SUAXOAKH_Load(object sender, EventArgs e)
        {
            string str = "select * from KHACHHANG";
            SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);

            ///liên kết các cột từ câu lệnh truy vấn vào các textbox
            txtMaKH.DataBindings.Add("Text", dt, "MAKH");
            txtHoKh.DataBindings.Add("Text", dt, "HOKH");
            txtTenKh.DataBindings.Add("Text", dt, "TENKH");
            txtsdt.DataBindings.Add("Text", dt, "DIENTHOAIKH");
            txtdiachi.DataBindings.Add("Text", dt, "DIACHIKH");
            txtemail.DataBindings.Add("Text", dt, "EMAILKH");
            txtgioitinh.DataBindings.Add("Text", dt, "GIOITINHKH");
            MyBDS = this.BindingContext[dt];
            //gán giá trị tổng số mẫu tin vào label

            //làm mở các nút lệnh
            btdau.Enabled = true;
            bttruoc.Enabled = true;
            btke.Enabled = true;
            btcuoi.Enabled = true;
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

        private void btSua_Click(object sender, EventArgs e)
        {
            string makh = txtMaKH.Text;
            string hokh = txtHoKh.Text;
            string tenkh = txtTenKh.Text;
            string sdt = txtsdt.Text;
            string diachi = txtdiachi.Text;
            string email = txtemail.Text;
            string gioitinh = txtgioitinh.Text;
            string update = @"update KHACHHANG set TENKH = N'" + tenkh +
                "',HOKH=N'" + hokh + "',DIENTHOAIKH='" + sdt + "',DIACHIKH=N'" + diachi + "',EMAILKH='" + email + "',GIOITINHKH='" + gioitinh  + "' WHERE MAKH='" + makh+ "';";
            data.EXECUTENONQUERY(update);
            MessageBox.Show("Sửa thành công " + makh, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
          
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = txtMaKH.Text;

                string delete = @"delete from KHACHHANG
                        where MAKH='" + makh + "';";
                data.EXECUTENONQUERY(delete);
                MessageBox.Show("Xóa thành công " + makh, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            txtMaKH.Text = "";txtHoKh.Text = "";
            txtTenKh.Text = ""; txtgioitinh.Text = "";
            txtdiachi.Text = "";txtemail.Text = "";
            txtsdt.Text = "";
        }
    }
}
