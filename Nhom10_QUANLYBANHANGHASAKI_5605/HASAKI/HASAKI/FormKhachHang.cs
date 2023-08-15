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


namespace HASAKI
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        private BindingSource bdsoure = new BindingSource();
        private DataTable DT = new DataTable();
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            bdsoure.DataSource = data.ThongTinKH();
            dgvKH.DataSource = bdsoure;
            dgvKH.Columns[0].HeaderText = "Mã KH";
            dgvKH.Columns[1].HeaderText ="Họ KH";
            dgvKH.Columns[2].HeaderText = "Tên KH";
            dgvKH.Columns[3].HeaderText = "Phái";
            dgvKH.Columns[4].HeaderText = "Địa chỉ";
            dgvKH.Columns[5].HeaderText = "SĐT";
            dgvKH.Columns[6].HeaderText = "Email";

            DataGridView x = dgvKH;
            {
                x.Columns[0].Width = 80;
                x.Columns[1].Width = 100;
                x.Columns[2].Width = 100;
                x.Columns[3].Width = 70;
                x.Columns[4].Width = 200;
                x.Columns[5].Width = 120;
                x.Columns[6].Width = 150;
               

                x.GridColor = Color.DarkRed;
                

            }
            
             dgvKH.Font = new Font("iCiel Baliho Script", 10, FontStyle.Regular);
            this.dgvKH.DefaultCellStyle.ForeColor = Color.DarkRed;
            dgvKH.EnableHeadersVisualStyles = false;
            dgvKH.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvKH.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKH.DefaultCellStyle.BackColor = Color.White;
            dgvKH.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
            dgvKH.AllowUserToResizeColumns = false;
            dgvKH.AllowUserToResizeRows = false;
            dgvKH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void btfresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cbboxSX.Text = "";
            rbDC.Checked = false;
            rbmakh.Checked = false;
            rbsdt.Checked = false;
            rbtenkh.Checked = false;
            FormKhachHang_Load(sender, e);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string tim = txtSearch.Text;
            if(rbmakh.Checked==true)
            {
                string str = "Select * from KHACHHANG where MAKH='" + tim + "'";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKH.DataSource = dt;
            }
            if (rbtenkh.Checked == true)
            {
                DataView dv = new DataView(data.Executequery("Select * from KHACHHANG"));
                dv.RowFilter = string.Format("TENKH like '%{0}%'", tim);
                dgvKH.DataSource = dv;
            }
            if (rbDC.Checked == true)
            {
                DataView dv = new DataView(data.Executequery("Select * from KHACHHANG"));
                dv.RowFilter = string.Format("DIACHIKH like '%{0}%'", tim);
                dgvKH.DataSource = dv;
            }
            if (rbsdt.Checked == true)
            {
                DataView dv = new DataView(data.Executequery("Select * from KHACHHANG"));
                dv.RowFilter = string.Format("DIENTHOAIKH like '%{0}%'", tim);
                dgvKH.DataSource = dv;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADDKH f = new ADDKH();
            f.ShowDialog();
            FormKhachHang_Load(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SUAXOAKH f = new SUAXOAKH();
            f.ShowDialog();
            FormKhachHang_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            SUAXOAKH f = new SUAXOAKH();
            f.ShowDialog();
            FormKhachHang_Load(sender, e);
        }

        private void btsapxep_Click(object sender, EventArgs e)
        {
            if(cbboxSX.Text=="Mã khách hàng")
            {
                string str = "Select * from KHACHHANG ORDER BY MAKH ASC";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKH.DataSource = dt;
            }
            if (cbboxSX.Text == "Tên khách hàng")
            {
                string str = "Select * from KHACHHANG ORDER BY TENKH ASC";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKH.DataSource = dt;
            }
            if (cbboxSX.Text == "Giới tính")
            {
                string str = "Select * from KHACHHANG ORDER BY GIOITINHKH ASC";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKH.DataSource = dt;
            }
            if (cbboxSX.Text == "Địa chỉ")
            {
                string str = "Select * from KHACHHANG ORDER BY DIACHIKH ASC";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvKH.DataSource = dt;
            }
        }
    }
}
