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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 0, 0);
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(11, 9);
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
            label2.Location = new Point(140, 70);
            label2.Name = "label2";
            label2.Size = new Size(389, 32);
            label2.TabIndex = 1;
            label2.Text = "\"Unlock Your Future Today\"";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(621, 172);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources.NEDUET_logo_svg;
            pictureBox1.Location = new Point(3, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLight;
            label3.Font = new Font("Arial", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(164, 215);
            label3.Name = "label3";
            label3.Size = new Size(272, 32);
            label3.TabIndex = 3;
            label3.Text = "Are you a Student?";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.FromArgb(64, 0, 0);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(164, 269);
            button1.Name = "button1";
            button1.Size = new Size(272, 45);
            button1.TabIndex = 5;
            button1.Text = "STUDENT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlLight;
            label5.Font = new Font("Arial", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(154, 434);
            label5.Name = "label5";
            label5.Size = new Size(296, 32);
            label5.TabIndex = 6;
            label5.Text = "Are you a Company?";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.FromArgb(64, 0, 0);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(164, 482);
            button2.Name = "button2";
            button2.Size = new Size(272, 45);
            button2.TabIndex = 7;
            button2.Text = "COMPANY";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Arial", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(267, 355);
            label4.Name = "label4";
            label4.Size = new Size(56, 32);
            label4.TabIndex = 8;
            label4.Text = "OR";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 631);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Mainform";
            Text = "Mainform";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button1;
        private Label label5;
        private Button button2;
        private Label label4;
    }
}