namespace CollegeInformationSystem
{
    partial class EditStudent
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
            label3 = new Label();
            select_student_combobox = new ComboBox();
            fname_label = new Label();
            fname = new RichTextBox();
            label2 = new Label();
            lname = new RichTextBox();
            label4 = new Label();
            select_campus_combobox = new ComboBox();
            label5 = new Label();
            select_department_combobox = new ComboBox();
            label6 = new Label();
            select_course_combobox = new ComboBox();
            label7 = new Label();
            gwa_input = new RichTextBox();
            add_btn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 39);
            label1.TabIndex = 2;
            label1.Text = "Edit a Student";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(-4, 65);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 9;
            label3.Text = "  Select Student";
            // 
            // select_student_combobox
            // 
            select_student_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            select_student_combobox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            select_student_combobox.FormattingEnabled = true;
            select_student_combobox.Location = new Point(10, 99);
            select_student_combobox.Name = "select_student_combobox";
            select_student_combobox.Size = new Size(253, 33);
            select_student_combobox.TabIndex = 8;
            select_student_combobox.SelectedIndexChanged += select_student_combobox_SelectedIndexChanged;
            // 
            // fname_label
            // 
            fname_label.AutoSize = true;
            fname_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            fname_label.Location = new Point(257, 65);
            fname_label.Name = "fname_label";
            fname_label.Size = new Size(116, 28);
            fname_label.TabIndex = 11;
            fname_label.Text = "  First Name";
            // 
            // fname
            // 
            fname.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            fname.Location = new Point(272, 99);
            fname.Name = "fname";
            fname.Size = new Size(253, 33);
            fname.TabIndex = 10;
            fname.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(522, 65);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 13;
            label2.Text = "  Last Name";
            // 
            // lname
            // 
            lname.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lname.Location = new Point(535, 99);
            lname.Name = "lname";
            lname.Size = new Size(253, 33);
            lname.TabIndex = 12;
            lname.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(-4, 145);
            label4.Name = "label4";
            label4.Size = new Size(149, 28);
            label4.TabIndex = 15;
            label4.Text = "  Select Campus";
            // 
            // select_campus_combobox
            // 
            select_campus_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            select_campus_combobox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            select_campus_combobox.FormattingEnabled = true;
            select_campus_combobox.Location = new Point(10, 179);
            select_campus_combobox.Name = "select_campus_combobox";
            select_campus_combobox.Size = new Size(363, 33);
            select_campus_combobox.TabIndex = 14;
            select_campus_combobox.SelectedIndexChanged += select_campus_combobox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(411, 145);
            label5.Name = "label5";
            label5.Size = new Size(184, 28);
            label5.TabIndex = 17;
            label5.Text = "  Select Department";
            // 
            // select_department_combobox
            // 
            select_department_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            select_department_combobox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            select_department_combobox.FormattingEnabled = true;
            select_department_combobox.Location = new Point(425, 179);
            select_department_combobox.Name = "select_department_combobox";
            select_department_combobox.Size = new Size(363, 33);
            select_department_combobox.TabIndex = 16;
            select_department_combobox.SelectedIndexChanged += select_department_combobox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(-2, 226);
            label6.Name = "label6";
            label6.Size = new Size(139, 28);
            label6.TabIndex = 19;
            label6.Text = "  Select Course";
            // 
            // select_course_combobox
            // 
            select_course_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            select_course_combobox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            select_course_combobox.FormattingEnabled = true;
            select_course_combobox.Location = new Point(12, 260);
            select_course_combobox.Name = "select_course_combobox";
            select_course_combobox.Size = new Size(363, 33);
            select_course_combobox.TabIndex = 18;
            select_course_combobox.SelectedIndexChanged += select_course_combobox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(411, 226);
            label7.Name = "label7";
            label7.Size = new Size(256, 28);
            label7.TabIndex = 21;
            label7.Text = "  General Weighted Average";
            // 
            // gwa_input
            // 
            gwa_input.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            gwa_input.Location = new Point(425, 257);
            gwa_input.Name = "gwa_input";
            gwa_input.Size = new Size(358, 33);
            gwa_input.TabIndex = 20;
            gwa_input.Text = "";
            // 
            // add_btn
            // 
            add_btn.BackgroundImage = Properties.Resources.bg_btn;
            add_btn.BackgroundImageLayout = ImageLayout.Stretch;
            add_btn.Cursor = Cursors.Hand;
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatStyle = FlatStyle.Flat;
            add_btn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            add_btn.ForeColor = SystemColors.ButtonHighlight;
            add_btn.Location = new Point(666, 334);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(122, 45);
            add_btn.TabIndex = 22;
            add_btn.Text = "SAVE";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.bg_btn;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(522, 334);
            button1.Name = "button1";
            button1.Size = new Size(122, 45);
            button1.TabIndex = 23;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 391);
            Controls.Add(button1);
            Controls.Add(add_btn);
            Controls.Add(label7);
            Controls.Add(gwa_input);
            Controls.Add(label6);
            Controls.Add(select_course_combobox);
            Controls.Add(label5);
            Controls.Add(select_department_combobox);
            Controls.Add(label4);
            Controls.Add(select_campus_combobox);
            Controls.Add(label2);
            Controls.Add(lname);
            Controls.Add(fname_label);
            Controls.Add(fname);
            Controls.Add(label3);
            Controls.Add(select_student_combobox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "EditStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            Load += EditStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private ComboBox select_student_combobox;
        private Label fname_label;
        private RichTextBox fname;
        private Label label2;
        private RichTextBox lname;
        private Label label4;
        private ComboBox select_campus_combobox;
        private Label label5;
        private ComboBox select_department_combobox;
        private Label label6;
        private ComboBox select_course_combobox;
        private Label label7;
        private RichTextBox gwa_input;
        private Button add_btn;
        private Button button1;
    }
}