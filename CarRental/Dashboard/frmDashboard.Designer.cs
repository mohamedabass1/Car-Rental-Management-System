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
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.FlowLayoutPanel flpCards;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardTotalCars;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardAvailable;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardRented;
        private Guna.UI2.WinForms.Guna2ShadowPanel cardIncome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalCarsTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTotalCarsValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAvailableTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAvailableValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRentedTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRentedValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIncomeTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblIncomeValue;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlChartCard;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOverview;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHeaderTitle;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// This InitializeComponent replaces the previous vanilla layout with a modern Guna2 UI layout:
        /// - Sidebar (left)
        /// - Header (top, draggable)
        /// - Main content with responsive cards and a chart card.
        /// All controls use Guna.UI2.WinForms where appropriate and follow a modern premium style.
                /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 5000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 7200D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 6800D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 9200D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 11500D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 9800D);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.flpCards = new System.Windows.Forms.FlowLayoutPanel();
            this.cardTotalCars = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTotalCarsTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTotalCarsValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cardAvailable = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblAvailableTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAvailableValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cardRented = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblRentedTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRentedValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cardIncome = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblIncomeTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblIncomeValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlChartCard = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.chartOverview = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.flpCards.SuspendLayout();
            this.cardTotalCars.SuspendLayout();
            this.cardAvailable.SuspendLayout();
            this.cardRented.SuspendLayout();
            this.cardIncome.SuspendLayout();
            this.pnlChartCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOverview)).BeginInit();
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
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Enabled = true;
            this.pnlHeader.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlHeader.Size = new System.Drawing.Size(1462, 72);
            this.pnlHeader.TabIndex = 3;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(24, 20);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(96, 27);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Dashboard";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.pnlMain.Controls.Add(this.flpCards);
            this.pnlMain.Controls.Add(this.pnlChartCard);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 72);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(24);
            this.pnlMain.Size = new System.Drawing.Size(1462, 720);
            this.pnlMain.TabIndex = 4;
            // 
            // flpCards
            // 
            this.flpCards.AutoScroll = true;
            this.flpCards.BackColor = System.Drawing.Color.Transparent;
            this.flpCards.Controls.Add(this.cardTotalCars);
            this.flpCards.Controls.Add(this.cardAvailable);
            this.flpCards.Controls.Add(this.cardRented);
            this.flpCards.Controls.Add(this.cardIncome);
            this.flpCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpCards.Location = new System.Drawing.Point(24, 24);
            this.flpCards.Name = "flpCards";
            this.flpCards.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.flpCards.Size = new System.Drawing.Size(1414, 140);
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
            this.cardTotalCars.ShadowShift = 4;
            this.cardTotalCars.Size = new System.Drawing.Size(270, 110);
            this.cardTotalCars.TabIndex = 1;
            // 
            // lblTotalCarsTitle
            // 
            this.lblTotalCarsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCarsTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblTotalCarsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblTotalCarsTitle.Location = new System.Drawing.Point(18, 14);
            this.lblTotalCarsTitle.Name = "lblTotalCarsTitle";
            this.lblTotalCarsTitle.Size = new System.Drawing.Size(55, 17);
            this.lblTotalCarsTitle.TabIndex = 0;
            this.lblTotalCarsTitle.Text = "Total Cars";
            // 
            // lblTotalCarsValue
            // 
            this.lblTotalCarsValue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCarsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalCarsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(75)))), ((int)(((byte)(164)))));
            this.lblTotalCarsValue.Location = new System.Drawing.Point(18, 36);
            this.lblTotalCarsValue.Name = "lblTotalCarsValue";
            this.lblTotalCarsValue.Size = new System.Drawing.Size(39, 34);
            this.lblTotalCarsValue.TabIndex = 1;
            this.lblTotalCarsValue.Text = "128";
            // 
            // cardAvailable
            // 
            this.cardAvailable.BackColor = System.Drawing.Color.Transparent;
            this.cardAvailable.Controls.Add(this.lblAvailableTitle);
            this.cardAvailable.Controls.Add(this.lblAvailableValue);
            this.cardAvailable.FillColor = System.Drawing.Color.White;
            this.cardAvailable.Location = new System.Drawing.Point(279, 3);
            this.cardAvailable.Name = "cardAvailable";
            this.cardAvailable.Radius = 12;
            this.cardAvailable.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.cardAvailable.ShadowShift = 4;
            this.cardAvailable.Size = new System.Drawing.Size(270, 110);
            this.cardAvailable.TabIndex = 2;
            // 
            // lblAvailableTitle
            // 
            this.lblAvailableTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblAvailableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblAvailableTitle.Location = new System.Drawing.Point(18, 14);
            this.lblAvailableTitle.Name = "lblAvailableTitle";
            this.lblAvailableTitle.Size = new System.Drawing.Size(77, 17);
            this.lblAvailableTitle.TabIndex = 0;
            this.lblAvailableTitle.Text = "Available Cars";
            // 
            // lblAvailableValue
            // 
            this.lblAvailableValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableValue.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblAvailableValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblAvailableValue.Location = new System.Drawing.Point(18, 36);
            this.lblAvailableValue.Name = "lblAvailableValue";
            this.lblAvailableValue.Size = new System.Drawing.Size(30, 34);
            this.lblAvailableValue.TabIndex = 1;
            this.lblAvailableValue.Text = "54";
            // 
            // cardRented
            // 
            this.cardRented.BackColor = System.Drawing.Color.Transparent;
            this.cardRented.Controls.Add(this.lblRentedTitle);
            this.cardRented.Controls.Add(this.lblRentedValue);
            this.cardRented.FillColor = System.Drawing.Color.White;
            this.cardRented.Location = new System.Drawing.Point(555, 3);
            this.cardRented.Name = "cardRented";
            this.cardRented.Radius = 12;
            this.cardRented.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.cardRented.ShadowShift = 4;
            this.cardRented.Size = new System.Drawing.Size(270, 110);
            this.cardRented.TabIndex = 3;
            // 
            // lblRentedTitle
            // 
            this.lblRentedTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRentedTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblRentedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblRentedTitle.Location = new System.Drawing.Point(18, 14);
            this.lblRentedTitle.Name = "lblRentedTitle";
            this.lblRentedTitle.Size = new System.Drawing.Size(68, 17);
            this.lblRentedTitle.TabIndex = 0;
            this.lblRentedTitle.Text = "Rented Now";
            // 
            // lblRentedValue
            // 
            this.lblRentedValue.BackColor = System.Drawing.Color.Transparent;
            this.lblRentedValue.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblRentedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.lblRentedValue.Location = new System.Drawing.Point(18, 36);
            this.lblRentedValue.Name = "lblRentedValue";
            this.lblRentedValue.Size = new System.Drawing.Size(26, 34);
            this.lblRentedValue.TabIndex = 1;
            this.lblRentedValue.Text = "12";
            // 
            // cardIncome
            // 
            this.cardIncome.BackColor = System.Drawing.Color.Transparent;
            this.cardIncome.Controls.Add(this.lblIncomeTitle);
            this.cardIncome.Controls.Add(this.lblIncomeValue);
            this.cardIncome.FillColor = System.Drawing.Color.White;
            this.cardIncome.Location = new System.Drawing.Point(831, 3);
            this.cardIncome.Name = "cardIncome";
            this.cardIncome.Radius = 12;
            this.cardIncome.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.cardIncome.ShadowShift = 4;
            this.cardIncome.Size = new System.Drawing.Size(270, 110);
            this.cardIncome.TabIndex = 4;
            // 
            // lblIncomeTitle
            // 
            this.lblIncomeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeTitle.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.lblIncomeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblIncomeTitle.Location = new System.Drawing.Point(18, 14);
            this.lblIncomeTitle.Name = "lblIncomeTitle";
            this.lblIncomeTitle.Size = new System.Drawing.Size(43, 17);
            this.lblIncomeTitle.TabIndex = 0;
            this.lblIncomeTitle.Text = "Income";
            // 
            // lblIncomeValue
            // 
            this.lblIncomeValue.BackColor = System.Drawing.Color.Transparent;
            this.lblIncomeValue.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblIncomeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.lblIncomeValue.Location = new System.Drawing.Point(18, 36);
            this.lblIncomeValue.Name = "lblIncomeValue";
            this.lblIncomeValue.Size = new System.Drawing.Size(85, 34);
            this.lblIncomeValue.TabIndex = 1;
            this.lblIncomeValue.Text = "$18,940";
            // 
            // pnlChartCard
            // 
            this.pnlChartCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlChartCard.Controls.Add(this.chartOverview);
            this.pnlChartCard.FillColor = System.Drawing.Color.White;
            this.pnlChartCard.Location = new System.Drawing.Point(24, 180);
            this.pnlChartCard.Name = "pnlChartCard";
            this.pnlChartCard.Radius = 12;
            this.pnlChartCard.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.pnlChartCard.ShadowShift = 6;
            this.pnlChartCard.Size = new System.Drawing.Size(1154, 420);
            this.pnlChartCard.TabIndex = 5;
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
            this.chartOverview.Location = new System.Drawing.Point(20, 20);
            this.chartOverview.Name = "chartOverview";
            series1.BorderWidth = 3;
            series1.ChartArea = "MainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            series1.Name = "Revenue";
            dataPoint1.AxisLabel = "Jan";
            dataPoint2.AxisLabel = "Feb";
            dataPoint3.AxisLabel = "Mar";
            dataPoint4.AxisLabel = "Apr";
            dataPoint5.AxisLabel = "May";
            dataPoint6.AxisLabel = "Jun";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series1.Points.Add(dataPoint6);
            this.chartOverview.Series.Add(series1);
            this.chartOverview.Size = new System.Drawing.Size(1114, 380);
            this.chartOverview.TabIndex = 0;
            this.chartOverview.Text = "chartOverview";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1462, 792);
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
            this.cardRented.ResumeLayout(false);
            this.cardRented.PerformLayout();
            this.cardIncome.ResumeLayout(false);
            this.cardIncome.PerformLayout();
            this.pnlChartCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}