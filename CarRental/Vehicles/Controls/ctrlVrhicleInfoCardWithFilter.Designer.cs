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
            this.ctrlVehicleInfoCard1 = new CarRental.Vehicles.Controls.ctrlVehicleInfoCard();
            this.SuspendLayout();
            // 
            // ctrlVehicleInfoCard1
            // 
            this.ctrlVehicleInfoCard1.BackColor = System.Drawing.Color.White;
            this.ctrlVehicleInfoCard1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ctrlVehicleInfoCard1.Location = new System.Drawing.Point(13, 103);
            this.ctrlVehicleInfoCard1.Margin = new System.Windows.Forms.Padding(4);
            this.ctrlVehicleInfoCard1.Name = "ctrlVehicleInfoCard1";
            this.ctrlVehicleInfoCard1.Size = new System.Drawing.Size(890, 324);
            this.ctrlVehicleInfoCard1.TabIndex = 0;
            // 
            // ctrlVrhicleInfoCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrlVehicleInfoCard1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ctrlVrhicleInfoCardWithFilter";
            this.Size = new System.Drawing.Size(1005, 469);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlVehicleInfoCard ctrlVehicleInfoCard1;
    }
}
