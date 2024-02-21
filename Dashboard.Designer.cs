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
            show_campuses = new Button();
            show_passed_students = new Button();
            dataGridView1 = new DataGridView();
            edit_student = new Button();
            label1 = new Label();
            generate_report = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // show_campuses
            // 
            show_campuses.BackColor = SystemColors.InactiveCaption;
            show_campuses.BackgroundImage = Properties.Resources.bg_btn;
            show_campuses.BackgroundImageLayout = ImageLayout.Stretch;
            show_campuses.Cursor = Cursors.Hand;
            show_campuses.FlatAppearance.BorderSize = 0;
            show_campuses.FlatStyle = FlatStyle.Flat;
            show_campuses.Font = new Font("SansSerif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            show_campuses.ForeColor = Color.White;
            show_campuses.Location = new Point(25, 376);
            show_campuses.Name = "show_campuses";
            show_campuses.Size = new Size(174, 45);
            show_campuses.TabIndex = 0;
            show_campuses.Text = "SHOW CAMPUSES";
            show_campuses.UseVisualStyleBackColor = false;
            // 
            // show_passed_students
            // 
            show_passed_students.BackColor = SystemColors.InactiveCaption;
            show_passed_students.BackgroundImage = Properties.Resources.bg_btn;
            show_passed_students.BackgroundImageLayout = ImageLayout.Stretch;
            show_passed_students.Cursor = Cursors.Hand;
            show_passed_students.FlatAppearance.BorderSize = 0;
            show_passed_students.FlatStyle = FlatStyle.Flat;
            show_passed_students.Font = new Font("SansSerif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            show_passed_students.ForeColor = Color.White;
            show_passed_students.Location = new Point(399, 376);
            show_passed_students.Name = "show_passed_students";
            show_passed_students.Size = new Size(174, 45);
            show_passed_students.TabIndex = 1;
            show_passed_students.Text = "SHOW PASSED STUDENTS";
            show_passed_students.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(738, 299);
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
            edit_student.Font = new Font("SansSerif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            edit_student.ForeColor = Color.White;
            edit_student.Location = new Point(212, 376);
            edit_student.Name = "edit_student";
            edit_student.Size = new Size(174, 45);
            edit_student.TabIndex = 3;
            edit_student.Text = "EDIT A STUDENT";
            edit_student.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
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
            generate_report.Font = new Font("SansSerif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            generate_report.ForeColor = Color.White;
            generate_report.Location = new Point(589, 376);
            generate_report.Name = "generate_report";
            generate_report.Size = new Size(174, 45);
            generate_report.TabIndex = 5;
            generate_report.Text = "GENERATE REPORT";
            generate_report.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(generate_report);
            Controls.Add(label1);
            Controls.Add(edit_student);
            Controls.Add(dataGridView1);
            Controls.Add(show_passed_students);
            Controls.Add(show_campuses);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button show_campuses;
        private Button show_passed_students;
        private DataGridView dataGridView1;
        private Button edit_student;
        private Label label1;
        private Button generate_report;
    }
}