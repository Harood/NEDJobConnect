using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace registration_login_system
{
    public partial class JobForm : Form
    {
        private readonly string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\PMLS\\source\\repos\\secondgui\\secondgui\\bin\\Debug\\net8.0-windows\\db_users1.mdb";

        public JobForm()
        {
            InitializeComponent();
            LoadAndDisplayAllJobs();
            PopulateFilterComboBox();
        }

        private void LoadAndDisplayAllJobs()
        {
            DisplayResults(LoadJobs());
        }

        private List<JobListing> LoadJobs(string query = "SELECT JobID, Company, Title, Description, Requirements, Type FROM JobListings", params OleDbParameter[] parameters)
        {
            List<JobListing> jobListings = new List<JobListing>();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            jobListings.Add(new JobListing
                            {
                                JobID = (int)reader["JobID"],
                                Company = reader["Company"].ToString(),
                                Title = reader["Title"].ToString(),
                                Description = reader["Description"].ToString(),
                                Requirements = reader["Requirements"].ToString(),
                                Type = reader["Type"].ToString()
                            });
                        }
                    }
                }
            }

            return jobListings;
        }

        private List<JobListing> SearchJobs(string criteria, string jobType)
        {
            string query = "SELECT JobID, Title, Description, Requirements, Company, Type FROM JobListings " +
                           "WHERE (Title LIKE @Criteria OR Description LIKE @Criteria OR Company LIKE @Criteria OR Type LIKE @Criteria OR Requirements LIKE @Criteria) " +
                           "AND (@JobType = 'All' OR Type = @JobType)";
            var parameterCriteria = new OleDbParameter("@Criteria", "%" + criteria + "%");
            var parameterJobType = new OleDbParameter("@JobType", jobType);
            return LoadJobs(query, parameterCriteria, parameterJobType);
        }

        private void DisplayResults(List<JobListing> results)
        {
            dgvResults.Columns.Clear();
            dgvResults.AutoGenerateColumns = false;

            // Define DataGridView columns
            DataGridViewTextBoxColumn jobIDColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "JobID",
                HeaderText = "Job ID",
                Visible = false // Hide this column
            };
            dgvResults.Columns.Add(jobIDColumn);

            DataGridViewTextBoxColumn titleColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Title",
                HeaderText = "Job Title"
            };
            dgvResults.Columns.Add(titleColumn);

            DataGridViewTextBoxColumn companyColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Company",
                HeaderText = "Company Name"
            };
            dgvResults.Columns.Add(companyColumn);

            DataGridViewTextBoxColumn descriptionColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description"
            };
            dgvResults.Columns.Add(descriptionColumn);

            DataGridViewTextBoxColumn requirementsColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Requirements",
                HeaderText = "Requirements"
            };
            dgvResults.Columns.Add(requirementsColumn);

            DataGridViewTextBoxColumn typeColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Type",
                HeaderText = "Type"
            };
            dgvResults.Columns.Add(typeColumn);

            // Apply button column
            DataGridViewButtonColumn applyButtonColumn = new DataGridViewButtonColumn
            {
                Text = "Apply",
                UseColumnTextForButtonValue = true,
                HeaderText = "Apply",
                Name = "ApplyButtonColumn" // Name to reference in dgvResults_CellContentClick
            };
            applyButtonColumn.DefaultCellStyle.Padding = new Padding(10, 0, 10, 0); // Adjust button padding if needed
            dgvResults.Columns.Add(applyButtonColumn);

            dgvResults.DataSource = results;
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvResults.Columns["ApplyButtonColumn"].Index)
            {
                JobListing selectedJob = (JobListing)dgvResults.Rows[e.RowIndex].DataBoundItem;
                OpenApplicationForm(selectedJob);
            }
        }

        private void OpenApplicationForm(JobListing selectedJob)
        {
            ApplicationForm applicationForm = new ApplicationForm();
            applicationForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchCriteria = txtSearchCriteria.Text.Trim();
            string selectedType = comboBox1.SelectedItem.ToString();

            DisplayResults(SearchJobs(searchCriteria, selectedType));
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtSearchCriteria.Text = string.Empty;
            LoadAndDisplayAllJobs();
        }

        private void PopulateFilterComboBox()
        {
            comboBox1.Items.AddRange(new[] { "All", "Job", "Internship" });
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBox1.SelectedItem.ToString();
            string searchCriteria = txtSearchCriteria.Text.Trim();

            DisplayResults(SearchJobs(searchCriteria, selectedType));
        }
    }
}
