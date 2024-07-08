using secondgui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration_login_system
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CompLogin().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            // Create an instance of the RoundedPanel
            RoundedPanel roundedPanel = new RoundedPanel
            {
                BorderRadius = 60, // Adjust the roundness
                Size = new Size(600, 400), // Adjust the size
                Location = new Point(100, 150), // Adjust the location
                BackColor = Color.LightBlue // Adjust the background color
            };

            // Add the custom panel to the form
            this.Controls.Add(roundedPanel);
        }
    }
}
