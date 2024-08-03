namespace Cinema
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTroGiup = new System.Windows.Forms.Button();
            this.btnGioiThieu = new System.Windows.Forms.Button();
            this.btnQLKhachHang = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQLThucAn = new System.Windows.Forms.Button();
            this.btnQLKhuyenMai = new System.Windows.Forms.Button();
            this.btnQLLoaiPhim = new System.Windows.Forms.Button();
            this.btnQLVe = new System.Windows.Forms.Button();
            this.btnQLLichChieuPhim = new System.Windows.Forms.Button();
            this.btnQLPhim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnTroGiup);
            this.panel1.Controls.Add(this.btnGioiThieu);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 664);
            this.panel1.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(3, 449);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(304, 70);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnTroGiup
            // 
            this.btnTroGiup.Location = new System.Drawing.Point(3, 525);
            this.btnTroGiup.Name = "btnTroGiup";
            this.btnTroGiup.Size = new System.Drawing.Size(304, 67);
            this.btnTroGiup.TabIndex = 1;
            this.btnTroGiup.Text = "Trợ Giúp";
            this.btnTroGiup.UseVisualStyleBackColor = true;
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.Location = new System.Drawing.Point(3, 598);
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.Size = new System.Drawing.Size(304, 66);
            this.btnGioiThieu.TabIndex = 0;
            this.btnGioiThieu.Text = "Giới Thiệu";
            this.btnGioiThieu.UseVisualStyleBackColor = true;
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.Location = new System.Drawing.Point(35, 49);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Size = new System.Drawing.Size(228, 145);
            this.btnQLKhachHang.TabIndex = 1;
            this.btnQLKhachHang.Text = "Quản lí khách hàng";
            this.btnQLKhachHang.UseVisualStyleBackColor = true;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Location = new System.Drawing.Point(280, 49);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(226, 145);
            this.btnQLNhanVien.TabIndex = 2;
            this.btnQLNhanVien.Text = "Quản lí nhân viên";
            this.btnQLNhanVien.UseVisualStyleBackColor = true;
            this.btnQLNhanVien.Click += new System.EventHandler(this.btnQLNhanVien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQLKhachHang);
            this.groupBox1.Controls.Add(this.btnQLNhanVien);
            this.groupBox1.Location = new System.Drawing.Point(347, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "1";
            this.groupBox1.Text = "Quản trị";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQLThucAn);
            this.groupBox2.Controls.Add(this.btnQLKhuyenMai);
            this.groupBox2.Controls.Add(this.btnQLLoaiPhim);
            this.groupBox2.Controls.Add(this.btnQLVe);
            this.groupBox2.Controls.Add(this.btnQLLichChieuPhim);
            this.groupBox2.Controls.Add(this.btnQLPhim);
            this.groupBox2.Location = new System.Drawing.Point(347, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 378);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "2";
            this.groupBox2.Text = "Quản lí rạp phim";
            // 
            // btnQLThucAn
            // 
            this.btnQLThucAn.Location = new System.Drawing.Point(608, 41);
            this.btnQLThucAn.Name = "btnQLThucAn";
            this.btnQLThucAn.Size = new System.Drawing.Size(182, 309);
            this.btnQLThucAn.TabIndex = 5;
            this.btnQLThucAn.Text = "Quản lí thức ăn";
            this.btnQLThucAn.UseVisualStyleBackColor = true;
            this.btnQLThucAn.Click += new System.EventHandler(this.btnQLThucAn_Click);
            // 
            // btnQLKhuyenMai
            // 
            this.btnQLKhuyenMai.Location = new System.Drawing.Point(40, 270);
            this.btnQLKhuyenMai.Name = "btnQLKhuyenMai";
            this.btnQLKhuyenMai.Size = new System.Drawing.Size(351, 80);
            this.btnQLKhuyenMai.TabIndex = 4;
            this.btnQLKhuyenMai.Text = "Quản lí khuyến mãi";
            this.btnQLKhuyenMai.UseVisualStyleBackColor = true;
            this.btnQLKhuyenMai.Click += new System.EventHandler(this.btnQLKhuyenMai_Click);
            // 
            // btnQLLoaiPhim
            // 
            this.btnQLLoaiPhim.Location = new System.Drawing.Point(232, 41);
            this.btnQLLoaiPhim.Name = "btnQLLoaiPhim";
            this.btnQLLoaiPhim.Size = new System.Drawing.Size(159, 97);
            this.btnQLLoaiPhim.TabIndex = 3;
            this.btnQLLoaiPhim.Text = "Quản lí loại phim";
            this.btnQLLoaiPhim.UseVisualStyleBackColor = true;
            this.btnQLLoaiPhim.Click += new System.EventHandler(this.btnQLLoaiPhim_Click);
            // 
            // btnQLVe
            // 
            this.btnQLVe.Location = new System.Drawing.Point(425, 41);
            this.btnQLVe.Name = "btnQLVe";
            this.btnQLVe.Size = new System.Drawing.Size(177, 309);
            this.btnQLVe.TabIndex = 2;
            this.btnQLVe.Text = "Quản lí vé";
            this.btnQLVe.UseVisualStyleBackColor = true;
            // 
            // btnQLLichChieuPhim
            // 
            this.btnQLLichChieuPhim.Location = new System.Drawing.Point(40, 41);
            this.btnQLLichChieuPhim.Name = "btnQLLichChieuPhim";
            this.btnQLLichChieuPhim.Size = new System.Drawing.Size(159, 97);
            this.btnQLLichChieuPhim.TabIndex = 1;
            this.btnQLLichChieuPhim.Text = "Quản lí lịch chiếu phim";
            this.btnQLLichChieuPhim.UseVisualStyleBackColor = true;
            this.btnQLLichChieuPhim.Click += new System.EventHandler(this.btnQLLichChieuPhim_Click);
            // 
            // btnQLPhim
            // 
            this.btnQLPhim.Location = new System.Drawing.Point(40, 173);
            this.btnQLPhim.Name = "btnQLPhim";
            this.btnQLPhim.Size = new System.Drawing.Size(351, 70);
            this.btnQLPhim.TabIndex = 0;
            this.btnQLPhim.Text = "Quản lí phim";
            this.btnQLPhim.UseVisualStyleBackColor = true;
            this.btnQLPhim.Click += new System.EventHandler(this.btnQLPhim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 674);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQLKhachHang;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQLThucAn;
        private System.Windows.Forms.Button btnQLKhuyenMai;
        private System.Windows.Forms.Button btnQLLoaiPhim;
        private System.Windows.Forms.Button btnQLVe;
        private System.Windows.Forms.Button btnQLLichChieuPhim;
        private System.Windows.Forms.Button btnQLPhim;
        private System.Windows.Forms.Button btnGioiThieu;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnTroGiup;
    }
}

