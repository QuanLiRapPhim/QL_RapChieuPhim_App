namespace Cinema
{
    partial class NhomNguoiDung
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
            System.Windows.Forms.Label maNhomNguoiDungLabel;
            System.Windows.Forms.Label tenNhomLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhomNguoiDung));
            this.nhomNguoiDungBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.nhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCinema = new Cinema.DataSetCinema();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nhomNguoiDungBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nhomNguoiDungDataGridView = new System.Windows.Forms.DataGridView();
            this.maNhomNguoiDungTextBox = new System.Windows.Forms.TextBox();
            this.tenNhomTextBox = new System.Windows.Forms.TextBox();
            this.nhomNguoiDungTableAdapter = new Cinema.DataSetCinemaTableAdapters.NhomNguoiDungTableAdapter();
            this.tableAdapterManager = new Cinema.DataSetCinemaTableAdapters.TableAdapterManager();
            this.nguoiDungNhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nguoiDungNhomNguoiDungTableAdapter = new Cinema.DataSetCinemaTableAdapters.NguoiDungNhomNguoiDungTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maNhomNguoiDungLabel = new System.Windows.Forms.Label();
            tenNhomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingNavigator)).BeginInit();
            this.nhomNguoiDungBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungNhomNguoiDungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maNhomNguoiDungLabel
            // 
            maNhomNguoiDungLabel.AutoSize = true;
            maNhomNguoiDungLabel.Location = new System.Drawing.Point(219, 77);
            maNhomNguoiDungLabel.Name = "maNhomNguoiDungLabel";
            maNhomNguoiDungLabel.Size = new System.Drawing.Size(162, 20);
            maNhomNguoiDungLabel.TabIndex = 2;
            maNhomNguoiDungLabel.Text = "Mã nhóm người dùng:";
            // 
            // tenNhomLabel
            // 
            tenNhomLabel.AutoSize = true;
            tenNhomLabel.Location = new System.Drawing.Point(219, 109);
            tenNhomLabel.Name = "tenNhomLabel";
            tenNhomLabel.Size = new System.Drawing.Size(167, 20);
            tenNhomLabel.TabIndex = 4;
            tenNhomLabel.Text = "Tên nhóm người dùng:";
            // 
            // nhomNguoiDungBindingNavigator
            // 
            this.nhomNguoiDungBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nhomNguoiDungBindingNavigator.BindingSource = this.nhomNguoiDungBindingSource;
            this.nhomNguoiDungBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nhomNguoiDungBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nhomNguoiDungBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.nhomNguoiDungBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.nhomNguoiDungBindingNavigatorSaveItem});
            this.nhomNguoiDungBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nhomNguoiDungBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nhomNguoiDungBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nhomNguoiDungBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nhomNguoiDungBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nhomNguoiDungBindingNavigator.Name = "nhomNguoiDungBindingNavigator";
            this.nhomNguoiDungBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nhomNguoiDungBindingNavigator.Size = new System.Drawing.Size(965, 38);
            this.nhomNguoiDungBindingNavigator.TabIndex = 0;
            this.nhomNguoiDungBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // nhomNguoiDungBindingSource
            // 
            this.nhomNguoiDungBindingSource.DataMember = "NhomNguoiDung";
            this.nhomNguoiDungBindingSource.DataSource = this.dataSetCinema;
            // 
            // dataSetCinema
            // 
            this.dataSetCinema.DataSetName = "DataSetCinema";
            this.dataSetCinema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // nhomNguoiDungBindingNavigatorSaveItem
            // 
            this.nhomNguoiDungBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nhomNguoiDungBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nhomNguoiDungBindingNavigatorSaveItem.Image")));
            this.nhomNguoiDungBindingNavigatorSaveItem.Name = "nhomNguoiDungBindingNavigatorSaveItem";
            this.nhomNguoiDungBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.nhomNguoiDungBindingNavigatorSaveItem.Text = "Save Data";
            this.nhomNguoiDungBindingNavigatorSaveItem.Click += new System.EventHandler(this.nhomNguoiDungBindingNavigatorSaveItem_Click);
            // 
            // nhomNguoiDungDataGridView
            // 
            this.nhomNguoiDungDataGridView.AutoGenerateColumns = false;
            this.nhomNguoiDungDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhomNguoiDungDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.nhomNguoiDungDataGridView.DataSource = this.nhomNguoiDungBindingSource;
            this.nhomNguoiDungDataGridView.Location = new System.Drawing.Point(116, 155);
            this.nhomNguoiDungDataGridView.Name = "nhomNguoiDungDataGridView";
            this.nhomNguoiDungDataGridView.RowHeadersWidth = 62;
            this.nhomNguoiDungDataGridView.RowTemplate.Height = 28;
            this.nhomNguoiDungDataGridView.Size = new System.Drawing.Size(628, 245);
            this.nhomNguoiDungDataGridView.TabIndex = 1;
            // 
            // maNhomNguoiDungTextBox
            // 
            this.maNhomNguoiDungTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhomNguoiDungBindingSource, "MaNhomNguoiDung", true));
            this.maNhomNguoiDungTextBox.Location = new System.Drawing.Point(394, 74);
            this.maNhomNguoiDungTextBox.Name = "maNhomNguoiDungTextBox";
            this.maNhomNguoiDungTextBox.Size = new System.Drawing.Size(299, 26);
            this.maNhomNguoiDungTextBox.TabIndex = 3;
            // 
            // tenNhomTextBox
            // 
            this.tenNhomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhomNguoiDungBindingSource, "TenNhom", true));
            this.tenNhomTextBox.Location = new System.Drawing.Point(394, 106);
            this.tenNhomTextBox.Name = "tenNhomTextBox";
            this.tenNhomTextBox.Size = new System.Drawing.Size(299, 26);
            this.tenNhomTextBox.TabIndex = 5;
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
            // nguoiDungNhomNguoiDungBindingSource
            // 
            this.nguoiDungNhomNguoiDungBindingSource.DataMember = "NguoiDungNhomNguoiDung";
            this.nguoiDungNhomNguoiDungBindingSource.DataSource = this.dataSetCinema;
            // 
            // nguoiDungNhomNguoiDungTableAdapter
            // 
            this.nguoiDungNhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhóm người dùng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNhom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhóm";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // NhomNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(965, 492);
            this.Controls.Add(maNhomNguoiDungLabel);
            this.Controls.Add(this.maNhomNguoiDungTextBox);
            this.Controls.Add(tenNhomLabel);
            this.Controls.Add(this.tenNhomTextBox);
            this.Controls.Add(this.nhomNguoiDungDataGridView);
            this.Controls.Add(this.nhomNguoiDungBindingNavigator);
            this.Name = "NhomNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhomNguoiDung";
            this.Load += new System.EventHandler(this.NhomNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingNavigator)).EndInit();
            this.nhomNguoiDungBindingNavigator.ResumeLayout(false);
            this.nhomNguoiDungBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhomNguoiDungDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungNhomNguoiDungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetCinema dataSetCinema;
        private System.Windows.Forms.BindingSource nhomNguoiDungBindingSource;
        private DataSetCinemaTableAdapters.NhomNguoiDungTableAdapter nhomNguoiDungTableAdapter;
        private DataSetCinemaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nhomNguoiDungBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton nhomNguoiDungBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nhomNguoiDungDataGridView;
        private System.Windows.Forms.TextBox maNhomNguoiDungTextBox;
        private System.Windows.Forms.TextBox tenNhomTextBox;
        private System.Windows.Forms.BindingSource nguoiDungNhomNguoiDungBindingSource;
        private DataSetCinemaTableAdapters.NguoiDungNhomNguoiDungTableAdapter nguoiDungNhomNguoiDungTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}