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
    public partial class FormNCC : Form
    {
        public FormNCC()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        private BindingSource bdsoure = new BindingSource();
        private DataTable DT = new DataTable();
        private void FormNCC_Load(object sender, EventArgs e)
        {
            bdsoure.DataSource = data.NCC();
            dgvNCC.DataSource = bdsoure;
            dgvNCC.Columns[0].HeaderText = "Mã NCC";
            dgvNCC.Columns[1].HeaderText = "Tên NCC";
            dgvNCC.Columns[2].HeaderText = "Địa chỉ NCC";
            dgvNCC.Columns[3].HeaderText = "Điện thoại";
            dgvNCC.Columns[4].HeaderText = "WEB";
            

            DataGridView x = dgvNCC;
            {
                x.Columns[0].Width = 80;
                x.Columns[1].Width = 100;
                x.Columns[2].Width = 100;
                x.Columns[3].Width = 70;
                x.Columns[4].Width = 200;
               


                x.GridColor = Color.DarkRed;


            }

            dgvNCC.Font = new Font("iCiel Baliho Script", 10, FontStyle.Regular);
            this.dgvNCC.DefaultCellStyle.ForeColor = Color.DarkRed;
            dgvNCC.EnableHeadersVisualStyles = false;
            dgvNCC.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvNCC.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNCC.DefaultCellStyle.BackColor = Color.White;
            dgvNCC.DefaultCellStyle.SelectionBackColor = Color.IndianRed;
            dgvNCC.AllowUserToResizeColumns = false;
            dgvNCC.AllowUserToResizeRows = false;
            dgvNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
           txtTimMaNCC.Text = "";
            txtTimTenNCC.Text = "";

            chkMaNCC.Checked = false;
            chkTenNCC.Checked = false;
            
            FormNCC_Load(sender, e);
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNCC = txtMaNCC.Text;
                string TenNCC = txtTenNCC.Text;
                string DiachiNCC = txtDiachiNCC.Text;
                string DT = txtDtNCC.Text;
                string WEB = txtWeb.Text;
                data.EXECUTENONQUERY(@"INSERT into NHACUNGCAP(MANCC,TENNCC,DIACHINCC,DIENTHOAIKH,WEB)
                                    Values('" + MaNCC + "',N'" + TenNCC + "',N'" + DiachiNCC + "','" + DT + "',N'" + WEB + "')");

                MessageBox.Show("Thêm thành công " + MaNCC, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                FormNCC_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maNCC = dgvNCC.CurrentRow.Cells[0].Value.ToString();
                string delete = @"delete from NHACUNGCAP
                        where MANCC='" + maNCC + "';";
                data.EXECUTENONQUERY(delete);
                MessageBox.Show("Xóa thành công " + maNCC, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                FormNCC_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNCC = txtMaNCC.Text;
                string TenNCC = txtTenNCC.Text;
                string DiachiNCC = txtDiachiNCC.Text;
                string DT = txtDtNCC.Text;
                string WEB = txtWeb.Text;
                string update = @"update NHACUNGCAP set MANCC = '" + MaNCC +
                  "',TENNCC=N'" + TenNCC + "',DIACHINCC=N'" + DiachiNCC + "',DIENTHOAIKH='" + DT + "',WEB=N'" + WEB + "' WHERE MANCC='" + MaNCC + "';";
                data.EXECUTENONQUERY(update);
                MessageBox.Show("Sửa thành công " + MaNCC, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                FormNCC_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            if (chkMaNCC.Checked == true)
            {
                string str = "Select* from NHACUNGCAP where MANCC='" + txtTimMaNCC.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNCC.DataSource = dt;

            }
            if (chkTenNCC.Checked == true)
            {
                string str = "Select* from NHACUNGCAP where TENNCC=N'" + txtTimTenNCC.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNCC.DataSource = dt;

            }
        }

        private void dgvNCC_SelectionChanged(object sender, EventArgs e)
        {
            try
            {


                txtMaNCC.Text = dgvNCC.CurrentRow.Cells[0].Value.ToString();
                txtTenNCC.Text = dgvNCC.CurrentRow.Cells[1].Value.ToString();
                txtDiachiNCC.Text = dgvNCC.CurrentRow.Cells[2].Value.ToString();
                txtDtNCC.Text = dgvNCC.CurrentRow.Cells[3].Value.ToString();
                txtWeb.Text = dgvNCC.CurrentRow.Cells[4].Value.ToString();


            }
            catch { }
        }
    }
}
