using registration_login_system;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace secondgui
{
    public partial class LogIn : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\PMLS\\source\\repos\\secondgui\\secondgui\\bin\\Debug\\net8.0-windows\\db_users1.mdb");

        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginQuery = "SELECT * FROM Students WHERE StudentID = @StudentID AND Password = @Password";

            try
            {
                using (OleDbCommand cmd = new OleDbCommand(loginQuery, con))
                {
                    cmd.Parameters.AddWithValue("@StudentID", textUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", textPassword.Text);

                    con.Open();
                    using (OleDbDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // Successful login
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new JobForm().Show();
                            this.Hide();
                        }
                        else
                        {
                            // Invalid login
                            MessageBox.Show("Invalid StudentID or Password, Please Try again!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textPassword.Clear();
                            textUsername.Focus();
                        }
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
            // Clear username and password fields
            textUsername.Clear();
            textPassword.Clear();
            textUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Open registration form
            new Register().Show();
            this.Hide();
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide password based on checkbox
            textPassword.PasswordChar = showpassword.Checked ? '\0' : '*';
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
