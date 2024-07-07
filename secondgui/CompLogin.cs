using System;
using System.Windows.Forms;
using System.Data.OleDb;
using registration_login_system;

namespace secondgui
{
    public partial class CompLogin : Form
    {
        private OleDbConnection con;
        private OleDbCommand cmd;

        public CompLogin()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\PMLS\\source\\repos\\secondgui\\secondgui\\bin\\Debug\\net8.0-windows\\db_users1.mdb");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
                        ClearInputs();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new CompanyRegister().Show();
            this.Hide();
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = showpassword.Checked ? '\0' : '*';
        }

        private void CompLogin_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here
        }

        private void ClearInputs()
        {
            textUsername.Text = "";
            textPassword.Text = "";
            textUsername.Focus();
        }
    }
}
