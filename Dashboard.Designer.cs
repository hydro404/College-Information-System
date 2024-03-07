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
            dataGridView1 = new DataGridView();
            save_changes = new Button();
            label1 = new Label();
            generate_report = new Button();
            add_student = new Button();
            delete_student = new Button();
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
            show_campuses.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            show_campuses.ForeColor = Color.White;
            show_campuses.Location = new Point(25, 376);
            show_campuses.Name = "show_campuses";
            show_campuses.Size = new Size(125, 45);
            show_campuses.TabIndex = 0;
            show_campuses.Text = "SHOW CAMPUSES";
            show_campuses.UseVisualStyleBackColor = false;
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
            // save_changes
            // 
            save_changes.BackColor = SystemColors.InactiveCaption;
            save_changes.BackgroundImage = Properties.Resources.bg_btn;
            save_changes.BackgroundImageLayout = ImageLayout.Stretch;
            save_changes.Cursor = Cursors.Hand;
            save_changes.FlatAppearance.BorderSize = 0;
            save_changes.FlatStyle = FlatStyle.Flat;
            save_changes.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            save_changes.ForeColor = Color.White;
            save_changes.Location = new Point(332, 376);
            save_changes.Name = "save_changes";
            save_changes.Size = new Size(125, 45);
            save_changes.TabIndex = 3;
            save_changes.Text = "SAVE CHANGES";
            save_changes.UseVisualStyleBackColor = false;
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
            generate_report.Location = new Point(638, 376);
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
            add_student.Location = new Point(179, 376);
            add_student.Name = "add_student";
            add_student.Size = new Size(125, 45);
            add_student.TabIndex = 6;
            add_student.Text = "ADD A STUDENT";
            add_student.UseVisualStyleBackColor = false;
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
            delete_student.Location = new Point(487, 376);
            delete_student.Name = "delete_student";
            delete_student.Size = new Size(125, 45);
            delete_student.TabIndex = 7;
            delete_student.Text = "DELETE A STUDENT";
            delete_student.UseVisualStyleBackColor = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(delete_student);
            Controls.Add(add_student);
            Controls.Add(generate_report);
            Controls.Add(label1);
            Controls.Add(save_changes);
            Controls.Add(dataGridView1);
            Controls.Add(show_campuses);
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

        private Button show_campuses;
        private DataGridView dataGridView1;
        private Button save_changes;
        private Label label1;
        private Button generate_report;
        private Button add_student;
        private Button delete_student;
    }
}