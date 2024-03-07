namespace CollegeInformationSystem
{
    partial class login_form
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            picturebox_wave = new PictureBox();
            login_label = new Label();
            email_label = new Label();
            password_label = new Label();
            email = new RichTextBox();
            login_btn = new Button();
            reset_password_link = new LinkLabel();
            register_link = new LinkLabel();
            password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturebox_wave).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.svgviewer_png_output;
            pictureBox1.Location = new Point(-5, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 116);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // picturebox_wave
            // 
            picturebox_wave.Image = Properties.Resources.svgviewer_png_output;
            picturebox_wave.Location = new Point(-4, -14);
            picturebox_wave.Name = "picturebox_wave";
            picturebox_wave.Size = new Size(502, 90);
            picturebox_wave.TabIndex = 0;
            picturebox_wave.TabStop = false;
            picturebox_wave.Click += picturebox_wave_Click;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            login_label.Location = new Point(196, 117);
            login_label.Name = "login_label";
            login_label.Size = new Size(101, 38);
            login_label.TabIndex = 1;
            login_label.Text = "Login";
            login_label.Click += label2_Click;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            email_label.Location = new Point(90, 205);
            email_label.Name = "email_label";
            email_label.Size = new Size(141, 28);
            email_label.TabIndex = 2;
            email_label.Text = "  Email address";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            password_label.Location = new Point(90, 282);
            password_label.Name = "password_label";
            password_label.Size = new Size(103, 28);
            password_label.TabIndex = 3;
            password_label.Text = "  Password";
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(103, 238);
            email.Name = "email";
            email.Size = new Size(292, 33);
            email.TabIndex = 6;
            email.Text = "";
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.InactiveCaption;
            login_btn.BackgroundImage = Properties.Resources.bg_btn;
            login_btn.BackgroundImageLayout = ImageLayout.Stretch;
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(185, 424);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(122, 45);
            login_btn.TabIndex = 8;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // reset_password_link
            // 
            reset_password_link.ActiveLinkColor = SystemColors.ButtonFace;
            reset_password_link.AutoSize = true;
            reset_password_link.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            reset_password_link.LinkColor = Color.Black;
            reset_password_link.Location = new Point(101, 353);
            reset_password_link.Name = "reset_password_link";
            reset_password_link.Size = new Size(112, 19);
            reset_password_link.TabIndex = 9;
            reset_password_link.TabStop = true;
            reset_password_link.Text = "Forgot Password";
            reset_password_link.VisitedLinkColor = SystemColors.ButtonFace;
            reset_password_link.LinkClicked += reset_password_link_LinkClicked;
            // 
            // register_link
            // 
            register_link.ActiveLinkColor = SystemColors.ButtonFace;
            register_link.AutoSize = true;
            register_link.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            register_link.LinkColor = Color.Black;
            register_link.Location = new Point(289, 65);
            register_link.Name = "register_link";
            register_link.Size = new Size(170, 21);
            register_link.TabIndex = 11;
            register_link.TabStop = true;
            register_link.Text = "I don't have an account";
            register_link.VisitedLinkColor = SystemColors.ButtonFace;
            register_link.LinkClicked += register_link_LinkClicked;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(103, 313);
            password.Name = "password";
            password.PasswordChar = '•';
            password.Size = new Size(292, 34);
            password.TabIndex = 12;
            // 
            // login_form
            // 
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(484, 552);
            Controls.Add(password);
            Controls.Add(register_link);
            Controls.Add(reset_password_link);
            Controls.Add(login_btn);
            Controls.Add(email);
            Controls.Add(password_label);
            Controls.Add(email_label);
            Controls.Add(login_label);
            Controls.Add(picturebox_wave);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "login_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += login_form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturebox_wave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox picturebox_wave;
        private Label login_label;
        private Label email_label;
        private Label password_label;
        private RichTextBox email;
        private Button login_btn;
        private LinkLabel reset_password_link;
        private LinkLabel register_link;
        private TextBox password;
    }
}