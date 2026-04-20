using System;
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
            //SetupDashboardUI();
            //LoadDummyData();
            ApplyHighFidelityDesign();


        }
        // 1. تعريف لوحة ألوان احترافية (Modern Dark Theme Palette)
        private readonly Color FormBackground = Color.FromArgb(30, 30, 47);      // خلفية داكنة رئيسية
        private readonly Color CardBackground = Color.FromArgb(39, 41, 61);      // لون البطاقات
        private readonly Color TextPrimary = Color.White;                        // النصوص الرئيسية (الأرقام)
        private readonly Color TextSecondary = Color.FromArgb(154, 154, 169);    // النصوص الفرعية (العناوين)
        private readonly Color AccentColor = Color.FromArgb(29, 142, 238);       // الأزرق الدلالي
        private void ApplyHighFidelityDesign()
        {
            // إعدادات النافذة الأساسية
            this.BackColor = FormBackground;
            this.Size = new Size(1366, 800);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(40); // هوامش عامة حول الفورم بالكامل

            // ==========================================
            // Section 1: Header (الترويسة)
            // ==========================================
            Panel pnlHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                BackColor = Color.Transparent
            };

            Label lblWelcome = new Label
            {
                Text = "Dashboard Overview",
                Font = new Font("Segoe UI", 24F, FontStyle.Bold),
                ForeColor = TextPrimary,
                AutoSize = true,
                Location = new Point(0, 0)
            };

            Label lblSubTitle = new Label
            {
                Text = $"Welcome back, Admin | {DateTime.Now.ToString("dd MMMM yyyy")}",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = TextSecondary,
                AutoSize = true,
                Location = new Point(5, 45)
            };

            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(lblSubTitle);
            this.Controls.Add(pnlHeader);

            // ==========================================
            // Section 2: Main Content Layout (تخطيط المحتوى)
            // ==========================================
            TableLayoutPanel mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                BackColor = Color.Transparent,
                Padding = new Padding(0, 20, 0, 0)
            };
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F)); // 65% للبطاقات
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F)); // 35% للرسم البياني

            // ==========================================
            // Section 3: Cards Grid (شبكة البطاقات)
            // ==========================================
            FlowLayoutPanel cardsPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                AutoScroll = true
            };

            // إنشاء البطاقات مع بيانات وهمية وألوان مميزة لكل حالة
            cardsPanel.Controls.Add(CreateModernCard("  TOTAL CUSTOMERS", " 1,204", Color.FromArgb(29, 142, 238)));  // أزرق
            cardsPanel.Controls.Add(CreateModernCard("  SYSTEM USERS", " 12", Color.FromArgb(225, 78, 202)));        // وردي
            cardsPanel.Controls.Add(CreateModernCard("  TOTAL VEHICLES", " 350", Color.FromArgb(0, 242, 195)));      // أكوا
            cardsPanel.Controls.Add(CreateModernCard("  ACTIVE BOOKINGS", " 85", Color.FromArgb(253, 141, 20)));     // برتقالي
            cardsPanel.Controls.Add(CreateModernCard("  PENDING RETURNS", " 40", Color.FromArgb(253, 93, 147)));     // أحمر فاتح
            cardsPanel.Controls.Add(CreateModernCard("  TRANSACTIONS", " 15,420", Color.FromArgb(52, 70, 117)));     // رمادي مزرق

            mainLayout.Controls.Add(cardsPanel, 0, 0);

            // ==========================================
            // Section 4: Chart Area (منطقة الرسم البياني)
            // ==========================================
            Panel chartPanel = CreateChartPanel();
            mainLayout.Controls.Add(chartPanel, 1, 0);

            this.Controls.Add(mainLayout);
            pnlHeader.SendToBack(); // ترتيب الطبقات لضمان ظهور الترويسة في الأعلى
        }

        /// <summary>
        /// وظيفة مساعدة لإنشاء بطاقة إحصائيات بتصميم عالي الدقة
        /// </summary>
        private Panel CreateModernCard(string title, string value, Color accentColor)
        {
            Panel card = new Panel
            {
                Width = 260,
                Height = 160,
                BackColor = CardBackground,
                Margin = new Padding(0, 0, 20, 20),
                Padding = new Padding(20) // مساحة تنفس داخلية
            };

            // شريط جانبي صغير يعطي لمسة جمالية (Accent Line)
            Panel accentLine = new Panel
            {
                Width = 4,
                Dock = DockStyle.Left,
                BackColor = accentColor
            };
            card.Controls.Add(accentLine);

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = TextSecondary,
                AutoSize = true,
                Location = new Point(20, 25)
            };

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 32F, FontStyle.Bold),
                ForeColor = TextPrimary,
                AutoSize = true,
                Location = new Point(15, 60)
            };

            card.Controls.Add(lblValue);
            card.Controls.Add(lblTitle);

            return card;
        }

        /// <summary>
        /// وظيفة مساعدة لإنشاء وتنسيق الرسم البياني ليتماشى مع الوضع الداكن
        /// </summary>
        private Panel CreateChartPanel()
        {
            Panel container = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = CardBackground,
                Padding = new Padding(20),
                Margin = new Padding(20, 0, 0, 20)
            };

            Label lblChartTitle = new Label
            {
                Text = "Fleet Status Overview",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = TextPrimary,
                AutoSize = true,
                Dock = DockStyle.Top,
                Padding = new Padding(0, 0, 0, 20)
            };
            container.Controls.Add(lblChartTitle);

            Chart chart = new Chart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent
            };

            ChartArea area = new ChartArea
            {
                Name = "MainArea",
                BackColor = Color.Transparent
            };
            chart.ChartAreas.Add(area);

            Legend legend = new Legend
            {
                Name = "Legend1",
                Docking = Docking.Bottom,
                BackColor = Color.Transparent,
                ForeColor = TextSecondary,
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Alignment = StringAlignment.Center
            };
            chart.Legends.Add(legend);

            Series series = new Series
            {
                Name = "Vehicles",
                ChartType = SeriesChartType.Doughnut,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                IsValueShownAsLabel = true,
                LabelForeColor = Color.White
            };

            // بيانات وهمية مع ألوان متناسقة مع الثيم
            DataPoint pntAvailable = new DataPoint { AxisLabel = "Available" };
            pntAvailable.SetValueY(280);
            pntAvailable.Color = Color.FromArgb(0, 242, 195); // أكوا

            DataPoint pntRented = new DataPoint { AxisLabel = "Rented" };
            pntRented.SetValueY(70);
            pntRented.Color = Color.FromArgb(253, 93, 147); // أحمر

            series.Points.Add(pntAvailable);
            series.Points.Add(pntRented);

            chart.Series.Add(series);
            container.Controls.Add(chart);

            return container;
        }

        /*
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
        */
    }
}
