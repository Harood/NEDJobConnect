namespace secondgui
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            showpassword = new CheckBox();
            textPassword = new TextBox();
            label3 = new Label();
            textUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label8 = new Label();
            studentid = new TextBox();
            label9 = new Label();
            label10 = new Label();
            cloudid = new TextBox();
            label11 = new Label();
            label12 = new Label();
            department = new ComboBox();
            label13 = new Label();
            textcomPassword = new TextBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(603, 447);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(149, 28);
            label6.TabIndex = 34;
            label6.Text = "Back to LOGIN";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(128, 64, 64);
            label5.Location = new Point(556, 419);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(246, 28);
            label5.TabIndex = 33;
            label5.Text = "Already have an account";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(499, 344);
            button2.Name = "button2";
            button2.Size = new Size(325, 51);
            button2.TabIndex = 32;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(499, 287);
            button1.Name = "button1";
            button1.Size = new Size(325, 51);
            button1.TabIndex = 31;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.BackColor = Color.White;
            showpassword.Cursor = Cursors.Hand;
            showpassword.FlatStyle = FlatStyle.Flat;
            showpassword.ForeColor = Color.FromArgb(128, 64, 64);
            showpassword.Location = new Point(646, 214);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(178, 32);
            showpassword.TabIndex = 30;
            showpassword.Text = "Show Password";
            showpassword.UseVisualStyleBackColor = false;
            showpassword.CheckedChanged += textBox5_TextChanged;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.RosyBrown;
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(499, 97);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(325, 30);
            textPassword.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(499, 66);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 28;
            label3.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.RosyBrown;
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(12, 97);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(196, 30);
            textUsername.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 26;
            label2.Text = "Student Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("MS UI Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(329, 40);
            label1.TabIndex = 25;
            label1.Text = "Registration Form";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(128, 64, 64);
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 36;
            label4.Text = "(Full Name)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(12, 171);
            label8.Name = "label8";
            label8.Size = new Size(112, 28);
            label8.TabIndex = 38;
            label8.Text = "Student ID";
            // 
            // studentid
            // 
            studentid.BackColor = Color.RosyBrown;
            studentid.BorderStyle = BorderStyle.None;
            studentid.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentid.Location = new Point(12, 202);
            studentid.Name = "studentid";
            studentid.Size = new Size(196, 30);
            studentid.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.FromArgb(128, 64, 64);
            label9.Location = new Point(12, 235);
            label9.Name = "label9";
            label9.Size = new Size(215, 28);
            label9.TabIndex = 40;
            label9.Text = "(example@SE-23088)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(64, 0, 0);
            label10.Location = new Point(12, 275);
            label10.Name = "label10";
            label10.Size = new Size(93, 28);
            label10.TabIndex = 41;
            label10.Text = "Cloud ID";
            // 
            // cloudid
            // 
            cloudid.BackColor = Color.RosyBrown;
            cloudid.BorderStyle = BorderStyle.None;
            cloudid.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cloudid.Location = new Point(12, 306);
            cloudid.Name = "cloudid";
            cloudid.Size = new Size(296, 30);
            cloudid.TabIndex = 42;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(128, 64, 64);
            label11.Location = new Point(12, 344);
            label11.Name = "label11";
            label11.Size = new Size(219, 28);
            label11.TabIndex = 43;
            label11.Text = "(example@neduet.pk)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.FromArgb(64, 0, 0);
            label12.Location = new Point(12, 388);
            label12.Name = "label12";
            label12.Size = new Size(127, 28);
            label12.TabIndex = 44;
            label12.Text = "Department";
            // 
            // department
            // 
            department.BackColor = Color.RosyBrown;
            department.FormattingEnabled = true;
            department.Items.AddRange(new object[] { "Software Engineering", "CSIT department", "Civil Engineering" });
            department.Location = new Point(12, 419);
            department.Name = "department";
            department.Size = new Size(222, 36);
            department.TabIndex = 45;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(64, 0, 0);
            label13.Location = new Point(499, 147);
            label13.Name = "label13";
            label13.Size = new Size(182, 28);
            label13.TabIndex = 46;
            label13.Text = "Confirm Password";
            // 
            // textcomPassword
            // 
            textcomPassword.BackColor = Color.RosyBrown;
            textcomPassword.BorderStyle = BorderStyle.None;
            textcomPassword.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textcomPassword.Location = new Point(499, 178);
            textcomPassword.Name = "textcomPassword";
            textcomPassword.PasswordChar = '*';
            textcomPassword.Size = new Size(325, 30);
            textcomPassword.TabIndex = 47;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 63);
            panel1.TabIndex = 48;
            // 
            // Register
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 492);
            Controls.Add(textcomPassword);
            Controls.Add(label13);
            Controls.Add(department);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(cloudid);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(studentid);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(showpassword);
            Controls.Add(textPassword);
            Controls.Add(label3);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 164, 164);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Register";
            RightToLeftLayout = true;
            Text = "a";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private Button button2;
        private Button button1;
        private CheckBox showpassword;
        private TextBox textPassword;
        private Label label3;
        private TextBox textUsername;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label8;
        private TextBox studentid;
        private Label label9;
        private Label label10;
        private TextBox cloudid;
        private Label label11;
        private Label label12;
        private ComboBox department;
        private Label label13;
        private TextBox textcomPassword;
        private Panel panel1;
    }
}
