namespace CarRental.Booking
{
    partial class frmShowBookingDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbCustomerInfo = new System.Windows.Forms.TabPage();
            this.ctrlCustomerInfoCard1 = new CarRental.Customers.ctrlCustomerInfoCard();
            this.tbVehicleInfo = new System.Windows.Forms.TabPage();
            this.ctrlVehicleInfoCard1 = new CarRental.Vehicles.Controls.ctrlVehicleInfoCard();
            this.ctrlBookingInfoCard1 = new CarRental.Booking.ctrlBookingInfoCard();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TabControl1.SuspendLayout();
            this.tbCustomerInfo.SuspendLayout();
            this.tbVehicleInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(948, 55);
            this.lblTitle.TabIndex = 121;
            this.lblTitle.Text = "Booking Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tbCustomerInfo);
            this.guna2TabControl1.Controls.Add(this.tbVehicleInfo);
            this.guna2TabControl1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(13, 54);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(973, 482);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 122;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tbCustomerInfo
            // 
            this.tbCustomerInfo.BackColor = System.Drawing.Color.White;
            this.tbCustomerInfo.Controls.Add(this.ctrlCustomerInfoCard1);
            this.tbCustomerInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tbCustomerInfo.Location = new System.Drawing.Point(4, 44);
            this.tbCustomerInfo.Name = "tbCustomerInfo";
            this.tbCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbCustomerInfo.Size = new System.Drawing.Size(965, 434);
            this.tbCustomerInfo.TabIndex = 0;
            this.tbCustomerInfo.Text = "Customer Infomation";
            // 
            // ctrlCustomerInfoCard1
            // 
            this.ctrlCustomerInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlCustomerInfoCard1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ctrlCustomerInfoCard1.Location = new System.Drawing.Point(7, 7);
            this.ctrlCustomerInfoCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCustomerInfoCard1.Name = "ctrlCustomerInfoCard1";
            this.ctrlCustomerInfoCard1.Size = new System.Drawing.Size(932, 426);
            this.ctrlCustomerInfoCard1.TabIndex = 0;
            // 
            // tbVehicleInfo
            // 
            this.tbVehicleInfo.Controls.Add(this.ctrlVehicleInfoCard1);
            this.tbVehicleInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tbVehicleInfo.Location = new System.Drawing.Point(4, 44);
            this.tbVehicleInfo.Name = "tbVehicleInfo";
            this.tbVehicleInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbVehicleInfo.Size = new System.Drawing.Size(965, 434);
            this.tbVehicleInfo.TabIndex = 1;
            this.tbVehicleInfo.Text = "Vehicle Infomation";
            this.tbVehicleInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlVehicleInfoCard1
            // 
            this.ctrlVehicleInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlVehicleInfoCard1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ctrlVehicleInfoCard1.Location = new System.Drawing.Point(26, 23);
            this.ctrlVehicleInfoCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlVehicleInfoCard1.Name = "ctrlVehicleInfoCard1";
            this.ctrlVehicleInfoCard1.Size = new System.Drawing.Size(890, 324);
            this.ctrlVehicleInfoCard1.TabIndex = 0;
            // 
            // ctrlBookingInfoCard1
            // 
            this.ctrlBookingInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlBookingInfoCard1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ctrlBookingInfoCard1.Location = new System.Drawing.Point(12, 544);
            this.ctrlBookingInfoCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlBookingInfoCard1.Name = "ctrlBookingInfoCard1";
            this.ctrlBookingInfoCard1.Size = new System.Drawing.Size(974, 277);
            this.ctrlBookingInfoCard1.TabIndex = 123;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BorderRadius = 8;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(200)))));
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::CarRental.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.Location = new System.Drawing.Point(822, 819);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 44);
            this.btnClose.TabIndex = 205;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowBookingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1011, 866);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlBookingInfoCard1);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmShowBookingDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Details";
            this.Load += new System.EventHandler(this.frmShowBookingDetails_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tbCustomerInfo.ResumeLayout(false);
            this.tbVehicleInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tbCustomerInfo;
        private System.Windows.Forms.TabPage tbVehicleInfo;
        private Customers.ctrlCustomerInfoCard ctrlCustomerInfoCard1;
        private Vehicles.Controls.ctrlVehicleInfoCard ctrlVehicleInfoCard1;
        private ctrlBookingInfoCard ctrlBookingInfoCard1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}