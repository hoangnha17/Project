namespace HASAKI
{
    partial class FrmBCKhachhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.KHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetKHACHHANG = new HASAKI.DataSetKHACHHANG();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KHACHHANGTableAdapter = new HASAKI.DataSetKHACHHANGTableAdapters.KHACHHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetKHACHHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // KHACHHANGBindingSource
            // 
            this.KHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.KHACHHANGBindingSource.DataSource = this.DataSetKHACHHANG;
            // 
            // DataSetKHACHHANG
            // 
            this.DataSetKHACHHANG.DataSetName = "DataSetKHACHHANG";
            this.DataSetKHACHHANG.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KHACHHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HASAKI.R_KHACHHANG.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1269, 616);
            this.reportViewer1.TabIndex = 0;
            // 
            // KHACHHANGTableAdapter
            // 
            this.KHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBCKhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 631);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmBCKhachhang";
            this.Text = "FrmBCKhachhang";
            this.Load += new System.EventHandler(this.FrmBCKhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetKHACHHANG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KHACHHANGBindingSource;
        private DataSetKHACHHANG DataSetKHACHHANG;
        private DataSetKHACHHANGTableAdapters.KHACHHANGTableAdapter KHACHHANGTableAdapter;
    }
}