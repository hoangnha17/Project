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
    public partial class FORMSUA : Form
    {
       
        public FORMSUA()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        BindingManagerBase MyBDS;
       
        private void FORMSUA_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string masp = txtmasp.Text;
            string tensp = txttensp.Text;
            string thanhphan = txtTP.Text;
            string dvt = txtdvt.Text;
            string gianhap = txtdgnhap.Text;
            string giaban = txtdgxuat.Text;
            string tonkho = txtkho.Text;
            string malh = txtmalh.Text;
            string xuatxu = txtXuatxu.Text;
            string update= @"update MATHANG set TENMH = N'" + tensp +
                "',DVT=N'" + dvt + "',SLTON='" + tonkho + "',DGNHAP='" +gianhap+ "',DGBAN='"+giaban+ "',THANHPHAN=N'"+thanhphan+ "',XUATXU=N'" +xuatxu + "' WHERE MAMH='" + masp +"'AND MALH='"+malh+ "';";
            data.EXECUTENONQUERY(update);
            MessageBox.Show("Sửa thành công " + masp, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            
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

        private void GbADD_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtXuatxu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmalh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdgxuat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdvt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttensp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdgnhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmasp_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
