namespace CollegeInformationSystem
{
    partial class Dashboard
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
            dataGridView1 = new DataGridView();
            edit_student = new Button();
            label1 = new Label();
            generate_report = new Button();
            add_student = new Button();
            delete_student = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(719, 299);
            dataGridView1.TabIndex = 2;
            // 
            // edit_student
            // 
            edit_student.BackColor = SystemColors.InactiveCaption;
            edit_student.BackgroundImage = Properties.Resources.bg_btn;
            edit_student.BackgroundImageLayout = ImageLayout.Stretch;
            edit_student.Cursor = Cursors.Hand;
            edit_student.FlatAppearance.BorderSize = 0;
            edit_student.FlatStyle = FlatStyle.Flat;
            edit_student.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            edit_student.ForeColor = Color.White;
            edit_student.Location = new Point(166, 376);
            edit_student.Name = "edit_student";
            edit_student.Size = new Size(125, 45);
            edit_student.TabIndex = 3;
            edit_student.Text = "EDIT A STUDENT";
            edit_student.UseVisualStyleBackColor = false;
            edit_student.Click += save_changes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 4;
            label1.Text = "Hello, Admin!";
            // 
            // generate_report
            // 
            generate_report.BackColor = SystemColors.InactiveCaption;
            generate_report.BackgroundImage = Properties.Resources.bg_btn;
            generate_report.BackgroundImageLayout = ImageLayout.Stretch;
            generate_report.Cursor = Cursors.Hand;
            generate_report.FlatAppearance.BorderSize = 0;
            generate_report.FlatStyle = FlatStyle.Flat;
            generate_report.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            generate_report.ForeColor = Color.White;
            generate_report.Location = new Point(629, 10);
            generate_report.Name = "generate_report";
            generate_report.Size = new Size(125, 45);
            generate_report.TabIndex = 5;
            generate_report.Text = "GENERATE REPORT";
            generate_report.UseVisualStyleBackColor = false;
            // 
            // add_student
            // 
            add_student.BackColor = SystemColors.InactiveCaption;
            add_student.BackgroundImage = Properties.Resources.bg_btn;
            add_student.BackgroundImageLayout = ImageLayout.Stretch;
            add_student.Cursor = Cursors.Hand;
            add_student.FlatAppearance.BorderSize = 0;
            add_student.FlatStyle = FlatStyle.Flat;
            add_student.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            add_student.ForeColor = Color.White;
            add_student.Location = new Point(35, 376);
            add_student.Name = "add_student";
            add_student.Size = new Size(125, 45);
            add_student.TabIndex = 6;
            add_student.Text = "ADD A STUDENT";
            add_student.UseVisualStyleBackColor = false;
            add_student.Click += add_student_Click;
            // 
            // delete_student
            // 
            delete_student.BackColor = SystemColors.InactiveCaption;
            delete_student.BackgroundImage = Properties.Resources.bg_btn;
            delete_student.BackgroundImageLayout = ImageLayout.Stretch;
            delete_student.Cursor = Cursors.Hand;
            delete_student.FlatAppearance.BorderSize = 0;
            delete_student.FlatStyle = FlatStyle.Flat;
            delete_student.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            delete_student.ForeColor = Color.White;
            delete_student.Location = new Point(297, 376);
            delete_student.Name = "delete_student";
            delete_student.Size = new Size(125, 45);
            delete_student.TabIndex = 7;
            delete_student.Text = "DELETE A STUDENT";
            delete_student.UseVisualStyleBackColor = false;
            delete_student.Click += delete_student_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.BackgroundImage = Properties.Resources.bg_btn;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(629, 376);
            button1.Name = "button1";
            button1.Size = new Size(125, 45);
            button1.TabIndex = 8;
            button1.Text = "LOGOUT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(delete_student);
            Controls.Add(add_student);
            Controls.Add(generate_report);
            Controls.Add(label1);
            Controls.Add(edit_student);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button edit_student;
        private Label label1;
        private Button generate_report;
        private Button add_student;
        private Button delete_student;
        private Button button1;
    }
}