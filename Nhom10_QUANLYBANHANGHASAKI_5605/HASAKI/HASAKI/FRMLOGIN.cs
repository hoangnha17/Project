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
    public partial class FRMLOGIN : Form
    {
        public FRMLOGIN()
        {
            InitializeComponent();
        }
        KetNoi data = new KetNoi();
        private BindingSource bdsoure = new BindingSource();
        private DataTable DT = new DataTable();
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRMLOGIN_Load(object sender, EventArgs e)
        {
            
            bdsoure.DataSource = data.LOGIN();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FRMLOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            

        }

        private void btLogin_Click_1(object sender, EventArgs e)
        {
            //string MANV = txtManv.Text;
            string ID = txtID.Text;
            string Pass = txtPass.Text;

            if (string.IsNullOrEmpty(ID))
            {
                MessageBox.Show("Hãy nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(Pass))
            {
                MessageBox.Show("Hãy nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Focus();
                return;
            }
            /*
            if (string.IsNullOrEmpty(MANV))
            {
                MessageBox.Show("Hãy nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtManv.Focus();
                return;
            }*/
            DT = data.Executequery("select * from USERS where TENDANGNHAP='" + ID + "' AND MATKHAU='" + Pass/*+"'AND MANV='"*+MANV*/+ "'");
            if (DT.Rows.Count > 0)
            {
                FRMGIAODIEN f = new FRMGIAODIEN(DT.Rows[0][3].ToString(), DT.Rows[0][2].ToString());
                this.Hide();
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
