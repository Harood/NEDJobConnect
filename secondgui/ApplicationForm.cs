using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace registration_login_system
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\PMLS\\source\\repos\\secondgui\\secondgui\\bin\\Debug\\net8.0-windows\\db_users1.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        string selectedCVFilePath = "";

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf|Word Documents|*.doc;*.docx|All Files|*.*"; // Filter to allow specific file types
            openFileDialog.Title = "Select CV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedCVFilePath = openFileDialog.FileName;
                button1.Text = selectedCVFilePath; // Display the file path on the button
                MessageBox.Show("CV file uploaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTechnicalSkills.Text) || string.IsNullOrEmpty(txtSoftSkills.Text) ||
                string.IsNullOrEmpty(selectedCVFilePath))
            {
                MessageBox.Show("Please fill all the required fields and select a CV file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                string register = "INSERT INTO Applications ([Name], [Email], [Phone No], [Address], [Degree], [Major], [Year of graduation], [Previous Job Title], [Company Name], [Duration], [Responsibilities], [Technical Skills], [Soft Skills], [Cover letter], [Resume]) VALUES (@name, @Email, @PhoneNo, @Address, @Degree, @Major, @YearOfGraduation, @PreviousJobTitle, @CompanyName, @Duration, @Responsibilities, @TechnicalSkills, @SoftSkills, @CoverLetter, @Resume)";
                cmd = new OleDbCommand(register, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@PhoneNo", textBox2.Text);
                cmd.Parameters.AddWithValue("@Address", textBox3.Text);
                cmd.Parameters.AddWithValue("@Degree", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Major", textBox5.Text);
                cmd.Parameters.AddWithValue("@YearOfGraduation", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@PreviousJobTitle", textBox6.Text);
                cmd.Parameters.AddWithValue("@CompanyName", textBox7.Text);
                cmd.Parameters.AddWithValue("@Duration", textBox8.Text);
                cmd.Parameters.AddWithValue("@Responsibilities", textBox9.Text);
                cmd.Parameters.AddWithValue("@TechnicalSkills", txtTechnicalSkills.Text);
                cmd.Parameters.AddWithValue("@SoftSkills", txtSoftSkills.Text);
                cmd.Parameters.AddWithValue("@CoverLetter", richTextBox1.Text);
                cmd.Parameters.AddWithValue("@Resume", selectedCVFilePath);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Application submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtEmail.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            txtTechnicalSkills.Text = "";
            txtSoftSkills.Text = "";
            richTextBox1.Text = "";
            button1.Text = ""; // Clear the displayed file path on the button
            selectedCVFilePath = ""; // Clear the stored file path
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
