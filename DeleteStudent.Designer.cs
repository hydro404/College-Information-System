namespace CollegeInformationSystem
{
    partial class DeleteStudent
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
            comboBox1 = new ComboBox();
            label3 = new Label();
            delete_btn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(69, 49);
            label1.Name = "label1";
            label1.Size = new Size(412, 39);
            label1.TabIndex = 3;
            label1.Text = "Delete a Student Record";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(148, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 33);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(134, 130);
            label3.Name = "label3";
            label3.Size = new Size(147, 28);
            label3.TabIndex = 10;
            label3.Text = "  Select Student";
            // 
            // delete_btn
            // 
            delete_btn.BackgroundImage = Properties.Resources.bg_btn;
            delete_btn.BackgroundImageLayout = ImageLayout.Stretch;
            delete_btn.Cursor = Cursors.Hand;
            delete_btn.FlatAppearance.BorderSize = 0;
            delete_btn.FlatStyle = FlatStyle.Flat;
            delete_btn.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            delete_btn.ForeColor = SystemColors.ButtonHighlight;
            delete_btn.Location = new Point(403, 383);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(122, 45);
            delete_btn.TabIndex = 23;
            delete_btn.Text = "DELETE";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
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
            button1.Location = new Point(260, 383);
            button1.Name = "button1";
            button1.Size = new Size(122, 45);
            button1.TabIndex = 24;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DeleteStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(553, 450);
            Controls.Add(button1);
            Controls.Add(delete_btn);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteStudent";
            Load += DeleteStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private Button delete_btn;
        private Button button1;
    }
}