using CarRental.People;
using CarRental_Buisness;
using System;
using System.Windows.Forms;
namespace CarRental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddUpdatePerson();
            frm.ShowDialog();



        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            clsPerson person = await clsPerson.FindAsync(4);

            if (person == null)
            {
                MessageBox.Show("Person was not found.");
                return;
            }


            MessageBox.Show("Person Full name before update :" + person.FullName);

            person.LastName = "Abass";

            if (await person.SaveAsync())
            {
                MessageBox.Show($"Person Updated Successfuly");

                MessageBox.Show("Person Full name after update :" + person.FullName);

            }
            else
                MessageBox.Show($"Person Updated failed");




        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (!await clsPerson.IsPersonExistsAsync(2))
            {
                MessageBox.Show($"Person does not exists");
                return;
            }

            if (await clsPerson.DeletePersonAsync(2))
            {
                MessageBox.Show($"Person Deleted Successfuly");

            }
            else
                MessageBox.Show($"Person Deleted Failed");
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersonInfo(4);
        }
    }
}
