using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeInformationSystem;

namespace CollegeInformationSystem
{
    public partial class login_form : Form
    {
        private DatabaseConnection databaseConnection;
        public login_form()
        {
            InitializeComponent();
            // Create an instance of DatabaseConnection
            databaseConnection = new DatabaseConnection();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void reset_password_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword reset_password = new ResetPassword();

            this.Hide();

            reset_password.ShowDialog();

            // Close the current form after the login form is closed
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                databaseConnection.Open();
                string emailText = email.Text;
                string passwordText = password.Text;
                if (databaseConnection.CheckLoginCredentials(emailText, passwordText))
                {
                    MessageBox.Show("Login Successful!");
                    Dashboard dashboard = new Dashboard();

                    this.Hide();

                    dashboard.ShowDialog();

                    // Close the current form after the login form is closed
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Invalid Credentials. Please try again.");
                }
            }
            catch { }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register_form register_form = new register_form();

            this.Hide();

            register_form.ShowDialog();

            // Close the current form after the login form is closed
            this.Close();
        }

        private void picturebox_wave_Click(object sender, EventArgs e)
        {

        }
    }
}