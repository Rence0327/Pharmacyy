using MySql.Data.MySqlClient; 
using System.Data;


namespace PharmacySystem
{
    public partial class ViewMedicineForm : Form
    {
        private string connectionString = "Server=localhost;Database=dbmeds;Uid=root;Pwd=neko;";

        public ViewMedicineForm()
        {
            InitializeComponent();
            LoadMedicines();
        }

        private void LoadMedicines()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id, brand_name, generic_name, use_description, expiry_date, price_per_piece, quantity FROM medicines";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvMedicines.DataSource = table;

                    // Format columns
                    dgvMedicines.Columns["price_per_piece"].DefaultCellStyle.Format = "N2";
                    dgvMedicines.Columns["expiry_date"].DefaultCellStyle.Format = "d";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewMedicineForm_Load(object sender, EventArgs e)
        {

        }
    }
}