using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASAKI
{
    public partial class FrmBCNhacungcap : Form
    {
        public FrmBCNhacungcap()
        {
            InitializeComponent();
        }

        private void FrmBCNhacungcap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetNHACUNGCAP.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.NHACUNGCAPTableAdapter.Fill(this.DataSetNHACUNGCAP.NHACUNGCAP);

            this.reportViewer1.RefreshReport();
        }
    }
}
