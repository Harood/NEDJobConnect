namespace registration_login_system
{
    partial class JobForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            btn_clear = new Button();
            txtSearchCriteria = new TextBox();
            label2 = new Label();
            dgvResults = new DataGridView();
            btnSearch_Click = new Button();
            panel2 = new Panel();
            label1 = new Label();
            jobFormBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)jobFormBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btn_clear);
            panel1.Controls.Add(txtSearchCriteria);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dgvResults);
            panel1.Controls.Add(btnSearch_Click);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = Color.FromArgb(164, 164, 164);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1474, 557);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.DarkRed;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 34);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(64, 0, 0);
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(907, 67);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(143, 43);
            btn_clear.TabIndex = 6;
            btn_clear.Text = "Clear";
            btn_clear.UseCompatibleTextRendering = true;
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // txtSearchCriteria
            // 
            txtSearchCriteria.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchCriteria.Location = new Point(350, 71);
            txtSearchCriteria.Name = "txtSearchCriteria";
            txtSearchCriteria.Size = new Size(402, 37);
            txtSearchCriteria.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(2, 74);
            label2.Name = "label2";
            label2.Size = new Size(342, 28);
            label2.TabIndex = 4;
            label2.Text = "Search for Jobs/Internships:";
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResults.BackgroundColor = Color.FromArgb(64, 0, 0);
            dgvResults.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 0, 0);
            dataGridViewCellStyle1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MistyRose;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            dgvResults.EnableHeadersVisualStyles = false;
            dgvResults.GridColor = Color.RosyBrown;
            dgvResults.Location = new Point(0, 158);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.RowHeadersWidth = 62;
            dgvResults.Size = new Size(1469, 394);
            dgvResults.TabIndex = 3;
            dgvResults.CellContentClick += dgvResults_CellContentClick;
            // 
            // btnSearch_Click
            // 
            btnSearch_Click.BackColor = Color.FromArgb(64, 0, 0);
            btnSearch_Click.Cursor = Cursors.Hand;
            btnSearch_Click.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch_Click.ForeColor = Color.White;
            btnSearch_Click.Location = new Point(758, 68);
            btnSearch_Click.Name = "btnSearch_Click";
            btnSearch_Click.Size = new Size(143, 43);
            btnSearch_Click.TabIndex = 2;
            btnSearch_Click.Text = "Search";
            btnSearch_Click.UseCompatibleTextRendering = true;
            btnSearch_Click.UseVisualStyleBackColor = false;
            btnSearch_Click.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.ForeColor = Color.FromArgb(164, 164, 164);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1469, 62);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.Font = new Font("Myanmar Text", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(-2, 5);
            label1.Name = "label1";
            label1.Size = new Size(481, 56);
            label1.TabIndex = 1;
            label1.Text = "Explore New Jobs/Internships:";
            // 
            // jobFormBindingSource
            // 
            jobFormBindingSource.DataSource = typeof(JobForm);
            // 
            // JobForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1472, 556);
            Controls.Add(panel1);
            Name = "JobForm";
            Text = "JobForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)jobFormBindingSource).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Label label1;
        private Button btnSearch_Click;
        private DataGridView dgvResults;
        private Label label2;
        private TextBox txtSearchCriteria;
        private Button btn_clear;
        private BindingSource jobFormBindingSource;
        private ComboBox comboBox1;
        private Panel panel2;
    }
}
