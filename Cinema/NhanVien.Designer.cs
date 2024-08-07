namespace Cinema
{
    partial class NhanVien
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
            System.Windows.Forms.Label maNhanVienLabel;
            System.Windows.Forms.Label tenNhanVienLabel;
            System.Windows.Forms.Label chucVuLabel;
            System.Windows.Forms.Label luongLabel;
            System.Windows.Forms.Label ngayTuyenDungLabel;
            System.Windows.Forms.Label tenDangNhapLabel;
            System.Windows.Forms.Label matKhauLabel;
            System.Windows.Forms.Label maRapLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.dataSetCinema = new Cinema.DataSetCinema();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new Cinema.DataSetCinemaTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new Cinema.DataSetCinemaTableAdapters.TableAdapterManager();
            this.nhanVienBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.nhanVienBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nhanVienDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVienTextBox = new System.Windows.Forms.TextBox();
            this.tenNhanVienTextBox = new System.Windows.Forms.TextBox();
            this.chucVuTextBox = new System.Windows.Forms.TextBox();
            this.luongTextBox = new System.Windows.Forms.TextBox();
            this.ngayTuyenDungDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tenDangNhapTextBox = new System.Windows.Forms.TextBox();
            this.matKhauTextBox = new System.Windows.Forms.TextBox();
            this.maRapTextBox = new System.Windows.Forms.TextBox();
            maNhanVienLabel = new System.Windows.Forms.Label();
            tenNhanVienLabel = new System.Windows.Forms.Label();
            chucVuLabel = new System.Windows.Forms.Label();
            luongLabel = new System.Windows.Forms.Label();
            ngayTuyenDungLabel = new System.Windows.Forms.Label();
            tenDangNhapLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            maRapLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCinema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingNavigator)).BeginInit();
            this.nhanVienBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maNhanVienLabel
            // 
            maNhanVienLabel.AutoSize = true;
            maNhanVienLabel.Location = new System.Drawing.Point(303, 52);
            maNhanVienLabel.Name = "maNhanVienLabel";
            maNhanVienLabel.Size = new System.Drawing.Size(107, 20);
            maNhanVienLabel.TabIndex = 2;
            maNhanVienLabel.Text = "Mã nhân viên:";
            // 
            // tenNhanVienLabel
            // 
            tenNhanVienLabel.AutoSize = true;
            tenNhanVienLabel.Location = new System.Drawing.Point(303, 84);
            tenNhanVienLabel.Name = "tenNhanVienLabel";
            tenNhanVienLabel.Size = new System.Drawing.Size(112, 20);
            tenNhanVienLabel.TabIndex = 4;
            tenNhanVienLabel.Text = "Tên nhân viên:";
            // 
            // chucVuLabel
            // 
            chucVuLabel.AutoSize = true;
            chucVuLabel.Location = new System.Drawing.Point(303, 116);
            chucVuLabel.Name = "chucVuLabel";
            chucVuLabel.Size = new System.Drawing.Size(70, 20);
            chucVuLabel.TabIndex = 6;
            chucVuLabel.Text = "Chức vụ:";
            // 
            // luongLabel
            // 
            luongLabel.AutoSize = true;
            luongLabel.Location = new System.Drawing.Point(303, 148);
            luongLabel.Name = "luongLabel";
            luongLabel.Size = new System.Drawing.Size(58, 20);
            luongLabel.TabIndex = 8;
            luongLabel.Text = "Lương:";
            // 
            // ngayTuyenDungLabel
            // 
            ngayTuyenDungLabel.AutoSize = true;
            ngayTuyenDungLabel.Location = new System.Drawing.Point(303, 181);
            ngayTuyenDungLabel.Name = "ngayTuyenDungLabel";
            ngayTuyenDungLabel.Size = new System.Drawing.Size(132, 20);
            ngayTuyenDungLabel.TabIndex = 10;
            ngayTuyenDungLabel.Text = "Ngày tuyển dụng:";
            // 
            // tenDangNhapLabel
            // 
            tenDangNhapLabel.AutoSize = true;
            tenDangNhapLabel.Location = new System.Drawing.Point(303, 212);
            tenDangNhapLabel.Name = "tenDangNhapLabel";
            tenDangNhapLabel.Size = new System.Drawing.Size(120, 20);
            tenDangNhapLabel.TabIndex = 12;
            tenDangNhapLabel.Text = "Tên đăng nhập:";
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Location = new System.Drawing.Point(303, 244);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(79, 20);
            matKhauLabel.TabIndex = 14;
            matKhauLabel.Text = "Mật khẩu:";
            // 
            // maRapLabel
            // 
            maRapLabel.AutoSize = true;
            maRapLabel.Location = new System.Drawing.Point(308, 274);
            maRapLabel.Name = "maRapLabel";
            maRapLabel.Size = new System.Drawing.Size(62, 20);
            maRapLabel.TabIndex = 16;
            maRapLabel.Text = "Mã rạp:";
            // 
            // dataSetCinema
            // 
            this.dataSetCinema.DataSetName = "DataSetCinema";
            this.dataSetCinema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.dataSetCinema;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NhomNguoiDungTableAdapter = null;
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
            // nhanVienBindingNavigator
            // 
            this.nhanVienBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nhanVienBindingNavigator.BindingSource = this.nhanVienBindingSource;
            this.nhanVienBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nhanVienBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nhanVienBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.nhanVienBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nhanVienBindingNavigatorSaveItem});
            this.nhanVienBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nhanVienBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nhanVienBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nhanVienBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nhanVienBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nhanVienBindingNavigator.Name = "nhanVienBindingNavigator";
            this.nhanVienBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nhanVienBindingNavigator.Size = new System.Drawing.Size(1305, 38);
            this.nhanVienBindingNavigator.TabIndex = 0;
            this.nhanVienBindingNavigator.Text = "bindingNavigator1";
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
            // nhanVienBindingNavigatorSaveItem
            // 
            this.nhanVienBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nhanVienBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nhanVienBindingNavigatorSaveItem.Image")));
            this.nhanVienBindingNavigatorSaveItem.Name = "nhanVienBindingNavigatorSaveItem";
            this.nhanVienBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.nhanVienBindingNavigatorSaveItem.Text = "Save Data";
            this.nhanVienBindingNavigatorSaveItem.Click += new System.EventHandler(this.nhanVienBindingNavigatorSaveItem_Click);
            // 
            // nhanVienDataGridView
            // 
            this.nhanVienDataGridView.AutoGenerateColumns = false;
            this.nhanVienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhanVienDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.nhanVienDataGridView.DataSource = this.nhanVienBindingSource;
            this.nhanVienDataGridView.Location = new System.Drawing.Point(12, 323);
            this.nhanVienDataGridView.Name = "nhanVienDataGridView";
            this.nhanVienDataGridView.RowHeadersWidth = 62;
            this.nhanVienDataGridView.RowTemplate.Height = 28;
            this.nhanVienDataGridView.Size = new System.Drawing.Size(1270, 372);
            this.nhanVienDataGridView.TabIndex = 1;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Luong";
            this.dataGridViewTextBoxColumn4.HeaderText = "Luong";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NgayTuyenDung";
            this.dataGridViewTextBoxColumn5.HeaderText = "NgayTuyenDung";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn6.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn7.HeaderText = "MatKhau";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MaRap";
            this.dataGridViewTextBoxColumn8.HeaderText = "MaRap";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // maNhanVienTextBox
            // 
            this.maNhanVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaNhanVien", true));
            this.maNhanVienTextBox.Location = new System.Drawing.Point(448, 49);
            this.maNhanVienTextBox.Name = "maNhanVienTextBox";
            this.maNhanVienTextBox.Size = new System.Drawing.Size(200, 26);
            this.maNhanVienTextBox.TabIndex = 3;
            // 
            // tenNhanVienTextBox
            // 
            this.tenNhanVienTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TenNhanVien", true));
            this.tenNhanVienTextBox.Location = new System.Drawing.Point(448, 81);
            this.tenNhanVienTextBox.Name = "tenNhanVienTextBox";
            this.tenNhanVienTextBox.Size = new System.Drawing.Size(200, 26);
            this.tenNhanVienTextBox.TabIndex = 5;
            // 
            // chucVuTextBox
            // 
            this.chucVuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "ChucVu", true));
            this.chucVuTextBox.Location = new System.Drawing.Point(448, 113);
            this.chucVuTextBox.Name = "chucVuTextBox";
            this.chucVuTextBox.Size = new System.Drawing.Size(200, 26);
            this.chucVuTextBox.TabIndex = 7;
            // 
            // luongTextBox
            // 
            this.luongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "Luong", true));
            this.luongTextBox.Location = new System.Drawing.Point(448, 145);
            this.luongTextBox.Name = "luongTextBox";
            this.luongTextBox.Size = new System.Drawing.Size(200, 26);
            this.luongTextBox.TabIndex = 9;
            // 
            // ngayTuyenDungDateTimePicker
            // 
            this.ngayTuyenDungDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nhanVienBindingSource, "NgayTuyenDung", true));
            this.ngayTuyenDungDateTimePicker.Location = new System.Drawing.Point(448, 177);
            this.ngayTuyenDungDateTimePicker.Name = "ngayTuyenDungDateTimePicker";
            this.ngayTuyenDungDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.ngayTuyenDungDateTimePicker.TabIndex = 11;
            // 
            // tenDangNhapTextBox
            // 
            this.tenDangNhapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "TenDangNhap", true));
            this.tenDangNhapTextBox.Location = new System.Drawing.Point(448, 209);
            this.tenDangNhapTextBox.Name = "tenDangNhapTextBox";
            this.tenDangNhapTextBox.Size = new System.Drawing.Size(200, 26);
            this.tenDangNhapTextBox.TabIndex = 13;
            // 
            // matKhauTextBox
            // 
            this.matKhauTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MatKhau", true));
            this.matKhauTextBox.Location = new System.Drawing.Point(448, 241);
            this.matKhauTextBox.Name = "matKhauTextBox";
            this.matKhauTextBox.Size = new System.Drawing.Size(200, 26);
            this.matKhauTextBox.TabIndex = 15;
            // 
            // maRapTextBox
            // 
            this.maRapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "MaRap", true));
            this.maRapTextBox.Location = new System.Drawing.Point(448, 274);
            this.maRapTextBox.Name = "maRapTextBox";
            this.maRapTextBox.Size = new System.Drawing.Size(200, 26);
            this.maRapTextBox.TabIndex = 17;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(206)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1305, 720);
            this.Controls.Add(maNhanVienLabel);
            this.Controls.Add(this.maNhanVienTextBox);
            this.Controls.Add(tenNhanVienLabel);
            this.Controls.Add(this.tenNhanVienTextBox);
            this.Controls.Add(chucVuLabel);
            this.Controls.Add(this.chucVuTextBox);
            this.Controls.Add(luongLabel);
            this.Controls.Add(this.luongTextBox);
            this.Controls.Add(ngayTuyenDungLabel);
            this.Controls.Add(this.ngayTuyenDungDateTimePicker);
            this.Controls.Add(tenDangNhapLabel);
            this.Controls.Add(this.tenDangNhapTextBox);
            this.Controls.Add(matKhauLabel);
            this.Controls.Add(this.matKhauTextBox);
            this.Controls.Add(maRapLabel);
            this.Controls.Add(this.maRapTextBox);
            this.Controls.Add(this.nhanVienDataGridView);
            this.Controls.Add(this.nhanVienBindingNavigator);
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCinema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingNavigator)).EndInit();
            this.nhanVienBindingNavigator.ResumeLayout(false);
            this.nhanVienBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetCinema dataSetCinema;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DataSetCinemaTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DataSetCinemaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nhanVienBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nhanVienBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView nhanVienDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox maNhanVienTextBox;
        private System.Windows.Forms.TextBox tenNhanVienTextBox;
        private System.Windows.Forms.TextBox chucVuTextBox;
        private System.Windows.Forms.TextBox luongTextBox;
        private System.Windows.Forms.DateTimePicker ngayTuyenDungDateTimePicker;
        private System.Windows.Forms.TextBox tenDangNhapTextBox;
        private System.Windows.Forms.TextBox matKhauTextBox;
        private System.Windows.Forms.TextBox maRapTextBox;
    }
}