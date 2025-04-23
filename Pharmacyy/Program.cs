using System;
using System.Windows.Forms;

namespace PharmacySystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize database connection
            InitializeDatabase();

            // Start with the login form
            Application.Run(new LoginForm());
        }

        static void InitializeDatabase()
        {
            try
            {
                // You could add database initialization code here if needed
                // For example, checking if tables exist, creating them if not
                // Or verifying the connection is working
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database initialization failed: " + ex.Message,
                    "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1); // Exit the application if database isn't available
            }
        }
    }
}