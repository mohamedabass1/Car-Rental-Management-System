using System.Drawing;
using System.Windows.Forms;

namespace CarRental.Dashbiard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            this.Controls.Clear();

            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Dock = DockStyle.Top;
            flow.Height = 160;
            flow.Padding = new Padding(20);

            this.Controls.Add(flow);

            flow.Controls.Add(CreateModernCard("Customers", "7", Properties.Resources.users1, Color.Blue));
            flow.Controls.Add(CreateModernCard("Users", "4", Properties.Resources.users1, Color.Green));
            flow.Controls.Add(CreateModernCard("Vehicles", "100", Properties.Resources.users1, Color.Orange));
            flow.Controls.Add(CreateModernCard("Bookings", "10", Properties.Resources.users1, Color.Purple));
            flow.Controls.Add(CreateModernCard("Return", "4", Properties.Resources.ReturnCar_100, Color.Teal));
            flow.Controls.Add(CreateModernCard("Transactions", "10", Properties.Resources.TransactionBlue, Color.Red));
        }

        private Panel CreateModernCard(string title, string value, Image icon, Color accent)
        {
            Panel card = new Panel();
            card.Size = new Size(220, 120);
            card.BackColor = Color.White;
            card.Margin = new Padding(15);
            card.BorderStyle = BorderStyle.None;

            // Shadow (fake)
            card.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle,
                    Color.FromArgb(220, 220, 220), ButtonBorderStyle.Solid);
            };

            // Icon
            PictureBox pb = new PictureBox();
            pb.Image = icon;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Size = new Size(32, 32);
            pb.Location = new Point(15, 15);

            // Title
            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 10F);
            lblTitle.ForeColor = Color.Gray;
            lblTitle.Location = new Point(15, 80);
            lblTitle.AutoSize = true;

            // Value
            Label lblValue = new Label();
            lblValue.Text = value;
            lblValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblValue.ForeColor = accent;
            lblValue.Location = new Point(15, 40);
            lblValue.AutoSize = true;

            // Accent Line
            Panel line = new Panel();
            line.BackColor = accent;
            line.Dock = DockStyle.Left;
            line.Width = 5;

            // Hover Effect 🔥
            card.MouseEnter += (s, e) =>
            {
                card.BackColor = Color.FromArgb(245, 245, 245);
            };
            card.MouseLeave += (s, e) =>
            {
                card.BackColor = Color.White;
            };

            card.Controls.Add(line);
            card.Controls.Add(pb);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);

            return card;
        }

    }
}
