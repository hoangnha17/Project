using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HASAKI
{
    public partial class FRMGIAODIEN : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );
        KetNoi data = new KetNoi();
        private BindingSource bdsoure = new BindingSource();
        private DataTable DT = new DataTable();
        string QUYEN = "";
        string MANV = "";
        public FRMGIAODIEN(string QUYEN,string MANV)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btSP.Height;
            pnlNav.Top = btSP.Top;
            pnlNav.Left = btSP.Left;
            this.QUYEN = QUYEN;
            this.MANV = MANV;
        }

        

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void FRMGIAODIEN_Load(object sender, EventArgs e)
        {
            bdsoure.DataSource = data.LOGIN();
            DT= data.Executequery("select HONV+' '+TENNV from NHANVIEN where MANV='" + MANV +"'");
            //lblTen.Text = DT.Rows[0][0].ToString();
            lbluser.Text = QUYEN;
            string x = "Quản lý";
            if (String.Compare(QUYEN, x, true) == 0)
            {
                lblTentrang.Text = "ss đúng";
            }
            
            
        }
       
        private void btHome_Click(object sender, EventArgs e)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
           
            
            lblTentrang.Text = "Trang chủ";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSanPham());
            lblTentrang.Text = btSP.Text;
            pnlNav.Height = btSP.Height;
            pnlNav.Top = btSP.Top;
            pnlNav.Left = btSP.Left;
            btSP.BackColor = Color.IndianRed;



        }

        private void btKhachang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachHang());
            lblTentrang.Text = btKhachang.Text;
            pnlNav.Height = btKhachang.Height;
            pnlNav.Top = btKhachang.Top;
            pnlNav.Left = btKhachang.Left;
            btKhachang.BackColor = Color.IndianRed;
        }

        private void btHoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon());
            lblTentrang.Text = btHoadon.Text;
            pnlNav.Height = btHoadon.Height;
            pnlNav.Top = btHoadon.Top;
            pnlNav.Left = btHoadon.Left;
            btHoadon.BackColor = Color.IndianRed;
        }

        private void btNhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien());
            lblTentrang.Text = btNhanvien.Text;
            pnlNav.Height = btNhanvien.Height;
            pnlNav.Top = btNhanvien.Top;
            pnlNav.Left = btNhanvien.Left;
            btNhanvien.BackColor = Color.IndianRed;
        }

        private void btThongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThongke());
            lblTentrang.Text = btThongke.Text;
            pnlNav.Height = btThongke.Height;
            pnlNav.Top = btThongke.Top;
            pnlNav.Left = btThongke.Left;
            btThongke.BackColor = Color.IndianRed;
        }

        private void btKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNCC());
            lblTentrang.Text = btKho.Text;
            pnlNav.Height = btKho.Height;
            pnlNav.Top = btKho.Top;
            pnlNav.Left = btKho.Left;
            btKho.BackColor = Color.IndianRed;
        }

        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            FormTaikhoan F = new FormTaikhoan();
            
            F.ShowDialog();

            lblTentrang.Text = btTaiKhoan.Text;
            pnlNav.Height = btTaiKhoan.Height;
            pnlNav.Top = btTaiKhoan.Top;
            pnlNav.Left = btTaiKhoan.Left;
            btTaiKhoan.BackColor = Color.IndianRed;
            FRMGIAODIEN_Load(sender, e);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();

                FRMLOGIN F = new FRMLOGIN();
                this.Hide();
                F.ShowDialog();
            }
        }

        private void btSP_Leave(object sender, EventArgs e)
        {
            btSP.BackColor = Color.Transparent;
        }

        private void btKhachang_Leave(object sender, EventArgs e)
        {
            btKhachang.BackColor = Color.Transparent;
        }

        private void btHoadon_Leave(object sender, EventArgs e)
        {
            btHoadon.BackColor = Color.Transparent;
        }

        private void btNhanvien_Leave(object sender, EventArgs e)
        {
            btNhanvien.BackColor = Color.Transparent;
        }

        private void btThongke_Leave(object sender, EventArgs e)
        {
            btThongke.BackColor = Color.Transparent;
        }

        private void btKho_Leave(object sender, EventArgs e)
        {
            btKho.BackColor = Color.Transparent;
        }

        private void btTaiKhoan_Leave(object sender, EventArgs e)
        {
            btTaiKhoan.BackColor = Color.Transparent;
        }
    }
}
