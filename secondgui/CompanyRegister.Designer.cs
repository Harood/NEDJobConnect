﻿namespace secondgui
{
    partial class CompanyRegister
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
            label10 = new Label();
            cloudid = new TextBox();
            label13 = new Label();
            textcomPassword = new TextBox();
            panel1 = new Panel();
            label11 = new Label();
            contactno = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(356, 501);
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
            label5.Location = new Point(311, 473);
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
            button2.Location = new Point(12, 419);
            button2.Name = "button2";
            button2.Size = new Size(827, 51);
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
            button1.Location = new Point(12, 362);
            button1.Name = "button1";
            button1.Size = new Size(827, 51);
            button1.TabIndex = 31;
            button1.Text = "REGISTER NOW!";
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
            showpassword.Location = new Point(651, 238);
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
            textPassword.Location = new Point(457, 97);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(372, 30);
            textPassword.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(457, 66);
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
            textUsername.Size = new Size(372, 30);
            textUsername.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(156, 28);
            label2.TabIndex = 26;
            label2.Text = "CompanyName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.Font = new Font("MS UI Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(431, 40);
            label1.TabIndex = 25;
            label1.Text = "Register Your Company";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(128, 64, 64);
            label4.Location = new Point(12, 130);
            label4.Name = "label4";
            label4.Size = new Size(242, 28);
            label4.TabIndex = 36;
            label4.Text = "(Full Name of Company)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.FromArgb(64, 0, 0);
            label10.Location = new Point(12, 178);
            label10.Name = "label10";
            label10.Size = new Size(64, 28);
            label10.TabIndex = 41;
            label10.Text = "Email";
            // 
            // cloudid
            // 
            cloudid.BackColor = Color.RosyBrown;
            cloudid.BorderStyle = BorderStyle.None;
            cloudid.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cloudid.Location = new Point(12, 209);
            cloudid.Name = "cloudid";
            cloudid.Size = new Size(372, 30);
            cloudid.TabIndex = 42;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.FromArgb(64, 0, 0);
            label13.Location = new Point(457, 178);
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
            textcomPassword.Location = new Point(457, 209);
            textcomPassword.Name = "textcomPassword";
            textcomPassword.PasswordChar = '*';
            textcomPassword.Size = new Size(372, 30);
            textcomPassword.TabIndex = 47;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 63);
            panel1.TabIndex = 48;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.FromArgb(128, 64, 64);
            label11.Location = new Point(12, 242);
            label11.Name = "label11";
            label11.Size = new Size(222, 28);
            label11.TabIndex = 43;
            label11.Text = "(e.g abcd@gmail.com)";
            // 
            // contactno
            // 
            contactno.BackColor = Color.RosyBrown;
            contactno.BorderStyle = BorderStyle.None;
            contactno.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactno.Location = new Point(12, 317);
            contactno.Name = "contactno";
            contactno.Size = new Size(372, 30);
            contactno.TabIndex = 50;
            contactno.TextChanged += contactno_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(12, 286);
            label7.Name = "label7";
            label7.Size = new Size(119, 28);
            label7.TabIndex = 51;
            label7.Text = "Contact No";
            // 
            // CompanyRegister
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 538);
            Controls.Add(label7);
            Controls.Add(contactno);
            Controls.Add(textcomPassword);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(cloudid);
            Controls.Add(label10);
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
            Name = "CompanyRegister";
            RightToLeftLayout = true;
            Text = "a";
            Load += CompanyRegister_Load;
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
        private Label label10;
        private TextBox cloudid;
        private Label label13;
        private TextBox textcomPassword;
        private Panel panel1;
        private Label label11;
        private TextBox contactno;
        private Label label7;
    }
}
