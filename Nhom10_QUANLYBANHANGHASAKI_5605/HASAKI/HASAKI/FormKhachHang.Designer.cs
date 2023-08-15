namespace HASAKI
{
    partial class FormKhachHang
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.btfresh = new System.Windows.Forms.Button();
            this.rbmakh = new System.Windows.Forms.RadioButton();
            this.rbtenkh = new System.Windows.Forms.RadioButton();
            this.rbDC = new System.Windows.Forms.RadioButton();
            this.rbsdt = new System.Windows.Forms.RadioButton();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.cbboxSX = new System.Windows.Forms.ComboBox();
            this.btsapxep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.IndianRed;
            this.txtSearch.Location = new System.Drawing.Point(40, 50);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(395, 28);
            this.txtSearch.TabIndex = 0;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.Transparent;
            this.btSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("iCiel Baliho Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.White;
            this.btSearch.Location = new System.Drawing.Point(441, 50);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(63, 28);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Transparent;
            this.btSua.BackgroundImage = global::HASAKI.Properties.Resources._24;
            this.btSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btSua.FlatAppearance.BorderSize = 2;
            this.btSua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("iCiel Baliho Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Location = new System.Drawing.Point(762, 50);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(82, 30);
            this.btSua.TabIndex = 2;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Transparent;
            this.btXoa.BackgroundImage = global::HASAKI.Properties.Resources.xoa;
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btXoa.FlatAppearance.BorderSize = 2;
            this.btXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("iCiel Baliho Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(842, 50);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(82, 30);
            this.btXoa.TabIndex = 3;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btthem
            // 
            this.btthem.BackColor = System.Drawing.Color.Transparent;
            this.btthem.BackgroundImage = global::HASAKI.Properties.Resources._12;
            this.btthem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btthem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btthem.FlatAppearance.BorderSize = 2;
            this.btthem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btthem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btthem.Font = new System.Drawing.Font("iCiel Baliho Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.Color.White;
            this.btthem.Location = new System.Drawing.Point(686, 50);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(82, 30);
            this.btthem.TabIndex = 4;
            this.btthem.UseVisualStyleBackColor = false;
            this.btthem.Click += new System.EventHandler(this.button2_Click);
            // 
            // btfresh
            // 
            this.btfresh.BackColor = System.Drawing.Color.Transparent;
            this.btfresh.BackgroundImage = global::HASAKI.Properties.Resources.Thiết_kế_không_tên__3_11;
            this.btfresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btfresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btfresh.FlatAppearance.BorderSize = 2;
            this.btfresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btfresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btfresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btfresh.Font = new System.Drawing.Font("iCiel Baliho Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btfresh.ForeColor = System.Drawing.Color.White;
            this.btfresh.Location = new System.Drawing.Point(610, 50);
            this.btfresh.Name = "btfresh";
            this.btfresh.Size = new System.Drawing.Size(82, 30);
            this.btfresh.TabIndex = 5;
            this.btfresh.UseVisualStyleBackColor = false;
            this.btfresh.Click += new System.EventHandler(this.btfresh_Click);
            // 
            // rbmakh
            // 
            this.rbmakh.AutoSize = true;
            this.rbmakh.BackColor = System.Drawing.Color.White;
            this.rbmakh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbmakh.FlatAppearance.BorderSize = 2;
            this.rbmakh.FlatAppearance.CheckedBackColor = System.Drawing.Color.RosyBrown;
            this.rbmakh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbmakh.Font = new System.Drawing.Font("iCiel Baliho Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmakh.ForeColor = System.Drawing.Color.IndianRed;
            this.rbmakh.Location = new System.Drawing.Point(40, 17);
            this.rbmakh.Name = "rbmakh";
            this.rbmakh.Size = new System.Drawing.Size(110, 26);
            this.rbmakh.TabIndex = 6;
            this.rbmakh.TabStop = true;
            this.rbmakh.Text = "Mã khách hàng";
            this.rbmakh.UseVisualStyleBackColor = false;
            // 
            // rbtenkh
            // 
            this.rbtenkh.AutoSize = true;
            this.rbtenkh.BackColor = System.Drawing.Color.Snow;
            this.rbtenkh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rbtenkh.FlatAppearance.BorderSize = 2;
            this.rbtenkh.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rbtenkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtenkh.Font = new System.Drawing.Font("iCiel Baliho Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtenkh.ForeColor = System.Drawing.Color.IndianRed;
            this.rbtenkh.Location = new System.Drawing.Point(156, 17);
            this.rbtenkh.Name = "rbtenkh";
            this.rbtenkh.Size = new System.Drawing.Size(112, 26);
            this.rbtenkh.TabIndex = 7;
            this.rbtenkh.TabStop = true;
            this.rbtenkh.Text = "Tên khách hàng";
            this.rbtenkh.UseVisualStyleBackColor = false;
            // 
            // rbDC
            // 
            this.rbDC.AutoSize = true;
            this.rbDC.BackColor = System.Drawing.Color.Snow;
            this.rbDC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rbDC.FlatAppearance.BorderSize = 2;
            this.rbDC.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rbDC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbDC.Font = new System.Drawing.Font("iCiel Baliho Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDC.ForeColor = System.Drawing.Color.IndianRed;
            this.rbDC.Location = new System.Drawing.Point(274, 17);
            this.rbDC.Name = "rbDC";
            this.rbDC.Size = new System.Drawing.Size(63, 26);
            this.rbDC.TabIndex = 8;
            this.rbDC.TabStop = true;
            this.rbDC.Text = "Địa chỉ";
            this.rbDC.UseVisualStyleBackColor = false;
            // 
            // rbsdt
            // 
            this.rbsdt.AutoSize = true;
            this.rbsdt.BackColor = System.Drawing.Color.Snow;
            this.rbsdt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rbsdt.FlatAppearance.BorderSize = 2;
            this.rbsdt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rbsdt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbsdt.Font = new System.Drawing.Font("iCiel Baliho Script", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsdt.ForeColor = System.Drawing.Color.IndianRed;
            this.rbsdt.Location = new System.Drawing.Point(343, 18);
            this.rbsdt.Name = "rbsdt";
            this.rbsdt.Size = new System.Drawing.Size(96, 26);
            this.rbsdt.TabIndex = 9;
            this.rbsdt.TabStop = true;
            this.rbsdt.Text = "Số điện thoại";
            this.rbsdt.UseVisualStyleBackColor = false;
            // 
            // dgvKH
            // 
            this.dgvKH.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.GridColor = System.Drawing.Color.DarkRed;
            this.dgvKH.Location = new System.Drawing.Point(40, 95);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.Size = new System.Drawing.Size(880, 406);
            this.dgvKH.TabIndex = 10;
            // 
            // cbboxSX
            // 
            this.cbboxSX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbboxSX.Font = new System.Drawing.Font("iCiel Baliho Script", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxSX.ForeColor = System.Drawing.Color.IndianRed;
            this.cbboxSX.FormattingEnabled = true;
            this.cbboxSX.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Tên khách hàng",
            "Giới tính",
            "Địa chỉ"});
            this.cbboxSX.Location = new System.Drawing.Point(610, 17);
            this.cbboxSX.Name = "cbboxSX";
            this.cbboxSX.Size = new System.Drawing.Size(224, 27);
            this.cbboxSX.TabIndex = 11;
            // 
            // btsapxep
            // 
            this.btsapxep.BackColor = System.Drawing.Color.Transparent;
            this.btsapxep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btsapxep.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btsapxep.FlatAppearance.BorderSize = 2;
            this.btsapxep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btsapxep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btsapxep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsapxep.Font = new System.Drawing.Font("iCiel Baliho Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsapxep.ForeColor = System.Drawing.Color.White;
            this.btsapxep.Location = new System.Drawing.Point(842, 15);
            this.btsapxep.Name = "btsapxep";
            this.btsapxep.Size = new System.Drawing.Size(82, 30);
            this.btsapxep.TabIndex = 12;
            this.btsapxep.Text = "Sắp xếp";
            this.btsapxep.UseVisualStyleBackColor = false;
            this.btsapxep.Click += new System.EventHandler(this.btsapxep_Click);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HASAKI.Properties.Resources._6276d52ee94846a65fb6df2b5b3ef3d7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 513);
            this.ControlBox = false;
            this.Controls.Add(this.btsapxep);
            this.Controls.Add(this.cbboxSX);
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.rbsdt);
            this.Controls.Add(this.rbDC);
            this.Controls.Add(this.rbtenkh);
            this.Controls.Add(this.rbmakh);
            this.Controls.Add(this.btfresh);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "FormKhachHang";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btfresh;
        private System.Windows.Forms.RadioButton rbmakh;
        private System.Windows.Forms.RadioButton rbtenkh;
        private System.Windows.Forms.RadioButton rbDC;
        private System.Windows.Forms.RadioButton rbsdt;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.ComboBox cbboxSX;
        private System.Windows.Forms.Button btsapxep;
    }
}