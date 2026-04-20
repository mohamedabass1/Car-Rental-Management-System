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
            BuildDashboard();
        }

        private void BuildDashboard()
        {
            this.BackColor = Color.FromArgb(245, 245, 245);

            Panel container = new Panel();
            container.Dock = DockStyle.Fill;
            container.Padding = new Padding(30);

            this.Controls.Add(container);

            AddHeader(container);
            AddCards(container);
            AddChart(container);
        }

        private void AddHeader(Control parent)
        {
            Label hi = new Label();
            hi.Text = "Hi User";
            hi.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            hi.ForeColor = Color.FromArgb(64, 64, 64);
            hi.Location = new Point(10, 10);

            Label welcome = new Label();
            welcome.Text = "Welcome Back";
            welcome.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            welcome.ForeColor = Color.FromArgb(64, 64, 64);
            welcome.Location = new Point(10, 40);

            parent.Controls.Add(hi);
            parent.Controls.Add(welcome);
        }

        private void AddCards(Control parent)
        {
            FlowLayoutPanel grid = new FlowLayoutPanel();
            grid.Location = new Point(10, 120);
            grid.Size = new Size(900, 300);
            grid.WrapContents = true;

            parent.Controls.Add(grid);

            grid.Controls.Add(CreateCard("Customers", "7", Color.FromArgb(0, 118, 212)));
            grid.Controls.Add(CreateCard("Users", "4", Color.Green));
            grid.Controls.Add(CreateCard("Vehicles", "100", Color.Orange));
            grid.Controls.Add(CreateCard("Booking", "10", Color.Purple));
            grid.Controls.Add(CreateCard("Return", "4", Color.Teal));
            grid.Controls.Add(CreateCard("Transactions", "10", Color.Red));
        }

        private Panel CreateCard(string title, string value, Color accent)
        {
            Panel card = new Panel();
            card.Size = new Size(200, 110);
            card.BackColor = Color.White;
            card.Margin = new Padding(15);

            // Shadow
            card.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                    Color.FromArgb(220, 220, 220), ButtonBorderStyle.Solid);
            };

            // Value
            Label lblValue = new Label();
            lblValue.Text = value;
            lblValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblValue.ForeColor = accent;
            lblValue.Location = new Point(15, 15);
            lblValue.AutoSize = true;

            // Title
            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 10F);
            lblTitle.ForeColor = Color.Gray;
            lblTitle.Location = new Point(15, 60);
            lblTitle.AutoSize = true;

            // Accent line
            Panel line = new Panel();
            line.BackColor = accent;
            line.Dock = DockStyle.Left;
            line.Width = 4;

            // Hover 🔥
            card.MouseEnter += (s, e) =>
            {
                card.BackColor = Color.FromArgb(240, 240, 240);
            };

            card.MouseLeave += (s, e) =>
            {
                card.BackColor = Color.White;
            };

            card.Controls.Add(line);
            card.Controls.Add(lblValue);
            card.Controls.Add(lblTitle);

            return card;
        }
        private void AddChart(Control parent)
        {
            Panel chartCard = new Panel();
            chartCard.Size = new Size(300, 300);
            chartCard.Location = new Point(950, 120);
            chartCard.BackColor = Color.White;

            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea area = new ChartArea();
            chart.ChartAreas.Add(area);

            Series s = new Series();
            s.ChartType = SeriesChartType.Doughnut;
            s.Points.AddXY("Available", 95);
            s.Points.AddXY("Rented", 5);

            chart.Series.Add(s);

            chartCard.Controls.Add(chart);
            parent.Controls.Add(chartCard);
        }



    }
}
