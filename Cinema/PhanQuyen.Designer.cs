namespace Cinema
{
    partial class PhanQuyen
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
            this.tableAdapterManager = new Cinema.DataSetCinemaTableAdapters.TableAdapterManager();
            this.nhomNguoiDungTableAdapter = new Cinema.DataSetCinemaTableAdapters.NhomNguoiDungTableAdapter();
            this.nhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pQ_DKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pQ_DKTableAdapter = new Cinema.DataSetCinemaTableAdapters.PQ_DKTableAdapter();
            this.pQ_DKDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pQ_DKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pQ_DKDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetCinema
            // 
            this.dataSetCinema.DataSetName = "DataSetCinema";
            this.dataSetCinema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.NhanVienTableAdapter = null;
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
            // nhomNguoiDungTableAdapter
            // 
            this.nhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // nhomNguoiDungBindingSource
            // 
            this.nhomNguoiDungBindingSource.DataMember = "NhomNguoiDung";
            this.nhomNguoiDungBindingSource.DataSource = this.dataSetCinema;
            // 
            // nhomNguoiDungDataGridView
            // 
            this.nhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.nhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.nhomNguoiDungDataGridView.DataSource = this.nhomNguoiDungBindingSource;
            this.nhomNguoiDungDataGridView.Location = new System.Drawing.Point(12, 116);
            this.nhomNguoiDungDataGridView.Name = "nhomNguoiDungDataGridView";
            this.nhomNguoiDungDataGridView.RowHeadersWidth = 62;
            this.nhomNguoiDungDataGridView.RowTemplate.Height = 28;
            this.nhomNguoiDungDataGridView.Size = new System.Drawing.Size(465, 357);
            this.nhomNguoiDungDataGridView.TabIndex = 2;
            this.nhomNguoiDungDataGridView.SelectionChanged += new System.EventHandler(this.nhomNguoiDungDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn5.HeaderText = "TenNhom";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // pQ_DKBindingSource
            // 
            this.pQ_DKBindingSource.DataMember = "PQ_DK";
            this.pQ_DKBindingSource.DataSource = this.dataSetCinema;
            // 
            // pQ_DKTableAdapter
            // 
            this.pQ_DKTableAdapter.ClearBeforeFill = true;
            // 
            // pQ_DKDataGridView
            // 
            this.pQ_DKDataGridView.AutoGenerateColumns = false;
            this.pQ_DKDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pQ_DKDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1});
            this.pQ_DKDataGridView.DataSource = this.pQ_DKBindingSource;
            this.pQ_DKDataGridView.Location = new System.Drawing.Point(493, 116);
            this.pQ_DKDataGridView.Name = "pQ_DKDataGridView";
            this.pQ_DKDataGridView.RowHeadersWidth = 62;
            this.pQ_DKDataGridView.RowTemplate.Height = 28;
            this.pQ_DKDataGridView.Size = new System.Drawing.Size(778, 357);
            this.pQ_DKDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaManHinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaManHinh";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenManHinh";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenManHinh";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.HeaderText = "CoQuyen";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1068, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lưu ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1307, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pQ_DKDataGridView);
            this.Controls.Add(this.nhomNguoiDungDataGridView);
            this.Name = "PhanQuyen";
            this.Text = "PhanQuyen";
            this.Load += new System.EventHandler(this.PhanQuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pQ_DKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pQ_DKDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSetCinema dataSetCinema;
        private DataSetCinemaTableAdapters.TableAdapterManager tableAdapterManager;
        private DataSetCinemaTableAdapters.NhomNguoiDungTableAdapter nhomNguoiDungTableAdapter;
        private System.Windows.Forms.BindingSource nhomNguoiDungBindingSource;
        private System.Windows.Forms.DataGridView nhomNguoiDungDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource pQ_DKBindingSource;
        private DataSetCinemaTableAdapters.PQ_DKTableAdapter pQ_DKTableAdapter;
        private System.Windows.Forms.DataGridView pQ_DKDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button button1;
    }
}