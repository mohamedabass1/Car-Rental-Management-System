using CarRentalSystem.Presentation.Booking;
using CarRentalSystem.Presentation.Customers;
using CarRentalSystem.Presentation.Dashbiard;
using CarRentalSystem.Presentation.Return;
using CarRentalSystem.Presentation.Transactions;
using CarRentalSystem.Presentation.Users;
using CarRentalSystem.Presentation.Vehciles;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace CarRentalSystem.Presentation
{
    public partial class frmMainScreen : Form
    {
        Panel myPanel;
        public frmMainScreen()
        {
            InitializeComponent();
            myPanel = mainPanal;

        }

        // Load Specific Form  int the Panel in this form
        public void _LoadForm(Form frm)
        {
            if (frm == null) return;

            // لو الفورم المفتوح هو نفسه الفورم اللي اشتي افتحه متعملش حاجة
            if (myPanel.Controls.Count > 0 && myPanel.Controls[0].GetType() == frm.GetType())
                return;

            if (myPanel.Controls.Count > 0)
            {
                myPanel.Controls[0].Dispose();
                myPanel.Controls.Clear();
            }


            frm.BackColor = Color.FromArgb(241, 245, 249);
            frm.TopLevel = false;
            frm.AutoScroll = true;
            frm.Dock = DockStyle.Fill;
            myPanel.Controls.Add(frm);
            myPanel.Tag = frm;
            frm.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            OpenPage(new frmDashboard(), "Dashboard", btnDashboard);
        }
        private void OpenPage(Form frm, string title, Control btn)
        {
            lblTitle.Text = title;
            _LoadForm(frm);
            MoveIndicator(btn);
        }
        private void MoveIndicator(Control btn)
        {
            Indicator1.Top = btn.Top;
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenPage(new frmDashboard(), "Dashboard", btnDashboard);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            OpenPage(new frmRentalBookingList(), "Manage Booking", btnBooking);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            OpenPage(new frmManageVehicleReturns(), "Manage Returns", btnReturn);

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            OpenPage(new frmTransactionsList(), "Manage Transactions", btnTransactions);

        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenPage(new frmListVehicles(), "Manage Vehicles", btnVehicles);

        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenPage(new frmListCustomers(), "Manage Customers", btnCustomers);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenPage(new frmUsers(), "Manage Users", btnUsers);

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnMax_Click_1(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMainMenue_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                panelMenu.Width = 300;
            }
            else
            {
                panelMenu.Width = 280;
            }
        }
    }
}
