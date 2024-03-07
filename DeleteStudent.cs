using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeInformationSystem;

namespace CollegeInformationSystem
{
    public partial class DeleteStudent : Form
    {
        private DatabaseConnection databaseConnection;
        public DeleteStudent()
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            string columnID = "student_id";
            string comboBoxQuery = "SELECT student_id, student_fname, student_lname FROM college.student;";
            databaseConnection.LoadDataIntoComboBox2(comboBoxQuery, comboBox1, columnID);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, string> selectedStudentId = (KeyValuePair<string, string>)comboBox1.SelectedItem;
            string id = selectedStudentId.Key;

            try
            {
                databaseConnection.DeleteData("student", "student_id", id);
                MessageBox.Show("Deleted Successfully!");
                Dashboard dashboard = new Dashboard();

                this.Hide();

                dashboard.ShowDialog();

                this.Close();
            }
            catch
            {
                MessageBox.Show("There was an error deleting the student");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();

            this.Hide();

            dashboard.ShowDialog();

            this.Close();
        }
    }
}
