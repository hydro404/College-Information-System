namespace CollegeInformationSystem
{
    partial class register_form
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
            register_label = new Label();
            email_label = new Label();
            email = new RichTextBox();
            password = new RichTextBox();
            password_label = new Label();
            confirm_password = new RichTextBox();
            label2 = new Label();
            register_btn = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.svgviewer_png_output;
            pictureBox1.Location = new Point(-4, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(502, 92);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.Font = new Font("SansSerif", 24.75F, FontStyle.Bold, GraphicsUnit.Point);
            register_label.Location = new Point(173, 95);
            register_label.Name = "register_label";
            register_label.Size = new Size(148, 38);
            register_label.TabIndex = 1;
            register_label.Text = "Register";
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
            confirm_password.Location = new Point(103, 354);
            confirm_password.Name = "confirm_password";
            confirm_password.Size = new Size(292, 33);
            confirm_password.TabIndex = 7;
            confirm_password.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SansSerif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 319);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 6;
            label2.Text = "  Confirm Password";
            // 
            // register_btn
            // 
            register_btn.BackColor = SystemColors.InactiveCaption;
            register_btn.BackgroundImage = Properties.Resources.bg_btn;
            register_btn.BackgroundImageLayout = ImageLayout.Stretch;
            register_btn.FlatStyle = FlatStyle.Popup;
            register_btn.Font = new Font("SansSerif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            register_btn.ForeColor = Color.White;
            register_btn.Location = new Point(183, 404);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(122, 45);
            register_btn.TabIndex = 8;
            register_btn.Text = "REGISTER";
            register_btn.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("SansSerif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(291, 63);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(176, 17);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "I already have an account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // register_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(484, 461);
            Controls.Add(linkLabel1);
            Controls.Add(register_btn);
            Controls.Add(confirm_password);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(password_label);
            Controls.Add(email);
            Controls.Add(email_label);
            Controls.Add(register_label);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "register_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label register_label;
        private Label email_label;
        private RichTextBox email;
        private RichTextBox password;
        private Label password_label;
        private RichTextBox confirm_password;
        private Label label2;
        private Button register_btn;
        private LinkLabel linkLabel1;
    }
}