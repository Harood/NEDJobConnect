namespace registration_login_system
{
    partial class JobAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            textTitle = new TextBox();
            label2 = new Label();
            textname = new TextBox();
            textDescription = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textRequirements = new TextBox();
            label6 = new Label();
            comboType = new ComboBox();
            label7 = new Label();
            btnAddJob = new Button();
            jobFormBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)jobFormBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.Font = new Font("Myanmar Text", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-2, 11);
            label1.Name = "label1";
            label1.Size = new Size(403, 56);
            label1.TabIndex = 2;
            label1.Text = "Add New Job/Internship!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1376, 66);
            panel1.TabIndex = 3;
            // 
            // textTitle
            // 
            textTitle.Location = new Point(139, 88);
            textTitle.Margin = new Padding(3, 4, 3, 4);
            textTitle.Name = "textTitle";
            textTitle.Size = new Size(308, 31);
            textTitle.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(107, 26);
            label2.TabIndex = 5;
            label2.Text = "Job Title:";
            // 
            // textname
            // 
            textname.Location = new Point(221, 152);
            textname.Margin = new Padding(3, 4, 3, 4);
            textname.Name = "textname";
            textname.Size = new Size(226, 31);
            textname.TabIndex = 7;
            // 
            // textDescription
            // 
            textDescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textDescription.Location = new Point(488, 136);
            textDescription.Margin = new Padding(3, 4, 3, 4);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.PlaceholderText = "Enter job description here...";
            textDescription.Size = new Size(426, 186);
            textDescription.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 0, 0);
            label4.Location = new Point(488, 94);
            label4.Name = "label4";
            label4.Size = new Size(179, 26);
            label4.TabIndex = 9;
            label4.Text = "Job Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(943, 88);
            label5.Name = "label5";
            label5.Size = new Size(205, 26);
            label5.TabIndex = 10;
            label5.Text = "Job Requirements:";
            // 
            // textRequirements
            // 
            textRequirements.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textRequirements.Location = new Point(943, 136);
            textRequirements.Margin = new Padding(3, 4, 3, 4);
            textRequirements.Multiline = true;
            textRequirements.Name = "textRequirements";
            textRequirements.PlaceholderText = "Enter job requirements here...";
            textRequirements.Size = new Size(392, 186);
            textRequirements.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(13, 222);
            label6.Name = "label6";
            label6.Size = new Size(112, 26);
            label6.TabIndex = 12;
            label6.Text = "Job Type:";
            // 
            // comboType
            // 
            comboType.BackColor = Color.White;
            comboType.Cursor = Cursors.Hand;
            comboType.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboType.ForeColor = Color.Black;
            comboType.FormattingEnabled = true;
            comboType.Items.AddRange(new object[] { "Job", "Internship" });
            comboType.Location = new Point(156, 219);
            comboType.Margin = new Padding(3, 4, 3, 4);
            comboType.Name = "comboType";
            comboType.Size = new Size(292, 34);
            comboType.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(13, 155);
            label7.Name = "label7";
            label7.Size = new Size(181, 26);
            label7.TabIndex = 16;
            label7.Text = "Company Name:";
            // 
            // btnAddJob
            // 
            btnAddJob.BackColor = Color.FromArgb(64, 0, 0);
            btnAddJob.Cursor = Cursors.Hand;
            btnAddJob.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddJob.ForeColor = SystemColors.ControlLight;
            btnAddJob.Location = new Point(310, 281);
            btnAddJob.Margin = new Padding(3, 4, 3, 4);
            btnAddJob.Name = "btnAddJob";
            btnAddJob.Size = new Size(138, 56);
            btnAddJob.TabIndex = 17;
            btnAddJob.Text = "Add Job";
            btnAddJob.UseVisualStyleBackColor = false;
            btnAddJob.Click += btnAddJob_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(64, 0, 0);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MistyRose;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DarkRed;
            dataGridView1.Location = new Point(13, 365);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(1363, 295);
            dataGridView1.TabIndex = 18;
            // 
            // JobAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Bisque;
            ClientSize = new Size(1405, 675);
            Controls.Add(dataGridView1);
            Controls.Add(btnAddJob);
            Controls.Add(label7);
            Controls.Add(comboType);
            Controls.Add(label6);
            Controls.Add(textRequirements);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textDescription);
            Controls.Add(textname);
            Controls.Add(label2);
            Controls.Add(textTitle);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "JobAddForm";
            Text = "Add Job Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)jobFormBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox textTitle;
        private Label label2;
        private TextBox textname;
        private TextBox textDescription;
        private Label label4;
        private Label label5;
        private TextBox textRequirements;
        private Label label6;
        private ComboBox comboType;
        private Label label7;
        private Button btnAddJob;
        private BindingSource jobFormBindingSource;
        private DataGridView dataGridView1;
    }
}
