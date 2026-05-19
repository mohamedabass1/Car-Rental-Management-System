namespace CarRentalSystem.Presentation.Booking
{
    partial class frmAddNewBooking
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tbCustomerInfo = new System.Windows.Forms.TabPage();
            this.ctrlCustomerInfoCardWithFilter1 = new CarRentalSystem.Presentation.Customers.Controls.ctrlCustomerInfoCardWithFilter();
            this.tbVehicleInfo = new System.Windows.Forms.TabPage();
            this.ctrlVehicleInfoCardWithFilter1 = new CarRentalSystem.Presentation.Vehicles.Controls.ctrlVehicleInfoCardWithFilter();
            this.gbBookingInfo = new System.Windows.Forms.GroupBox();
            this.txtPaymentDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInitalCheckNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDropOfLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPickupLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInitalTotalDueAmount = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpStartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblInitalRentalDays = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRntalPricePerDay = new System.Windows.Forms.Label();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.pbGendor = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.llShowTransactionInfo = new System.Windows.Forms.LinkLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.guna2TabControl1.SuspendLayout();
            this.tbCustomerInfo.SuspendLayout();
            this.tbVehicleInfo.SuspendLayout();
            this.gbBookingInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(54, -5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(948, 47);
            this.lblTitle.TabIndex = 120;
            this.lblTitle.Text = "Vehicle Booking";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tbCustomerInfo);
            this.guna2TabControl1.Controls.Add(this.tbVehicleInfo);
            this.guna2TabControl1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(22, 44);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(1000, 576);
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
            this.guna2TabControl1.TabIndex = 121;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.guna2TabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.guna2TabControl1_Selecting);
            // 
            // tbCustomerInfo
            // 
            this.tbCustomerInfo.BackColor = System.Drawing.Color.White;
            this.tbCustomerInfo.Controls.Add(this.ctrlCustomerInfoCardWithFilter1);
            this.tbCustomerInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tbCustomerInfo.Location = new System.Drawing.Point(4, 44);
            this.tbCustomerInfo.Name = "tbCustomerInfo";
            this.tbCustomerInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbCustomerInfo.Size = new System.Drawing.Size(992, 528);
            this.tbCustomerInfo.TabIndex = 0;
            this.tbCustomerInfo.Text = "Customer Infomation";
            // 
            // ctrlCustomerInfoCardWithFilter1
            // 
            this.ctrlCustomerInfoCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlCustomerInfoCardWithFilter1.FilterEnabled = true;
            this.ctrlCustomerInfoCardWithFilter1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ctrlCustomerInfoCardWithFilter1.Location = new System.Drawing.Point(14, 5);
            this.ctrlCustomerInfoCardWithFilter1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlCustomerInfoCardWithFilter1.Name = "ctrlCustomerInfoCardWithFilter1";
            this.ctrlCustomerInfoCardWithFilter1.Size = new System.Drawing.Size(933, 499);
            this.ctrlCustomerInfoCardWithFilter1.TabIndex = 0;
            this.ctrlCustomerInfoCardWithFilter1.OnCustomerSelected += new System.Action<int>(this.ctrlCustomerInfoCardWithFilter1_OnCustomerSelected);
            // 
            // tbVehicleInfo
            // 
            this.tbVehicleInfo.Controls.Add(this.ctrlVehicleInfoCardWithFilter1);
            this.tbVehicleInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tbVehicleInfo.Location = new System.Drawing.Point(4, 44);
            this.tbVehicleInfo.Name = "tbVehicleInfo";
            this.tbVehicleInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbVehicleInfo.Size = new System.Drawing.Size(992, 528);
            this.tbVehicleInfo.TabIndex = 1;
            this.tbVehicleInfo.Text = "Vehicle Infomation";
            this.tbVehicleInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlVehicleInfoCardWithFilter1
            // 
            this.ctrlVehicleInfoCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlVehicleInfoCardWithFilter1.FilterEnabled = true;
            this.ctrlVehicleInfoCardWithFilter1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ctrlVehicleInfoCardWithFilter1.Location = new System.Drawing.Point(27, 33);
            this.ctrlVehicleInfoCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlVehicleInfoCardWithFilter1.Name = "ctrlVehicleInfoCardWithFilter1";
            this.ctrlVehicleInfoCardWithFilter1.Size = new System.Drawing.Size(911, 433);
            this.ctrlVehicleInfoCardWithFilter1.TabIndex = 0;
            this.ctrlVehicleInfoCardWithFilter1.OnVehicleSelected += new System.Action<int>(this.ctrlVehicleInfoCardWithFilter1_OnVehicleSelected);
            // 
            // gbBookingInfo
            // 
            this.gbBookingInfo.BackColor = System.Drawing.Color.White;
            this.gbBookingInfo.Controls.Add(this.txtPaymentDetails);
            this.gbBookingInfo.Controls.Add(this.pictureBox11);
            this.gbBookingInfo.Controls.Add(this.label9);
            this.gbBookingInfo.Controls.Add(this.txtInitalCheckNotes);
            this.gbBookingInfo.Controls.Add(this.pictureBox10);
            this.gbBookingInfo.Controls.Add(this.label8);
            this.gbBookingInfo.Controls.Add(this.txtDropOfLocation);
            this.gbBookingInfo.Controls.Add(this.pictureBox9);
            this.gbBookingInfo.Controls.Add(this.label2);
            this.gbBookingInfo.Controls.Add(this.txtPickupLocation);
            this.gbBookingInfo.Controls.Add(this.lblInitalTotalDueAmount);
            this.gbBookingInfo.Controls.Add(this.pictureBox4);
            this.gbBookingInfo.Controls.Add(this.label3);
            this.gbBookingInfo.Controls.Add(this.dtpEndDate);
            this.gbBookingInfo.Controls.Add(this.dtpStartDate);
            this.gbBookingInfo.Controls.Add(this.lblInitalRentalDays);
            this.gbBookingInfo.Controls.Add(this.pictureBox3);
            this.gbBookingInfo.Controls.Add(this.label7);
            this.gbBookingInfo.Controls.Add(this.pictureBox1);
            this.gbBookingInfo.Controls.Add(this.lblRntalPricePerDay);
            this.gbBookingInfo.Controls.Add(this.lblVehicleID);
            this.gbBookingInfo.Controls.Add(this.lblCustomerID);
            this.gbBookingInfo.Controls.Add(this.label22);
            this.gbBookingInfo.Controls.Add(this.label5);
            this.gbBookingInfo.Controls.Add(this.lblBookingID);
            this.gbBookingInfo.Controls.Add(this.pbGendor);
            this.gbBookingInfo.Controls.Add(this.pictureBox8);
            this.gbBookingInfo.Controls.Add(this.pictureBox7);
            this.gbBookingInfo.Controls.Add(this.pictureBox6);
            this.gbBookingInfo.Controls.Add(this.pictureBox5);
            this.gbBookingInfo.Controls.Add(this.pictureBox2);
            this.gbBookingInfo.Controls.Add(this.label15);
            this.gbBookingInfo.Controls.Add(this.label12);
            this.gbBookingInfo.Controls.Add(this.label6);
            this.gbBookingInfo.Controls.Add(this.label4);
            this.gbBookingInfo.Controls.Add(this.label1);
            this.gbBookingInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gbBookingInfo.Location = new System.Drawing.Point(26, 628);
            this.gbBookingInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBookingInfo.Name = "gbBookingInfo";
            this.gbBookingInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBookingInfo.Size = new System.Drawing.Size(996, 269);
            this.gbBookingInfo.TabIndex = 122;
            this.gbBookingInfo.TabStop = false;
            this.gbBookingInfo.Text = "Booking Information";
            // 
            // txtPaymentDetails
            // 
            this.txtPaymentDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.txtPaymentDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaymentDetails.DefaultText = "";
            this.txtPaymentDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaymentDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaymentDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaymentDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaymentDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtPaymentDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPaymentDetails.ForeColor = System.Drawing.Color.Black;
            this.txtPaymentDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaymentDetails.Location = new System.Drawing.Point(727, 225);
            this.txtPaymentDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPaymentDetails.Name = "txtPaymentDetails";
            this.txtPaymentDetails.PlaceholderText = "";
            this.txtPaymentDetails.SelectedText = "";
            this.txtPaymentDetails.Size = new System.Drawing.Size(249, 32);
            this.txtPaymentDetails.TabIndex = 164;
            this.txtPaymentDetails.Validating += new System.ComponentModel.CancelEventHandler(this.txtPickupLocation_Validating);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::CarRentalSystem.Presentation.Properties.Resources.Notes_32;
            this.pictureBox11.Location = new System.Drawing.Point(687, 227);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(33, 29);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 163;
            this.pictureBox11.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(497, 227);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 23);
            this.label9.TabIndex = 162;
            this.label9.Text = "Payment Details:";
            // 
            // txtInitalCheckNotes
            // 
            this.txtInitalCheckNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.txtInitalCheckNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInitalCheckNotes.DefaultText = "";
            this.txtInitalCheckNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtInitalCheckNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtInitalCheckNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitalCheckNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtInitalCheckNotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtInitalCheckNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitalCheckNotes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtInitalCheckNotes.ForeColor = System.Drawing.Color.Black;
            this.txtInitalCheckNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtInitalCheckNotes.Location = new System.Drawing.Point(727, 183);
            this.txtInitalCheckNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInitalCheckNotes.Name = "txtInitalCheckNotes";
            this.txtInitalCheckNotes.PlaceholderText = "";
            this.txtInitalCheckNotes.SelectedText = "";
            this.txtInitalCheckNotes.Size = new System.Drawing.Size(249, 32);
            this.txtInitalCheckNotes.TabIndex = 161;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::CarRentalSystem.Presentation.Properties.Resources.Notes_32;
            this.pictureBox10.Location = new System.Drawing.Point(687, 185);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(33, 29);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 160;
            this.pictureBox10.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(497, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 23);
            this.label8.TabIndex = 159;
            this.label8.Text = "Inital Check Notes:";
            // 
            // txtDropOfLocation
            // 
            this.txtDropOfLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.txtDropOfLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDropOfLocation.DefaultText = "";
            this.txtDropOfLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDropOfLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDropOfLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDropOfLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDropOfLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtDropOfLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDropOfLocation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDropOfLocation.ForeColor = System.Drawing.Color.Black;
            this.txtDropOfLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDropOfLocation.Location = new System.Drawing.Point(727, 141);
            this.txtDropOfLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDropOfLocation.Name = "txtDropOfLocation";
            this.txtDropOfLocation.PlaceholderText = "";
            this.txtDropOfLocation.SelectedText = "";
            this.txtDropOfLocation.Size = new System.Drawing.Size(249, 32);
            this.txtDropOfLocation.TabIndex = 158;
            this.txtDropOfLocation.Validating += new System.ComponentModel.CancelEventHandler(this.txtPickupLocation_Validating);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::CarRentalSystem.Presentation.Properties.Resources.Country_32;
            this.pictureBox9.Location = new System.Drawing.Point(687, 143);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(33, 29);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 157;
            this.pictureBox9.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(511, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 23);
            this.label2.TabIndex = 156;
            this.label2.Text = "Drop Of Location:";
            // 
            // txtPickupLocation
            // 
            this.txtPickupLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.txtPickupLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPickupLocation.DefaultText = "";
            this.txtPickupLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPickupLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPickupLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPickupLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPickupLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtPickupLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPickupLocation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPickupLocation.ForeColor = System.Drawing.Color.Black;
            this.txtPickupLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPickupLocation.Location = new System.Drawing.Point(727, 97);
            this.txtPickupLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPickupLocation.Name = "txtPickupLocation";
            this.txtPickupLocation.PlaceholderText = "";
            this.txtPickupLocation.SelectedText = "";
            this.txtPickupLocation.Size = new System.Drawing.Size(249, 31);
            this.txtPickupLocation.TabIndex = 155;
            this.txtPickupLocation.Validating += new System.ComponentModel.CancelEventHandler(this.txtPickupLocation_Validating);
            // 
            // lblInitalTotalDueAmount
            // 
            this.lblInitalTotalDueAmount.AutoSize = true;
            this.lblInitalTotalDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitalTotalDueAmount.Location = new System.Drawing.Point(729, 65);
            this.lblInitalTotalDueAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitalTotalDueAmount.Name = "lblInitalTotalDueAmount";
            this.lblInitalTotalDueAmount.Size = new System.Drawing.Size(53, 20);
            this.lblInitalTotalDueAmount.TabIndex = 154;
            this.lblInitalTotalDueAmount.Text = "[????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRentalSystem.Presentation.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(688, 61);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 153;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(453, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 23);
            this.label3.TabIndex = 152;
            this.label3.Text = "Inital Total Due Amount:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BorderRadius = 10;
            this.dtpEndDate.Checked = true;
            this.dtpEndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(200)))));
            this.dtpEndDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpEndDate.ForeColor = System.Drawing.Color.White;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(180, 187);
            this.dtpEndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(144, 36);
            this.dtpEndDate.TabIndex = 151;
            this.dtpEndDate.Value = new System.DateTime(2026, 4, 27, 0, 58, 7, 931);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BorderRadius = 10;
            this.dtpStartDate.Checked = true;
            this.dtpStartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(200)))));
            this.dtpStartDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpStartDate.ForeColor = System.Drawing.Color.White;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(180, 142);
            this.dtpStartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(144, 36);
            this.dtpStartDate.TabIndex = 150;
            this.dtpStartDate.Value = new System.DateTime(2026, 4, 27, 0, 58, 7, 931);
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // lblInitalRentalDays
            // 
            this.lblInitalRentalDays.AutoSize = true;
            this.lblInitalRentalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitalRentalDays.Location = new System.Drawing.Point(232, 232);
            this.lblInitalRentalDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInitalRentalDays.Name = "lblInitalRentalDays";
            this.lblInitalRentalDays.Size = new System.Drawing.Size(53, 20);
            this.lblInitalRentalDays.TabIndex = 142;
            this.lblInitalRentalDays.Text = "[????]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRentalSystem.Presentation.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(193, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 141;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 23);
            this.label7.TabIndex = 140;
            this.label7.Text = "Inital Rental Days:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRentalSystem.Presentation.Properties.Resources.id;
            this.pictureBox1.Location = new System.Drawing.Point(137, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // lblRntalPricePerDay
            // 
            this.lblRntalPricePerDay.AutoSize = true;
            this.lblRntalPricePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRntalPricePerDay.Location = new System.Drawing.Point(729, 30);
            this.lblRntalPricePerDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRntalPricePerDay.Name = "lblRntalPricePerDay";
            this.lblRntalPricePerDay.Size = new System.Drawing.Size(53, 20);
            this.lblRntalPricePerDay.TabIndex = 137;
            this.lblRntalPricePerDay.Text = "[????]";
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleID.Location = new System.Drawing.Point(176, 108);
            this.lblVehicleID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(53, 20);
            this.lblVehicleID.TabIndex = 135;
            this.lblVehicleID.Text = "[????]";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerID.Location = new System.Drawing.Point(176, 69);
            this.lblCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(53, 20);
            this.lblCustomerID.TabIndex = 131;
            this.lblCustomerID.Text = "[????]";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(14, 33);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 23);
            this.label22.TabIndex = 113;
            this.label22.Text = "Booking ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(16, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 129;
            this.label5.Text = "Vehicle ID:";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.Location = new System.Drawing.Point(176, 33);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(53, 20);
            this.lblBookingID.TabIndex = 127;
            this.lblBookingID.Text = "[????]";
            // 
            // pbGendor
            // 
            this.pbGendor.Image = global::CarRentalSystem.Presentation.Properties.Resources.id;
            this.pbGendor.Location = new System.Drawing.Point(137, 105);
            this.pbGendor.Name = "pbGendor";
            this.pbGendor.Size = new System.Drawing.Size(33, 29);
            this.pbGendor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGendor.TabIndex = 130;
            this.pbGendor.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::CarRentalSystem.Presentation.Properties.Resources.id;
            this.pictureBox8.Location = new System.Drawing.Point(137, 66);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(33, 29);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 128;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::CarRentalSystem.Presentation.Properties.Resources.Calendar_32;
            this.pictureBox7.Location = new System.Drawing.Point(137, 187);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 29);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 126;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CarRentalSystem.Presentation.Properties.Resources.Country_32;
            this.pictureBox6.Location = new System.Drawing.Point(687, 99);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 29);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 125;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CarRentalSystem.Presentation.Properties.Resources.Calendar_32;
            this.pictureBox5.Location = new System.Drawing.Point(137, 146);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 124;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarRentalSystem.Presentation.Properties.Resources.money_32;
            this.pictureBox2.Location = new System.Drawing.Point(688, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 121;
            this.pictureBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(518, 97);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 23);
            this.label15.TabIndex = 120;
            this.label15.Text = "Pickup Location:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(16, 187);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 23);
            this.label12.TabIndex = 119;
            this.label12.Text = "End Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(16, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 118;
            this.label6.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(480, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 23);
            this.label4.TabIndex = 117;
            this.label4.Text = "Rental Price Per Day:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 114;
            this.label1.Text = "Customer ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // llShowTransactionInfo
            // 
            this.llShowTransactionInfo.AutoSize = true;
            this.llShowTransactionInfo.Enabled = false;
            this.llShowTransactionInfo.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.llShowTransactionInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(200)))));
            this.llShowTransactionInfo.Location = new System.Drawing.Point(44, 918);
            this.llShowTransactionInfo.Name = "llShowTransactionInfo";
            this.llShowTransactionInfo.Size = new System.Drawing.Size(200, 22);
            this.llShowTransactionInfo.TabIndex = 206;
            this.llShowTransactionInfo.TabStop = true;
            this.llShowTransactionInfo.Text = "Show Transaction Info";
            this.llShowTransactionInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llShowTransactionInfo_LinkClicked);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(200)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::CarRentalSystem.Presentation.Properties.Resources.Close_32;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button1.Location = new System.Drawing.Point(698, 899);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(126, 40);
            this.guna2Button1.TabIndex = 205;
            this.guna2Button1.Text = "Close";
            this.guna2Button1.Click += new System.EventHandler(this.btnClose);
            // 
            // btnBooking
            // 
            this.btnBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnBooking.Enabled = false;
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnBooking.Image = global::CarRentalSystem.Presentation.Properties.Resources.Save_32;
            this.btnBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooking.Location = new System.Drawing.Point(849, 900);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(161, 40);
            this.btnBooking.TabIndex = 204;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = false;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // frmAddNewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1048, 953);
            this.Controls.Add(this.llShowTransactionInfo);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.gbBookingInfo);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddNewBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Booking";
            this.Load += new System.EventHandler(this.frmAddNewBooking_Load);
            this.guna2TabControl1.ResumeLayout(false);
            this.tbCustomerInfo.ResumeLayout(false);
            this.tbVehicleInfo.ResumeLayout(false);
            this.gbBookingInfo.ResumeLayout(false);
            this.gbBookingInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tbCustomerInfo;
        private System.Windows.Forms.TabPage tbVehicleInfo;
        private Vehicles.Controls.ctrlVehicleInfoCardWithFilter ctrlVehicleInfoCardWithFilter1;
        private System.Windows.Forms.GroupBox gbBookingInfo;
        private System.Windows.Forms.Label lblInitalRentalDays;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRntalPricePerDay;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.PictureBox pbGendor;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblInitalTotalDueAmount;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPickupLocation;
        private Guna.UI2.WinForms.Guna2TextBox txtDropOfLocation;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtInitalCheckNotes;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtPaymentDetails;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel llShowTransactionInfo;
        private Customers.Controls.ctrlCustomerInfoCardWithFilter ctrlCustomerInfoCardWithFilter1;
    }
}