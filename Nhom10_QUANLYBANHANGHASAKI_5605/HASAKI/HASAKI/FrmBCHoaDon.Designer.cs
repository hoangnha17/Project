namespace HASAKI
{
    partial class FrmBCHoaDon
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
            this.DataSetHOADON = new HASAKI.DataSetHOADON();
            this.HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HOADONTableAdapter = new HASAKI.DataSetHOADONTableAdapters.HOADONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHOADON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HOADONBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HASAKI.R_HOADON.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(15, 16);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1253, 603);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetHOADON
            // 
            this.DataSetHOADON.DataSetName = "DataSetHOADON";
            this.DataSetHOADON.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOADONBindingSource
            // 
            this.HOADONBindingSource.DataMember = "HOADON";
            this.HOADONBindingSource.DataSource = this.DataSetHOADON;
            // 
            // HOADONTableAdapter
            // 
            this.HOADONTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBCHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 631);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmBCHoaDon";
            this.Text = "FrmBCHoaDon";
            this.Load += new System.EventHandler(this.FrmBCHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHOADON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HOADONBindingSource;
        private DataSetHOADON DataSetHOADON;
        private DataSetHOADONTableAdapters.HOADONTableAdapter HOADONTableAdapter;
    }
}