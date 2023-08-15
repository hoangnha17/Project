namespace HASAKI
{
    partial class FRMGIAODIEN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMGIAODIEN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Body = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btThoat = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btHome = new System.Windows.Forms.Button();
            this.btKho = new System.Windows.Forms.Button();
            this.btThongke = new System.Windows.Forms.Button();
            this.btNhanvien = new System.Windows.Forms.Button();
            this.btHoadon = new System.Windows.Forms.Button();
            this.btKhachang = new System.Windows.Forms.Button();
            this.btSP = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.btTaiKhoan = new System.Windows.Forms.Button();
            this.lblTentrang = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel_Body);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel_top);
            this.panel1.Location = new System.Drawing.Point(-4, -39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1799, 971);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_Body
            // 
            this.panel_Body.BackColor = System.Drawing.Color.Transparent;
            this.panel_Body.BackgroundImage = global::HASAKI.Properties.Resources._33677014;
            this.panel_Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Body.Location = new System.Drawing.Point(237, 129);
            this.panel_Body.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_Body.Name = "panel_Body";
            this.panel_Body.Size = new System.Drawing.Size(1291, 679);
            this.panel_Body.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.pnlNav);
            this.panel2.Controls.Add(this.btThoat);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btKho);
            this.panel2.Controls.Add(this.btThongke);
            this.panel2.Controls.Add(this.btNhanvien);
            this.panel2.Controls.Add(this.btHoadon);
            this.panel2.Controls.Add(this.btKhachang);
            this.panel2.Controls.Add(this.btSP);
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 748);
            this.panel2.TabIndex = 1;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Gold;
            this.pnlNav.Location = new System.Drawing.Point(1, 178);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(13, 123);
            this.pnlNav.TabIndex = 1;
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Transparent;
            this.btThoat.BackgroundImage = global::HASAKI.Properties.Resources.Thiết_kế_không_tên__6_;
            this.btThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.SeaShell;
            this.btThoat.Location = new System.Drawing.Point(-1, 666);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(237, 82);
            this.btThoat.TabIndex = 9;
            this.btThoat.Text = "Đăng xuất";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Controls.Add(this.btHome);
            this.panel4.Location = new System.Drawing.Point(-3, -4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(241, 130);
            this.panel4.TabIndex = 8;
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.Color.Transparent;
            this.btHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btHome.BackgroundImage")));
            this.btHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHome.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Location = new System.Drawing.Point(67, 20);
            this.btHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(111, 82);
            this.btHome.TabIndex = 0;
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // btKho
            // 
            this.btKho.BackColor = System.Drawing.Color.Transparent;
            this.btKho.BackgroundImage = global::HASAKI.Properties.Resources.Thiết_kế_không_tên__7_;
            this.btKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btKho.FlatAppearance.BorderSize = 0;
            this.btKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btKho.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKho.ForeColor = System.Drawing.Color.SeaShell;
            this.btKho.Location = new System.Drawing.Point(-1, 571);
            this.btKho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btKho.Name = "btKho";
            this.btKho.Size = new System.Drawing.Size(240, 95);
            this.btKho.TabIndex = 6;
            this.btKho.Text = "Nhà cung cấp";
            this.btKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btKho.UseVisualStyleBackColor = false;
            this.btKho.Click += new System.EventHandler(this.btKho_Click);
            this.btKho.Leave += new System.EventHandler(this.btKho_Leave);
            // 
            // btThongke
            // 
            this.btThongke.BackColor = System.Drawing.Color.Transparent;
            this.btThongke.BackgroundImage = global::HASAKI.Properties.Resources.Thiết_kế_không_tên__8_;
            this.btThongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btThongke.FlatAppearance.BorderSize = 0;
            this.btThongke.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btThongke.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongke.ForeColor = System.Drawing.Color.SeaShell;
            this.btThongke.Location = new System.Drawing.Point(-4, 487);
            this.btThongke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThongke.Name = "btThongke";
            this.btThongke.Size = new System.Drawing.Size(240, 86);
            this.btThongke.TabIndex = 5;
            this.btThongke.Text = "Báo cáo";
            this.btThongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThongke.UseVisualStyleBackColor = false;
            this.btThongke.Click += new System.EventHandler(this.btThongke_Click);
            this.btThongke.Leave += new System.EventHandler(this.btThongke_Leave);
            // 
            // btNhanvien
            // 
            this.btNhanvien.BackColor = System.Drawing.Color.Transparent;
            this.btNhanvien.BackgroundImage = global::HASAKI.Properties.Resources.Thiết_kế_không_tên__11_;
            this.btNhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btNhanvien.FlatAppearance.BorderSize = 0;
            this.btNhanvien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btNhanvien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhanvien.ForeColor = System.Drawing.Color.SeaShell;
            this.btNhanvien.Location = new System.Drawing.Point(-3, 388);
            this.btNhanvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNhanvien.Name = "btNhanvien";
            this.btNhanvien.Size = new System.Drawing.Size(239, 92);
            this.btNhanvien.TabIndex = 4;
            this.btNhanvien.Text = "Nhân viên";
            this.btNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNhanvien.UseVisualStyleBackColor = false;
            this.btNhanvien.Click += new System.EventHandler(this.btNhanvien_Click);
            this.btNhanvien.Leave += new System.EventHandler(this.btNhanvien_Leave);
            // 
            // btHoadon
            // 
            this.btHoadon.BackColor = System.Drawing.Color.Transparent;
            this.btHoadon.BackgroundImage = global::HASAKI.Properties.Resources.Thiết_kế_không_tên__10_;
            this.btHoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btHoadon.FlatAppearance.BorderSize = 0;
            this.btHoadon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btHoadon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btHoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoadon.ForeColor = System.Drawing.Color.SeaShell;
            this.btHoadon.Location = new System.Drawing.Point(-4, 300);
            this.btHoadon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btHoadon.Name = "btHoadon";
            this.btHoadon.Size = new System.Drawing.Size(241, 80);
            this.btHoadon.TabIndex = 3;
            this.btHoadon.Text = "Hóa đơn";
            this.btHoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btHoadon.UseVisualStyleBackColor = false;
            this.btHoadon.Click += new System.EventHandler(this.btHoadon_Click);
            this.btHoadon.Leave += new System.EventHandler(this.btHoadon_Leave);
            // 
            // btKhachang
            // 
            this.btKhachang.BackColor = System.Drawing.Color.Transparent;
            this.btKhachang.BackgroundImage = global::HASAKI.Properties.Resources.khachhang;
            this.btKhachang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btKhachang.FlatAppearance.BorderSize = 0;
            this.btKhachang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btKhachang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btKhachang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKhachang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhachang.ForeColor = System.Drawing.Color.SeaShell;
            this.btKhachang.Location = new System.Drawing.Point(-4, 212);
            this.btKhachang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btKhachang.Name = "btKhachang";
            this.btKhachang.Size = new System.Drawing.Size(243, 90);
            this.btKhachang.TabIndex = 2;
            this.btKhachang.Text = "Khách hàng";
            this.btKhachang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btKhachang.UseVisualStyleBackColor = false;
            this.btKhachang.Click += new System.EventHandler(this.btKhachang_Click);
            this.btKhachang.Leave += new System.EventHandler(this.btKhachang_Leave);
            // 
            // btSP
            // 
            this.btSP.BackColor = System.Drawing.Color.Transparent;
            this.btSP.BackgroundImage = global::HASAKI.Properties.Resources.Thiết_kế_không_tên;
            this.btSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSP.FlatAppearance.BorderSize = 0;
            this.btSP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSP.ForeColor = System.Drawing.Color.SeaShell;
            this.btSP.Location = new System.Drawing.Point(-3, 127);
            this.btSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSP.Name = "btSP";
            this.btSP.Size = new System.Drawing.Size(241, 86);
            this.btSP.TabIndex = 1;
            this.btSP.Text = "Sản phẩm";
            this.btSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSP.UseVisualStyleBackColor = false;
            this.btSP.Click += new System.EventHandler(this.btSP_Click);
            this.btSP.Leave += new System.EventHandler(this.btSP_Leave);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel_top.Controls.Add(this.lbluser);
            this.panel_top.Controls.Add(this.lblTen);
            this.panel_top.Controls.Add(this.btTaiKhoan);
            this.panel_top.Controls.Add(this.lblTentrang);
            this.panel_top.Location = new System.Drawing.Point(233, 36);
            this.panel_top.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1295, 102);
            this.panel_top.TabIndex = 2;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.DarkRed;
            this.lbluser.Location = new System.Drawing.Point(1007, 57);
            this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(127, 20);
            this.lbluser.TabIndex = 9;
            this.lbluser.Text = "Nguyễn Văn A";
            this.lbluser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTen.Location = new System.Drawing.Point(995, 33);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(127, 20);
            this.lblTen.TabIndex = 8;
            this.lblTen.Text = "Nguyễn Văn A";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btTaiKhoan
            // 
            this.btTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.btTaiKhoan.BackgroundImage = global::HASAKI.Properties.Resources.Thiết_kế_không_tên__13_;
            this.btTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btTaiKhoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btTaiKhoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaiKhoan.ForeColor = System.Drawing.Color.SeaShell;
            this.btTaiKhoan.Location = new System.Drawing.Point(1156, -26);
            this.btTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTaiKhoan.Name = "btTaiKhoan";
            this.btTaiKhoan.Size = new System.Drawing.Size(143, 122);
            this.btTaiKhoan.TabIndex = 7;
            this.btTaiKhoan.Text = "Đổi mật khẩu";
            this.btTaiKhoan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btTaiKhoan.UseVisualStyleBackColor = false;
            this.btTaiKhoan.Click += new System.EventHandler(this.btTaiKhoan_Click);
            this.btTaiKhoan.Leave += new System.EventHandler(this.btTaiKhoan_Leave);
            // 
            // lblTentrang
            // 
            this.lblTentrang.AutoSize = true;
            this.lblTentrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentrang.ForeColor = System.Drawing.Color.White;
            this.lblTentrang.Location = new System.Drawing.Point(27, 20);
            this.lblTentrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTentrang.Name = "lblTentrang";
            this.lblTentrang.Size = new System.Drawing.Size(221, 39);
            this.lblTentrang.TabIndex = 0;
            this.lblTentrang.Text = "TRANG CHỦ";
            // 
            // FRMGIAODIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1517, 743);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FRMGIAODIEN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMGIAODIEN";
            this.Load += new System.EventHandler(this.FRMGIAODIEN_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSP;
        private System.Windows.Forms.Button btKhachang;
        private System.Windows.Forms.Button btThongke;
        private System.Windows.Forms.Button btNhanvien;
        private System.Windows.Forms.Button btHoadon;
        private System.Windows.Forms.Button btKho;
        private System.Windows.Forms.Button btTaiKhoan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lblTentrang;
        private System.Windows.Forms.Panel panel_Body;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lbluser;
    }
}