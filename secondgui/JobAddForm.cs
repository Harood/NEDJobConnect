using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace registration_login_system
{
    public partial class JobAddForm : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\PMLS\\source\\repos\\secondgui\\secondgui\\bin\\Debug\\net8.0-windows\\db_users1.mdb";

        public JobAddForm()
        {
            InitializeComponent();
            LoadAndDisplayAllJobs();
        }

        private void LoadAndDisplayAllJobs()
        {
            var jobListings = LoadAllJobs();
            DisplayResults(jobListings);
        }

        private List<JobListing> LoadAllJobs()
        {
            var jobListings = new List<JobListing>();

            using (var connection = new OleDbConnection(connectionString))
            {
                const string query = "SELECT JobID, Title, Description, Company, Requirements, Type FROM JobListings";
                using (var command = new OleDbCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var job = new JobListing
                            {
                                JobID = (int)reader["JobID"],
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString(),
                                Company = reader["Company"].ToString(),
                                Requirements = reader["Requirements"].ToString(),
                                Type = reader["Type"].ToString()
                            };
                            jobListings.Add(job);
                        }
                    }
                }
            }

            return jobListings;
        }

        private void DisplayResults(List<JobListing> results)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "JobID", HeaderText = "Job ID", Visible = true },
                new DataGridViewTextBoxColumn { DataPropertyName = "Title", HeaderText = "Job Title" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Description", HeaderText = "Description" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Company", HeaderText = "Company Name" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Requirements", HeaderText = "Requirements" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Type", HeaderText = "Type", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill }
            });

            dataGridView1.DataSource = results;
        }

        private void ClearInputs()
        {
            textTitle.Clear();
            textDescription.Clear();
            textname.Clear();
            textRequirements.Clear();
            comboType.SelectedIndex = -1;
        }

        private int GenerateRandomJobId()
        {
            return new Random().Next(10000, 99999);
        }

        

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textTitle.Text) ||
                string.IsNullOrWhiteSpace(textDescription.Text) ||
                string.IsNullOrWhiteSpace(textname.Text) ||
                string.IsNullOrWhiteSpace(textRequirements.Text) ||
                comboType.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new OleDbConnection(connectionString))
            {
                int jobId = GenerateRandomJobId();
                const string query = "INSERT INTO JobListings (JobID, Title, Description, Company, Requirements, Type) " +
                                     "VALUES (@JobID, @Title, @Description, @Company, @Requirements, @Type)";
                using (var command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@JobID", jobId);
                    command.Parameters.AddWithValue("@Title", textTitle.Text);
                    command.Parameters.AddWithValue("@Description", textDescription.Text);
                    command.Parameters.AddWithValue("@Company", textname.Text);
                    command.Parameters.AddWithValue("@Requirements", textRequirements.Text);
                    command.Parameters.AddWithValue("@Type", comboType.Text);

                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            LoadAndDisplayAllJobs();
            ClearInputs();
        }
    }
}
