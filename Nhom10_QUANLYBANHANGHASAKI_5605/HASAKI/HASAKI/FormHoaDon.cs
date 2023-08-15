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
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        private BindingSource bdsoure = new BindingSource();
        private DataTable DT = new DataTable();
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            bdsoure.DataSource = data.hoadon();
            dgvDH.DataSource = bdsoure;
            dgvDH.Columns[0].HeaderText = "Mã Đơn hàng";
            dgvDH.Columns[1].HeaderText = "Mã khách hàng";
            dgvDH.Columns[2].HeaderText = "Mã nhân viên";
            dgvDH.Columns[3].HeaderText = "Trị giá";
            dgvDH.Columns[4].HeaderText = "Ngày lập";
            dgvDH.Columns[5].HeaderText = "Phương thức thanh toán";
            
            //dgvDH.Columns[6].HeaderText = "Giảm giá";
            
            DataGridView x = dgvDH;
            {
                x.Columns[0].Width = 100;
                x.Columns[1].Width = 100;
                x.Columns[2].Width = 100;
                x.Columns[3].Width = 100;
                x.Columns[4].Width = 90;
                x.Columns[5].Width = 160;
                //x.Columns[6].Width = 110;
                
                

                x.GridColor = Color.Wheat;


            }
            dgvDH.Font = new Font("iCiel Baliho Script", 10, FontStyle.Regular);
            this.dgvDH.DefaultCellStyle.ForeColor = Color.IndianRed;
            dgvDH.EnableHeadersVisualStyles = false;
            dgvDH.ColumnHeadersDefaultCellStyle.BackColor = Color.Salmon;
            dgvDH.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDH.DefaultCellStyle.BackColor = Color.White;
            dgvDH.DefaultCellStyle.SelectionBackColor = Color.Salmon;
            dgvDH.AllowUserToResizeColumns = false;
            dgvDH.AllowUserToResizeRows = false;
            dgvDH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvDH_SelectionChanged(object sender, EventArgs e)
        {
            try
            {


                txtMahd.Text = dgvDH.CurrentRow.Cells[0].Value.ToString();
                txtMakh.Text = dgvDH.CurrentRow.Cells[1].Value.ToString();
                txtManv.Text = dgvDH.CurrentRow.Cells[2].Value.ToString();
                txtTG.Text = dgvDH.CurrentRow.Cells[3].Value.ToString();
                dtNgaylap.Text = dgvDH.CurrentRow.Cells[4].Value.ToString();
                txtPTTT.Text = dgvDH.CurrentRow.Cells[5].Value.ToString();
                txtGiamgia.Text = dgvDH.CurrentRow.Cells[6].Value.ToString();
              
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
            txtThongtintim.Text = "";
            chkMahd.Checked = false;
            chkMakh.Checked = false;
            chkManv.Checked = false;
            FormHoaDon_Load(sender, e);
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            string Mahd = txtMahd.Text;
            string Makh = txtMakh.Text;
            string Manv = txtManv.Text;
            string Trigia = txtTG.Text;
            string Ngaylap = dtNgaylap.Text;
            string PTTT = txtPTTT.Text;
            string Giamgia = txtGiamgia.Text;
            data.EXECUTENONQUERY(@"INSERT into HOADON(MADH,MAKH,MANV,TRIGIA,NGAYLAP,PTTT,GIAMGIA)
                                    Values('" + Mahd + "','" + Makh + "','" + Manv + "','" + Trigia + "',Convert(datetime,'" + Ngaylap + "'),N'" + PTTT + "','" + Giamgia + "')");

            MessageBox.Show("Thêm thành công " + Mahd, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            FormHoaDon_Load(sender, e);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string mahd = dgvDH.CurrentRow.Cells[0].Value.ToString();
                string delete = @"delete from HOADON
                        where MADH='" + mahd + "';";
                data.EXECUTENONQUERY(delete);
                MessageBox.Show("Xóa thành công " + mahd, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                FormHoaDon_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            string Mahd = txtMahd.Text;
            string Makh = txtMakh.Text;
            string Manv = txtManv.Text;
            string Trigia = txtTG.Text;
            string Ngaylap = dtNgaylap.Text;
            string PTTT = txtPTTT.Text;
            string Giamgia = txtGiamgia.Text;
            string update = @"update HOADON set MAKH = '" + Makh +
               "',MANV='" + Manv + "',TRIGIA='" + Trigia + "',NGAYLAP='" + Ngaylap + "',PTTT=N'" + PTTT + "',GIAMGIA='" + Giamgia + "' WHERE MADH='" + Mahd + "';";
            data.EXECUTENONQUERY(update);
            MessageBox.Show("Sửa thành công " + Mahd, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            FormHoaDon_Load(sender, e);
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            string tim = txtThongtintim.Text;
            if (chkMahd.Checked == true)
            {
                string str = "Select * from HOADON where MADH='" + tim + "'";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDH.DataSource = dt;
            }
            if (chkMakh.Checked == true )
            {
                string str = "Select * from HOADON where MAKH='" + tim + "'";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDH.DataSource = dt;
            }
            if (chkManv.Checked==true)
            {
                string str = "Select * from HOADON where MANV='" + tim + "'";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDH.DataSource = dt;
            }
        }

       

       

      
    }
}
