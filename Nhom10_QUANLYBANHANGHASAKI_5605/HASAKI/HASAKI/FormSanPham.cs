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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        private BindingSource bdsoure = new BindingSource();
        private DataTable DT = new DataTable();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tim = txtThongtintimkiem.Text;
            if (rdMaSP.Checked==true)
            {
                string str = "Select * from MATHANG where MAMH='" + tim + "'";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSP.DataSource = dt;
            }
            if (rdTenSP.Checked==true)
            {
                DataView dv = new DataView(data.Executequery("Select * from MATHANG"));
                dv.RowFilter = string.Format("TENMH like '%{0}%'",tim);
                dgvSP.DataSource = dv;
            }
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            bdsoure.DataSource = data.ThongTinSP();
            dgvSP.DataSource = bdsoure;
            dgvSP.Columns[0].HeaderText = "Mã SP";
            dgvSP.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSP.Columns[2].HeaderText = "ĐVT";
            dgvSP.Columns[3].HeaderText = "Tồn";
            dgvSP.Columns[4].HeaderText = "Giá nhập";
            dgvSP.Columns[5].HeaderText = "Giá bán";
            dgvSP.Columns[6].HeaderText = "Mã LH";
            dgvSP.Columns[7].HeaderText = "Thành phần";
            dgvSP.Columns[8].HeaderText = "Xuất xứ";
            DataGridView x = dgvSP;
            {
                x.Columns[0].Width = 70;
                x.Columns[1].Width = 210;
                x.Columns[2].Width = 80;
                x.Columns[3].Width = 55;
                x.Columns[4].Width = 65;
                x.Columns[5].Width = 65;
                x.Columns[6].Width = 60;
                x.Columns[7].Width = 180;
                x.Columns[8].Width = 80;

                x.GridColor = Color.IndianRed;
               
            }
            //int currentcell = dgvSP.CurrentCell.RowIndex;
            //lblMasp.Text = dgvSP.Rows[currentcell].Cells[0].Value.ToString();
            //string TEN = "BODY1";
            //if (lblMasp.Text.CompareTo(TEN) == 0)
            //{
                Image pic = Image.FromFile("bo.png");
            HINH.BackgroundImage = pic;
            HINH.BackgroundImageLayout = ImageLayout.Zoom;
            //}
            dgvSP.Font = new Font("iCiel Baliho Script", 10, FontStyle.Regular);
            this.dgvSP.DefaultCellStyle.ForeColor = Color.DarkRed;
            dgvSP.EnableHeadersVisualStyles = false;
            dgvSP.ColumnHeadersDefaultCellStyle.BackColor = Color.MistyRose;
            dgvSP.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkRed;
            dgvSP.DefaultCellStyle.BackColor = Color.White;
            dgvSP.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
            dgvSP.AllowUserToResizeColumns = false;
            dgvSP.AllowUserToResizeRows = false;
            dgvSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;





        }

        private void lblSLTon_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {

        }
        
        private void dgvSP_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                
               
                lblMasp.Text = dgvSP.CurrentRow.Cells[0].Value.ToString();
                lblXuatXu.Text = dgvSP.CurrentRow.Cells[8].Value.ToString();
                lblSLTon.Text = dgvSP.CurrentRow.Cells[3].Value.ToString();
                txtDongia.Text = dgvSP.CurrentRow.Cells[5].Value.ToString();
                txtTenSP.Text = dgvSP.CurrentRow.Cells[1].Value.ToString();
                txtThanhPhan.Text = dgvSP.CurrentRow.Cells[7].Value.ToString();
                txtGianhap.Text=dgvSP.CurrentRow.Cells[4].Value.ToString();
                lblDVT.Text = dgvSP.CurrentRow.Cells[2].Value.ToString();
                lblMalh.Text = dgvSP.CurrentRow.Cells[6].Value.ToString();

            }
            catch { }
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            FRMADDSP f = new FRMADDSP();
            
            f.ShowDialog();
            FormSanPham_Load(sender,e);
        }

        private void btSapxep_Click(object sender, EventArgs e)
        {
            if(rdGiamin.Checked==true)
             
            {
                string str = "Select * from MATHANG ORDER BY DGBAN ASC";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSP.DataSource = dt;
            }
            if (rdXUATXU.Checked==true)
            {
                string str = "Select * from MATHANG ORDER BY XUATXU DESC";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSP.DataSource = dt;
            }
        }

        private void txtGianhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            FRMXOA f = new FRMXOA();

            f.ShowDialog();
            FormSanPham_Load(sender, e);
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            FORMSUA f = new FORMSUA();

            f.ShowDialog();
            FormSanPham_Load(sender, e);
        }

        private void BTLAMMOI_Click(object sender, EventArgs e)
        {
            txtThongtintimkiem.Text = "";
            rdGiamin.Checked = false;
            rdMaSP.Checked = false; 
            rdTenSP.Checked = false; 
            rdXUATXU.Checked = false; 
            FormSanPham_Load(sender, e);
        }
    }
}
