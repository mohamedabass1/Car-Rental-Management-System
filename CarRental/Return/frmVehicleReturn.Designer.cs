namespace CarRental.Return
{
    partial class frmVehicleReturn
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
            this.ctrlBookingInfoCardWithFilter1 = new CarRental.Booking.Controls.ctrlBookingInfoCardWithFilter();
            this.gbReturnInfo = new System.Windows.Forms.GroupBox();
            this.llShowReturnDetails = new System.Windows.Forms.LinkLabel();
            this.llShowUpdatedTransactionInfo = new System.Windows.Forms.LinkLabel();
            this.txtFinalCheckNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMileage = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdditionalCharges = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblActualTotalDueAmount = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpActualReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblActualRentalDays = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConsumedMileage = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblReturnID = new System.Windows.Forms.Label();
            this.pbGendor = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbReturnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(910, 47);
            this.lblTitle.TabIndex = 121;
            this.lblTitle.Text = "Vehicle Return";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrlBookingInfoCardWithFilter1
            // 
            this.ctrlBookingInfoCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlBookingInfoCardWithFilter1.FilterEnabled = true;
            this.ctrlBookingInfoCardWithFilter1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ctrlBookingInfoCardWithFilter1.Location = new System.Drawing.Point(6, 59);
            this.ctrlBookingInfoCardWithFilter1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlBookingInfoCardWithFilter1.Name = "ctrlBookingInfoCardWithFilter1";
            this.ctrlBookingInfoCardWithFilter1.Size = new System.Drawing.Size(974, 351);
            this.ctrlBookingInfoCardWithFilter1.TabIndex = 122;
            // 
            // gbReturnInfo
            // 
            this.gbReturnInfo.BackColor = System.Drawing.Color.White;
            this.gbReturnInfo.Controls.Add(this.llShowReturnDetails);
            this.gbReturnInfo.Controls.Add(this.llShowUpdatedTransactionInfo);
            this.gbReturnInfo.Controls.Add(this.txtFinalCheckNotes);
            this.gbReturnInfo.Controls.Add(this.pictureBox10);
            this.gbReturnInfo.Controls.Add(this.label8);
            this.gbReturnInfo.Controls.Add(this.txtMileage);
            this.gbReturnInfo.Controls.Add(this.pictureBox9);
            this.gbReturnInfo.Controls.Add(this.label2);
            this.gbReturnInfo.Controls.Add(this.txtAdditionalCharges);
            this.gbReturnInfo.Controls.Add(this.lblActualTotalDueAmount);
            this.gbReturnInfo.Controls.Add(this.pictureBox4);
            this.gbReturnInfo.Controls.Add(this.label3);
            this.gbReturnInfo.Controls.Add(this.dtpActualReturnDate);
            this.gbReturnInfo.Controls.Add(this.lblActualRentalDays);
            this.gbReturnInfo.Controls.Add(this.pictureBox3);
            this.gbReturnInfo.Controls.Add(this.label7);
            this.gbReturnInfo.Controls.Add(this.pictureBox1);
            this.gbReturnInfo.Controls.Add(this.lblConsumedMileage);
            this.gbReturnInfo.Controls.Add(this.label22);
            this.gbReturnInfo.Controls.Add(this.label5);
            this.gbReturnInfo.Controls.Add(this.lblReturnID);
            this.gbReturnInfo.Controls.Add(this.pbGendor);
            this.gbReturnInfo.Controls.Add(this.pictureBox6);
            this.gbReturnInfo.Controls.Add(this.pictureBox5);
            this.gbReturnInfo.Controls.Add(this.label15);
            this.gbReturnInfo.Controls.Add(this.label6);
            this.gbReturnInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.gbReturnInfo.Location = new System.Drawing.Point(6, 422);
            this.gbReturnInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbReturnInfo.Name = "gbReturnInfo";
            this.gbReturnInfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbReturnInfo.Size = new System.Drawing.Size(974, 269);
            this.gbReturnInfo.TabIndex = 123;
            this.gbReturnInfo.TabStop = false;
            this.gbReturnInfo.Text = "Return Information";
            // 
            // llShowReturnDetails
            // 
            this.llShowReturnDetails.AutoSize = true;
            this.llShowReturnDetails.Enabled = false;
            this.llShowReturnDetails.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowReturnDetails.LinkColor = System.Drawing.Color.Blue;
            this.llShowReturnDetails.Location = new System.Drawing.Point(295, 236);
            this.llShowReturnDetails.Name = "llShowReturnDetails";
            this.llShowReturnDetails.Size = new System.Drawing.Size(173, 23);
            this.llShowReturnDetails.TabIndex = 209;
            this.llShowReturnDetails.TabStop = true;
            this.llShowReturnDetails.Text = "Show Return Details";
            // 
            // llShowUpdatedTransactionInfo
            // 
            this.llShowUpdatedTransactionInfo.AutoSize = true;
            this.llShowUpdatedTransactionInfo.Enabled = false;
            this.llShowUpdatedTransactionInfo.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llShowUpdatedTransactionInfo.LinkColor = System.Drawing.Color.Blue;
            this.llShowUpdatedTransactionInfo.Location = new System.Drawing.Point(18, 236);
            this.llShowUpdatedTransactionInfo.Name = "llShowUpdatedTransactionInfo";
            this.llShowUpdatedTransactionInfo.Size = new System.Drawing.Size(262, 23);
            this.llShowUpdatedTransactionInfo.TabIndex = 208;
            this.llShowUpdatedTransactionInfo.TabStop = true;
            this.llShowUpdatedTransactionInfo.Text = "Show Updated Transaction Info";
            // 
            // txtFinalCheckNotes
            // 
            this.txtFinalCheckNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.txtFinalCheckNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFinalCheckNotes.DefaultText = "";
            this.txtFinalCheckNotes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFinalCheckNotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFinalCheckNotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinalCheckNotes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFinalCheckNotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtFinalCheckNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalCheckNotes.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFinalCheckNotes.ForeColor = System.Drawing.Color.Black;
            this.txtFinalCheckNotes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFinalCheckNotes.Location = new System.Drawing.Point(685, 163);
            this.txtFinalCheckNotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFinalCheckNotes.Name = "txtFinalCheckNotes";
            this.txtFinalCheckNotes.PlaceholderText = "";
            this.txtFinalCheckNotes.SelectedText = "";
            this.txtFinalCheckNotes.Size = new System.Drawing.Size(281, 96);
            this.txtFinalCheckNotes.TabIndex = 161;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::CarRental.Properties.Resources.Notes_32;
            this.pictureBox10.Location = new System.Drawing.Point(645, 165);
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
            this.label8.Location = new System.Drawing.Point(455, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 23);
            this.label8.TabIndex = 159;
            this.label8.Text = "Final Check Notes:";
            // 
            // txtMileage
            // 
            this.txtMileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.txtMileage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMileage.DefaultText = "";
            this.txtMileage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMileage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMileage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMileage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMileage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtMileage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMileage.ForeColor = System.Drawing.Color.Black;
            this.txtMileage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMileage.Location = new System.Drawing.Point(687, 118);
            this.txtMileage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.PlaceholderText = "";
            this.txtMileage.SelectedText = "";
            this.txtMileage.Size = new System.Drawing.Size(281, 32);
            this.txtMileage.TabIndex = 158;
            this.txtMileage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMileage_KeyPress);
            this.txtMileage.Validating += new System.ComponentModel.CancelEventHandler(this.txtMileage_Validating);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::CarRental.Properties.Resources.Country_32;
            this.pictureBox9.Location = new System.Drawing.Point(647, 120);
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
            this.label2.Location = new System.Drawing.Point(543, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 156;
            this.label2.Text = "Mileage:";
            // 
            // txtAdditionalCharges
            // 
            this.txtAdditionalCharges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.txtAdditionalCharges.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdditionalCharges.DefaultText = "";
            this.txtAdditionalCharges.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdditionalCharges.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdditionalCharges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalCharges.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdditionalCharges.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtAdditionalCharges.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalCharges.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAdditionalCharges.ForeColor = System.Drawing.Color.Black;
            this.txtAdditionalCharges.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdditionalCharges.Location = new System.Drawing.Point(687, 77);
            this.txtAdditionalCharges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdditionalCharges.Name = "txtAdditionalCharges";
            this.txtAdditionalCharges.PlaceholderText = "";
            this.txtAdditionalCharges.SelectedText = "";
            this.txtAdditionalCharges.Size = new System.Drawing.Size(281, 31);
            this.txtAdditionalCharges.TabIndex = 155;
            this.txtAdditionalCharges.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdditionalCharges_KeyPress);
            this.txtAdditionalCharges.Validating += new System.ComponentModel.CancelEventHandler(this.txtAdditionalCharges_Validating);
            // 
            // lblActualTotalDueAmount
            // 
            this.lblActualTotalDueAmount.AutoSize = true;
            this.lblActualTotalDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualTotalDueAmount.Location = new System.Drawing.Point(692, 39);
            this.lblActualTotalDueAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualTotalDueAmount.Name = "lblActualTotalDueAmount";
            this.lblActualTotalDueAmount.Size = new System.Drawing.Size(53, 20);
            this.lblActualTotalDueAmount.TabIndex = 154;
            this.lblActualTotalDueAmount.Text = "[????]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CarRental.Properties.Resources.money_32;
            this.pictureBox4.Location = new System.Drawing.Point(651, 35);
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
            this.label3.Location = new System.Drawing.Point(400, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 23);
            this.label3.TabIndex = 152;
            this.label3.Text = "Actual Total Due Amount:";
            // 
            // dtpActualReturnDate
            // 
            this.dtpActualReturnDate.BorderRadius = 10;
            this.dtpActualReturnDate.Checked = true;
            this.dtpActualReturnDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(200)))));
            this.dtpActualReturnDate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtpActualReturnDate.ForeColor = System.Drawing.Color.White;
            this.dtpActualReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpActualReturnDate.Location = new System.Drawing.Point(248, 159);
            this.dtpActualReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpActualReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpActualReturnDate.Name = "dtpActualReturnDate";
            this.dtpActualReturnDate.Size = new System.Drawing.Size(144, 36);
            this.dtpActualReturnDate.TabIndex = 150;
            this.dtpActualReturnDate.Value = new System.DateTime(2026, 4, 27, 0, 58, 7, 931);
            // 
            // lblActualRentalDays
            // 
            this.lblActualRentalDays.AutoSize = true;
            this.lblActualRentalDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualRentalDays.Location = new System.Drawing.Point(244, 77);
            this.lblActualRentalDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActualRentalDays.Name = "lblActualRentalDays";
            this.lblActualRentalDays.Size = new System.Drawing.Size(53, 20);
            this.lblActualRentalDays.TabIndex = 142;
            this.lblActualRentalDays.Text = "[????]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarRental.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(204, 71);
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
            this.label7.Location = new System.Drawing.Point(7, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 23);
            this.label7.TabIndex = 140;
            this.label7.Text = "Actual Rental Days:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarRental.Properties.Resources.id;
            this.pictureBox1.Location = new System.Drawing.Point(205, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // lblConsumedMileage
            // 
            this.lblConsumedMileage.AutoSize = true;
            this.lblConsumedMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumedMileage.Location = new System.Drawing.Point(244, 117);
            this.lblConsumedMileage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsumedMileage.Name = "lblConsumedMileage";
            this.lblConsumedMileage.Size = new System.Drawing.Size(53, 20);
            this.lblConsumedMileage.TabIndex = 135;
            this.lblConsumedMileage.Text = "[????]";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(7, 31);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 23);
            this.label22.TabIndex = 113;
            this.label22.Text = "Return ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 23);
            this.label5.TabIndex = 129;
            this.label5.Text = "Consumed Mileage:";
            // 
            // lblReturnID
            // 
            this.lblReturnID.AutoSize = true;
            this.lblReturnID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnID.Location = new System.Drawing.Point(244, 35);
            this.lblReturnID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnID.Name = "lblReturnID";
            this.lblReturnID.Size = new System.Drawing.Size(53, 20);
            this.lblReturnID.TabIndex = 127;
            this.lblReturnID.Text = "[????]";
            // 
            // pbGendor
            // 
            this.pbGendor.Image = global::CarRental.Properties.Resources.Number_32;
            this.pbGendor.Location = new System.Drawing.Point(205, 114);
            this.pbGendor.Name = "pbGendor";
            this.pbGendor.Size = new System.Drawing.Size(33, 29);
            this.pbGendor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGendor.TabIndex = 130;
            this.pbGendor.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::CarRental.Properties.Resources.Country_32;
            this.pictureBox6.Location = new System.Drawing.Point(647, 79);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(33, 29);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 125;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::CarRental.Properties.Resources.Calendar_32;
            this.pictureBox5.Location = new System.Drawing.Point(205, 163);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 124;
            this.pictureBox5.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(440, 77);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 23);
            this.label15.TabIndex = 120;
            this.label15.Text = "Additional Charges:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(7, 163);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 23);
            this.label6.TabIndex = 118;
            this.label6.Text = "Actual Return Date:";
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
            this.btnClose.Location = new System.Drawing.Point(657, 698);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 40);
            this.btnClose.TabIndex = 207;
            this.btnClose.Text = "Close";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnReturn.Enabled = false;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Image = global::CarRental.Properties.Resources.Save_32;
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(811, 698);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 40);
            this.btnReturn.TabIndex = 206;
            this.btnReturn.Text = "Booking";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmVehicleReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(989, 748);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gbReturnInfo);
            this.Controls.Add(this.ctrlBookingInfoCardWithFilter1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVehicleReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Return";
            this.gbReturnInfo.ResumeLayout(false);
            this.gbReturnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Booking.Controls.ctrlBookingInfoCardWithFilter ctrlBookingInfoCardWithFilter1;
        private System.Windows.Forms.GroupBox gbReturnInfo;
        private Guna.UI2.WinForms.Guna2TextBox txtFinalCheckNotes;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtMileage;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtAdditionalCharges;
        private System.Windows.Forms.Label lblActualTotalDueAmount;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpActualReturnDate;
        private System.Windows.Forms.Label lblActualRentalDays;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConsumedMileage;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblReturnID;
        private System.Windows.Forms.PictureBox pbGendor;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel llShowUpdatedTransactionInfo;
        private System.Windows.Forms.LinkLabel llShowReturnDetails;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}