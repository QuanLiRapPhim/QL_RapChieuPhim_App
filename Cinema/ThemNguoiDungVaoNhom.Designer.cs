namespace Cinema
{
    partial class btnThemVaoNhom
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
            this.dataSetCinema = new Cinema.DataSetCinema();
            this.nhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomNguoiDungTableAdapter = new Cinema.DataSetCinemaTableAdapters.NhomNguoiDungTableAdapter();
            this.tableAdapterManager = new Cinema.DataSetCinemaTableAdapters.TableAdapterManager();
            this.nhanVienTableAdapter = new Cinema.DataSetCinemaTableAdapters.NhanVienTableAdapter();
            this.cboNhomNguoiDung = new System.Windows.Forms.ComboBox();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiDungNhomNguoiDung_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungNhomNguoiDung_DKTableAdapter = new Cinema.DataSetCinemaTableAdapters.NguoiDungNhomNguoiDung_DKTableAdapter();
            this.fill_DKToolStrip = new System.Windows.Forms.ToolStrip();
            this.maNhomNguoiDungToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.maNhomNguoiDungToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fill_DKToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dgv_NhomNguoiDung = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoaiKhoiNhom = new System.Windows.Forms.Button();
            this.nguoiDungNhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungNhomNguoiDungTableAdapter = new Cinema.DataSetCinemaTableAdapters.NguoiDungNhomNguoiDungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungNhomNguoiDung_DKBindingSource)).BeginInit();
            this.fill_DKToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhomNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungNhomNguoiDungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetCinema
            // 
            this.dataSetCinema.DataSetName = "DataSetCinema";
            this.dataSetCinema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhomNguoiDungBindingSource
            // 
            this.nhomNguoiDungBindingSource.DataMember = "NhomNguoiDung";
            this.nhomNguoiDungBindingSource.DataSource = this.dataSetCinema;
            // 
            // nhomNguoiDungTableAdapter
            // 
            this.nhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApDungKhuyenMaiTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietDonHangThucAnTableAdapter = null;
            this.tableAdapterManager.DanhGiaPhimTableAdapter = null;
            this.tableAdapterManager.DonHangThucAnTableAdapter = null;
            this.tableAdapterManager.GheTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.KhuyenMaiTableAdapter = null;
            this.tableAdapterManager.ManHinhChieuTableAdapter = null;
            this.tableAdapterManager.ManHinhTableAdapter = null;
            this.tableAdapterManager.NguoiDungNhomNguoiDung_DKTableAdapter = null;
            this.tableAdapterManager.NguoiDungNhomNguoiDungTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.NhomNguoiDungTableAdapter = this.nhomNguoiDungTableAdapter;
            this.tableAdapterManager.PhanQuyenTableAdapter = null;
            this.tableAdapterManager.PhimTableAdapter = null;
            this.tableAdapterManager.RapChieuPhimTableAdapter = null;
            this.tableAdapterManager.SuatChieuTableAdapter = null;
            this.tableAdapterManager.ThanhToanTableAdapter = null;
            this.tableAdapterManager.TheLoaiTableAdapter = null;
            this.tableAdapterManager.ThucAnTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Cinema.DataSetCinemaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VeTableAdapter = null;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // cboNhomNguoiDung
            // 
            this.cboNhomNguoiDung.DataSource = this.nhomNguoiDungBindingSource;
            this.cboNhomNguoiDung.DisplayMember = "TenNhom";
            this.cboNhomNguoiDung.FormattingEnabled = true;
            this.cboNhomNguoiDung.Location = new System.Drawing.Point(704, 136);
            this.cboNhomNguoiDung.Name = "cboNhomNguoiDung";
            this.cboNhomNguoiDung.Size = new System.Drawing.Size(300, 28);
            this.cboNhomNguoiDung.TabIndex = 1;
            this.cboNhomNguoiDung.ValueMember = "MaNhomNguoiDung";
            this.cboNhomNguoiDung.SelectedIndexChanged += new System.EventHandler(this.nhomNguoiDungComboBox_SelectedIndexChanged);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dataSetCinema;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvNhanVien.DataSource = this.nhanVienBindingSource;
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 191);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 62;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.Size = new System.Drawing.Size(525, 321);
            this.dgvNhanVien.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhanVien";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNhanVien";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhanVien";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenNhanVien";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ChucVu";
            this.dataGridViewTextBoxColumn3.HeaderText = "ChucVu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // nguoiDungNhomNguoiDung_DKBindingSource
            // 
            this.nguoiDungNhomNguoiDung_DKBindingSource.DataMember = "NguoiDungNhomNguoiDung_DK";
            this.nguoiDungNhomNguoiDung_DKBindingSource.DataSource = this.dataSetCinema;
            // 
            // nguoiDungNhomNguoiDung_DKTableAdapter
            // 
            this.nguoiDungNhomNguoiDung_DKTableAdapter.ClearBeforeFill = true;
            // 
            // fill_DKToolStrip
            // 
            this.fill_DKToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fill_DKToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maNhomNguoiDungToolStripLabel,
            this.maNhomNguoiDungToolStripTextBox,
            this.fill_DKToolStripButton});
            this.fill_DKToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fill_DKToolStrip.Name = "fill_DKToolStrip";
            this.fill_DKToolStrip.Size = new System.Drawing.Size(1140, 34);
            this.fill_DKToolStrip.TabIndex = 2;
            this.fill_DKToolStrip.Text = "fill_DKToolStrip";
            // 
            // maNhomNguoiDungToolStripLabel
            // 
            this.maNhomNguoiDungToolStripLabel.Name = "maNhomNguoiDungToolStripLabel";
            this.maNhomNguoiDungToolStripLabel.Size = new System.Drawing.Size(184, 29);
            this.maNhomNguoiDungToolStripLabel.Text = "MaNhomNguoiDung:";
            // 
            // maNhomNguoiDungToolStripTextBox
            // 
            this.maNhomNguoiDungToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.maNhomNguoiDungToolStripTextBox.Name = "maNhomNguoiDungToolStripTextBox";
            this.maNhomNguoiDungToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fill_DKToolStripButton
            // 
            this.fill_DKToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fill_DKToolStripButton.Name = "fill_DKToolStripButton";
            this.fill_DKToolStripButton.Size = new System.Drawing.Size(67, 29);
            this.fill_DKToolStripButton.Text = "Fill_DK";
            this.fill_DKToolStripButton.Click += new System.EventHandler(this.fill_DKToolStripButton_Click);
            // 
            // dgv_NhomNguoiDung
            // 
            this.dgv_NhomNguoiDung.AutoGenerateColumns = false;
            this.dgv_NhomNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhomNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgv_NhomNguoiDung.DataSource = this.nguoiDungNhomNguoiDung_DKBindingSource;
            this.dgv_NhomNguoiDung.Location = new System.Drawing.Point(704, 191);
            this.dgv_NhomNguoiDung.Name = "dgv_NhomNguoiDung";
            this.dgv_NhomNguoiDung.RowHeadersWidth = 62;
            this.dgv_NhomNguoiDung.RowTemplate.Height = 28;
            this.dgv_NhomNguoiDung.Size = new System.Drawing.Size(424, 321);
            this.dgv_NhomNguoiDung.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MaNhanVien";
            this.dataGridViewTextBoxColumn9.HeaderText = "MaNhanVien";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn10.HeaderText = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = ">>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoaiKhoiNhom
            // 
            this.btnLoaiKhoiNhom.Location = new System.Drawing.Point(578, 371);
            this.btnLoaiKhoiNhom.Name = "btnLoaiKhoiNhom";
            this.btnLoaiKhoiNhom.Size = new System.Drawing.Size(100, 35);
            this.btnLoaiKhoiNhom.TabIndex = 5;
            this.btnLoaiKhoiNhom.Text = "<<<";
            this.btnLoaiKhoiNhom.UseVisualStyleBackColor = true;
            this.btnLoaiKhoiNhom.Click += new System.EventHandler(this.btnLoaiKhoiNhom_Click);
            // 
            // nguoiDungNhomNguoiDungBindingSource
            // 
            this.nguoiDungNhomNguoiDungBindingSource.DataMember = "NguoiDungNhomNguoiDung";
            this.nguoiDungNhomNguoiDungBindingSource.DataSource = this.dataSetCinema;
            // 
            // nguoiDungNhomNguoiDungTableAdapter
            // 
            this.nguoiDungNhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // btnThemVaoNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1140, 603);
            this.Controls.Add(this.btnLoaiKhoiNhom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_NhomNguoiDung);
            this.Controls.Add(this.fill_DKToolStrip);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.cboNhomNguoiDung);
            this.Name = "btnThemVaoNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNguoiDungVaoNhom";
            this.Load += new System.EventHandler(this.ThemNguoiDungVaoNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungNhomNguoiDung_DKBindingSource)).EndInit();
            this.fill_DKToolStrip.ResumeLayout(false);
            this.fill_DKToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhomNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungNhomNguoiDungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetCinema dataSetCinema;
        private System.Windows.Forms.BindingSource nhomNguoiDungBindingSource;
        private DataSetCinemaTableAdapters.NhomNguoiDungTableAdapter nhomNguoiDungTableAdapter;
        private DataSetCinemaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cboNhomNguoiDung;
        private DataSetCinemaTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.BindingSource nguoiDungNhomNguoiDung_DKBindingSource;
        private DataSetCinemaTableAdapters.NguoiDungNhomNguoiDung_DKTableAdapter nguoiDungNhomNguoiDung_DKTableAdapter;
        private System.Windows.Forms.ToolStrip fill_DKToolStrip;
        private System.Windows.Forms.ToolStripLabel maNhomNguoiDungToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox maNhomNguoiDungToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fill_DKToolStripButton;
        private System.Windows.Forms.DataGridView dgv_NhomNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoaiKhoiNhom;
        private System.Windows.Forms.BindingSource nguoiDungNhomNguoiDungBindingSource;
        private DataSetCinemaTableAdapters.NguoiDungNhomNguoiDungTableAdapter nguoiDungNhomNguoiDungTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}