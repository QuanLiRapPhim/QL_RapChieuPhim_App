namespace Cinema
{
    partial class QLNhanVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhómNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíNhómNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmNgườiDùngVàoNhómToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mànHìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phânQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.nhómNgườiDùngToolStripMenuItem,
            this.mànHìnhToolStripMenuItem,
            this.phânQuyềnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // nhómNgườiDùngToolStripMenuItem
            // 
            this.nhómNgườiDùngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíNhómNgườiDùngToolStripMenuItem,
            this.thêmNgườiDùngVàoNhómToolStripMenuItem});
            this.nhómNgườiDùngToolStripMenuItem.Name = "nhómNgườiDùngToolStripMenuItem";
            this.nhómNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(177, 29);
            this.nhómNgườiDùngToolStripMenuItem.Text = "Nhóm người dùng";
            this.nhómNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.nhómNgườiDùngToolStripMenuItem_Click);
            // 
            // quảnLíNhómNgườiDùngToolStripMenuItem
            // 
            this.quảnLíNhómNgườiDùngToolStripMenuItem.Name = "quảnLíNhómNgườiDùngToolStripMenuItem";
            this.quảnLíNhómNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.quảnLíNhómNgườiDùngToolStripMenuItem.Text = "Quản lí nhóm người dùng";
            this.quảnLíNhómNgườiDùngToolStripMenuItem.Click += new System.EventHandler(this.quảnLíNhómNgườiDùngToolStripMenuItem_Click);
            // 
            // thêmNgườiDùngVàoNhómToolStripMenuItem
            // 
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Name = "thêmNgườiDùngVàoNhómToolStripMenuItem";
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Size = new System.Drawing.Size(343, 34);
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Text = "Thêm người dùng vào nhóm";
            this.thêmNgườiDùngVàoNhómToolStripMenuItem.Click += new System.EventHandler(this.thêmNgườiDùngVàoNhómToolStripMenuItem_Click);
            // 
            // mànHìnhToolStripMenuItem
            // 
            this.mànHìnhToolStripMenuItem.Name = "mànHìnhToolStripMenuItem";
            this.mànHìnhToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.mànHìnhToolStripMenuItem.Text = "Màn hình";
            // 
            // phânQuyềnToolStripMenuItem
            // 
            this.phânQuyềnToolStripMenuItem.Name = "phânQuyềnToolStripMenuItem";
            this.phânQuyềnToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.phânQuyềnToolStripMenuItem.Text = "Phân Quyền";
            this.phânQuyềnToolStripMenuItem.Click += new System.EventHandler(this.phânQuyềnToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1077, 689);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLNhanVien";
            this.Text = "QLNhanVien";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhómNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíNhómNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmNgườiDùngVàoNhómToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mànHìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phânQuyềnToolStripMenuItem;
    }
}