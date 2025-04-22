using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PharmacySystem
{
    public partial class RestockForm : Form
    {
        private string connectionString = "Server=localhost;Database=dbmeds;Uid=root;Pwd=neko;";

        public RestockForm()
        {
            InitializeComponent();
            LoadMedicines();
        }

        private void LoadMedicines()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, brand_name, generic_name, quantity FROM medicines";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbMedicines.DataSource = table;
                cmbMedicines.DisplayMember = "brand_name";
                cmbMedicines.ValueMember = "id";
            }
        }

        private void cmbMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicines.SelectedItem is DataRowView row)
            {
                txtCurrentQty.Text = row["quantity"].ToString();
                txtGenericName.Text = row["generic_name"].ToString();
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAddQty.Text, out int addQty) || addQty <= 0)
            {
                MessageBox.Show("Please enter valid quantity");
                return;
            }

            int medicineId = (int)cmbMedicines.SelectedValue;
            DateTime restockDate = dtpRestockDate.Value;
            string notes = txtNotes.Text;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert into restocks table
                    string restockQuery = @"INSERT INTO tblrestocks 
                                         (medicine_id, quantity_added, restock_date, notes) 
                                         VALUES (@med, @qty, @date, @notes)";
                    MySqlCommand cmd = new MySqlCommand(restockQuery, connection);
                    cmd.Parameters.AddWithValue("@med", medicineId);
                    cmd.Parameters.AddWithValue("@qty", addQty);
                    cmd.Parameters.AddWithValue("@date", restockDate);
                    cmd.Parameters.AddWithValue("@notes", notes);
                    cmd.ExecuteNonQuery();

                    // Update medicines table
                    string updateQuery = @"UPDATE medicines 
                                        SET quantity = quantity + @qty 
                                        WHERE id = @med";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                    updateCmd.Parameters.AddWithValue("@qty", addQty);
                    updateCmd.Parameters.AddWithValue("@med", medicineId);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Restock completed successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}