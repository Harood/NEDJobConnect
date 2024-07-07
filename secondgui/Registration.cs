using System;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace secondgui
{
    public partial class Register : Form
    {
        private OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\PMLS\\source\\repos\\secondgui\\secondgui\\bin\\Debug\\net8.0-windows\\db_users1.mdb");
        private OleDbCommand cmd = new OleDbCommand();

        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textUsername.Text == "" || textPassword.Text == "" || textcomPassword.Text == "" || studentid.Text == "" || cloudid.Text == "" || department.Text == "")
            {
                MessageBox.Show("Please fill in all fields!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textPassword.Text != textcomPassword.Text)
            {
                MessageBox.Show("Passwords do not match!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Text = "";
                textcomPassword.Text = "";
                textPassword.Focus();
                return;
            }

            if (!IsValidStudentId(studentid.Text))
            {
                MessageBox.Show("Invalid student ID format. Please enter a valid student ID like 460**** (e.g., 4607895)", "Student ID Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentid.Focus();
                return;
            }

            if (!IsValidEmail(cloudid.Text))
            {
                MessageBox.Show("Invalid cloud ID format. Please enter a valid cloud ID like LastName460****@cloud.neduet.edu.pk", "CloudID Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cloudid.Focus();
                return;
            }

            if (!IsValidPassword(textPassword.Text))
            {
                MessageBox.Show("Password does not meet the criteria. It should be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one digit, and one special character.", "Password Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Focus();
                return;
            }

            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                string registerQuery = "INSERT INTO Students ([StudentName], [Password], [StudentID], [cloudid], [Department]) VALUES (@StudentName, @Password, @StudentID, @cloudid, @Department)";
                cmd = new OleDbCommand(registerQuery, con);
                cmd.Parameters.AddWithValue("@StudentName", textUsername.Text);
                cmd.Parameters.AddWithValue("@Password", textPassword.Text);
                cmd.Parameters.AddWithValue("@StudentID", studentid.Text);
                cmd.Parameters.AddWithValue("@cloudid", cloudid.Text);
                cmd.Parameters.AddWithValue("@Department", department.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear text fields
                ClearFields();
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

        private void ClearFields()
        {
            textUsername.Text = "";
            textPassword.Text = "";
            textcomPassword.Text = "";
            studentid.Text = "";
            cloudid.Text = "";
            department.Text = "";
            textUsername.Focus();
        }

        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[A-Z]+460\d{4}@cloud\.neduet\.edu\.pk$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidStudentId(string studentId)
        {
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
            textPassword.PasswordChar = showpassword.Checked ? '\0' : '*';
            textcomPassword.PasswordChar = showpassword.Checked ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
