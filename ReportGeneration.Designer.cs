namespace CollegeInformationSystem
{
    partial class ReportGeneration
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
            dataGridView1 = new DataGridView();
            export = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(281, 23);
            label1.TabIndex = 0;
            label1.Text = "Report on Students Enrolled";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(738, 299);
            dataGridView1.TabIndex = 1;
            // 
            // export
            // 
            export.BackColor = SystemColors.InactiveCaption;
            export.BackgroundImage = Properties.Resources.bg_btn;
            export.BackgroundImageLayout = ImageLayout.Stretch;
            export.FlatStyle = FlatStyle.Popup;
            export.Font = new Font("SansSerif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            export.ForeColor = Color.White;
            export.Location = new Point(496, 376);
            export.Name = "export";
            export.Size = new Size(122, 45);
            export.TabIndex = 2;
            export.Text = "EXPORT";
            export.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.BackgroundImage = Properties.Resources.bg_btn;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("SansSerif", 13F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(641, 376);
            button1.Name = "button1";
            button1.Size = new Size(122, 45);
            button1.TabIndex = 3;
            button1.Text = "GO BACK";
            button1.UseVisualStyleBackColor = false;
            // 
            // ReportGeneration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(export);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ReportGeneration";
            Text = "Report Generation";
            Load += ReportGeneration_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button export;
        private Button button1;
    }
}