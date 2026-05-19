using System.Drawing;
using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Return
{
    partial class frmManageVehicleReturns
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
            this.cbVehcileReturns = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showReturnDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.showBookingDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCustomerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.showVehicleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvVehcileReturns = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnVehicleReturn = new System.Windows.Forms.Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbVehcileReturns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehcileReturns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVehcileReturns
            // 
            this.cbVehcileReturns.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.cbVehcileReturns.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cbVehcileReturns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showReturnDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.showBookingDetailsToolStripMenuItem,
            this.showCustomerDetailsToolStripMenuItem,
            this.toolStripSeparator3,
            this.showVehicleDetailsToolStripMenuItem});
            this.cbVehcileReturns.Name = "guna2ContextMenuStrip1";
            this.cbVehcileReturns.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cbVehcileReturns.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.cbVehcileReturns.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cbVehcileReturns.RenderStyle.ColorTable = null;
            this.cbVehcileReturns.RenderStyle.RoundedEdges = true;
            this.cbVehcileReturns.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cbVehcileReturns.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cbVehcileReturns.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cbVehcileReturns.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cbVehcileReturns.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cbVehcileReturns.Size = new System.Drawing.Size(220, 174);
            // 
            // showReturnDetailsToolStripMenuItem
            // 
            this.showReturnDetailsToolStripMenuItem.Image = global::CarRentalSystem.Presentation.Properties.Resources.search_car48;
            this.showReturnDetailsToolStripMenuItem.Name = "showReturnDetailsToolStripMenuItem";
            this.showReturnDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.showReturnDetailsToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.showReturnDetailsToolStripMenuItem.Text = "Show Return Details";
            this.showReturnDetailsToolStripMenuItem.Click += new System.EventHandler(this.showReturnDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(216, 6);
            // 
            // showBookingDetailsToolStripMenuItem
            // 
            this.showBookingDetailsToolStripMenuItem.Image = global::CarRentalSystem.Presentation.Properties.Resources.person_details32;
            this.showBookingDetailsToolStripMenuItem.Name = "showBookingDetailsToolStripMenuItem";
            this.showBookingDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.showBookingDetailsToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.showBookingDetailsToolStripMenuItem.Text = "Booking Details";
            this.showBookingDetailsToolStripMenuItem.Click += new System.EventHandler(this.showBookingDetailsToolStripMenuItem_Click);
            // 
            // showCustomerDetailsToolStripMenuItem
            // 
            this.showCustomerDetailsToolStripMenuItem.Image = global::CarRentalSystem.Presentation.Properties.Resources.PersonDetails_32;
            this.showCustomerDetailsToolStripMenuItem.Name = "showCustomerDetailsToolStripMenuItem";
            this.showCustomerDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.showCustomerDetailsToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.showCustomerDetailsToolStripMenuItem.Text = "Customer Details";
            this.showCustomerDetailsToolStripMenuItem.Click += new System.EventHandler(this.showCustomerDetailsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(216, 6);
            // 
            // showVehicleDetailsToolStripMenuItem
            // 
            this.showVehicleDetailsToolStripMenuItem.Image = global::CarRentalSystem.Presentation.Properties.Resources.maintenance_vehicle32;
            this.showVehicleDetailsToolStripMenuItem.Name = "showVehicleDetailsToolStripMenuItem";
            this.showVehicleDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.showVehicleDetailsToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.showVehicleDetailsToolStripMenuItem.Text = "Vehicle Details";
            this.showVehicleDetailsToolStripMenuItem.Click += new System.EventHandler(this.showVehicleDetailsToolStripMenuItem_Click);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblRecordsCount.Location = new System.Drawing.Point(133, 704);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(32, 22);
            this.lblRecordsCount.TabIndex = 141;
            this.lblRecordsCount.Text = "??";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFilterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Location = new System.Drawing.Point(384, 245);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PlaceholderText = "";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(238, 36);
            this.txtFilterValue.TabIndex = 140;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(36, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 139;
            this.label1.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.cbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFilterBy.ItemHeight = 30;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Return ID",
            "Customer ID",
            "Customer Name",
            "Vehicle ID",
            "Booking ID",
            "Transaction ID"});
            this.cbFilterBy.Location = new System.Drawing.Point(127, 245);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(202, 36);
            this.cbFilterBy.TabIndex = 138;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(25, 703);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 136;
            this.label6.Text = "# Records:";
            // 
            // dgvVehcileReturns
            // 
            this.dgvVehcileReturns.AllowUserToAddRows = false;
            this.dgvVehcileReturns.AllowUserToDeleteRows = false;
            this.dgvVehcileReturns.AllowUserToOrderColumns = true;
            this.dgvVehcileReturns.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVehcileReturns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehcileReturns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehcileReturns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehcileReturns.ColumnHeadersHeight = 52;
            this.dgvVehcileReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVehcileReturns.ContextMenuStrip = this.cbVehcileReturns;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehcileReturns.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVehcileReturns.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.dgvVehcileReturns.Location = new System.Drawing.Point(22, 300);
            this.dgvVehcileReturns.Margin = new System.Windows.Forms.Padding(0);
            this.dgvVehcileReturns.MultiSelect = false;
            this.dgvVehcileReturns.Name = "dgvVehcileReturns";
            this.dgvVehcileReturns.ReadOnly = true;
            this.dgvVehcileReturns.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVehcileReturns.RowHeadersVisible = false;
            this.dgvVehcileReturns.RowTemplate.Height = 44;
            this.dgvVehcileReturns.Size = new System.Drawing.Size(1424, 392);
            this.dgvVehcileReturns.TabIndex = 144;
            this.dgvVehcileReturns.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvVehcileReturns.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVehcileReturns.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVehcileReturns.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.dgvVehcileReturns.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVehcileReturns.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVehcileReturns.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(252)))), ((int)(((byte)(231)))));
            this.dgvVehcileReturns.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.dgvVehcileReturns.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVehcileReturns.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dgvVehcileReturns.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVehcileReturns.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVehcileReturns.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvVehcileReturns.ThemeStyle.ReadOnly = true;
            this.dgvVehcileReturns.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVehcileReturns.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVehcileReturns.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dgvVehcileReturns.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.dgvVehcileReturns.ThemeStyle.RowsStyle.Height = 44;
            this.dgvVehcileReturns.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(250)))), ((int)(((byte)(229)))));
            this.dgvVehcileReturns.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnVehicleReturn
            // 
            this.btnVehicleReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVehicleReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnVehicleReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVehicleReturn.FlatAppearance.BorderSize = 0;
            this.btnVehicleReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(120)))), ((int)(((byte)(87)))));
            this.btnVehicleReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnVehicleReturn.Image = global::CarRentalSystem.Presentation.Properties.Resources.add_car40;
            this.btnVehicleReturn.Location = new System.Drawing.Point(1365, 233);
            this.btnVehicleReturn.Margin = new System.Windows.Forms.Padding(0);
            this.btnVehicleReturn.Name = "btnVehicleReturn";
            this.btnVehicleReturn.Size = new System.Drawing.Size(74, 54);
            this.btnVehicleReturn.TabIndex = 137;
            this.btnVehicleReturn.UseVisualStyleBackColor = false;
            this.btnVehicleReturn.Click += new System.EventHandler(this.btnVehicleReturn_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2PictureBox2.Image = global::CarRentalSystem.Presentation.Properties.Resources.Return;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(614, 26);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(253, 167);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 135;
            this.guna2PictureBox2.TabStop = false;
            // 
            // frmManageVehicleReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1463, 753);
            this.Controls.Add(this.dgvVehcileReturns);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.btnVehicleReturn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2PictureBox2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmManageVehicleReturns";
            this.Text = "frmReturn";
            this.Load += new System.EventHandler(this.frmManageVehicleReturns_Load);
            this.cbVehcileReturns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehcileReturns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContextMenuStrip cbVehcileReturns;
        private System.Windows.Forms.ToolStripMenuItem showReturnDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem showBookingDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCustomerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem showVehicleDetailsToolStripMenuItem;
        private System.Windows.Forms.Label lblRecordsCount;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnVehicleReturn;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVehcileReturns;
    }
}