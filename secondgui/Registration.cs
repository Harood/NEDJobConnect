using System;
using System.Windows.Forms;
using System.Data.OleDb;

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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textUsername.Text == "" && textPassword.Text == "" && textcomPassword.Text == "")
            {
                MessageBox.Show("Fields are empty!", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textPassword.Text == textcomPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES('" + textUsername.Text + "','" + textPassword.Text + "','"+ studentid.Text+ "','"+ cloudid.Text+ "','"+department.Text+"')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();
                textUsername.Text = "";
                textPassword.Text = "";
                textcomPassword.Text = "";
                MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registration Failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Text = "";
                textcomPassword.Text = "";
                textPassword.Focus();
            }
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
            textUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
    }
}
