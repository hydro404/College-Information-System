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
    public partial class AddStudent : Form
    {
        private DatabaseConnection databaseConnection;
        public AddStudent()
        {
            InitializeComponent();
            databaseConnection = new DatabaseConnection();
        }

        private void email_label_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            string column = "campus_name";
            string table = "campus";
            string comboBoxQuery = $"SELECT {column} FROM {table}";
            databaseConnection.LoadDataIntoComboBox(comboBoxQuery, select_campus_combobox);
        }

        private void select_campus_combobox_SelectedValueChanged(object sender, EventArgs e)
        {
            string column = "campus_name";
            string table = "campus";
            string comboBoxQuery = $"SELECT {column} FROM {table} WHERE";
            databaseConnection.LoadDataIntoComboBox(comboBoxQuery, select_campus_combobox);
        }
    }
}
