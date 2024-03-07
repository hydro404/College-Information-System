namespace CollegeInformationSystem
{
    partial class AddStudent
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
            fname = new RichTextBox();
            label1 = new Label();
            fname_label = new Label();
            lname_label = new Label();
            lname = new RichTextBox();
            select_campus_combobox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            select_department_combobox = new ComboBox();
            label5 = new Label();
            select_course_combobox = new ComboBox();
            add_btn = new Button();
            cancel_btn = new Button();
            SuspendLayout();
            // 
            // fname
            // 
            fname.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            fname.Location = new Point(26, 118);
            fname.Name = "fname";
            fname.Size = new Size(201, 33);
            fname.TabIndex = 0;
            fname.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(285, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 39);
            label1.TabIndex = 1;
            label1.Text = "Add a Student";
            // 
            // fname_label
            // 
            fname_label.AutoSize = true;
            fname_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            fname_label.Location = new Point(12, 87);
            fname_label.Name = "fname_label";
            fname_label.Size = new Size(116, 28);
            fname_label.TabIndex = 3;
            fname_label.Text = "  First Name";
            fname_label.Click += email_label_Click;
            // 
            // lname_label
            // 
            lname_label.AutoSize = true;
            lname_label.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lname_label.Location = new Point(231, 87);
            lname_label.Name = "lname_label";
            lname_label.Size = new Size(113, 28);
            lname_label.TabIndex = 5;
            lname_label.Text = "  Last Name";
            // 
            // lname
            // 
            lname.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lname.Location = new Point(245, 118);
            lname.Name = "lname";
            lname.Size = new Size(201, 33);
            lname.TabIndex = 4;
            lname.Text = "";
            // 
            // select_campus_combobox
            // 
            select_campus_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            select_campus_combobox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            select_campus_combobox.FormattingEnabled = true;
            select_campus_combobox.Location = new Point(469, 118);
            select_campus_combobox.Name = "select_campus_combobox";
            select_campus_combobox.Size = new Size(306, 33);
            select_campus_combobox.TabIndex = 6;
            select_campus_combobox.SelectedValueChanged += select_campus_combobox_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(455, 84);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 7;
            label3.Text = "  Select Campus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 174);
            label4.Name = "label4";
            label4.Size = new Size(184, 28);
            label4.TabIndex = 9;
            label4.Text = "  Select Department";
            // 
            // select_department_combobox
            // 
            select_department_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            select_department_combobox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            select_department_combobox.FormattingEnabled = true;
            select_department_combobox.Location = new Point(26, 208);
            select_department_combobox.Name = "select_department_combobox";
            select_department_combobox.Size = new Size(306, 33);
            select_department_combobox.TabIndex = 8;
            select_department_combobox.SelectedIndexChanged += select_department_combobox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(455, 174);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 11;
            label5.Text = "  Select Course";
            // 
            // select_course_combobox
            // 
            select_course_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            select_course_combobox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            select_course_combobox.FormattingEnabled = true;
            select_course_combobox.Location = new Point(469, 208);
            select_course_combobox.Name = "select_course_combobox";
            select_course_combobox.Size = new Size(306, 33);
            select_course_combobox.TabIndex = 10;
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
            add_btn.Location = new Point(653, 291);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(122, 45);
            add_btn.TabIndex = 12;
            add_btn.Text = "SAVE";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // cancel_btn
            // 
            cancel_btn.BackgroundImage = Properties.Resources.bg_btn;
            cancel_btn.BackgroundImageLayout = ImageLayout.Stretch;
            cancel_btn.Cursor = Cursors.Hand;
            cancel_btn.FlatAppearance.BorderSize = 0;
            cancel_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            cancel_btn.ForeColor = SystemColors.ButtonHighlight;
            cancel_btn.Location = new Point(503, 291);
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(122, 45);
            cancel_btn.TabIndex = 13;
            cancel_btn.Text = "CANCEL";
            cancel_btn.UseVisualStyleBackColor = true;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 357);
            Controls.Add(cancel_btn);
            Controls.Add(add_btn);
            Controls.Add(label5);
            Controls.Add(select_course_combobox);
            Controls.Add(label4);
            Controls.Add(select_department_combobox);
            Controls.Add(label3);
            Controls.Add(select_campus_combobox);
            Controls.Add(lname_label);
            Controls.Add(lname);
            Controls.Add(fname_label);
            Controls.Add(label1);
            Controls.Add(fname);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddStudent";
            Load += AddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox fname;
        private Label label1;
        private Label fname_label;
        private Label lname_label;
        private RichTextBox lname;
        private ComboBox select_campus_combobox;
        private Label label3;
        private Label label4;
        private ComboBox select_department_combobox;
        private Label label5;
        private ComboBox select_course_combobox;
        private Button add_btn;
        private Button cancel_btn;
    }
}