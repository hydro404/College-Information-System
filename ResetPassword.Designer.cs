namespace CollegeInformationSystem
{
    partial class ResetPassword
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
            pictureBox1 = new PictureBox();
            reset_password_label = new Label();
            email_label = new Label();
            email = new RichTextBox();
            password = new RichTextBox();
            password_label = new Label();
            confirm_password = new RichTextBox();
            confirm_password_label = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.svgviewer_png_output;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 90);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // reset_password_label
            // 
            reset_password_label.AutoSize = true;
            reset_password_label.Font = new Font("SansSerif", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            reset_password_label.Location = new Point(112, 92);
            reset_password_label.Name = "reset_password_label";
            reset_password_label.Size = new Size(270, 38);
            reset_password_label.TabIndex = 1;
            reset_password_label.Text = "Reset Password";
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("SansSerif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            email_label.Location = new Point(90, 158);
            email_label.Name = "email_label";
            email_label.Size = new Size(134, 21);
            email_label.TabIndex = 2;
            email_label.Text = "  Email address";
            // 
            // email
            // 
            email.Location = new Point(103, 193);
            email.Name = "email";
            email.Size = new Size(292, 33);
            email.TabIndex = 3;
            email.Text = "";
            // 
            // password
            // 
            password.Location = new Point(103, 274);
            password.Name = "password";
            password.Size = new Size(292, 33);
            password.TabIndex = 5;
            password.Text = "";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("SansSerif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            password_label.Location = new Point(90, 239);
            password_label.Name = "password_label";
            password_label.Size = new Size(99, 21);
            password_label.TabIndex = 4;
            password_label.Text = "  Password";
            // 
            // confirm_password
            // 
            confirm_password.Location = new Point(103, 352);
            confirm_password.Name = "confirm_password";
            confirm_password.Size = new Size(292, 33);
            confirm_password.TabIndex = 7;
            confirm_password.Text = "";
            // 
            // confirm_password_label
            // 
            confirm_password_label.AutoSize = true;
            confirm_password_label.Font = new Font("SansSerif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_password_label.Location = new Point(90, 317);
            confirm_password_label.Name = "confirm_password_label";
            confirm_password_label.Size = new Size(167, 21);
            confirm_password_label.TabIndex = 6;
            confirm_password_label.Text = "  Confirm Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.BackgroundImage = Properties.Resources.bg_btn;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("SansSerif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(184, 394);
            button1.Name = "button1";
            button1.Size = new Size(122, 45);
            button1.TabIndex = 8;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(484, 461);
            Controls.Add(button1);
            Controls.Add(confirm_password);
            Controls.Add(confirm_password_label);
            Controls.Add(password);
            Controls.Add(password_label);
            Controls.Add(email);
            Controls.Add(email_label);
            Controls.Add(reset_password_label);
            Controls.Add(pictureBox1);
            Name = "ResetPassword";
            Text = "Reset Password";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label reset_password_label;
        private Label email_label;
        private RichTextBox email;
        private RichTextBox password;
        private Label password_label;
        private RichTextBox confirm_password;
        private Label confirm_password_label;
        private Button button1;
    }
}