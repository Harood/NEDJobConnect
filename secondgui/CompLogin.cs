using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using registration_login_system;
namespace secondgui
{
    public partial class CompLogin : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\PMLS\\source\\repos\\secondgui\\secondgui\\bin\\Debug\\net8.0-windows\\db_users1.mdb");
        OleDbCommand cmd;
        public CompLogin()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }

            string login = "SELECT * FROM Companies WHERE CompanyID = @CompanyID AND Password = @Password";
            cmd = new OleDbCommand(login, con);
            cmd.Parameters.AddWithValue("@CompanyID", textUsername.Text);
            cmd.Parameters.AddWithValue("@Password", textPassword.Text);

            using (OleDbDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    new JobAddForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid CompanyID or Password, Please Try again!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            new CompanyRegister().Show();
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

        private void CompLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
