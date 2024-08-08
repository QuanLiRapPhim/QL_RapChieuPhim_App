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
    public partial class NhomNguoiDung : Form
    {
        public NhomNguoiDung()
        {
            InitializeComponent();
        }

        private void nhomNguoiDungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.nhomNguoiDungBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataSetCinema);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi không thể cập nhật!");
                NhomNguoiDung_Load(sender, e);
            }
            

        }

        private void NhomNguoiDung_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCinema.NguoiDungNhomNguoiDung' table. You can move, or remove it, as needed.
            this.nguoiDungNhomNguoiDungTableAdapter.Fill(this.dataSetCinema.NguoiDungNhomNguoiDung);
            // TODO: This line of code loads data into the 'dataSetCinema.NhomNguoiDung' table. You can move, or remove it, as needed.
            this.nhomNguoiDungTableAdapter.Fill(this.dataSetCinema.NhomNguoiDung);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
