using MySql.Data.MySqlClient; 
using System.Data;

namespace PharmacySystem
{
    public partial class AddMedicineForm : Form
    {
        private string connectionString = "Server=localhost;Database=dbmeds;Uid=root;Pwd=neko;";

        public AddMedicineForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string brandName = txtBrandName.Text;
            string genericName = txtGenericName.Text;
            string useDescription = txtUseDescription.Text;
            DateTime expiryDate = dtpExpiryDate.Value;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO medicines 
                                    (brand_name, generic_name, use_description, expiry_date, price_per_piece, quantity) 
                                    VALUES (@brand, @generic, @use, @expiry, @price, @qty)";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@brand", brandName);
                    cmd.Parameters.AddWithValue("@generic", genericName);
                    cmd.Parameters.AddWithValue("@use", useDescription);
                    cmd.Parameters.AddWithValue("@expiry", expiryDate);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@qty", quantity);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Medicine added successfully!");
                        this.Close();
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