using CarRental.Booking;
using CarRental.Customers;
using CarRental.Dashbiard;
using CarRental.Return;
using CarRental.Transactions;
using CarRental.Users;
using CarRental.Vehciles;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace CarRental
{
    public partial class frmMainMenue : Form
    {
        Panel myPanel;
        public frmMainMenue()
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


            frm.BackColor = Color.FromArgb(245, 245, 245);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            myPanel.Controls.Add(frm);
            myPanel.Tag = frm;
            frm.Show();
        }

        private void OpenPage(Form frm, string title, Control btn)
        {
            lblTitle.Text = title;
            _LoadForm(frm);
            MoveIndicator(btn);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            OpenPage(new frmDashboard(), "Dashboard", btnDashboard);
        }


        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenPage(new frmDashboard(), "Dashboard", btnDashboard);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            OpenPage(new frmRentalBookingList(), "Manageg Booking", btnBooking);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            OpenPage(new frmReturn(), "Manageg Return", btnReturn);

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            OpenPage(new frmTransactions(), "Manageg Transactions", btnTransactions);

        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenPage(new frmListVehicles(), "Manageg Vehicles", btnVehicles);

        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenPage(new frmListCustomers(), "Manage Customers", btnCustomers);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenPage(new frmUsers(), "Manageg Users", btnUsers);

        }

        private void mainPanal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnMax_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MoveIndicator(Control btn)
        {
            Indicator1.Top = btn.Top;
        }
    }
}
