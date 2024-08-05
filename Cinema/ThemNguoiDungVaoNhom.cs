using Cinema.DataSetCinemaTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class btnThemVaoNhom : Form
    {
        public btnThemVaoNhom()
        {
            InitializeComponent();
        }

        private void nhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhomNguoiDungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetCinema);

        }

        private void ThemNguoiDungVaoNhom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCinema.NguoiDungNhomNguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungNhomNguoiDungTableAdapter.Fill(this.dataSetCinema.NguoiDungNhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSetCinema.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dataSetCinema.NhanVien);
            // TODO: This line of code loads data into the 'dataSetCinema.NhomNguoiDung' table. You can move, or remove it, as needed.
            this.nhomNguoiDungTableAdapter.Fill(this.dataSetCinema.NhomNguoiDung);

        }

        private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.nguoiDungNhomNguoiDung_DKTableAdapter.Fill_DK(this.dataSetCinema.NguoiDungNhomNguoiDung_DK, new System.Nullable<int>(((int)(System.Convert.ChangeType(maNhomNguoiDungToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void nhomNguoiDungComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.nguoiDungNhomNguoiDung_DKTableAdapter.Fill_DK(this.dataSetCinema.NguoiDungNhomNguoiDung_DK, new System.Nullable<int>(((int)(System.Convert.ChangeType(cboNhomNguoiDung.SelectedValue.ToString(), typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TenDN = int.Parse(dgvNhanVien.CurrentRow.Cells[0].Value.ToString());

            // Chuyển đổi giá trị từ ComboBox sang int
            int MaNhomND = int.Parse(cboNhomNguoiDung.SelectedValue.ToString());
            this.nguoiDungNhomNguoiDung_DKTableAdapter.Insert(TenDN, MaNhomND);
            MessageBox.Show("Thành công!!");
        }

        private void btnLoaiKhoiNhom_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow item in dgv_NhomNguoiDung.SelectedRows)
            //{
            //    // Giả sử Delete chỉ chấp nhận hai đối số
            //    if
            //    (this.nguoiDungNhomNguoiDung_DKTableAdapter.del(item.Cells[0].Value.ToString(), cboNhomNguoiDung.SelectedValue.ToString()))
            //    {
            //        MessageBox.Show("Thành công");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thất bại");
            //    }
            //    //LoadComboByCondition();
            //}
        }
    }
}
