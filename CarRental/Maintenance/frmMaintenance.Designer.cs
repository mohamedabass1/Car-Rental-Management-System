namespace CarRental.Maintenance
{
    partial class frmMaintenance
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
            this.ctrlVrhicleInfoCardWithFilter1 = new CarRental.Vehicles.Controls.ctrlVehicleInfoCardWithFilter();
            this.SuspendLayout();
            // 
            // ctrlVrhicleInfoCardWithFilter1
            // 
            this.ctrlVrhicleInfoCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlVrhicleInfoCardWithFilter1.FilterEnabled = true;
            this.ctrlVrhicleInfoCardWithFilter1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ctrlVrhicleInfoCardWithFilter1.Location = new System.Drawing.Point(14, 26);
            this.ctrlVrhicleInfoCardWithFilter1.Margin = new System.Windows.Forms.Padding(5);
            this.ctrlVrhicleInfoCardWithFilter1.Name = "ctrlVrhicleInfoCardWithFilter1";
            this.ctrlVrhicleInfoCardWithFilter1.Size = new System.Drawing.Size(911, 433);
            this.ctrlVrhicleInfoCardWithFilter1.TabIndex = 0;
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1099, 516);
            this.Controls.Add(this.ctrlVrhicleInfoCardWithFilter1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Maintenance";
            this.ResumeLayout(false);

        }

        #endregion

        private Vehicles.Controls.ctrlVehicleInfoCardWithFilter ctrlVrhicleInfoCardWithFilter1;
    }
}