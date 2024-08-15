namespace secondgui
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            textUsername = new TextBox();
            label2 = new Label();
            button3 = new Button();
            textPassword = new TextBox();
            showpassword = new CheckBox();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label7 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.PeachPuff;
            label6.Location = new Point(209, 579);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(220, 32);
            label6.TabIndex = 23;
            label6.Text = "Create an account";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.MistyRose;
            label5.Location = new Point(160, 541);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(323, 38);
            label5.TabIndex = 22;
            label5.Text = "?Don't have an account";
            // 
            // button2
            // 
            button2.BackColor = Color.MistyRose;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(148, 461);
            button2.Name = "button2";
            button2.Size = new Size(350, 59);
            button2.TabIndex = 21;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Location = new Point(148, 380);
            button1.Name = "button1";
            button1.Size = new Size(350, 60);
            button1.TabIndex = 20;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.PeachPuff;
            label3.Location = new Point(52, 147);
            label3.Name = "label3";
            label3.Size = new Size(147, 38);
            label3.TabIndex = 15;
            label3.Text = "Password:";
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.MistyRose;
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("MS UI Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(65, 88);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(506, 40);
            textUsername.TabIndex = 14;
            textUsername.TextChanged += textUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.PeachPuff;
            label2.Location = new Point(52, 33);
            label2.Name = "label2";
            label2.Size = new Size(166, 38);
            label2.TabIndex = 13;
            label2.Text = "Student ID:";
            // 
            // button3
            // 
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.MistyRose;
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Cursor = Cursors.Hand;
            textPassword.Font = new Font("MS UI Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(65, 202);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(506, 40);
            textPassword.TabIndex = 30;
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.BackColor = Color.FromArgb(64, 0, 0);
            showpassword.Cursor = Cursors.Hand;
            showpassword.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showpassword.ForeColor = Color.MistyRose;
            showpassword.Location = new Point(360, 257);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(216, 36);
            showpassword.TabIndex = 31;
            showpassword.Text = "Show Password";
            showpassword.UseVisualStyleBackColor = false;
            showpassword.CheckedChanged += showpassword_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textPassword);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textUsername);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(showpassword);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(639, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(663, 700);
            panel2.TabIndex = 32;
            // 
            // label1
            // 
            label1.Font = new Font("Myanmar Text", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(3, 284);
            label1.Name = "label1";
            label1.Size = new Size(619, 108);
            label1.TabIndex = 12;
            label1.Text = "STUDENT LOGIN PORTAL\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MistyRose;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(191, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = registration_login_system.Properties.Resources._130850;
            pictureBox2.Location = new Point(355, 625);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(436, 640);
            label7.Name = "label7";
            label7.Size = new Size(202, 38);
            label7.TabIndex = 32;
            label7.Text = "Back to Home";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 700);
            panel1.TabIndex = 24;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = registration_login_system.Properties.Resources._360_F_338908724_8Tfiyb0T3fd5Onk649ZrLUD9mHudWiJV;
            ClientSize = new Size(1300, 700);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(255, 192, 128);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button2;
        private Button button1;
        private Label label3;
        private TextBox textUsername;
        private Label label2;
        private Button button3;
        private TextBox textPassword;
        private CheckBox showpassword;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label7;
        private Panel panel1;
    }
}