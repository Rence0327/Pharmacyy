using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PharmacySystem;


namespace PharmacySystem
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Server=localhost;Database=dbmeds;Uid=root;Pwd=neko;";

        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM users WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MainMenuForm mainMenu = new MainMenuForm();
                            mainMenu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
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
            Application.Exit();
        }
    }
}