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
            password_label = new Label();
            confirm_password_label = new Label();
            button1 = new Button();
            login_link = new LinkLabel();
            register_link = new LinkLabel();
            password = new TextBox();
            confirm_password = new TextBox();
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
            reset_password_label.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            reset_password_label.Location = new Point(113, 136);
            reset_password_label.Name = "reset_password_label";
            reset_password_label.Size = new Size(271, 38);
            reset_password_label.TabIndex = 1;
            reset_password_label.Text = "Reset Password";
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            email_label.Location = new Point(90, 203);
            email_label.Name = "email_label";
            email_label.Size = new Size(133, 22);
            email_label.TabIndex = 2;
            email_label.Text = "  Email address";
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(103, 238);
            email.Name = "email";
            email.Size = new Size(292, 33);
            email.TabIndex = 3;
            email.Text = "";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            password_label.Location = new Point(90, 284);
            password_label.Name = "password_label";
            password_label.Size = new Size(99, 22);
            password_label.TabIndex = 4;
            password_label.Text = "  Password";
            // 
            // confirm_password_label
            // 
            confirm_password_label.AutoSize = true;
            confirm_password_label.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_password_label.Location = new Point(90, 362);
            confirm_password_label.Name = "confirm_password_label";
            confirm_password_label.Size = new Size(166, 22);
            confirm_password_label.TabIndex = 6;
            confirm_password_label.Text = "  Confirm Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.BackgroundImage = Properties.Resources.bg_btn;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(181, 450);
            button1.Name = "button1";
            button1.Size = new Size(122, 45);
            button1.TabIndex = 8;
            button1.Text = "CONFIRM";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // login_link
            // 
            login_link.AutoSize = true;
            login_link.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            login_link.LinkColor = Color.Black;
            login_link.Location = new Point(280, 74);
            login_link.Name = "login_link";
            login_link.Size = new Size(61, 28);
            login_link.TabIndex = 9;
            login_link.TabStop = true;
            login_link.Text = "Login";
            login_link.LinkClicked += login_link_LinkClicked;
            // 
            // register_link
            // 
            register_link.AutoSize = true;
            register_link.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            register_link.LinkColor = SystemColors.ActiveCaptionText;
            register_link.Location = new Point(376, 74);
            register_link.Name = "register_link";
            register_link.Size = new Size(82, 28);
            register_link.TabIndex = 10;
            register_link.TabStop = true;
            register_link.Text = "Register";
            register_link.LinkClicked += register_link_LinkClicked;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(104, 317);
            password.Name = "password";
            password.PasswordChar = '•';
            password.Size = new Size(291, 34);
            password.TabIndex = 11;
            // 
            // confirm_password
            // 
            confirm_password.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            confirm_password.Location = new Point(104, 387);
            confirm_password.Name = "confirm_password";
            confirm_password.PasswordChar = '•';
            confirm_password.Size = new Size(291, 34);
            confirm_password.TabIndex = 12;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(484, 552);
            Controls.Add(confirm_password);
            Controls.Add(password);
            Controls.Add(register_link);
            Controls.Add(login_link);
            Controls.Add(button1);
            Controls.Add(confirm_password_label);
            Controls.Add(password_label);
            Controls.Add(email);
            Controls.Add(email_label);
            Controls.Add(reset_password_label);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reset Password";
            Load += ResetPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label reset_password_label;
        private Label email_label;
        private RichTextBox email;
        private Label password_label;
        private Label confirm_password_label;
        private Button button1;
        private LinkLabel login_link;
        private LinkLabel register_link;
        private TextBox password;
        private TextBox confirm_password;
    }
}