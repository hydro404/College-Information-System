using System;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Data;

namespace CollegeInformationSystem
{
    internal class DatabaseConnection
    {
        private readonly string host;
        private readonly string user;
        private readonly string password;
        private readonly string database;
        private readonly MySqlConnection connection;

        public DatabaseConnection()
        {
            // Assign constant values to host, user, password, and database
            host = "127.0.0.1";
            user = "root";
            password = "@Hydrogn10";
            database = "college";

            // Construct the connection string using the constant values
            string connectionString = $"Server={host};Database={database};User ID={user};Password={password};";
            connection = new MySqlConnection(connectionString);
        }

        public void Open()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void Close()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public void InsertData(string tableName, string[] columnNames, string[] values)
        {
            try
            {
                Open();
                for (int i = 0; i < columnNames.Length; i++)
                {
                    if (columnNames[i].ToLower() == "password")
                    {
                        values[i] = HashPassword(values[i]);
                    }
                }
                // Construct the SQL command for insertion
                string columns = string.Join(", ", columnNames);
                string placeholders = string.Join(", ", values.Select(_ => "?"));
                string query = $"INSERT INTO {tableName} ({columns}) VALUES ({placeholders})";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameters to the command
                    for (int i = 0; i < values.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@param{i + 1}", values[i]);
                    }

                    // Execute the query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Registered!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email already exists. Please try again.");
            }
            finally
            {
                Close();
            }
        }

        public void UpdateData(string tableName, string[] columnNames, string[] values, string conditionColumn, string conditionValue)
        {
            try
            {
                Open();
                for (int i = 0; i < columnNames.Length; i++)
                {
                    if (columnNames[i].ToLower() == "password")
                    {
                        values[i] = HashPassword(values[i]);
                    }
                }

                // Construct the SQL command for updating
                string setClause = string.Join(", ", columnNames.Select((col, i) => $"{col} = @param{i + 1}"));
                string query = $"UPDATE {tableName} SET {setClause} WHERE {conditionColumn} = @ConditionValue";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Add parameters to the command for SET clause
                    for (int i = 0; i < values.Length; i++)
                    {
                        cmd.Parameters.AddWithValue($"@param{i + 1}", values[i]);
                    }

                    // Add parameter for the WHERE clause
                    cmd.Parameters.AddWithValue("@ConditionValue", conditionValue);

                    // Execute the query
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("Successfully Updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update failed. Please try again.");
            }
            finally
            {
                Close();
            }
        }

        public bool CheckLoginCredentials(string email, string password)
        {
            bool isAuthenticated = false;

            try
            {
                Open();

                // Hash the provided password
                string hashedPassword = HashPassword(password);

                // Construct the SQL command for checking login credentials
                string query = "SELECT COUNT(*) FROM users WHERE email = @Email AND password = @Password";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    // Execute the query
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // If there is a matching user, set isAuthenticated to true
                    isAuthenticated = count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking login credentials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }

            return isAuthenticated;
        }

        public void GetData(string query, DataGridView dataGridView)
        {
            try
            {
                Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., logging, displaying an error message)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Close();
            }
        }

        public void LoadDataIntoComboBox(string query, ComboBox comboBox, string idColumn)
        {
            try
            {
                Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming the column names are strings, adjust accordingly
                            
                            string id = reader[idColumn].ToString(); // Get the value of the ID column
                            string value = reader.GetString(1); // Assuming the display value column is at index 1
                            comboBox.Items.Add(new KeyValuePair<string, string>(id, value));
                        }
                    }
                }
                comboBox.DisplayMember = "Value"; // Display the "Value" property of KeyValuePair in the ComboBox
                comboBox.ValueMember = "Key"; // Use the "Key" property of KeyValuePair as the value
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., logging, displaying an error message)
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Close();
            }
        }
    }
}