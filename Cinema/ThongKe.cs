using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Cinema
{
    public partial class ThongKe : Form
    {
        private ManageCinemaDataContext cinema=new ManageCinemaDataContext();
        public ThongKe()
        {
            InitializeComponent();
            LoadChartData();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void LoadChartData()
        {
            var ticketData = cinema.Ves
                .Where(ve => ve.NgayDatVe.HasValue) // Lọc các vé có ngày đặt vé không null
                .GroupBy(ve => ve.NgayDatVe.Value.Month) // Sử dụng Value.Month để truy cập thuộc tính Month
                .Select(g => new
                {
                    Month = g.Key,
                    TicketCount = g.Count()
                })
                .OrderBy(data => data.Month)
                .Cast<dynamic>() // Chuyển đổi sang dynamic
                .ToList();

            ChartSeriesData(ticketData);
        }


        private void ChartSeriesData(List<dynamic> ticketData)
        {
            Series series = new Series("Số lượng vé");
            series.ChartType = SeriesChartType.Column;

            foreach (var data in ticketData)
            {
                series.Points.AddXY("Tháng " + data.Month.ToString(), data.TicketCount);
            }

            chart1.Series.Clear();
            chart1.Series.Add(series);

            // Thiết lập các thuộc tính của biểu đồ
            chart1.ChartAreas[0].AxisX.Title = "Tháng";
            chart1.ChartAreas[0].AxisY.Title = "Số lượng vé";
            chart1.Palette = ChartColorPalette.BrightPastel;
        }
    }
}
