using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CarRental.Dashbiard
{
    public partial class frmDashboard : Form
    {
        // ألوان التصميم الحديث (Modern Palette)
        private Color _bgColor = Color.FromArgb(243, 244, 246); // رمادي فاتح للخلفية
        private Color _cardColor = Color.White;
        private Color _primaryText = Color.FromArgb(31, 41, 55); // رمادي داكن للنصوص
        private Color _accentColor = Color.FromArgb(59, 130, 246); // أزرق حديث
        private Font _titleFont = new Font("Segoe UI", 18, FontStyle.Bold);
        private Font _cardTitleFont = new Font("Segoe UI", 12, FontStyle.Regular);
        private Font _cardValueFont = new Font("Segoe UI", 24, FontStyle.Bold);
        public frmDashboard()
        {
            InitializeComponent();
            SetupDashboardUI();
            LoadDummyData();
        }

        /// <summary>
        /// تقوم هذه الدالة بتجهيز وبناء عناصر الواجهة برمجياً
        /// </summary>
        private void SetupDashboardUI()
        {
            this.BackColor = _bgColor;
            this.Size = new Size(1100, 750);
            this.FormBorderStyle = FormBorderStyle.None; // إزالة حواف النافذة لتصميم أنظف (اختياري)
            this.AutoScroll = true;

            // 1. إضافة عنوان الترحيب
            Label lblWelcome = new Label
            {
                Text = "Welcome Back, User!",
                Font = _titleFont,
                ForeColor = _primaryText,
                AutoSize = true,
                Location = new Point(40, 30)
            };
            this.Controls.Add(lblWelcome);

            Label lblSubTitle = new Label
            {
                Text = "Here is the summary of your system today.",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(43, 65)
            };
            this.Controls.Add(lblSubTitle);

            // 2. حاوية للبطاقات (FlowLayoutPanel) لترتيب البطاقات تلقائياً
            FlowLayoutPanel cardsPanel = new FlowLayoutPanel
            {
                Location = new Point(40, 110),
                Size = new Size(650, 600),
                BackColor = Color.Transparent,
                AutoScroll = true
            };
            this.Controls.Add(cardsPanel);

            // 3. إنشاء البطاقات الستة وإضافتها للحاوية
            cardsPanel.Controls.Add(CreateCard("Customers", "lblCustomers", Color.FromArgb(16, 185, 129))); // أخضر
            cardsPanel.Controls.Add(CreateCard("Users", "lblUsers", Color.FromArgb(139, 92, 246))); // بنفسجي
            cardsPanel.Controls.Add(CreateCard("Vehicles", "lblVehicles", _accentColor)); // أزرق
            cardsPanel.Controls.Add(CreateCard("Bookings", "lblBookings", Color.FromArgb(245, 158, 11))); // برتقالي
            cardsPanel.Controls.Add(CreateCard("Returns", "lblReturns", Color.FromArgb(239, 68, 68))); // أحمر
            cardsPanel.Controls.Add(CreateCard("Transactions", "lblTransactions", Color.FromArgb(14, 165, 233))); // سماوي

            // 4. إضافة الرسم البياني (Chart)
            Chart vehicleChart = CreateChart();
            vehicleChart.Location = new Point(710, 110);
            this.Controls.Add(vehicleChart);
        }

        /// <summary>
        /// دالة مساعدة لإنشاء بطاقة (Card) بشكل قياسي
        /// </summary>
        private Panel CreateCard(string title, string valueLabelName, Color accentLineColor)
        {
            Panel card = new Panel
            {
                Size = new Size(300, 140),
                BackColor = _cardColor,
                Margin = new Padding(0, 0, 20, 20)
            };

            // خط جانبي ملون يعطي طابعاً حديثاً
            Panel accentLine = new Panel
            {
                BackColor = accentLineColor,
                Size = new Size(5, 140),
                Dock = DockStyle.Left
            };
            card.Controls.Add(accentLine);

            Label lblTitle = new Label
            {
                Text = title,
                Font = _cardTitleFont,
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(20, 20)
            };
            card.Controls.Add(lblTitle);

            Label lblValue = new Label
            {
                Name = valueLabelName, // اسم برمجي للوصول إليه لاحقاً
                Text = "0", // القيمة المبدئية
                Font = _cardValueFont,
                ForeColor = _primaryText,
                AutoSize = true,
                Location = new Point(20, 55)
            };
            card.Controls.Add(lblValue);

            return card;
        }

        /// <summary>
        /// إنشاء وتصميم الرسم البياني الدائري (Doughnut Chart)
        /// </summary>
        private Chart CreateChart()
        {
            Chart chart = new Chart
            {
                Size = new Size(330, 440),
                BackColor = _cardColor
            };

            ChartArea chartArea = new ChartArea
            {
                Name = "MainArea",
                BackColor = _cardColor
            };
            chart.ChartAreas.Add(chartArea);

            Legend legend = new Legend
            {
                Name = "Legend1",
                Docking = Docking.Bottom,
                Font = new Font("Segoe UI", 10),
                BackColor = _cardColor
            };
            chart.Legends.Add(legend);

            Series series = new Series
            {
                Name = "Vehicles",
                ChartType = SeriesChartType.Doughnut,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                IsValueShownAsLabel = true
            };
            chart.Series.Add(series);

            Title title = new Title
            {
                Text = "Vehicles Status",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = _primaryText
            };
            chart.Titles.Add(title);

            return chart;
        }

        /// <summary>
        /// تعبئة الواجهة بأرقام وهمية للتجربة
        /// </summary>
        private void LoadDummyData()
        {
            // تعبئة البطاقات عبر البحث عن أسماء الـ Labels التي أنشأناها برمجياً
            ((Label)this.Controls.Find("lblCustomers", true)[0]).Text = "1,240";
            ((Label)this.Controls.Find("lblUsers", true)[0]).Text = "15";
            ((Label)this.Controls.Find("lblVehicles", true)[0]).Text = "350";
            ((Label)this.Controls.Find("lblBookings", true)[0]).Text = "85";
            ((Label)this.Controls.Find("lblReturns", true)[0]).Text = "42";
            ((Label)this.Controls.Find("lblTransactions", true)[0]).Text = "12,500";

            // تعبئة الرسم البياني ببيانات وهمية
            Chart chart = (Chart)this.Controls[this.Controls.Count - 1]; // Chart هو آخر عنصر تمت إضافته

            DataPoint availablePoint = new DataPoint();
            availablePoint.SetValueXY("Available", 280);
            availablePoint.Color = Color.FromArgb(16, 185, 129); // أخضر

            DataPoint rentedPoint = new DataPoint();
            rentedPoint.SetValueXY("Rented", 70);
            rentedPoint.Color = Color.FromArgb(239, 68, 68); // أحمر

            chart.Series["Vehicles"].Points.Add(availablePoint);
            chart.Series["Vehicles"].Points.Add(rentedPoint);
        }
    }
}
