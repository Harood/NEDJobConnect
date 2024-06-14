using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using registration_login_system;
namespace secondgui
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\PMLS\\source\\repos\\secondgui\\secondgui\\bin\\Debug\\net8.0-windows\\db_users1.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }

            string login = "SELECT * FROM tbl_users WHERE username = @username AND password = @password";
            cmd = new OleDbCommand(login, con);
            cmd.Parameters.AddWithValue("@username", textUsername.Text);
            cmd.Parameters.AddWithValue("@password", textPassword.Text);

            using (OleDbDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    new dashboard().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password, Please Try again!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUsername.Text = "";
                    textPassword.Text = "";
                    textUsername.Focus();
                }
            }

            con.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textUsername.Text = "";
            textPassword.Text = "";
            textUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                textPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';
            }
        }
    }
}
