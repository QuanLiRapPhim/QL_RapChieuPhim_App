namespace Cinema
{
    partial class Phim
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtDaoDien = new System.Windows.Forms.TextBox();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtTomTat = new System.Windows.Forms.TextBox();
            this.txtHinhAnh = new System.Windows.Forms.TextBox();
            this.btnThemHinhAnh = new System.Windows.Forms.Button();
            this.btnThemPhim = new System.Windows.Forms.Button();
            this.btnXoaPhim = new System.Windows.Forms.Button();
            this.btnSuaPhim = new System.Windows.Forms.Button();
            this.Dat_ngaykhoichieu = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 394);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(930, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.FormattingEnabled = true;
            this.cboTheLoai.Location = new System.Drawing.Point(17, 112);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(276, 28);
            this.cboTheLoai.TabIndex = 1;
            this.cboTheLoai.SelectedIndexChanged += new System.EventHandler(this.cboTheLoai_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Phim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đạo diễn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tóm tắt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày khởi chiếu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hình ảnh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tên phim:";
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.Location = new System.Drawing.Point(497, 93);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.ReadOnly = true;
            this.txtMaPhim.Size = new System.Drawing.Size(390, 26);
            this.txtMaPhim.TabIndex = 11;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.Location = new System.Drawing.Point(497, 135);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(390, 26);
            this.txtTenPhim.TabIndex = 12;
            // 
            // txtDaoDien
            // 
            this.txtDaoDien.Location = new System.Drawing.Point(497, 176);
            this.txtDaoDien.Name = "txtDaoDien";
            this.txtDaoDien.Size = new System.Drawing.Size(390, 26);
            this.txtDaoDien.TabIndex = 13;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Location = new System.Drawing.Point(497, 219);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(390, 26);
            this.txtThoiLuong.TabIndex = 14;
            // 
            // txtTomTat
            // 
            this.txtTomTat.Location = new System.Drawing.Point(497, 266);
            this.txtTomTat.Name = "txtTomTat";
            this.txtTomTat.Size = new System.Drawing.Size(390, 26);
            this.txtTomTat.TabIndex = 15;
            // 
            // txtHinhAnh
            // 
            this.txtHinhAnh.Location = new System.Drawing.Point(497, 352);
            this.txtHinhAnh.Name = "txtHinhAnh";
            this.txtHinhAnh.Size = new System.Drawing.Size(244, 26);
            this.txtHinhAnh.TabIndex = 17;
            // 
            // btnThemHinhAnh
            // 
            this.btnThemHinhAnh.Location = new System.Drawing.Point(762, 350);
            this.btnThemHinhAnh.Name = "btnThemHinhAnh";
            this.btnThemHinhAnh.Size = new System.Drawing.Size(158, 31);
            this.btnThemHinhAnh.TabIndex = 18;
            this.btnThemHinhAnh.Text = "Thêm hình ảnh";
            this.btnThemHinhAnh.UseVisualStyleBackColor = true;
            this.btnThemHinhAnh.Click += new System.EventHandler(this.btnThemHinhAnh_Click);
            // 
            // btnThemPhim
            // 
            this.btnThemPhim.Location = new System.Drawing.Point(38, 56);
            this.btnThemPhim.Name = "btnThemPhim";
            this.btnThemPhim.Size = new System.Drawing.Size(118, 41);
            this.btnThemPhim.TabIndex = 19;
            this.btnThemPhim.Text = "Thêm";
            this.btnThemPhim.UseVisualStyleBackColor = true;
            this.btnThemPhim.Click += new System.EventHandler(this.btnThemPhim_Click);
            // 
            // btnXoaPhim
            // 
            this.btnXoaPhim.Location = new System.Drawing.Point(38, 119);
            this.btnXoaPhim.Name = "btnXoaPhim";
            this.btnXoaPhim.Size = new System.Drawing.Size(118, 36);
            this.btnXoaPhim.TabIndex = 20;
            this.btnXoaPhim.Text = "Xóa";
            this.btnXoaPhim.UseVisualStyleBackColor = true;
            this.btnXoaPhim.Click += new System.EventHandler(this.btnXoaPhim_Click);
            // 
            // btnSuaPhim
            // 
            this.btnSuaPhim.Location = new System.Drawing.Point(38, 170);
            this.btnSuaPhim.Name = "btnSuaPhim";
            this.btnSuaPhim.Size = new System.Drawing.Size(118, 39);
            this.btnSuaPhim.TabIndex = 21;
            this.btnSuaPhim.Text = "Sửa";
            this.btnSuaPhim.UseVisualStyleBackColor = true;
            this.btnSuaPhim.Click += new System.EventHandler(this.btnSuaPhim_Click);
            // 
            // Dat_ngaykhoichieu
            // 
            this.Dat_ngaykhoichieu.Location = new System.Drawing.Point(497, 312);
            this.Dat_ngaykhoichieu.Name = "Dat_ngaykhoichieu";
            this.Dat_ngaykhoichieu.Size = new System.Drawing.Size(390, 26);
            this.Dat_ngaykhoichieu.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Thể loại phim:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnXoaPhim);
            this.groupBox1.Controls.Add(this.btnThemPhim);
            this.groupBox1.Controls.Add(this.btnSuaPhim);
            this.groupBox1.Location = new System.Drawing.Point(22, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 230);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chỉnh sửa thông tin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 69);
            this.panel1.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.label9.Location = new System.Drawing.Point(354, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 52);
            this.label9.TabIndex = 26;
            this.label9.Text = "PHIM";
            // 
            // Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(949, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Dat_ngaykhoichieu);
            this.Controls.Add(this.btnThemHinhAnh);
            this.Controls.Add(this.txtHinhAnh);
            this.Controls.Add(this.txtTomTat);
            this.Controls.Add(this.txtThoiLuong);
            this.Controls.Add(this.txtDaoDien);
            this.Controls.Add(this.txtTenPhim);
            this.Controls.Add(this.txtMaPhim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTheLoai);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Phim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phim";
            this.Load += new System.EventHandler(this.Phim_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboTheLoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhim;
        private System.Windows.Forms.TextBox txtTenPhim;
        private System.Windows.Forms.TextBox txtDaoDien;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.TextBox txtTomTat;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.Button btnThemHinhAnh;
        private System.Windows.Forms.Button btnThemPhim;
        private System.Windows.Forms.Button btnXoaPhim;
        private System.Windows.Forms.Button btnSuaPhim;
        private System.Windows.Forms.DateTimePicker Dat_ngaykhoichieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}