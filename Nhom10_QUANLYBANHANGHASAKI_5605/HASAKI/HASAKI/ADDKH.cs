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
    public partial class ADDKH : Form
    {
        public ADDKH()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        private BindingSource bdsoure = new BindingSource();
        private DataTable DT = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string makh = txtMaKH.Text;
                string hokh = txtHoKh.Text;
                string tenkh = txtTenKh.Text;
                string sdt = txtsdt.Text;
                string diachi = txtdiachi.Text;
                string email= txtemail.Text;
                string gioitinh="";
                if(rbNu.Checked==true)
                {
                    gioitinh = "Nữ";
                
                }
                else if(rbNam.Checked==true)
                {
                    gioitinh = "Nam";
                }
                else
                {
                    gioitinh = "KHAC";
                }
                string insert = @"INSERT into KHACHHANG Values('" + makh + "',N'" + hokh + "',N'" + tenkh + "',N'" + gioitinh + "',N'" + diachi + "','" + sdt + "','" + email  + "')";
                data.EXECUTENONQUERY(insert);
                MessageBox.Show("Thêm đc rùi nhen!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ADDKH_Load(sender, e);
        }

        private void ADDKH_Load(object sender, EventArgs e)
        {
            bdsoure.DataSource = data.ThongTinKH();
        }
    }
}
