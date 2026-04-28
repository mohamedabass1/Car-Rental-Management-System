namespace CarRental.Customers.Controols
{
    partial class ctrlCustomerInfoCardWithFilter
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
            this.txtCustomerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.ctrlCustomerInfoCard1 = new CarRental.Customers.ctrlCustomerInfoCard();
            this.btnAddNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddNewCustomer);
            this.gbFilter.Controls.Add(this.btnFindCustomer);
            this.gbFilter.Controls.Add(this.txtCustomerID);
            this.gbFilter.Controls.Add(this.label22);
            this.gbFilter.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.gbFilter.Location = new System.Drawing.Point(14, 4);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(906, 88);
            this.gbFilter.TabIndex = 2;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(235)))));
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerID.DefaultText = "";
            this.txtCustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.txtCustomerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtCustomerID.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Location = new System.Drawing.Point(236, 29);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.PlaceholderText = "";
            this.txtCustomerID.SelectedText = "";
            this.txtCustomerID.Size = new System.Drawing.Size(295, 43);
            this.txtCustomerID.TabIndex = 0;
            this.txtCustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerID_KeyPress);
            this.txtCustomerID.Validating += new System.ComponentModel.CancelEventHandler(this.txtCustomerID_Validating);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(97, 37);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 23);
            this.label22.TabIndex = 114;
            this.label22.Text = "Customer ID :";
            // 
            // ctrlCustomerInfoCard1
            // 
            this.ctrlCustomerInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlCustomerInfoCard1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ctrlCustomerInfoCard1.Location = new System.Drawing.Point(1, 92);
            this.ctrlCustomerInfoCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlCustomerInfoCard1.Name = "ctrlCustomerInfoCard1";
            this.ctrlCustomerInfoCard1.Size = new System.Drawing.Size(932, 469);
            this.ctrlCustomerInfoCard1.TabIndex = 0;
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnAddNewCustomer.BorderThickness = 1;
            this.btnAddNewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewCustomer.Image = global::CarRental.Properties.Resources.Add_Person_401;
            this.btnAddNewCustomer.ImageSize = new System.Drawing.Size(36, 36);
            this.btnAddNewCustomer.Location = new System.Drawing.Point(655, 29);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(56, 43);
            this.btnAddNewCustomer.TabIndex = 116;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnFindCustomer.BorderThickness = 1;
            this.btnFindCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnFindCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnFindCustomer.Image = global::CarRental.Properties.Resources.SearchPerson;
            this.btnFindCustomer.ImageSize = new System.Drawing.Size(36, 36);
            this.btnFindCustomer.Location = new System.Drawing.Point(580, 29);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(56, 43);
            this.btnFindCustomer.TabIndex = 115;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CustomerInfoCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.ctrlCustomerInfoCard1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CustomerInfoCardWithFilter";
            this.Size = new System.Drawing.Size(933, 554);
            this.Load += new System.EventHandler(this.CustomerInfoCardWithFilter_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCustomerInfoCard ctrlCustomerInfoCard1;
        private System.Windows.Forms.GroupBox gbFilter;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCustomer;
        private Guna.UI2.WinForms.Guna2Button btnFindCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
