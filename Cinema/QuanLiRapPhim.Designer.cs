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
            this.btnPhim = new System.Windows.Forms.Button();
            this.btnTheLoai = new System.Windows.Forms.Button();
            this.panlTop = new System.Windows.Forms.Panel();
            this.panlBody = new System.Windows.Forms.Panel();
            this.panleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panleft
            // 
            this.panleft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panleft.Controls.Add(this.btnPhim);
            this.panleft.Controls.Add(this.btnTheLoai);
            this.panleft.Location = new System.Drawing.Point(12, 12);
            this.panleft.Name = "panleft";
            this.panleft.Size = new System.Drawing.Size(197, 560);
            this.panleft.TabIndex = 0;
            // 
            // btnPhim
            // 
            this.btnPhim.Location = new System.Drawing.Point(0, 258);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Size = new System.Drawing.Size(197, 70);
            this.btnPhim.TabIndex = 1;
            this.btnPhim.Text = "Phim";
            this.btnPhim.UseVisualStyleBackColor = true;
            // 
            // btnTheLoai
            // 
            this.btnTheLoai.Location = new System.Drawing.Point(0, 151);
            this.btnTheLoai.Name = "btnTheLoai";
            this.btnTheLoai.Size = new System.Drawing.Size(197, 70);
            this.btnTheLoai.TabIndex = 0;
            this.btnTheLoai.Text = "Thể loại";
            this.btnTheLoai.UseVisualStyleBackColor = true;
            this.btnTheLoai.Click += new System.EventHandler(this.btnTheLoai_Click);
            // 
            // panlTop
            // 
            this.panlTop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panlTop.Location = new System.Drawing.Point(215, 12);
            this.panlTop.Name = "panlTop";
            this.panlTop.Size = new System.Drawing.Size(803, 100);
            this.panlTop.TabIndex = 1;
            // 
            // panlBody
            // 
            this.panlBody.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panlBody.Location = new System.Drawing.Point(215, 118);
            this.panlBody.Name = "panlBody";
            this.panlBody.Size = new System.Drawing.Size(841, 544);
            this.panlBody.TabIndex = 2;
            // 
            // QuanLiRapPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 674);
            this.Controls.Add(this.panlBody);
            this.Controls.Add(this.panlTop);
            this.Controls.Add(this.panleft);
            this.Name = "QuanLiRapPhim";
            this.Text = "QuanLiRapPhim";
            this.panleft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panleft;
        private System.Windows.Forms.Panel panlTop;
        private System.Windows.Forms.Panel panlBody;
        private System.Windows.Forms.Button btnPhim;
        private System.Windows.Forms.Button btnTheLoai;
    }
}