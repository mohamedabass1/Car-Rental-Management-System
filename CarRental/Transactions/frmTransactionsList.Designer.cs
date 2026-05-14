namespace CarRental.Transactions
{
    partial class frmTransactionsList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTransactionsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsRentalTransactions = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showBookingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showTransactionDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVehicleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showReturnDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsList)).BeginInit();
            this.cmsRentalTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFilterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Location = new System.Drawing.Point(343, 278);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PlaceholderText = "";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(238, 36);
            this.txtFilterValue.TabIndex = 104;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 103;
            this.label1.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Transaction ID",
            "Customer ID",
            "Customer Name",
            "Booking ID",
            "Return ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(122, 278);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(202, 36);
            this.cbFilterBy.TabIndex = 102;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRecordsCount.Location = new System.Drawing.Point(141, 709);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(24, 21);
            this.lblRecordsCount.TabIndex = 100;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 709);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 99;
            this.label2.Text = "# Records:";
            // 
            // dgvTransactionsList
            // 
            this.dgvTransactionsList.AllowUserToAddRows = false;
            this.dgvTransactionsList.AllowUserToDeleteRows = false;
            this.dgvTransactionsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvTransactionsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactionsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactionsList.ColumnHeadersHeight = 42;
            this.dgvTransactionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTransactionsList.ContextMenuStrip = this.cmsRentalTransactions;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactionsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransactionsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactionsList.Location = new System.Drawing.Point(26, 329);
            this.dgvTransactionsList.Name = "dgvTransactionsList";
            this.dgvTransactionsList.ReadOnly = true;
            this.dgvTransactionsList.RowHeadersVisible = false;
            this.dgvTransactionsList.RowTemplate.Height = 36;
            this.dgvTransactionsList.Size = new System.Drawing.Size(1426, 365);
            this.dgvTransactionsList.TabIndex = 97;
            this.dgvTransactionsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactionsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTransactionsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTransactionsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTransactionsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTransactionsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactionsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactionsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.dgvTransactionsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransactionsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dgvTransactionsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTransactionsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTransactionsList.ThemeStyle.HeaderStyle.Height = 42;
            this.dgvTransactionsList.ThemeStyle.ReadOnly = true;
            this.dgvTransactionsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactionsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransactionsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvTransactionsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.dgvTransactionsList.ThemeStyle.RowsStyle.Height = 36;
            this.dgvTransactionsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactionsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsRentalTransactions
            // 
            this.cmsRentalTransactions.AutoSize = false;
            this.cmsRentalTransactions.DropShadowEnabled = false;
            this.cmsRentalTransactions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmsRentalTransactions.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.cmsRentalTransactions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBookingDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showCustomerDetailsToolStripMenuItem,
            this.toolStripSeparator3,
            this.showTransactionDetailsToolStripMenuItem,
            this.showVehicleDetailsToolStripMenuItem,
            this.showReturnDetailsToolStripMenuItem});
            this.cmsRentalTransactions.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.cmsRentalTransactions.Name = "guna2ContextMenuStrip1";
            this.cmsRentalTransactions.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsRentalTransactions.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cmsRentalTransactions.RenderStyle.ColorTable = null;
            this.cmsRentalTransactions.RenderStyle.RoundedEdges = true;
            this.cmsRentalTransactions.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsRentalTransactions.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.cmsRentalTransactions.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsRentalTransactions.RenderStyle.SeparatorColor = System.Drawing.Color.Gray;
            this.cmsRentalTransactions.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.cmsRentalTransactions.Size = new System.Drawing.Size(280, 178);
            // 
            // showBookingDetailsToolStripMenuItem
            // 
            this.showBookingDetailsToolStripMenuItem.Image = global::CarRental.Properties.Resources.edit_321;
            this.showBookingDetailsToolStripMenuItem.Name = "showBookingDetailsToolStripMenuItem";
            this.showBookingDetailsToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.showBookingDetailsToolStripMenuItem.Text = "Show Booking Details";
            this.showBookingDetailsToolStripMenuItem.Click += new System.EventHandler(this.showBookingDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(276, 6);
            // 
            // showCustomerDetailsToolStripMenuItem
            // 
            this.showCustomerDetailsToolStripMenuItem.Image = global::CarRental.Properties.Resources.PersonDetails_32;
            this.showCustomerDetailsToolStripMenuItem.Name = "showCustomerDetailsToolStripMenuItem";
            this.showCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.showCustomerDetailsToolStripMenuItem.Text = "Show Customer Details";
            this.showCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.showCustomerDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(276, 6);
            // 
            // showTransactionDetailsToolStripMenuItem
            // 
            this.showTransactionDetailsToolStripMenuItem.Image = global::CarRental.Properties.Resources.Notes_32;
            this.showTransactionDetailsToolStripMenuItem.Name = "showTransactionDetailsToolStripMenuItem";
            this.showTransactionDetailsToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.showTransactionDetailsToolStripMenuItem.Text = "Show Transaction Details";
            this.showTransactionDetailsToolStripMenuItem.Click += new System.EventHandler(this.showTransactionDetailsToolStripMenuItem_Click);
            // 
            // showVehicleDetailsToolStripMenuItem
            // 
            this.showVehicleDetailsToolStripMenuItem.Name = "showVehicleDetailsToolStripMenuItem";
            this.showVehicleDetailsToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.showVehicleDetailsToolStripMenuItem.Text = "Show Vehicle Details";
            this.showVehicleDetailsToolStripMenuItem.Click += new System.EventHandler(this.showVehicleDetailsToolStripMenuItem_Click);
            // 
            // showReturnDetailsToolStripMenuItem
            // 
            this.showReturnDetailsToolStripMenuItem.Name = "showReturnDetailsToolStripMenuItem";
            this.showReturnDetailsToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.showReturnDetailsToolStripMenuItem.Text = "Show Return Details";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2PictureBox1.Image = global::CarRental.Properties.Resources.transactions;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(620, 61);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(200, 140);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 98;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmTransactionsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1479, 792);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.dgvTransactionsList);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTransactionsList";
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactionsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionsList)).EndInit();
            this.cmsRentalTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransactionsList;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsRentalTransactions;
        private System.Windows.Forms.ToolStripMenuItem showBookingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem showTransactionDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVehicleDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showReturnDetailsToolStripMenuItem;
    }
}