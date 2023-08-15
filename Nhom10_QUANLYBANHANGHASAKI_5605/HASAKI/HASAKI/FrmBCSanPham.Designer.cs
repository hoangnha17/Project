namespace HASAKI
{
    partial class FrmBCSanPham
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
            this.DataSetSANPHAM = new HASAKI.DataSetSANPHAM();
            this.MATHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MATHANGTableAdapter = new HASAKI.DataSetSANPHAMTableAdapters.MATHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSANPHAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MATHANGBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HASAKI.R_SANPHAM.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(22, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1215, 596);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetSANPHAM
            // 
            this.DataSetSANPHAM.DataSetName = "DataSetSANPHAM";
            this.DataSetSANPHAM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MATHANGBindingSource
            // 
            this.MATHANGBindingSource.DataMember = "MATHANG";
            this.MATHANGBindingSource.DataSource = this.DataSetSANPHAM;
            // 
            // MATHANGTableAdapter
            // 
            this.MATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBCSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 631);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmBCSanPham";
            this.Text = "FrmBCSanPham";
            this.Load += new System.EventHandler(this.FrmBCSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSANPHAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MATHANGBindingSource;
        private DataSetSANPHAM DataSetSANPHAM;
        private DataSetSANPHAMTableAdapters.MATHANGTableAdapter MATHANGTableAdapter;
    }
}