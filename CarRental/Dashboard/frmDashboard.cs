using CarRental_Buisness.Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CarRental.Dashbiard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private async void frmDashboard_Load(object sender, EventArgs e)
        {
            // Get Dashboard Statistics  
            var Statistics = await clsDashboardService.GetDashboardStatsAsync();



            lblTotalCarsValue.Text = Statistics.TotalVehicles.ToString();

            lblAvailableValue.Text = Statistics.AvailableVehicles.ToString();

            lblCustomersValue.Text = Statistics.CustomersCount.ToString();

            lblBookingsValue.Text = Statistics.ActiveBookings.ToString();
            lblReturnedVehicles.Text = "74";


            // Configure line chart (monthly revenue)
            var revenue = new[] { 5000, 7200, 6800, 9200, 11500, 9800, 12500, 14000, 13200, 15000, 16000, 17500 };
            chartOverview.Series.Clear();
            var series = new Series("Revenue")
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 3,
                Color = Color.FromArgb(99, 102, 241)
            };
            chartOverview.ChartAreas[0].AxisX.Title = "Month";
            chartOverview.ChartAreas[0].AxisY.Title = "USD";

            for (int i = 0; i < revenue.Length; i++)
            {
                series.Points.AddXY(new DateTime(DateTime.Now.Year, i + 1, 1).ToString("MMM"), revenue[i]);
            }
            chartOverview.Series.Add(series);

            // Configure pie chart (top models)
            chartTopModels.Series.Clear();
            var pie = new Series("TopModels")
            {
                ChartType = SeriesChartType.Pie
            };
            pie.Points.Add(new DataPoint(0, 34) { LegendText = "Model A" });
            pie.Points.Add(new DataPoint(0, 25) { LegendText = "Model B" });
            pie.Points.Add(new DataPoint(0, 20) { LegendText = "Model C" });
            pie.Points.Add(new DataPoint(0, 21) { LegendText = "Other" });
            chartTopModels.Series.Add(pie);
            chartTopModels.Legends.Clear();
            chartTopModels.Legends.Add(new Legend());

            // Fill recent orders grid (sample)
            dgvRecent.Columns.Clear();
            dgvRecent.Columns.Add("OrderID", "Order ID");
            dgvRecent.Columns.Add("Customer", "Customer");
            dgvRecent.Columns.Add("Car", "Car");
            dgvRecent.Columns.Add("Status", "Status");

            dgvRecent.Rows.Add("ORD-1001", "Mohamed Abass", "Model A", "Confirmed");
            dgvRecent.Rows.Add("ORD-1002", "Sara Hassan", "Model B", "Pending");
            dgvRecent.Rows.Add("ORD-1003", "Mohamed Adel", "Model C", "Completed");
            dgvRecent.Rows.Add("ORD-1004", "Lina Youssef", "Model A", "Confirmed");

            // Style grid for modern look
            dgvRecent.EnableHeadersVisualStyles = false;
            dgvRecent.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvRecent.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(55, 65, 81);
            dgvRecent.DefaultCellStyle.SelectionBackColor = Color.FromArgb(241, 245, 249);
            dgvRecent.DefaultCellStyle.SelectionForeColor = Color.FromArgb(17, 24, 39);

            // Ensure responsive resize
            this.Resize += FrmDashboard_Resize;
            ApplyResponsiveLayout();
        }

        private void FrmDashboard_Resize(object sender, EventArgs e)
        {
            ApplyResponsiveLayout();
        }

        private void ApplyResponsiveLayout()
        {
            // Simple responsive adjustments: make charts and right column scale with form size
            try
            {
                int width = this.ClientSize.Width - 36; // padding
                // Left chart area width ~65%, right column ~35%
                int leftWidth = (int)(width * 0.65);
                int rightWidth = width - leftWidth - 18;

                pnlChartsArea.Width = Math.Max(480, leftWidth);
                pnlChartsArea.Height = Math.Max(300, this.ClientSize.Height - pnlHeader.Height - flpCards.Height - 60);

                pnlRightColumn.Left = pnlChartsArea.Right + 18;
                pnlRightColumn.Width = Math.Max(300, rightWidth);
                pnlRightColumn.Height = pnlChartsArea.Height;
            }
            catch
            {
                // keep safe if layout calculation fails
            }
        }

        // Hover effects for cards: subtle shadow increase and slight fill tint
        private void Card_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2ShadowPanel card)
            {
                card.ShadowShift = 12;
                card.FillColor = ControlPaint.Light(card.FillColor, 0.02f);
            }
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2ShadowPanel card)
            {
                card.ShadowShift = 6;
                // restore to white for consistency (cards use white fill)
                card.FillColor = Color.White;
            }
        }
    }
}
