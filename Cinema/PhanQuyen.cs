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
    public partial class PhanQuyen : Form
    {
        public PhanQuyen()
        {
            InitializeComponent();
        }

        //private void fill_DKToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.pQ_DKTableAdapter.Fill_DK(this.dataSetCinema.PQ_DK, new System.Nullable<int>(((int)(System.Convert.ChangeType(maNhomNDToolStripTextBox.Text, typeof(int))))));
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'dataSetCinema.NhomNguoiDung' table. You can move, or remove it, as needed.
            this.nhomNguoiDungTableAdapter.Fill(this.dataSetCinema.NhomNguoiDung);

        }

        private void fill_DKToolStripButton_Click_1(object sender, EventArgs e)
        {
          

        }

        private void nhomNguoiDungDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(nhomNguoiDungDataGridView != null)
            {
                int manhomnd = int.Parse(nhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString());
                try
                {
                    this.pQ_DKTableAdapter.Fill_DK(this.dataSetCinema.PQ_DK, manhomnd);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i< pQ_DKDataGridView.Rows.Count;i++)
            {
                int manhomnd = int.Parse(nhomNguoiDungDataGridView.CurrentRow.Cells[0].Value.ToString());
                int mmh = int.Parse(pQ_DKDataGridView.CurrentRow.Cells[0].Value.ToString());

                PhanQuyenTableAdapter phanQuyenTableAdapter = new PhanQuyenTableAdapter();
                int? pKC=phanQuyenTableAdapter.KTKC(manhomnd, mmh);
                if(pKC.Value==0) 
                {
                    phanQuyenTableAdapter.Them(manhomnd,mmh,false);
                    MessageBox.Show("them");
                }
                else
                {
                    phanQuyenTableAdapter.Sua(true,manhomnd,mmh);
                    MessageBox.Show("sua");
                }
            }
            

        }
    }
}
