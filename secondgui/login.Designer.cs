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
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            textPassword = new TextBox();
            showpassword = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(580, 482);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(183, 28);
            label6.TabIndex = 23;
            label6.Text = "Create an account";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(128, 64, 64);
            label5.Location = new Point(561, 454);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(225, 28);
            label5.TabIndex = 22;
            label5.Text = "Don't have an account";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(520, 381);
            button2.Name = "button2";
            button2.Size = new Size(325, 51);
            button2.TabIndex = 21;
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
            button1.Location = new Point(520, 314);
            button1.Name = "button1";
            button1.Size = new Size(325, 51);
            button1.TabIndex = 20;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 64, 64);
            label3.Location = new Point(514, 141);
            label3.Name = "label3";
            label3.Size = new Size(129, 32);
            label3.TabIndex = 15;
            label3.Text = "Password:";
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.RosyBrown;
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.Location = new Point(520, 81);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(325, 30);
            textUsername.TabIndex = 14;
            textUsername.TextChanged += textUsername_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 64, 64);
            label2.Location = new Point(514, 46);
            label2.Name = "label2";
            label2.Size = new Size(142, 32);
            label2.TabIndex = 13;
            label2.Text = "Student ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(45, 266);
            label1.Name = "label1";
            label1.Size = new Size(344, 71);
            label1.TabIndex = 12;
            label1.Text = "STUDENT LOGIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -7);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 641);
            panel1.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Myanmar Text", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(127, 321);
            label4.Name = "label4";
            label4.Size = new Size(182, 71);
            label4.TabIndex = 13;
            label4.Text = "PORTAL";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            textPassword.BackColor = Color.RosyBrown;
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(520, 178);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(325, 30);
            textPassword.TabIndex = 30;
            // 
            // showpassword
            // 
            showpassword.AutoSize = true;
            showpassword.BackColor = SystemColors.Control;
            showpassword.Cursor = Cursors.Hand;
            showpassword.FlatStyle = FlatStyle.Flat;
            showpassword.ForeColor = Color.FromArgb(128, 64, 64);
            showpassword.Location = new Point(667, 226);
            showpassword.Name = "showpassword";
            showpassword.Size = new Size(178, 32);
            showpassword.TabIndex = 31;
            showpassword.Text = "Show Password";
            showpassword.UseVisualStyleBackColor = false;
            showpassword.CheckedChanged += showpassword_CheckedChanged;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(903, 633);
            Controls.Add(showpassword);
            Controls.Add(textPassword);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(255, 192, 128);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button2;
        private Button button1;
        private Label label3;
        private TextBox textUsername;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
        private TextBox textPassword;
        private CheckBox showpassword;
        private Label label4;
    }
}