namespace HASAKI
{
    partial class FrmBCNhacungcap
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
            this.NHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetNHACUNGCAP = new HASAKI.DataSetNHACUNGCAP();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NHACUNGCAPTableAdapter = new HASAKI.DataSetNHACUNGCAPTableAdapters.NHACUNGCAPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NHACUNGCAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNHACUNGCAP)).BeginInit();
            this.SuspendLayout();
            // 
            // NHACUNGCAPBindingSource
            // 
            this.NHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.NHACUNGCAPBindingSource.DataSource = this.DataSetNHACUNGCAP;
            // 
            // DataSetNHACUNGCAP
            // 
            this.DataSetNHACUNGCAP.DataSetName = "DataSetNHACUNGCAP";
            this.DataSetNHACUNGCAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.NHACUNGCAPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HASAKI.R_NHACUNGCAP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1267, 619);
            this.reportViewer1.TabIndex = 0;
            // 
            // NHACUNGCAPTableAdapter
            // 
            this.NHACUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBCNhacungcap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 631);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmBCNhacungcap";
            this.Text = "FrmBCNhacungcap";
            this.Load += new System.EventHandler(this.FrmBCNhacungcap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NHACUNGCAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNHACUNGCAP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NHACUNGCAPBindingSource;
        private DataSetNHACUNGCAP DataSetNHACUNGCAP;
        private DataSetNHACUNGCAPTableAdapters.NHACUNGCAPTableAdapter NHACUNGCAPTableAdapter;
    }
}