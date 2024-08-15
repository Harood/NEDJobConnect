namespace registration_login_system
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">bool value indicating whether managed resources should be disposed; otherwise, false.</param>
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new RoundedPanel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel2 = new RoundedPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(11, 22);
            label1.Name = "label1";
            label1.Size = new Size(577, 46);
            label1.TabIndex = 0;
            label1.Text = "Welcome to NEDJobConnect!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(199, 82);
            label2.Name = "label2";
            label2.Size = new Size(389, 32);
            label2.TabIndex = 1;
            label2.Text = "\"Unlock Your Future Today\"";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.BorderRadius = 30;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 151);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Bisque;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.NEDUET_logo_svg;
            pictureBox1.Location = new Point(636, 381);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Bisque;
            label3.Font = new Font("Arial", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(111, 209);
            label3.Name = "label3";
            label3.Size = new Size(517, 32);
            label3.TabIndex = 3;
            label3.Text = "Join Us as a Job Seeker or Recruiter!";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(234, 288);
            button1.Name = "button1";
            button1.Size = new Size(272, 45);
            button1.TabIndex = 5;
            button1.Text = "STUDENT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(64, 0, 0);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(234, 366);
            button2.Name = "button2";
            button2.Size = new Size(272, 45);
            button2.TabIndex = 7;
            button2.Text = "COMPANY";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MistyRose;
            panel2.BorderRadius = 30;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(270, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 514);
            panel2.TabIndex = 9;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_338908724_8Tfiyb0T3fd5Onk649ZrLUD9mHudWiJV;
            ClientSize = new Size(1278, 644);
            Controls.Add(panel2);
            Name = "Mainform";
            Text = "Mainform";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private RoundedPanel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
        private Button button2;
        private RoundedPanel panel2;
    }
}
