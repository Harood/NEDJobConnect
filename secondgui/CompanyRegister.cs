using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace secondgui
{
    public partial class CompanyRegister : Form
    {
        public CompanyRegister()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\PMLS\\source\\repos\\secondgui\\secondgui\\bin\\Debug\\net8.0-windows\\db_users1.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        // Variable to keep track of the last used sequential number
        int lastCompanyId = 0;

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textUsername.Text == "" || textPassword.Text == "" || textcomPassword.Text == "" || cloudid.Text == "" || contactno.Text == "")
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
            else if (!IsValidPassword(textPassword.Text))
            {
                MessageBox.Show("Password does not meet the strength criteria. It should be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one digit, and one special character.", "Password Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Focus();
            }
            else if (!IsValidEmail(cloudid.Text))
            {
                MessageBox.Show("Invalid email address. The email should follow the format: example@email.com", "Email Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cloudid.Focus();
            }
            else if (!IsValidContactNumber(contactno.Text))
            {
                MessageBox.Show("Invalid contact number. It should be between 10 to 15 digits long and contain only digits.", "Contact Number Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contactno.Focus();
            }
            else
            {
                try
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    // Generate a simple Company ID
                    string companyId = GenerateCompanyId(textUsername.Text);

                    string register = "INSERT INTO Companies ([CompanyName], [Password], [CompanyID], [Email], [Contactno]) VALUES (@CompanyName, @Password, @CompanyID, @Email, @Contactno)";
                    cmd = new OleDbCommand(register, con);
                    cmd.Parameters.AddWithValue("@CompanyName", textUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", textPassword.Text);
                    cmd.Parameters.AddWithValue("@CompanyID", companyId);
                    cmd.Parameters.AddWithValue("@Email", cloudid.Text);
                    cmd.Parameters.AddWithValue("@Contactno", contactno.Text);

                    cmd.ExecuteNonQuery();

                    // Show registration success message with Company ID and Password
                    MessageBox.Show($"Registration Successful!\n\nYour Company ID: {companyId}\nYour Password: {textPassword.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear text fields
                    textUsername.Text = "";
                    textPassword.Text = "";
                    textcomPassword.Text = "";
                    cloudid.Text = "";
                    contactno.Text = "";
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

        private bool IsValidContactNumber(string contactNumber)
        {
            // Define a regular expression for validating the contact number
            string contactNumberPattern = @"^\d{10,15}$";
            return Regex.IsMatch(contactNumber, contactNumberPattern);
        }
        private bool IsValidPassword(string password)
        {
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }
        private bool IsValidEmail(string email)
        {
            // Define a regular expression for validating the specific email format
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, emailPattern);
        }

        private string GenerateCompanyId(string companyName)
        {
            // Example: Generate a simple ID using initials and a sequential number
            string initials = GetInitials(companyName);
            lastCompanyId++; // Increment the last used sequential number
            string companyId = $"{initials}-{lastCompanyId.ToString("D4")}"; // D4 ensures 4-digit sequential number
            return companyId;
        }

        private string GetInitials(string name)
        {
            // Example: Get initials from the company name
            string[] words = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string initials = "";
            foreach (string word in words)
            {
                initials += word[0]; // Take the first letter of each word
            }
            return initials.ToUpper(); // Convert to uppercase
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
            cloudid.Text = "";
            contactno.Text = "";

            textUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new CompLogin().Show();
            this.Hide();
        }
        private void contactno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
