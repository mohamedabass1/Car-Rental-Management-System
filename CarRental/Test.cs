using CarRental.People;
using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Form form = new frmAddUpdateCustomer(1);
            form.ShowDialog();
        }
    }
}
