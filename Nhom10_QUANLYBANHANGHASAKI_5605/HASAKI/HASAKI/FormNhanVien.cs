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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        private BindingSource bdsoure = new BindingSource();
        private DataTable DT = new DataTable();
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            bdsoure.DataSource = data.NHANVIEN();
            dgvNV.DataSource = bdsoure;
            dgvNV.Columns[0].HeaderText = "Mã MV";
            dgvNV.Columns[1].HeaderText = "Họ NV";
            dgvNV.Columns[2].HeaderText = "Tên NV";
            dgvNV.Columns[3].HeaderText = "Phái";
            dgvNV.Columns[4].HeaderText = "Ngày sinh";
            dgvNV.Columns[5].HeaderText = "Địa chỉ";
            dgvNV.Columns[6].HeaderText = "SĐT";
            dgvNV.Columns[7].HeaderText = "Email";
            dgvNV.Columns[8].HeaderText = "Chức vụ";
            DataGridView x = dgvNV;
            {
                x.Columns[0].Width = 75;
                x.Columns[1].Width = 90;
                x.Columns[2].Width = 90;
                x.Columns[3].Width = 50;
                x.Columns[4].Width = 90;
                x.Columns[5].Width = 160;
                x.Columns[6].Width = 110;
                x.Columns[7].Width = 100;
                x.Columns[7].Width = 80;

                x.GridColor = Color.Indigo;


            }
            //dgvNV.Font = new Font("iCiel Baliho Script", 10, FontStyle.Regular);
            //this.dgvNV.DefaultCellStyle.ForeColor = Color.IndianRed;
            //dgvNV.EnableHeadersVisualStyles = false;
            //dgvNV.ColumnHeadersDefaultCellStyle.BackColor = Color.Indigo;
            //dgvNV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //dgvNV.DefaultCellStyle.BackColor = Color.White;
            //dgvNV.DefaultCellStyle.SelectionBackColor = Color.Violet;
            //dgvNV.AllowUserToResizeColumns = false;
            //dgvNV.AllowUserToResizeRows = false;
            //dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

      
        private void bttruoc_Click(object sender, EventArgs e)
        {
           bdsoure.Position -= 1;

            if (bdsoure.Position == 0)
            {
                btdau.Enabled = false;
                bttruoc.Enabled = false;
            }
            btke.Enabled = true;
            btcuoi.Enabled = true;
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hoNV = txtHoNV.Text;
            string tenNV = txtTenNV.Text;
            string sdt = txtsdt.Text;
            string diachi = txtdiachi.Text;
            string chucvu = txtchucvu.Text;
            string email = txtemail.Text;
            string gioitinh = txtGT.Text;
            string ngaysinh = dtngaysinh.Text;
            data.EXECUTENONQUERY( @"INSERT into NHANVIEN(MANV,HONV,TENNV,GIOITINHNV,NGAYSINH,DIACHINV,DIENTHOAINV,EMAILNV,CHUCVU)
                                    Values('" + maNV + "',N'" + hoNV + "',N'" + tenNV + "',N'" + gioitinh + "',Convert(datetime,'" + ngaysinh + "'),N'" + diachi + "','" + sdt + "','" + email + "',N'" + chucvu + "')");
           
            MessageBox.Show("Thêm thành công " + maNV, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            FormNhanVien_Load(sender, e);
           

        }

        private void dgvNV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {


                txtMaNV.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
                txtHoNV.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();
                txtTenNV.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();
                txtGT.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();
               dtngaysinh.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();
                txtdiachi.Text = dgvNV.CurrentRow.Cells[5].Value.ToString();
                txtsdt.Text = dgvNV.CurrentRow.Cells[6].Value.ToString();
                txtemail.Text = dgvNV.CurrentRow.Cells[7].Value.ToString();
                txtchucvu.Text = dgvNV.CurrentRow.Cells[8].Value.ToString();
            }
            catch { }

        }

        private void btdau_Click(object sender, EventArgs e)
        {
            bdsoure.Position = 0;

            btdau.Enabled = false;
            bttruoc.Enabled = false;
            btke.Enabled = true;
            btcuoi.Enabled = true;
        }

        private void btke_Click(object sender, EventArgs e)
        {
            bdsoure.Position += 1;

            if (bdsoure.Position == bdsoure.Count - 1)
            {
                btke.Enabled = false;
                btcuoi.Enabled = false;
            }
            btdau.Enabled = true;
            bttruoc.Enabled = true;
        }

        private void btcuoi_Click(object sender, EventArgs e)
        {
           bdsoure.Position = bdsoure.Count;

            btdau.Enabled = true;
            bttruoc.Enabled = true;
            btke.Enabled = false;
            btcuoi.Enabled = false;
        }

        private void btfresh_Click(object sender, EventArgs e)
        {
            
            txtThongtintimkiem.Text = "";
            rdMaNV.Checked =false;
            rdTENNV.Checked = false;
            FormNhanVien_Load(sender, e);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string manv= dgvNV.CurrentRow.Cells[0].Value.ToString();
                string delete = @"delete from NHANVIEN
                        where MANV='" + manv + "';";
                data.EXECUTENONQUERY(delete);
                MessageBox.Show("Xóa thành công " + manv , "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                FormNhanVien_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hoNV = txtHoNV.Text;
            string tenNV = txtTenNV.Text;
            string sdt = txtsdt.Text;
            string diachi = txtdiachi.Text;
            string chucvu = txtchucvu.Text;
            string email = txtemail.Text;
            string gioitinh = txtGT.Text;
            string ngaysinh = dtngaysinh.Text;
            string update = @"update NHANVIEN set TENNV = N'" + tenNV +
                "',HONV=N'" + hoNV + "',DIENTHOAINV='" + sdt + "',DIACHINV=N'" + diachi +"',CHUCVU=N'" + chucvu + "',EMAILNV='" + email + "',GIOITINHNV=N'" + gioitinh + "',NGAYSINH='" + ngaysinh  + "' WHERE MANV='" + maNV + "';";
            data.EXECUTENONQUERY(update);
            MessageBox.Show("Sửa thành công " + maNV, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            FormNhanVien_Load(sender, e);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            string tim = txtThongtintimkiem.Text;
            if (rdMaNV.Checked == true)
            {
                string str = "Select * from NHANVIEN where MANV='" + tim + "'";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNV.DataSource = dt;
            }
            if (rdTENNV.Checked == true)
            {
                DataView dv = new DataView(data.Executequery("Select * from NHANVIEN"));
                dv.RowFilter = string.Format("TENNV like '%{0}%'", tim);
                dgvNV.DataSource = dv;
            }
        }
    }
}
