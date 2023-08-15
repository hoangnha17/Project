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
    public partial class FormTaikhoan : Form
    {
        KetNoi data = new KetNoi();
      
        public FormTaikhoan()
        {
            InitializeComponent();
            
           
        }
      
       SqlConnection cn=new SqlConnection(@"Data Source=DESKTOP-4VN354L\HP;Initial Catalog=QUANLYBANHANGHASAKI;Integrated Security=True");
        private void btLogin_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("select count(*) from LOGIN where ID=N'" + txtID.Text + "'AND PASS=N'" + txtPass.Text + "'",cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                if( (txtnewpass.Text == txtnhaplai.Text )&&(txtnewpass.Text!=""))
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("Update LOGIN set PASS = N'" + txtnewpass.Text + "' WHERE ID = N'" + txtID.Text + "'AND PASS = N'" + txtPass.Text + "'",cn);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    MessageBox.Show("Đổi mật khẩu thành công ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }else
            {
                MessageBox.Show("ID hoặc Pass không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FormTaikhoan_Load(object sender, EventArgs e)
        {
        
            string str = "select * from LOGIN";
            SqlDataAdapter da = new SqlDataAdapter(str, data.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtID.DataBindings.Add("Text", dt, "ID");
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
