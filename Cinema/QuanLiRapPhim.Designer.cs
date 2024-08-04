namespace Cinema
{
    partial class QuanLiRapPhim
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
            this.panleft = new System.Windows.Forms.Panel();
            this.btnLichChieu = new System.Windows.Forms.Button();
            this.btnPhim = new System.Windows.Forms.Button();
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.panlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panlBody = new System.Windows.Forms.Panel();
            this.panleft.SuspendLayout();
            this.panlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panleft
            // 
            this.panleft.BackColor = System.Drawing.Color.Black;
            this.panleft.Controls.Add(this.btnLichChieu);
            this.panleft.Controls.Add(this.btnPhim);
            this.panleft.Controls.Add(this.btnTheLoai);
            this.panleft.Location = new System.Drawing.Point(-1, -2);
            this.panleft.Name = "panleft";
            this.panleft.Size = new System.Drawing.Size(219, 793);
            this.panleft.TabIndex = 0;
            // 
            // btnLichChieu
            // 
            this.btnLichChieu.Location = new System.Drawing.Point(3, 331);
            this.btnLichChieu.Name = "btnLichChieu";
            this.btnLichChieu.Size = new System.Drawing.Size(216, 113);
            this.btnLichChieu.TabIndex = 2;
            this.btnLichChieu.Text = "Lịch chiếu phim";
            this.btnLichChieu.UseVisualStyleBackColor = true;
            this.btnLichChieu.Click += new System.EventHandler(this.btnLichChieu_Click);
            // 
            // btnPhim
            // 
            this.btnPhim.Location = new System.Drawing.Point(3, 223);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Size = new System.Drawing.Size(216, 113);
            this.btnPhim.TabIndex = 1;
            this.btnPhim.Text = "Phim";
            this.btnPhim.UseVisualStyleBackColor = true;
            this.btnPhim.Click += new System.EventHandler(this.btnPhim_Click);
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Location = new System.Drawing.Point(3, 113);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(216, 113);
            this.btnTheLoai.TabIndex = 0;
            this.btnTheLoai.Text = "Thể loại";
            this.btnTheLoai.UseVisualStyleBackColor = true;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // panlTop
            // 
            this.panlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.panlTop.Controls.Add(this.label1);
            this.panlTop.Location = new System.Drawing.Point(215, -2);
            this.panlTop.Name = "panlTop";
            this.panlTop.Size = new System.Drawing.Size(1200, 114);
            this.panlTop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRANG QUẢN LÍ PHIM";
            // 
            // panlBody
            // 
            this.panlBody.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panlBody.Location = new System.Drawing.Point(215, 111);
            this.panlBody.Name = "panlBody";
            this.panlBody.Size = new System.Drawing.Size(1200, 680);
            this.panlBody.TabIndex = 2;
            // 
            // QuanLiRapPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 792);
            this.Controls.Add(this.panlBody);
            this.Controls.Add(this.panlTop);
            this.Controls.Add(this.panleft);
            this.Name = "QuanLiRapPhim";
            this.Text = "QuanLiRapPhim";
            this.panleft.ResumeLayout(false);
            this.panlTop.ResumeLayout(false);
            this.panlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panleft;
        private System.Windows.Forms.Panel panlTop;
        private System.Windows.Forms.Panel panlBody;
        private System.Windows.Forms.Button btnPhim;
        private System.Windows.Forms.Button btnTheLoai;
        private System.Windows.Forms.Button btnLichChieu;
        private System.Windows.Forms.Label label1;
    }
}