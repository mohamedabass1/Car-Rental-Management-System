namespace CarRentalSystem.Presentation.Booking.Controls
{
    partial class ctrlBookingInfoCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnFindBooking = new Guna.UI2.WinForms.Guna2Button();
            this.txtBookingID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.ctrlBookingInfoCard1 = new CarRentalSystem.Presentation.Booking.ctrlBookingInfoCard();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnFindBooking);
            this.gbFilter.Controls.Add(this.txtBookingID);
            this.gbFilter.Controls.Add(this.label22);
            this.gbFilter.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.gbFilter.Location = new System.Drawing.Point(3, -3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(968, 77);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnFindBooking
            // 
            this.btnFindBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnFindBooking.BorderThickness = 1;
            this.btnFindBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindBooking.FillColor = System.Drawing.Color.Transparent;
            this.btnFindBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindBooking.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindBooking.Image = global::CarRentalSystem.Presentation.Properties.Resources.search_car48;
            this.btnFindBooking.ImageSize = new System.Drawing.Size(36, 36);
            this.btnFindBooking.Location = new System.Drawing.Point(580, 23);
            this.btnFindBooking.Name = "btnFindBooking";
            this.btnFindBooking.Size = new System.Drawing.Size(56, 43);
            this.btnFindBooking.TabIndex = 115;
            this.btnFindBooking.Click += new System.EventHandler(this.btnFindBooking_Click);
            // 
            // txtBookingID
            // 
            this.txtBookingID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.txtBookingID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingID.DefaultText = "";
            this.txtBookingID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookingID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookingID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookingID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtBookingID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingID.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtBookingID.ForeColor = System.Drawing.Color.Black;
            this.txtBookingID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookingID.Location = new System.Drawing.Point(236, 23);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.PlaceholderText = "";
            this.txtBookingID.SelectedText = "";
            this.txtBookingID.Size = new System.Drawing.Size(295, 43);
            this.txtBookingID.TabIndex = 0;
            this.txtBookingID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookingID_KeyPress);
            this.txtBookingID.Validating += new System.ComponentModel.CancelEventHandler(this.txtBookingID_Validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(97, 31);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(118, 23);
            this.label22.TabIndex = 114;
            this.label22.Text = "Booking ID :";
            // 
            // ctrlBookingInfoCard1
            // 
            this.ctrlBookingInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlBookingInfoCard1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ctrlBookingInfoCard1.Location = new System.Drawing.Point(2, 74);
            this.ctrlBookingInfoCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlBookingInfoCard1.Name = "ctrlBookingInfoCard1";
            this.ctrlBookingInfoCard1.Size = new System.Drawing.Size(974, 277);
            this.ctrlBookingInfoCard1.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlBookingInfoCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlBookingInfoCard1);
            this.Controls.Add(this.gbFilter);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctrlBookingInfoCardWithFilter";
            this.Size = new System.Drawing.Size(974, 351);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private Guna.UI2.WinForms.Guna2Button btnFindBooking;
        private Guna.UI2.WinForms.Guna2TextBox txtBookingID;
        private System.Windows.Forms.Label label22;
        private ctrlBookingInfoCard ctrlBookingInfoCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
