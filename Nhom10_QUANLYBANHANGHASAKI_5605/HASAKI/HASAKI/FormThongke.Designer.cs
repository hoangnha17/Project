namespace HASAKI
{
    partial class FormThongke
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
            this.DataSetNhanvien = new HASAKI.DataSetNhanvien();
            this.NHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NHANVIENTableAdapter = new HASAKI.DataSetNhanvienTableAdapters.NHANVIENTableAdapter();
            this.DataSetSANPHAM = new HASAKI.DataSetSANPHAM();
            this.MATHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MATHANGTableAdapter = new HASAKI.DataSetSANPHAMTableAdapters.MATHANGTableAdapter();
            this.DataSetHOADON = new HASAKI.DataSetHOADON();
            this.HOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HOADONTableAdapter = new HASAKI.DataSetHOADONTableAdapters.HOADONTableAdapter();
            this.DataSetNHACUNGCAP = new HASAKI.DataSetNHACUNGCAP();
            this.NHACUNGCAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NHACUNGCAPTableAdapter = new HASAKI.DataSetNHACUNGCAPTableAdapters.NHACUNGCAPTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBDHD = new System.Windows.Forms.Button();
            this.btnBCNhanvien = new System.Windows.Forms.Button();
            this.btnBCSP = new System.Windows.Forms.Button();
            this.btnBCNCC = new System.Windows.Forms.Button();
            this.btnBCKhachhang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSANPHAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHOADON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNHACUNGCAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHACUNGCAPBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // DataSetNHACUNGCAP
            // 
            this.DataSetNHACUNGCAP.DataSetName = "DataSetNHACUNGCAP";
            this.DataSetNHACUNGCAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NHACUNGCAPBindingSource
            // 
            this.NHACUNGCAPBindingSource.DataMember = "NHACUNGCAP";
            this.NHACUNGCAPBindingSource.DataSource = this.DataSetNHACUNGCAP;
            // 
            // NHACUNGCAPTableAdapter
            // 
            this.NHACUNGCAPTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(417, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC BÁO CÁO THỐNG KÊ";
            // 
            // btnBDHD
            // 
            this.btnBDHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBDHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBDHD.ForeColor = System.Drawing.Color.Red;
            this.btnBDHD.Location = new System.Drawing.Point(968, 144);
            this.btnBDHD.Name = "btnBDHD";
            this.btnBDHD.Size = new System.Drawing.Size(227, 63);
            this.btnBDHD.TabIndex = 1;
            this.btnBDHD.Text = "HÓA ĐƠN ";
            this.btnBDHD.UseVisualStyleBackColor = false;
            this.btnBDHD.Click += new System.EventHandler(this.btnBDHD_Click);
            // 
            // btnBCNhanvien
            // 
            this.btnBCNhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBCNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCNhanvien.ForeColor = System.Drawing.Color.Red;
            this.btnBCNhanvien.Location = new System.Drawing.Point(76, 141);
            this.btnBCNhanvien.Name = "btnBCNhanvien";
            this.btnBCNhanvien.Size = new System.Drawing.Size(247, 63);
            this.btnBCNhanvien.TabIndex = 2;
            this.btnBCNhanvien.Text = "NHÂN VIÊN";
            this.btnBCNhanvien.UseVisualStyleBackColor = false;
            this.btnBCNhanvien.Click += new System.EventHandler(this.btnBCNhanvien_Click);
            // 
            // btnBCSP
            // 
            this.btnBCSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBCSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCSP.ForeColor = System.Drawing.Color.Red;
            this.btnBCSP.Location = new System.Drawing.Point(376, 141);
            this.btnBCSP.Name = "btnBCSP";
            this.btnBCSP.Size = new System.Drawing.Size(250, 63);
            this.btnBCSP.TabIndex = 3;
            this.btnBCSP.Text = "SẢN PHẨM";
            this.btnBCSP.UseVisualStyleBackColor = false;
            this.btnBCSP.Click += new System.EventHandler(this.btnBCSP_Click);
            // 
            // btnBCNCC
            // 
            this.btnBCNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBCNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCNCC.ForeColor = System.Drawing.Color.Red;
            this.btnBCNCC.Location = new System.Drawing.Point(683, 144);
            this.btnBCNCC.Name = "btnBCNCC";
            this.btnBCNCC.Size = new System.Drawing.Size(226, 60);
            this.btnBCNCC.TabIndex = 4;
            this.btnBCNCC.Text = "NHÀ CUNG CẤP";
            this.btnBCNCC.UseVisualStyleBackColor = false;
            this.btnBCNCC.Click += new System.EventHandler(this.btnBCNCC_Click);
            // 
            // btnBCKhachhang
            // 
            this.btnBCKhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBCKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCKhachhang.ForeColor = System.Drawing.Color.Red;
            this.btnBCKhachhang.Location = new System.Drawing.Point(498, 276);
            this.btnBCKhachhang.Name = "btnBCKhachhang";
            this.btnBCKhachhang.Size = new System.Drawing.Size(252, 55);
            this.btnBCKhachhang.TabIndex = 5;
            this.btnBCKhachhang.Text = "KHÁCH HÀNG";
            this.btnBCKhachhang.UseVisualStyleBackColor = false;
            this.btnBCKhachhang.Click += new System.EventHandler(this.btnBCKhachhang_Click);
            // 
            // FormThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1269, 631);
            this.Controls.Add(this.btnBCKhachhang);
            this.Controls.Add(this.btnBCNCC);
            this.Controls.Add(this.btnBCSP);
            this.Controls.Add(this.btnBCNhanvien);
            this.Controls.Add(this.btnBDHD);
            this.Controls.Add(this.label1);
            this.Name = "FormThongke";
            this.Text = "FormThongke";
            this.Load += new System.EventHandler(this.FormThongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetSANPHAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MATHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetHOADON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNHACUNGCAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NHACUNGCAPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource NHANVIENBindingSource;
        private DataSetNhanvien DataSetNhanvien;
        private DataSetNhanvienTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter;
        private System.Windows.Forms.BindingSource MATHANGBindingSource;
        private DataSetSANPHAM DataSetSANPHAM;
        private DataSetSANPHAMTableAdapters.MATHANGTableAdapter MATHANGTableAdapter;
        private System.Windows.Forms.BindingSource HOADONBindingSource;
        private DataSetHOADON DataSetHOADON;
        private DataSetHOADONTableAdapters.HOADONTableAdapter HOADONTableAdapter;
        private System.Windows.Forms.BindingSource NHACUNGCAPBindingSource;
        private DataSetNHACUNGCAP DataSetNHACUNGCAP;
        private DataSetNHACUNGCAPTableAdapters.NHACUNGCAPTableAdapter NHACUNGCAPTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBDHD;
        private System.Windows.Forms.Button btnBCNhanvien;
        private System.Windows.Forms.Button btnBCSP;
        private System.Windows.Forms.Button btnBCNCC;
        private System.Windows.Forms.Button btnBCKhachhang;
    }
}