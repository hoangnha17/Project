namespace HASAKI
{
    partial class FrmBCNhanVien
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetNhanvien = new HASAKI.DataSetNhanvien();
            this.NHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NHANVIENTableAdapter = new HASAKI.DataSetNhanvienTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NHANVIENBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HASAKI.R_NHANVIEN.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(38, 24);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1219, 494);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetNhanvien
            // 
            this.DataSetNhanvien.DataSetName = "DataSetNhanvien";
            this.DataSetNhanvien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NHANVIENBindingSource
            // 
            this.NHANVIENBindingSource.DataMember = "NHANVIEN";
            this.NHANVIENBindingSource.DataSource = this.DataSetNhanvien;
            // 
            // NHANVIENTableAdapter
            // 
            this.NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBCNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 631);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmBCNhanVien";
            this.Text = "FrmBCNhanVien";
            this.Load += new System.EventHandler(this.FrmBCNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NHANVIENBindingSource;
        private DataSetNhanvien DataSetNhanvien;
        private DataSetNhanvienTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter;
    }
}