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
    public partial class FRMADDSP : Form
    {
        public FRMADDSP()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        private BindingSource bdsoure = new BindingSource();
        private DataTable DT = new DataTable();
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void FRMADDSP_Load(object sender, EventArgs e)
        {
            bdsoure.DataSource = data.ThongTinSP();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                ///dòng mà mình click vào
                string masp = txtmasp.Text;
                string tensp = txttensp.Text;
                string thanhphan =txtTP.Text;
                string dvt = txtdvt.Text;
                string gianhap = txtdgnhap.Text;
                string giaban = txtdgxuat.Text;
                string tonkho = txtkho.Text;
                string malh = txtmalh.Text;
                string xuatxu = txtXuatxu.Text;

                string insert = @"INSERT into MATHANG Values('" + masp + "',N'" + tensp + "','" + dvt + "','" + tonkho + "','" + gianhap + "','" + giaban + "','"+ malh + "',N'"+ thanhphan + "','" + xuatxu + "')";
                data.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm đc rùi nhen!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            FRMADDSP_Load(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
