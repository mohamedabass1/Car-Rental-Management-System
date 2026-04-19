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


            frm.BackColor = Color.White;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            myPanel.Controls.Add(frm);
            myPanel.Tag = frm;
            frm.Show();
        }

        private void OpenPage(Form frm, string title)
        {
            lblTitle.Text = title;
            _LoadForm(frm);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            OpenPage(new frmDashboard(), "Dashboard");

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenPage(new frmDashboard(), "Dashboard");
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            OpenPage(new frmBooking(), "Manageg Booking");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            OpenPage(new frmReturn(), "Manageg Return");

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            OpenPage(new frmTransactions(), "Manageg Transactions");

        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OpenPage(new frmVehciles(), "Manageg Vehciles");

        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenPage(new frmListCustomers(), "Manage Customers");
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenPage(new frmUsers(), "Manageg Vehciles");

        }
    }
}
