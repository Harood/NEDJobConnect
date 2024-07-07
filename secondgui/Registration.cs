using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace secondgui
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\PMLS\\source\\repos\\secondgui\\secondgui\\bin\\Debug\\net8.0-windows\\db_users1.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textUsername.Text == "" || textPassword.Text == "" || textcomPassword.Text == "" || studentid.Text == "" || cloudid.Text == "" || department.Text == "")
            {
                MessageBox.Show("Fields are empty!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textPassword.Text != textcomPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Text = "";
                textcomPassword.Text = "";
                textPassword.Focus();
            }
            else if (!IsValidStudentId(studentid.Text))
            {
                MessageBox.Show("Invalid student ID. The student ID should follow the format: 460**** (e.g 4607895)", "Student ID Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentid.Focus();
            }
            else if (!IsValidEmail(cloudid.Text))
            {
                MessageBox.Show("Invalid cloud ID. The cloud ID should follow the format: LastName460****@cloud.neduet.edu.pk", "CloudID Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cloudid.Focus();
            }
            else if (!IsValidPassword(textPassword.Text))
            {
                MessageBox.Show("Password does not meet the strength criteria. It should be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one digit, and one special character.", "Password Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Focus();
            }
            else
            {
                try
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    string register = "INSERT INTO Students ([username], [password], [studentid], [cloudid], [department]) VALUES (@username, @password, @studentid, @cloudid, @department)";
                    cmd = new OleDbCommand(register, con);
                    cmd.Parameters.AddWithValue("@username", textUsername.Text);
                    cmd.Parameters.AddWithValue("@password", textPassword.Text);
                    cmd.Parameters.AddWithValue("@studentid", studentid.Text);
                    cmd.Parameters.AddWithValue("@cloudid", cloudid.Text);
                    cmd.Parameters.AddWithValue("@department", department.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear text fields
                    textUsername.Text = "";
                    textPassword.Text = "";
                    textcomPassword.Text = "";
                    studentid.Text = "";
                    cloudid.Text = "";
                    department.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Ensure the connection is closed
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            // Define a regular expression for validating the specific email format
            string emailPattern = @"^[A-Z]+460\d{4}@cloud\.neduet\.edu\.pk$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidStudentId(string studentId)
        {
            // Define a regular expression for validating the specific student ID format
            string studentIdPattern = @"^460\d{4}$";
            return Regex.IsMatch(studentId, studentIdPattern);
        }

        private bool IsValidPassword(string password)
        {
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                textPassword.PasswordChar = '\0';
                textcomPassword.PasswordChar = '\0';
            }
            else
            {
                textPassword.PasswordChar = '*';
                textcomPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textUsername.Text = "";
            textPassword.Text = "";
            textcomPassword.Text = "";
            studentid.Text = "";
            cloudid.Text = "";
            department.Text = "";
            textUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void studentid_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
