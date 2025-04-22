using MySql.Data.MySqlClient; 
using System.Data;

namespace PharmacySystem
{
    public partial class SearchForm : Form
    {
        private string connectionString = "Server=localhost;Database=dbmeds;Uid=root;Pwd=neko;";

        public SearchForm()
        {
            InitializeComponent();
            LoadAllMedicines();
        }

        private void LoadAllMedicines()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM medicines";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvResults.DataSource = table;

                    // Format columns
                    dgvResults.Columns["price_per_piece"].DefaultCellStyle.Format = "N2";
                    dgvResults.Columns["expiry_date"].DefaultCellStyle.Format = "d";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchTerm.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM medicines 
                                   WHERE brand_name LIKE @term 
                                   OR generic_name LIKE @term 
                                   OR use_description LIKE @term";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@term", "%" + searchTerm + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvResults.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadAllMedicines();
            txtSearchTerm.Clear();
        }

        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            if (dgvResults.DataSource is DataTable table)
            {
                table.DefaultView.Sort = "brand_name ASC";
                dgvResults.DataSource = table.DefaultView;
            }
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            if (dgvResults.DataSource is DataTable table)
            {
                table.DefaultView.Sort = "brand_name DESC";
                dgvResults.DataSource = table.DefaultView;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}