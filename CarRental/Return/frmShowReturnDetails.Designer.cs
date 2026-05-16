namespace CarRental.Return
{
    partial class frmShowReturnDetails
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
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbCustomerInfo = new System.Windows.Forms.TabPage();
            this.tbVehicleInfo = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ctrlReturnInfoCard1 = new CarRental.Return.Controls.ctrlReturnInfoCard();
            this.ctrlVehicleInfoCard1 = new CarRental.Vehicles.Controls.ctrlVehicleInfoCard();
            this.ctrlCustomerInfoCard1 = new CarRental.Customers.ctrlCustomerInfoCard();
            this.guna2TabControl1.SuspendLayout();
            this.tbCustomerInfo.SuspendLayout();
            this.tbVehicleInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.BorderRadius = 10;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.btnClose.Image = global::CarRental.Properties.Resources.close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24;
            this.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(822, 775);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 44);
            this.btnClose.TabIndex = 208;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tbCustomerInfo);
            this.guna2TabControl1.Controls.Add(this.tbVehicleInfo);
            this.guna2TabControl1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 45);
            this.guna2TabControl1.Location = new System.Drawing.Point(12, 43);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(973, 465);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 45);
            this.guna2TabControl1.TabIndex = 207;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tbCustomerInfo
            // 
            this.tbCustomerInfo.BackColor = System.Drawing.Color.White;
            this.tbCustomerInfo.Controls.Add(this.ctrlCustomerInfoCard1);
            this.tbCustomerInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.tbCustomerInfo.Location = new System.Drawing.Point(4, 49);
            this.tbCustomerInfo.Name = "tbCustomerInfo";
            this.tbCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbCustomerInfo.Size = new System.Drawing.Size(965, 412);
            this.tbCustomerInfo.TabIndex = 0;
            this.tbCustomerInfo.Text = "Customer Information";
            // 
            // tbVehicleInfo
            // 
            this.tbVehicleInfo.BackColor = System.Drawing.Color.White;
            this.tbVehicleInfo.Controls.Add(this.ctrlVehicleInfoCard1);
            this.tbVehicleInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.tbVehicleInfo.Location = new System.Drawing.Point(4, 49);
            this.tbVehicleInfo.Name = "tbVehicleInfo";
            this.tbVehicleInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbVehicleInfo.Size = new System.Drawing.Size(965, 429);
            this.tbVehicleInfo.TabIndex = 1;
            this.tbVehicleInfo.Text = "Vehicle Information";
            this.tbVehicleInfo.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.lblTitle.Location = new System.Drawing.Point(16, -10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(969, 55);
            this.lblTitle.TabIndex = 206;
            this.lblTitle.Text = "Return Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlReturnInfoCard1
            // 
            this.ctrlReturnInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlReturnInfoCard1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ctrlReturnInfoCard1.Location = new System.Drawing.Point(12, 516);
            this.ctrlReturnInfoCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlReturnInfoCard1.Name = "ctrlReturnInfoCard1";
            this.ctrlReturnInfoCard1.Size = new System.Drawing.Size(974, 251);
            this.ctrlReturnInfoCard1.TabIndex = 208;
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
            // ctrlCustomerInfoCard1
            // 
            this.ctrlCustomerInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlCustomerInfoCard1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ctrlCustomerInfoCard1.Location = new System.Drawing.Point(8, 8);
            this.ctrlCustomerInfoCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCustomerInfoCard1.Name = "ctrlCustomerInfoCard1";
            this.ctrlCustomerInfoCard1.Size = new System.Drawing.Size(926, 387);
            this.ctrlCustomerInfoCard1.TabIndex = 0;
            // 
            // frmShowReturnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(995, 824);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlReturnInfoCard1);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmShowReturnDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Detalis";
            this.Load += new System.EventHandler(this.frmShowReturnDetails_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tbCustomerInfo.ResumeLayout(false);
            this.tbVehicleInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tbCustomerInfo;
        private System.Windows.Forms.TabPage tbVehicleInfo;
        private Vehicles.Controls.ctrlVehicleInfoCard ctrlVehicleInfoCard1;
        private System.Windows.Forms.Label lblTitle;
        private Controls.ctrlReturnInfoCard ctrlReturnInfoCard1;
        private Customers.ctrlCustomerInfoCard ctrlCustomerInfoCard1;
    }
}