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
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            fname = new Label();
            label2 = new Label();
            lname = new RichTextBox();
            select_campus_combobox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            add_btn = new Button();
            cancel_btn = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(26, 118);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(201, 33);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(299, 26);
            label1.Name = "label1";
            label1.Size = new Size(245, 39);
            label1.TabIndex = 1;
            label1.Text = "Add a Student";
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            fname.Location = new Point(12, 87);
            fname.Name = "fname";
            fname.Size = new Size(116, 28);
            fname.TabIndex = 3;
            fname.Text = "  First Name";
            fname.Click += email_label_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(231, 87);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 5;
            label2.Text = "  Last Name";
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
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(26, 208);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(306, 33);
            comboBox1.TabIndex = 8;
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
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(469, 208);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(306, 33);
            comboBox2.TabIndex = 10;
            // 
            // add_btn
            // 
            add_btn.BackgroundImage = Properties.Resources.bg_btn;
            add_btn.BackgroundImageLayout = ImageLayout.Stretch;
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
            // 
            // cancel_btn
            // 
            cancel_btn.BackgroundImage = Properties.Resources.bg_btn;
            cancel_btn.BackgroundImageLayout = ImageLayout.Stretch;
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
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(select_campus_combobox);
            Controls.Add(label2);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "AddStudent";
            Text = "AddStudent";
            Load += AddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label1;
        private Label fname;
        private Label label2;
        private RichTextBox lname;
        private ComboBox select_campus_combobox;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private ComboBox comboBox2;
        private Button add_btn;
        private Button cancel_btn;
    }
}