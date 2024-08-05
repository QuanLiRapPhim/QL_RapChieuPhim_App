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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnTroGiup = new System.Windows.Forms.Button();
            this.btnGioiThieu = new System.Windows.Forms.Button();
            this.btnQLKhachHang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQLVe = new System.Windows.Forms.Button();
            this.btnQLKhuyenMai = new System.Windows.Forms.Button();
            this.btnCacPhim = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnTroGiup);
            this.panel1.Controls.Add(this.btnGioiThieu);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 664);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "TRANG CHỦ";
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
            this.btnTroGiup.Click += new System.EventHandler(this.btnTroGiup_Click);
            // 
            // btnGioiThieu
            // 
            this.btnGioiThieu.Location = new System.Drawing.Point(3, 598);
            this.btnGioiThieu.Name = "btnGioiThieu";
            this.btnGioiThieu.Size = new System.Drawing.Size(304, 66);
            this.btnGioiThieu.TabIndex = 0;
            this.btnGioiThieu.Text = "Giới Thiệu";
            this.btnGioiThieu.UseVisualStyleBackColor = true;
            this.btnGioiThieu.Click += new System.EventHandler(this.btnGioiThieu_Click);
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnQLKhachHang.Location = new System.Drawing.Point(74, 44);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Size = new System.Drawing.Size(338, 122);
            this.btnQLKhachHang.TabIndex = 1;
            this.btnQLKhachHang.Text = "Quản lí khách hàng";
            this.btnQLKhachHang.UseVisualStyleBackColor = false;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnQLKhachHang);
            this.groupBox2.Controls.Add(this.btnQLVe);
            this.groupBox2.Controls.Add(this.btnQLKhuyenMai);
            this.groupBox2.Controls.Add(this.btnCacPhim);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(325, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(911, 448);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Tag = "2";
            this.groupBox2.Text = "Quản lí rạp phim";
            // 
            // btnQLVe
            // 
            this.btnQLVe.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnQLVe.Location = new System.Drawing.Point(511, 257);
            this.btnQLVe.Name = "btnQLVe";
            this.btnQLVe.Size = new System.Drawing.Size(340, 123);
            this.btnQLVe.TabIndex = 5;
            this.btnQLVe.Text = "Quản lí vé";
            this.btnQLVe.UseVisualStyleBackColor = false;
            this.btnQLVe.Click += new System.EventHandler(this.btnQLVe_Click_1);
            // 
            // btnQLKhuyenMai
            // 
            this.btnQLKhuyenMai.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnQLKhuyenMai.Location = new System.Drawing.Point(74, 258);
            this.btnQLKhuyenMai.Name = "btnQLKhuyenMai";
            this.btnQLKhuyenMai.Size = new System.Drawing.Size(340, 122);
            this.btnQLKhuyenMai.TabIndex = 4;
            this.btnQLKhuyenMai.Text = "Quản lí khuyến mãi";
            this.btnQLKhuyenMai.UseVisualStyleBackColor = false;
            this.btnQLKhuyenMai.Click += new System.EventHandler(this.btnQLKhuyenMai_Click);
            // 
            // btnCacPhim
            // 
            this.btnCacPhim.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCacPhim.Location = new System.Drawing.Point(511, 44);
            this.btnCacPhim.Name = "btnCacPhim";
            this.btnCacPhim.Size = new System.Drawing.Size(338, 123);
            this.btnCacPhim.TabIndex = 2;
            this.btnCacPhim.Text = "Quản lí các phim";
            this.btnCacPhim.UseVisualStyleBackColor = false;
            this.btnCacPhim.Click += new System.EventHandler(this.btnQLVe_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(314, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 676);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(325, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 206);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.label2.Location = new System.Drawing.Point(186, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 148);
            this.label2.TabIndex = 6;
            this.label2.Text = "CINEMA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1238, 674);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQLKhachHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnQLKhuyenMai;
        private System.Windows.Forms.Button btnCacPhim;
        private System.Windows.Forms.Button btnGioiThieu;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnTroGiup;
        private System.Windows.Forms.Button btnQLVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}

