using System.Drawing;
using System.Windows.Forms;

namespace CarRentalSystem.Presentation.Vehciles
{
    partial class frmListVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListVehicles));
            this.label6 = new System.Windows.Forms.Label();
            this.dgvVehciles = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsVehicles = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.showVehicleDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMaintenanceHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPages = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbVehicleStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnNewMaintenance = new System.Windows.Forms.Button();
            this.btnAddNewVehcile = new System.Windows.Forms.Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehciles)).BeginInit();
            this.cmsVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(24, 730);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 124;
            this.label6.Text = "# Records:";
            // 
            // dgvVehciles
            // 
            this.dgvVehciles.AllowUserToAddRows = false;
            this.dgvVehciles.AllowUserToDeleteRows = false;
            this.dgvVehciles.AllowUserToOrderColumns = true;
            this.dgvVehciles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVehciles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehciles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehciles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehciles.ColumnHeadersHeight = 52;
            this.dgvVehciles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVehciles.ContextMenuStrip = this.cmsVehicles;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehciles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVehciles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvVehciles.Location = new System.Drawing.Point(27, 328);
            this.dgvVehciles.Margin = new System.Windows.Forms.Padding(0);
            this.dgvVehciles.MultiSelect = false;
            this.dgvVehciles.Name = "dgvVehciles";
            this.dgvVehciles.ReadOnly = true;
            this.dgvVehciles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVehciles.RowHeadersVisible = false;
            this.dgvVehciles.RowTemplate.Height = 44;
            this.dgvVehciles.Size = new System.Drawing.Size(1424, 392);
            this.dgvVehciles.TabIndex = 122;
            this.dgvVehciles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvVehciles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVehciles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVehciles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgvVehciles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVehciles.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVehciles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvVehciles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.dgvVehciles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVehciles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.dgvVehciles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVehciles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVehciles.ThemeStyle.HeaderStyle.Height = 52;
            this.dgvVehciles.ThemeStyle.ReadOnly = true;
            this.dgvVehciles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVehciles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVehciles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dgvVehciles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.dgvVehciles.ThemeStyle.RowsStyle.Height = 44;
            this.dgvVehciles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.dgvVehciles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // cmsVehicles
            // 
            this.cmsVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.cmsVehicles.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsVehicles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showVehicleDetailsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addNewVehicleToolStripMenuItem,
            this.editVehicleToolStripMenuItem,
            this.deleteVehicleToolStripMenuItem,
            this.toolStripSeparator3,
            this.maintenanceToolStripMenuItem,
            this.showMaintenanceHistoryToolStripMenuItem});
            this.cmsVehicles.Name = "guna2ContextMenuStrip1";
            this.cmsVehicles.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.cmsVehicles.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cmsVehicles.RenderStyle.ColorTable = null;
            this.cmsVehicles.RenderStyle.RoundedEdges = true;
            this.cmsVehicles.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsVehicles.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.cmsVehicles.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsVehicles.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cmsVehicles.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.cmsVehicles.Size = new System.Drawing.Size(267, 220);
            // 
            // showVehicleDetailsToolStripMenuItem
            // 
            this.showVehicleDetailsToolStripMenuItem.Image = global::CarRentalSystem.Presentation.Properties.Resources.vehicle_details32;
            this.showVehicleDetailsToolStripMenuItem.Name = "showVehicleDetailsToolStripMenuItem";
            this.showVehicleDetailsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.showVehicleDetailsToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.showVehicleDetailsToolStripMenuItem.Text = "Show Vehicle Details";
            this.showVehicleDetailsToolStripMenuItem.Click += new System.EventHandler(this.showVehicleDetailsToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(263, 6);
            // 
            // addNewVehicleToolStripMenuItem
            // 
            this.addNewVehicleToolStripMenuItem.Image = global::CarRentalSystem.Presentation.Properties.Resources.add_car32;
            this.addNewVehicleToolStripMenuItem.Name = "addNewVehicleToolStripMenuItem";
            this.addNewVehicleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.addNewVehicleToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.addNewVehicleToolStripMenuItem.Text = "Add New Vehicle";
            this.addNewVehicleToolStripMenuItem.Click += new System.EventHandler(this.addNewVehicleToolStripMenuItem_Click);
            // 
            // editVehicleToolStripMenuItem
            // 
            this.editVehicleToolStripMenuItem.Image = global::CarRentalSystem.Presentation.Properties.Resources.car_Edit32;
            this.editVehicleToolStripMenuItem.Name = "editVehicleToolStripMenuItem";
            this.editVehicleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.editVehicleToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.editVehicleToolStripMenuItem.Text = "Edit Vehicle";
            this.editVehicleToolStripMenuItem.Click += new System.EventHandler(this.editVehicleToolStripMenuItem_Click);
            // 
            // deleteVehicleToolStripMenuItem
            // 
            this.deleteVehicleToolStripMenuItem.Image = global::CarRentalSystem.Presentation.Properties.Resources.car_delete32;
            this.deleteVehicleToolStripMenuItem.Name = "deleteVehicleToolStripMenuItem";
            this.deleteVehicleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.deleteVehicleToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.deleteVehicleToolStripMenuItem.Text = "Delete Vehicle";
            this.deleteVehicleToolStripMenuItem.Click += new System.EventHandler(this.deleteVehicleToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(263, 6);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.Image = global::CarRentalSystem.Presentation.Properties.Resources.maintenance_vehicle32;
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            this.maintenanceToolStripMenuItem.Click += new System.EventHandler(this.maintenanceToolStripMenuItem_Click);
            // 
            // showMaintenanceHistoryToolStripMenuItem
            // 
            this.showMaintenanceHistoryToolStripMenuItem.Image = global::CarRentalSystem.Presentation.Properties.Resources.Calendar_321;
            this.showMaintenanceHistoryToolStripMenuItem.Name = "showMaintenanceHistoryToolStripMenuItem";
            this.showMaintenanceHistoryToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.showMaintenanceHistoryToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.showMaintenanceHistoryToolStripMenuItem.Text = "Show Maintenance History";
            this.showMaintenanceHistoryToolStripMenuItem.Click += new System.EventHandler(this.showMaintenanceHistoryToolStripMenuItem_Click);
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
            this.txtFilterValue.Location = new System.Drawing.Point(347, 272);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PlaceholderText = "";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(238, 36);
            this.txtFilterValue.TabIndex = 129;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 128;
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
            "Vehicle ID",
            "Make",
            "Model",
            "Year",
            "Plate Number",
            "Fuel Type",
            "Price",
            "Is Available"});
            this.cbFilterBy.Location = new System.Drawing.Point(126, 272);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(202, 36);
            this.cbFilterBy.TabIndex = 127;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblRecordsCount.Location = new System.Drawing.Point(132, 731);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(32, 22);
            this.lblRecordsCount.TabIndex = 130;
            this.lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(938, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 132;
            this.label2.Text = "Page No:";
            // 
            // cbPages
            // 
            this.cbPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPages.BackColor = System.Drawing.Color.Transparent;
            this.cbPages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPages.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPages.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPages.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbPages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbPages.ItemHeight = 30;
            this.cbPages.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbPages.Location = new System.Drawing.Point(1039, 277);
            this.cbPages.Name = "cbPages";
            this.cbPages.Size = new System.Drawing.Size(71, 36);
            this.cbPages.TabIndex = 131;
            this.cbPages.SelectedIndexChanged += new System.EventHandler(this.cbPages_SelectedIndexChanged);
            // 
            // cbVehicleStatus
            // 
            this.cbVehicleStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbVehicleStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVehicleStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehicleStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVehicleStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVehicleStatus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbVehicleStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbVehicleStatus.ItemHeight = 30;
            this.cbVehicleStatus.Items.AddRange(new object[] {
            "All",
            "Available",
            "Unavailable"});
            this.cbVehicleStatus.Location = new System.Drawing.Point(361, 272);
            this.cbVehicleStatus.Name = "cbVehicleStatus";
            this.cbVehicleStatus.Size = new System.Drawing.Size(138, 36);
            this.cbVehicleStatus.TabIndex = 133;
            this.cbVehicleStatus.SelectedIndexChanged += new System.EventHandler(this.cbVehicleStatus_SelectedIndexChanged);
            // 
            // btnNewMaintenance
            // 
            this.btnNewMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewMaintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnNewMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewMaintenance.FlatAppearance.BorderSize = 0;
            this.btnNewMaintenance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(78)))), ((int)(((byte)(216)))));
            this.btnNewMaintenance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnNewMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMaintenance.Image = global::CarRentalSystem.Presentation.Properties.Resources.car_return48;
            this.btnNewMaintenance.Location = new System.Drawing.Point(1246, 254);
            this.btnNewMaintenance.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewMaintenance.Name = "btnNewMaintenance";
            this.btnNewMaintenance.Size = new System.Drawing.Size(74, 54);
            this.btnNewMaintenance.TabIndex = 134;
            this.btnNewMaintenance.UseVisualStyleBackColor = false;
            this.btnNewMaintenance.Click += new System.EventHandler(this.btnNewMaintenance_Click);
            // 
            // btnAddNewVehcile
            // 
            this.btnAddNewVehcile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewVehcile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddNewVehcile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewVehcile.Image = global::CarRentalSystem.Presentation.Properties.Resources.add_car40;
            this.btnAddNewVehcile.Location = new System.Drawing.Point(1356, 254);
            this.btnAddNewVehcile.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewVehcile.Name = "btnAddNewVehcile";
            this.btnAddNewVehcile.Size = new System.Drawing.Size(81, 59);
            this.btnAddNewVehcile.TabIndex = 126;
            this.btnAddNewVehcile.UseVisualStyleBackColor = false;
            this.btnAddNewVehcile.Click += new System.EventHandler(this.btnAddNewVehcile_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(610, 18);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(253, 167);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 123;
            this.guna2PictureBox2.TabStop = false;
            // 
            // frmListVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1479, 776);
            this.Controls.Add(this.btnNewMaintenance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPages);
            this.Controls.Add(this.lblRecordsCount);
            this.Controls.Add(this.txtFilterValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.btnAddNewVehcile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.dgvVehciles);
            this.Controls.Add(this.cbVehicleStatus);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmListVehicles";
            this.Text = "frmVehciles";
            this.Load += new System.EventHandler(this.frmListVehciles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehciles)).EndInit();
            this.cmsVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddNewVehcile;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVehciles;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbPages;
        private Guna.UI2.WinForms.Guna2ComboBox cbVehicleStatus;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsVehicles;
        private System.Windows.Forms.ToolStripMenuItem showVehicleDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addNewVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMaintenanceHistoryToolStripMenuItem;
        private System.Windows.Forms.Button btnNewMaintenance;
    }
}