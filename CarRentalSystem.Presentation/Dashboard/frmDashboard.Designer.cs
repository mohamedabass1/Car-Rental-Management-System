namespace CarRentalSystem.Presentation.Dashbiard
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
        private Guna.UI2.WinForms.Guna2HtmlLabel lblReturnedVehicles;
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderSubtitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHeaderTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
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
            this.lblReturnedVehicles = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cardCustomers = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblCustomersTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCustomersValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cardBookings = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblBookingsTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblBookingsValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlChartsArea = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.chartOverview = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlRightColumn = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.chartTopModels = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlRecent = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblRecentTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvRecent = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.flpCards.SuspendLayout();
            this.cardTotalCars.SuspendLayout();
            this.cardAvailable.SuspendLayout();
            this.cardSold.SuspendLayout();
            this.cardCustomers.SuspendLayout();
            this.cardBookings.SuspendLayout();
            this.pnlChartsArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOverview)).BeginInit();
            this.pnlRightColumn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopModels)).BeginInit();
            this.pnlRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();
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
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Enabled = true;
            this.pnlHeader.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlHeader.Size = new System.Drawing.Size(1029, 75);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(22, 43);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(358, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Welcome back — overview of inventory, sales and recent bookings.";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(21, 16);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(213, 32);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Car Dealer Dashboard";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlMain.Controls.Add(this.flpCards);
            this.pnlMain.Controls.Add(this.pnlChartsArea);
            this.pnlMain.Controls.Add(this.pnlRightColumn);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 75);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.pnlMain.Size = new System.Drawing.Size(1029, 606);
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
            this.flpCards.Location = new System.Drawing.Point(15, 16);
            this.flpCards.Name = "flpCards";
            this.flpCards.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.flpCards.Size = new System.Drawing.Size(999, 107);
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
            this.cardTotalCars.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.cardTotalCars.ShadowShift = 6;
            this.cardTotalCars.Size = new System.Drawing.Size(189, 87);
            this.cardTotalCars.TabIndex = 1;
            this.cardTotalCars.MouseEnter += new System.EventHandler(this.Card_MouseEnter);
            this.cardTotalCars.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            // 
            // lblTotalCarsTitle
            // 
            this.lblTotalCarsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCarsTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblTotalCarsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblTotalCarsTitle.Location = new System.Drawing.Point(14, 12);
            this.lblTotalCarsTitle.Name = "lblTotalCarsTitle";
            this.lblTotalCarsTitle.Size = new System.Drawing.Size(55, 17);
            this.lblTotalCarsTitle.TabIndex = 0;
            this.lblTotalCarsTitle.Text = "Total Cars";
            // 
            // lblTotalCarsValue
            // 
            this.lblTotalCarsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCarsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalCarsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(75)))), ((int)(((byte)(164)))));
            this.lblTotalCarsValue.Location = new System.Drawing.Point(14, 31);
            this.lblTotalCarsValue.Name = "lblTotalCarsValue";
            this.lblTotalCarsValue.Size = new System.Drawing.Size(44, 39);
            this.lblTotalCarsValue.TabIndex = 1;
            this.lblTotalCarsValue.Text = "128";
            // 
            // cardAvailable
            // 
            this.cardAvailable.BackColor = System.Drawing.Color.Transparent;
            this.cardAvailable.Controls.Add(this.lblAvailableTitle);
            this.cardAvailable.Controls.Add(this.lblAvailableValue);
            this.cardAvailable.FillColor = System.Drawing.Color.White;
            this.cardAvailable.Location = new System.Drawing.Point(198, 3);
            this.cardAvailable.Name = "cardAvailable";
            this.cardAvailable.Radius = 12;
            this.cardAvailable.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.cardAvailable.ShadowShift = 6;
            this.cardAvailable.Size = new System.Drawing.Size(189, 87);
            this.cardAvailable.TabIndex = 2;
            this.cardAvailable.MouseEnter += new System.EventHandler(this.Card_MouseEnter);
            this.cardAvailable.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            // 
            // lblAvailableTitle
            // 
            this.lblAvailableTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblAvailableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblAvailableTitle.Location = new System.Drawing.Point(14, 12);
            this.lblAvailableTitle.Name = "lblAvailableTitle";
            this.lblAvailableTitle.Size = new System.Drawing.Size(77, 17);
            this.lblAvailableTitle.TabIndex = 0;
            this.lblAvailableTitle.Text = "Available Cars";
            // 
            // lblAvailableValue
            // 
            this.lblAvailableValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblAvailableValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblAvailableValue.Location = new System.Drawing.Point(14, 31);
            this.lblAvailableValue.Name = "lblAvailableValue";
            this.lblAvailableValue.Size = new System.Drawing.Size(34, 39);
            this.lblAvailableValue.TabIndex = 1;
            this.lblAvailableValue.Text = "54";
            // 
            // cardSold
            // 
            this.cardSold.BackColor = System.Drawing.Color.Transparent;
            this.cardSold.Controls.Add(this.lblSoldTitle);
            this.cardSold.Controls.Add(this.lblReturnedVehicles);
            this.cardSold.FillColor = System.Drawing.Color.White;
            this.cardSold.Location = new System.Drawing.Point(393, 3);
            this.cardSold.Name = "cardSold";
            this.cardSold.Radius = 12;
            this.cardSold.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.cardSold.ShadowShift = 6;
            this.cardSold.Size = new System.Drawing.Size(189, 87);
            this.cardSold.TabIndex = 3;
            this.cardSold.MouseEnter += new System.EventHandler(this.Card_MouseEnter);
            this.cardSold.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            // 
            // lblSoldTitle
            // 
            this.lblSoldTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSoldTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblSoldTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblSoldTitle.Location = new System.Drawing.Point(14, 12);
            this.lblSoldTitle.Name = "lblSoldTitle";
            this.lblSoldTitle.Size = new System.Drawing.Size(52, 17);
            this.lblSoldTitle.TabIndex = 0;
            this.lblSoldTitle.Text = "Cars Sold";
            // 
            // lblReturnedVehicles
            // 
            this.lblReturnedVehicles.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnedVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblReturnedVehicles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.lblReturnedVehicles.Location = new System.Drawing.Point(14, 31);
            this.lblReturnedVehicles.Name = "lblReturnedVehicles";
            this.lblReturnedVehicles.Size = new System.Drawing.Size(33, 39);
            this.lblReturnedVehicles.TabIndex = 1;
            this.lblReturnedVehicles.Text = "74";
            // 
            // cardCustomers
            // 
            this.cardCustomers.BackColor = System.Drawing.Color.Transparent;
            this.cardCustomers.Controls.Add(this.lblCustomersTitle);
            this.cardCustomers.Controls.Add(this.lblCustomersValue);
            this.cardCustomers.FillColor = System.Drawing.Color.White;
            this.cardCustomers.Location = new System.Drawing.Point(588, 3);
            this.cardCustomers.Name = "cardCustomers";
            this.cardCustomers.Radius = 12;
            this.cardCustomers.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.cardCustomers.ShadowShift = 6;
            this.cardCustomers.Size = new System.Drawing.Size(189, 87);
            this.cardCustomers.TabIndex = 4;
            this.cardCustomers.MouseEnter += new System.EventHandler(this.Card_MouseEnter);
            this.cardCustomers.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            // 
            // lblCustomersTitle
            // 
            this.lblCustomersTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblCustomersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblCustomersTitle.Location = new System.Drawing.Point(14, 12);
            this.lblCustomersTitle.Name = "lblCustomersTitle";
            this.lblCustomersTitle.Size = new System.Drawing.Size(96, 17);
            this.lblCustomersTitle.TabIndex = 0;
            this.lblCustomersTitle.Text = "Active Customers";
            // 
            // lblCustomersValue
            // 
            this.lblCustomersValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomersValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblCustomersValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblCustomersValue.Location = new System.Drawing.Point(14, 31);
            this.lblCustomersValue.Name = "lblCustomersValue";
            this.lblCustomersValue.Size = new System.Drawing.Size(34, 39);
            this.lblCustomersValue.TabIndex = 1;
            this.lblCustomersValue.Text = "45";
            // 
            // cardBookings
            // 
            this.cardBookings.BackColor = System.Drawing.Color.Transparent;
            this.cardBookings.Controls.Add(this.lblBookingsTitle);
            this.cardBookings.Controls.Add(this.lblBookingsValue);
            this.cardBookings.FillColor = System.Drawing.Color.White;
            this.cardBookings.Location = new System.Drawing.Point(783, 3);
            this.cardBookings.Name = "cardBookings";
            this.cardBookings.Radius = 12;
            this.cardBookings.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.cardBookings.ShadowShift = 6;
            this.cardBookings.Size = new System.Drawing.Size(189, 87);
            this.cardBookings.TabIndex = 5;
            this.cardBookings.MouseEnter += new System.EventHandler(this.Card_MouseEnter);
            this.cardBookings.MouseLeave += new System.EventHandler(this.Card_MouseLeave);
            // 
            // lblBookingsTitle
            // 
            this.lblBookingsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblBookingsTitle.Location = new System.Drawing.Point(14, 12);
            this.lblBookingsTitle.Name = "lblBookingsTitle";
            this.lblBookingsTitle.Size = new System.Drawing.Size(52, 17);
            this.lblBookingsTitle.TabIndex = 0;
            this.lblBookingsTitle.Text = "Bookings";
            // 
            // lblBookingsValue
            // 
            this.lblBookingsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblBookingsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblBookingsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblBookingsValue.Location = new System.Drawing.Point(14, 31);
            this.lblBookingsValue.Name = "lblBookingsValue";
            this.lblBookingsValue.Size = new System.Drawing.Size(29, 39);
            this.lblBookingsValue.TabIndex = 1;
            this.lblBookingsValue.Text = "18";
            // 
            // pnlChartsArea
            // 
            this.pnlChartsArea.BackColor = System.Drawing.Color.Transparent;
            this.pnlChartsArea.Controls.Add(this.chartOverview);
            this.pnlChartsArea.FillColor = System.Drawing.Color.White;
            this.pnlChartsArea.Location = new System.Drawing.Point(15, 133);
            this.pnlChartsArea.Name = "pnlChartsArea";
            this.pnlChartsArea.Radius = 12;
            this.pnlChartsArea.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.pnlChartsArea.ShadowShift = 8;
            this.pnlChartsArea.Size = new System.Drawing.Size(651, 416);
            this.pnlChartsArea.TabIndex = 6;
            // 
            // chartOverview
            // 
            this.chartOverview.BackColor = System.Drawing.Color.Transparent;
            this.chartOverview.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "MainArea";
            this.chartOverview.ChartAreas.Add(chartArea1);
            this.chartOverview.Location = new System.Drawing.Point(15, 16);
            this.chartOverview.Name = "chartOverview";
            series1.BorderWidth = 3;
            series1.ChartArea = "MainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            series1.Name = "Revenue";
            this.chartOverview.Series.Add(series1);
            this.chartOverview.Size = new System.Drawing.Size(621, 385);
            this.chartOverview.TabIndex = 0;
            this.chartOverview.Text = "chartOverview";
            // 
            // pnlRightColumn
            // 
            this.pnlRightColumn.BackColor = System.Drawing.Color.Transparent;
            this.pnlRightColumn.Controls.Add(this.chartTopModels);
            this.pnlRightColumn.Controls.Add(this.pnlRecent);
            this.pnlRightColumn.FillColor = System.Drawing.Color.Transparent;
            this.pnlRightColumn.Location = new System.Drawing.Point(682, 133);
            this.pnlRightColumn.Name = "pnlRightColumn";
            this.pnlRightColumn.ShadowColor = System.Drawing.Color.Black;
            this.pnlRightColumn.Size = new System.Drawing.Size(331, 416);
            this.pnlRightColumn.TabIndex = 7;
            // 
            // chartTopModels
            // 
            this.chartTopModels.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "PieArea";
            this.chartTopModels.ChartAreas.Add(chartArea2);
            this.chartTopModels.Location = new System.Drawing.Point(15, 16);
            this.chartTopModels.Name = "chartTopModels";
            series2.ChartArea = "PieArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Name = "TopModels";
            this.chartTopModels.Series.Add(series2);
            this.chartTopModels.Size = new System.Drawing.Size(300, 191);
            this.chartTopModels.TabIndex = 0;
            this.chartTopModels.Text = "chartTopModels";
            // 
            // pnlRecent
            // 
            this.pnlRecent.BackColor = System.Drawing.Color.Transparent;
            this.pnlRecent.Controls.Add(this.lblRecentTitle);
            this.pnlRecent.Controls.Add(this.dgvRecent);
            this.pnlRecent.FillColor = System.Drawing.Color.White;
            this.pnlRecent.Location = new System.Drawing.Point(15, 215);
            this.pnlRecent.Name = "pnlRecent";
            this.pnlRecent.Radius = 12;
            this.pnlRecent.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.pnlRecent.ShadowShift = 6;
            this.pnlRecent.Size = new System.Drawing.Size(300, 182);
            this.pnlRecent.TabIndex = 1;
            // 
            // lblRecentTitle
            // 
            this.lblRecentTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblRecentTitle.Location = new System.Drawing.Point(14, 9);
            this.lblRecentTitle.Name = "lblRecentTitle";
            this.lblRecentTitle.Size = new System.Drawing.Size(89, 19);
            this.lblRecentTitle.TabIndex = 0;
            this.lblRecentTitle.Text = "Recent Orders";
            // 
            // dgvRecent
            // 
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRecent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecent.ColumnHeadersHeight = 26;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecent.Location = new System.Drawing.Point(14, 33);
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.Size = new System.Drawing.Size(273, 135);
            this.dgvRecent.TabIndex = 1;
            this.dgvRecent.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecent.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRecent.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRecent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRecent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRecent.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecent.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecent.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRecent.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecent.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvRecent.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRecent.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecent.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvRecent.ThemeStyle.ReadOnly = true;
            this.dgvRecent.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecent.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecent.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgvRecent.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRecent.ThemeStyle.RowsStyle.Height = 22;
            this.dgvRecent.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecent.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1029, 681);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.flpCards.ResumeLayout(false);
            this.cardTotalCars.ResumeLayout(false);
            this.cardTotalCars.PerformLayout();
            this.cardAvailable.ResumeLayout(false);
            this.cardAvailable.PerformLayout();
            this.cardSold.ResumeLayout(false);
            this.cardSold.PerformLayout();
            this.cardCustomers.ResumeLayout(false);
            this.cardCustomers.PerformLayout();
            this.cardBookings.ResumeLayout(false);
            this.cardBookings.PerformLayout();
            this.pnlChartsArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOverview)).EndInit();
            this.pnlRightColumn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopModels)).EndInit();
            this.pnlRecent.ResumeLayout(false);
            this.pnlRecent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}