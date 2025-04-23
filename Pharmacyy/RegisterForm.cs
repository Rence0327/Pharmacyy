using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacySystem
{
    public partial class RegisterForm : Form
    {
        private const string EncryptionKey = "Your32ByteSecretKey1234567890123456"; // Must match LoginForm
        private string connectionString = "Server=localhost;Database=dbmeds;Uid=root;Pwd=neko;";

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if username already exists
                    string checkQuery = @"SELECT COUNT(*) FROM users 
                                        WHERE username = AES_ENCRYPT(@username, @encKey)";

                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@encKey", EncryptionKey);

                    int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists");
                        return;
                    }

                    // Insert new user with encrypted credentials
                    string insertQuery = @"INSERT INTO users (username, password) 
                                         VALUES (AES_ENCRYPT(@username, @encKey), 
                                                 AES_ENCRYPT(@password, @encKey))";

                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password);
                    insertCmd.Parameters.AddWithValue("@encKey", EncryptionKey);

                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Registration failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}