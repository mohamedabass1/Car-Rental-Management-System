namespace CarRental.Dashbiard
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Guna UI2 controls
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeaderTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeaderSubtitle;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel flpCards;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardTotalCars;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalCarsTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalCarsValue;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardAvailable;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAvailableTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAvailableValue;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardSold;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoldTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoldValue;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardCustomers;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomersTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomersValue;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardBookings;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBookingsTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBookingsValue;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlChartsArea;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOverview;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopModels;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlRightColumn;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlRecent;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRecent;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRecentTitle;

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
        /// InitializeComponent - modern Guna2 dashboard
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaMain = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series seriesMain = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaPie = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series seriesPie = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHeaderSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.flpCards = new System.Windows.Forms.FlowLayoutPanel();

            this.cardTotalCars = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTotalCarsTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalCarsValue = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.cardAvailable = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblAvailableTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAvailableValue = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.cardSold = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblSoldTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSoldValue = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.cardCustomers = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblCustomersTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCustomersValue = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.cardBookings = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblBookingsTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBookingsValue = new Guna.UI2.WinForms.Guna2HtmlLabel();

            this.pnlChartsArea = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.chartOverview = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopModels = new System.Windows.Forms.DataVisualization.Charting.Chart();

            this.pnlRightColumn = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlRecent = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblRecentTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvRecent = new Guna.UI2.WinForms.Guna2DataGridView();

            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlHeader;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.lblHeaderSubtitle);
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(249, 250, 252);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Enabled = true;
            this.pnlHeader.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlHeader.Size = new System.Drawing.Size(1200, 86);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.lblHeaderTitle.Location = new System.Drawing.Point(24, 18);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(220, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Car Dealer Dashboard";
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(420, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Welcome back — overview of inventory, sales and recent bookings.";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(246, 247, 250);
            this.pnlMain.Controls.Add(this.flpCards);
            this.pnlMain.Controls.Add(this.pnlChartsArea);
            this.pnlMain.Controls.Add(this.pnlRightColumn);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 86);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(18);
            this.pnlMain.Size = new System.Drawing.Size(1200, 700);
            this.pnlMain.TabIndex = 4;

            // 
            // flpCards
            // 
            this.flpCards.AutoScroll = true;
            this.flpCards.BackColor = System.Drawing.Color.Transparent;
            this.flpCards.Controls.Add(this.cardTotalCars);
            this.flpCards.Controls.Add(this.cardAvailable);
            this.flpCards.Controls.Add(this.cardSold);
            this.flpCards.Controls.Add(this.cardCustomers);
            this.flpCards.Controls.Add(this.cardBookings);
            this.flpCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCards.Location = new System.Drawing.Point(18, 18);
            this.flpCards.Name = "flpCards";
            this.flpCards.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.flpCards.Size = new System.Drawing.Size(1164, 124);
            this.flpCards.TabIndex = 0;
            // 
            // cardTotalCars
            // 
            this.cardTotalCars.BackColor = System.Drawing.Color.Transparent;
            this.cardTotalCars.Controls.Add(this.lblTotalCarsTitle);
            this.cardTotalCars.Controls.Add(this.lblTotalCarsValue);
            this.cardTotalCars.FillColor = System.Drawing.Color.White;
            this.cardTotalCars.Location = new System.Drawing.Point(3, 3);
            this.cardTotalCars.Name = "cardTotalCars";
            this.cardTotalCars.Radius = 12;
            this.cardTotalCars.ShadowColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.cardTotalCars.ShadowShift = 6;
            this.cardTotalCars.Size = new System.Drawing.Size(220, 100);
            this.cardTotalCars.TabIndex = 1;
            this.cardTotalCars.MouseEnter += new System.EventHandler(this.Card_MouseEnter);
            this.cardTotalCars.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            // 
            // lblTotalCarsTitle
            // 
            this.lblTotalCarsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCarsTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblTotalCarsTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);
            this.lblTotalCarsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblTotalCarsTitle.Name = "lblTotalCarsTitle";
            this.lblTotalCarsTitle.Size = new System.Drawing.Size(65, 17);
            this.lblTotalCarsTitle.TabIndex = 0;
            this.lblTotalCarsTitle.Text = "Total Cars";
            // 
            // lblTotalCarsValue
            // 
            this.lblTotalCarsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCarsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalCarsValue.ForeColor = System.Drawing.Color.FromArgb(34, 75, 164);
            this.lblTotalCarsValue.Location = new System.Drawing.Point(16, 36);
            this.lblTotalCarsValue.Name = "lblTotalCarsValue";
            this.lblTotalCarsValue.Size = new System.Drawing.Size(54, 38);
            this.lblTotalCarsValue.TabIndex = 1;
            this.lblTotalCarsValue.Text = "128";
            // 
            // cardAvailable
            // 
            this.cardAvailable.BackColor = System.Drawing.Color.Transparent;
            this.cardAvailable.Controls.Add(this.lblAvailableTitle);
            this.cardAvailable.Controls.Add(this.lblAvailableValue);
            this.cardAvailable.FillColor = System.Drawing.Color.White;
            this.cardAvailable.Location = new System.Drawing.Point(229, 3);
            this.cardAvailable.Name = "cardAvailable";
            this.cardAvailable.Radius = 12;
            this.cardAvailable.ShadowColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.cardAvailable.ShadowShift = 6;
            this.cardAvailable.Size = new System.Drawing.Size(220, 100);
            this.cardAvailable.TabIndex = 2;
            this.cardAvailable.MouseEnter += new System.EventHandler(this.Card_MouseEnter);
            this.cardAvailable.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            // 
            // lblAvailableTitle
            // 
            this.lblAvailableTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblAvailableTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);
            this.lblAvailableTitle.Location = new System.Drawing.Point(16, 14);
            this.lblAvailableTitle.Name = "lblAvailableTitle";
            this.lblAvailableTitle.Size = new System.Drawing.Size(93, 17);
            this.lblAvailableTitle.TabIndex = 0;
            this.lblAvailableTitle.Text = "Available Cars";
            // 
            // lblAvailableValue
            // 
            this.lblAvailableValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblAvailableValue.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblAvailableValue.Location = new System.Drawing.Point(16, 36);
            this.lblAvailableValue.Name = "lblAvailableValue";
            this.lblAvailableValue.Size = new System.Drawing.Size(30, 38);
            this.lblAvailableValue.TabIndex = 1;
            this.lblAvailableValue.Text = "54";
            // 
            // cardSold
            // 
            this.cardSold.BackColor = System.Drawing.Color.Transparent;
            this.cardSold.Controls.Add(this.lblSoldTitle);
            this.cardSold.Controls.Add(this.lblSoldValue);
            this.cardSold.FillColor = System.Drawing.Color.White;
            this.cardSold.Location = new System.Drawing.Point(455, 3);
            this.cardSold.Name = "cardSold";
            this.cardSold.Radius = 12;
            this.cardSold.ShadowColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.cardSold.ShadowShift = 6;
            this.cardSold.Size = new System.Drawing.Size(220, 100);
            this.cardSold.TabIndex = 3;
            this.cardSold.MouseEnter += new System.EventHandler(this.Card_MouseEnter);
            this.cardSold.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            // 
            // lblSoldTitle
            // 
            this.lblSoldTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSoldTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblSoldTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);
            this.lblSoldTitle.Location = new System.Drawing.Point(16, 14);
            this.lblSoldTitle.Name = "lblSoldTitle";
            this.lblSoldTitle.Size = new System.Drawing.Size(85, 17);
            this.lblSoldTitle.TabIndex = 0;
            this.lblSoldTitle.Text = "Cars Sold";
            // 
            // lblSoldValue
            // 
            this.lblSoldValue.BackColor = System.Drawing.Color.Transparent;
            this.lblSoldValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblSoldValue.ForeColor = System.Drawing.Color.FromArgb(249, 115, 22);
            this.lblSoldValue.Location = new System.Drawing.Point(16, 36);
            this.lblSoldValue.Name = "lblSoldValue";
            this.lblSoldValue.Size = new System.Drawing.Size(36, 38);
            this.lblSoldValue.TabIndex = 1;
            this.lblSoldValue.Text = "74";
            // 
            // cardCustomers
            // 
            this.cardCustomers.BackColor = System.Drawing.Color.Transparent;
            this.cardCustomers.Controls.Add(this.lblCustomersTitle);
            this.cardCustomers.Controls.Add(this.lblCustomersValue);
            this.cardCustomers.FillColor = System.Drawing.Color.White;
            this.cardCustomers.Location = new System.Drawing.Point(681, 3);
            this.cardCustomers.Name = "cardCustomers";
            this.cardCustomers.Radius = 12;
            this.cardCustomers.ShadowColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.cardCustomers.ShadowShift = 6;
            this.cardCustomers.Size = new System.Drawing.Size(220, 100);
            this.cardCustomers.TabIndex = 4;
            this.cardCustomers.MouseEnter += new System.EventHandler(this.Card_MouseEnter);
            this.cardCustomers.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            // 
            // lblCustomersTitle
            // 
            this.lblCustomersTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblCustomersTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);
            this.lblCustomersTitle.Location = new System.Drawing.Point(16, 14);
            this.lblCustomersTitle.Name = "lblCustomersTitle";
            this.lblCustomersTitle.Size = new System.Drawing.Size(110, 17);
            this.lblCustomersTitle.TabIndex = 0;
            this.lblCustomersTitle.Text = "Active Customers";
            // 
            // lblCustomersValue
            // 
            this.lblCustomersValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomersValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblCustomersValue.ForeColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.lblCustomersValue.Location = new System.Drawing.Point(16, 36);
            this.lblCustomersValue.Name = "lblCustomersValue";
            this.lblCustomersValue.Size = new System.Drawing.Size(36, 38);
            this.lblCustomersValue.TabIndex = 1;
            this.lblCustomersValue.Text = "45";
            // 
            // cardBookings
            // 
            this.cardBookings.BackColor = System.Drawing.Color.Transparent;
            this.cardBookings.Controls.Add(this.lblBookingsTitle);
            this.cardBookings.Controls.Add(this.lblBookingsValue);
            this.cardBookings.FillColor = System.Drawing.Color.White;
            this.cardBookings.Location = new System.Drawing.Point(907, 3);
            this.cardBookings.Name = "cardBookings";
            this.cardBookings.Radius = 12;
            this.cardBookings.ShadowColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.cardBookings.ShadowShift = 6;
            this.cardBookings.Size = new System.Drawing.Size(220, 100);
            this.cardBookings.TabIndex = 5;
            this.cardBookings.MouseEnter += new System.EventHandler(this.Card_MouseEnter);
            this.cardBookings.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            // 
            // lblBookingsTitle
            // 
            this.lblBookingsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150);
            this.lblBookingsTitle.Location = new System.Drawing.Point(16, 14);
            this.lblBookingsTitle.Name = "lblBookingsTitle";
            this.lblBookingsTitle.Size = new System.Drawing.Size(74, 17);
            this.lblBookingsTitle.TabIndex = 0;
            this.lblBookingsTitle.Text = "Bookings";
            // 
            // lblBookingsValue
            // 
            this.lblBookingsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblBookingsValue.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblBookingsValue.Location = new System.Drawing.Point(16, 36);
            this.lblBookingsValue.Name = "lblBookingsValue";
            this.lblBookingsValue.Size = new System.Drawing.Size(34, 38);
            this.lblBookingsValue.TabIndex = 1;
            this.lblBookingsValue.Text = "18";
            // 
            // pnlChartsArea
            // 
            this.pnlChartsArea.BackColor = System.Drawing.Color.Transparent;
            this.pnlChartsArea.Controls.Add(this.chartOverview);
            this.pnlChartsArea.FillColor = System.Drawing.Color.White;
            this.pnlChartsArea.Location = new System.Drawing.Point(18, 154);
            this.pnlChartsArea.Name = "pnlChartsArea";
            this.pnlChartsArea.Radius = 12;
            this.pnlChartsArea.ShadowColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.pnlChartsArea.ShadowShift = 8;
            this.pnlChartsArea.Size = new System.Drawing.Size(760, 480);
            this.pnlChartsArea.TabIndex = 6;
            // 
            // chartOverview (line)
            // 
            this.chartOverview.BackColor = System.Drawing.Color.Transparent;
            this.chartOverview.BorderlineColor = System.Drawing.Color.Transparent;
            chartAreaMain.Name = "MainArea";
            chartAreaMain.BackColor = System.Drawing.Color.Transparent;
            chartAreaMain.AxisX.MajorGrid.Enabled = false;
            chartAreaMain.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.chartOverview.ChartAreas.Add(chartAreaMain);
            this.chartOverview.Location = new System.Drawing.Point(18, 18);
            this.chartOverview.Name = "chartOverview";
            seriesMain.BorderWidth = 3;
            seriesMain.ChartArea = "MainArea";
            seriesMain.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesMain.Color = System.Drawing.Color.FromArgb(99, 102, 241);
            seriesMain.Name = "Revenue";
            this.chartOverview.Series.Add(seriesMain);
            this.chartOverview.Size = new System.Drawing.Size(724, 444);
            this.chartOverview.TabIndex = 0;
            this.chartOverview.Text = "chartOverview";
            // 
            // pnlRightColumn
            // 
            this.pnlRightColumn.BackColor = System.Drawing.Color.Transparent;
            this.pnlRightColumn.Controls.Add(this.chartTopModels);
            this.pnlRightColumn.Controls.Add(this.pnlRecent);
            this.pnlRightColumn.FillColor = System.Drawing.Color.Transparent;
            this.pnlRightColumn.Location = new System.Drawing.Point(796, 154);
            this.pnlRightColumn.Name = "pnlRightColumn";
            this.pnlRightColumn.Radius = 0;
            //this.pnlRightColumn.ShadowDecoration.Enabled = false;
            this.pnlRightColumn.Size = new System.Drawing.Size(386, 480);
            this.pnlRightColumn.TabIndex = 7;
            // 
            // chartTopModels (pie)
            // 
            this.chartTopModels.BackColor = System.Drawing.Color.Transparent;
            chartAreaPie.Name = "PieArea";
            chartAreaPie.BackColor = System.Drawing.Color.Transparent;
            this.chartTopModels.ChartAreas.Add(chartAreaPie);
            this.chartTopModels.Location = new System.Drawing.Point(18, 18);
            this.chartTopModels.Name = "chartTopModels";
            seriesPie.ChartArea = "PieArea";
            seriesPie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            seriesPie.Name = "TopModels";
            this.chartTopModels.Series.Add(seriesPie);
            this.chartTopModels.Size = new System.Drawing.Size(350, 220);
            this.chartTopModels.TabIndex = 0;
            this.chartTopModels.Text = "chartTopModels";
            // 
            // pnlRecent
            // 
            this.pnlRecent.BackColor = System.Drawing.Color.Transparent;
            this.pnlRecent.Controls.Add(this.lblRecentTitle);
            this.pnlRecent.Controls.Add(this.dgvRecent);
            this.pnlRecent.FillColor = System.Drawing.Color.White;
            this.pnlRecent.Location = new System.Drawing.Point(18, 248);
            this.pnlRecent.Name = "pnlRecent";
            this.pnlRecent.Radius = 12;
            this.pnlRecent.ShadowColor = System.Drawing.Color.FromArgb(60, 70, 90);
            this.pnlRecent.ShadowShift = 6;
            this.pnlRecent.Size = new System.Drawing.Size(350, 210);
            this.pnlRecent.TabIndex = 1;
            // 
            // lblRecentTitle
            // 
            this.lblRecentTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblRecentTitle.Location = new System.Drawing.Point(16, 10);
            this.lblRecentTitle.Name = "lblRecentTitle";
            this.lblRecentTitle.Size = new System.Drawing.Size(94, 19);
            this.lblRecentTitle.TabIndex = 0;
            this.lblRecentTitle.Text = "Recent Orders";
            // 
            // dgvRecent
            // 
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.AllowUserToResizeRows = false;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecent.ColumnHeadersHeight = 26;
            this.dgvRecent.Location = new System.Drawing.Point(16, 38);
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecent.Size = new System.Drawing.Size(318, 156);
            this.dgvRecent.TabIndex = 1;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 247, 250);
            this.ClientSize = new System.Drawing.Size(1200, 786);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);

            // finish
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
        }

        #endregion
    }
}