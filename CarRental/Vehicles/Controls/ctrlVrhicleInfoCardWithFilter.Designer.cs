namespace CarRental.Vehicles.Controls
{
    partial class ctrlVrhicleInfoCardWithFilter
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
            this.cbFilter = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.ctrlVehicleInfoCard1 = new CarRental.Vehicles.Controls.ctrlVehicleInfoCard();
            this.txtVehicleID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFindVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.cbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbFilter
            // 
            this.cbFilter.Controls.Add(this.btnAddNewVehicle);
            this.cbFilter.Controls.Add(this.btnFindVehicle);
            this.cbFilter.Controls.Add(this.txtVehicleID);
            this.cbFilter.Controls.Add(this.label22);
            this.cbFilter.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.cbFilter.Location = new System.Drawing.Point(10, 7);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(890, 88);
            this.cbFilter.TabIndex = 1;
            this.cbFilter.TabStop = false;
            this.cbFilter.Text = "Filter";
            this.cbFilter.Enter += new System.EventHandler(this.cbFilter_Enter);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(125, 40);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 23);
            this.label22.TabIndex = 114;
            this.label22.Text = "Vehicle ID :";
            // 
            // ctrlVehicleInfoCard1
            // 
            this.ctrlVehicleInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlVehicleInfoCard1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ctrlVehicleInfoCard1.Location = new System.Drawing.Point(8, 102);
            this.ctrlVehicleInfoCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlVehicleInfoCard1.Name = "ctrlVehicleInfoCard1";
            this.ctrlVehicleInfoCard1.Size = new System.Drawing.Size(890, 324);
            this.ctrlVehicleInfoCard1.TabIndex = 0;
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.txtVehicleID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVehicleID.DefaultText = "";
            this.txtVehicleID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVehicleID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVehicleID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVehicleID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVehicleID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtVehicleID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleID.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtVehicleID.ForeColor = System.Drawing.Color.Black;
            this.txtVehicleID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVehicleID.Location = new System.Drawing.Point(236, 29);
            this.txtVehicleID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.PlaceholderText = "";
            this.txtVehicleID.SelectedText = "";
            this.txtVehicleID.Size = new System.Drawing.Size(295, 43);
            this.txtVehicleID.TabIndex = 2;
            // 
            // btnFindVehicle
            // 
            this.btnFindVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnFindVehicle.BorderThickness = 1;
            this.btnFindVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindVehicle.FillColor = System.Drawing.Color.Transparent;
            this.btnFindVehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindVehicle.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindVehicle.Image = global::CarRental.Properties.Resources.search_car48;
            this.btnFindVehicle.ImageSize = new System.Drawing.Size(36, 36);
            this.btnFindVehicle.Location = new System.Drawing.Point(580, 29);
            this.btnFindVehicle.Name = "btnFindVehicle";
            this.btnFindVehicle.Size = new System.Drawing.Size(56, 43);
            this.btnFindVehicle.TabIndex = 115;
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnAddNewVehicle.BorderThickness = 1;
            this.btnAddNewVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewVehicle.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewVehicle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewVehicle.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewVehicle.Image = global::CarRental.Properties.Resources.add_car40;
            this.btnAddNewVehicle.ImageSize = new System.Drawing.Size(36, 36);
            this.btnAddNewVehicle.Location = new System.Drawing.Point(655, 29);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.Size = new System.Drawing.Size(56, 43);
            this.btnAddNewVehicle.TabIndex = 116;
            // 
            // ctrlVrhicleInfoCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.ctrlVehicleInfoCard1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ctrlVrhicleInfoCardWithFilter";
            this.Size = new System.Drawing.Size(911, 433);
            this.cbFilter.ResumeLayout(false);
            this.cbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlVehicleInfoCard ctrlVehicleInfoCard1;
        private System.Windows.Forms.GroupBox cbFilter;
        private System.Windows.Forms.Label label22;
        private Guna.UI2.WinForms.Guna2TextBox txtVehicleID;
        private Guna.UI2.WinForms.Guna2Button btnFindVehicle;
        private Guna.UI2.WinForms.Guna2Button btnAddNewVehicle;
    }
}
