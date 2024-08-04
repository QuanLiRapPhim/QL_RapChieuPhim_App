using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Microsoft.Reporting.WinForms;
namespace Cinema
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }
        KhachHang_BLL_DAL kh=new KhachHang_BLL_DAL();
        private void BaoCao_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "Cinema.reportKhachHang.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "KhachHang";
                reportDataSource.Value = kh.LoadKhachHang();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
