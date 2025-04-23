using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace PharmacySystem
{
    public partial class SellMedicineForm : Form
    {
        private string connectionString = "Server=localhost;Database=dbmeds;Uid=root;Pwd=neko;";
        private DataTable medicineTable = new DataTable();
        private decimal totalAmount = 0;

        public SellMedicineForm()
        {
            InitializeComponent();
            InitializeCartGridView();
            InitializeCartColumns();
            LoadCustomers();
            LoadMedicines();
        }

        private void InitializeCartGridView()
        {
            // Add hidden MedicineID column
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "MedicineID",
                HeaderText = "Medicine ID",
                Visible = false
            });
        }

        private void TxtCashAmount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCashAmount.Text, out decimal cashAmount))
            {
                decimal exchange = cashAmount - totalAmount;
                lblExchangeValue.Text = exchange.ToString("N2");
                lblExchangeValue.ForeColor = exchange >= 0 ? Color.Green : Color.Red;
            }
            else
            {
                lblExchangeValue.Text = "0.00";
                lblExchangeValue.ForeColor = Color.Green;
            }
        }



        private void LoadCustomers()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT customer_id, full_name FROM tblcustomers";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                cmbCustomers.DataSource = table;
                cmbCustomers.DisplayMember = "full_name";
                cmbCustomers.ValueMember = "customer_id";
            }
        }

        private void LoadMedicines()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, brand_name, generic_name, price_per_piece, quantity FROM medicines";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                medicineTable.Clear();
                adapter.Fill(medicineTable);
                cmbMedicines.DataSource = medicineTable;
                cmbMedicines.DisplayMember = "brand_name";
                cmbMedicines.ValueMember = "id";
            }
        }

        private void cmbMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicines.SelectedItem is DataRowView row)
            {
                txtPrice.Text = row["price_per_piece"]?.ToString() ?? string.Empty;
                txtAvailableQty.Text = row["quantity"]?.ToString() ?? string.Empty;
                txtGenericName.Text = row["generic_name"]?.ToString() ?? string.Empty;
            }
            else
            {
                txtPrice.Clear();
                txtAvailableQty.Clear();
                txtGenericName.Clear();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Validate quantity input
            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity");
                return;
            }

            // Validate available quantity
            if (!int.TryParse(txtAvailableQty.Text, out int availableQty) || qty > availableQty)
            {
                MessageBox.Show("Not enough stock available");
                return;
            }

            // Validate price
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price");
                return;
            }

            // Calculate totals
            decimal subtotal = price * qty;
            decimal discount = rbSenior.Checked || rbPWD.Checked ? subtotal * 0.20m : 0;
            decimal total = subtotal - discount;

            // Add to cart with MedicineID
            dgvCart.Rows.Add(
                cmbMedicines.SelectedValue, // MedicineID (hidden)
                cmbMedicines.Text,          // Brand Name
                txtGenericName.Text,        // Generic Name
                txtPrice.Text,               // Price
                qty.ToString(),             // Quantity
                subtotal.ToString("N2"),    // Subtotal
                discount.ToString("N2"),     // Discount
                total.ToString("N2")         // Total
            );

            // Update UI
            totalAmount += total;
            lblTotalAmount.Text = totalAmount.ToString("N2");
            txtQuantity.Clear();
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {

            if (dgvCart.Rows.Count == 0 || dgvCart.Rows.Count == 1 && dgvCart.Rows[0].IsNewRow)
            {
                MessageBox.Show("Cannot complete sale: Your cart is empty.", "Empty Cart",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Rest of your existing validation code
            if (!decimal.TryParse(txtCashAmount.Text, out decimal cashAmount))
            {
                MessageBox.Show("Please enter valid cash amount");
                return;
            }

            if (cashAmount <= 0)
            {
                MessageBox.Show("Cash amount must be greater than 0.");
                return;
            }
            else if (cashAmount < totalAmount)
            {
                MessageBox.Show("Cash amount is less than the total amount due.");
                return;
            }

            // Show exchange
            decimal exchange = cashAmount - totalAmount;
            MessageBox.Show($"Payment processed! Exchange: {exchange.ToString("N2")}");

            // Reset payment fields
            txtCashAmount.Text = "";
            lblExchangeValue.Text = "0.00";

            int customerId = (int)cmbCustomers.SelectedValue;
            DateTime purchaseDate = DateTime.Now;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (DataGridViewRow row in dgvCart.Rows)
                        {
                            if (row.IsNewRow || row.Cells["MedicineID"].Value == null)
                                continue;

                            // Get values from cart row
                            int medicineId = Convert.ToInt32(row.Cells["MedicineID"].Value);
                            int quantity = Convert.ToInt32(row.Cells[4].Value); // Quantity column
                            decimal total = decimal.Parse(row.Cells[7].Value.ToString(), NumberStyles.Currency);

                            // Insert purchase
                            string purchaseQuery = @"INSERT INTO tblpurchases 
                                                   (customer_id, medicine_id, quantity_bought, purchase_date) 
                                                   VALUES (@cust, @med, @qty, @date)";
                            using (MySqlCommand purchaseCmd = new MySqlCommand(purchaseQuery, connection, transaction))
                            {
                                purchaseCmd.Parameters.AddWithValue("@cust", customerId);
                                purchaseCmd.Parameters.AddWithValue("@med", medicineId);
                                purchaseCmd.Parameters.AddWithValue("@qty", quantity);
                                purchaseCmd.Parameters.AddWithValue("@date", purchaseDate);
                                purchaseCmd.ExecuteNonQuery();

                                // Get the last inserted purchase ID
                                long purchaseId = purchaseCmd.LastInsertedId;

                                // Insert sale
                                string saleQuery = @"INSERT INTO tblsales 
                                                   (purchase_id, total_amount) 
                                                   VALUES (@purchase, @total)";
                                using (MySqlCommand saleCmd = new MySqlCommand(saleQuery, connection, transaction))
                                {
                                    saleCmd.Parameters.AddWithValue("@purchase", purchaseId);
                                    saleCmd.Parameters.AddWithValue("@total", total);
                                    saleCmd.ExecuteNonQuery();
                                }

                                // Update stock
                                string stockQuery = @"UPDATE medicines 
                                                    SET quantity = quantity - @qty 
                                                    WHERE id = @med";
                                using (MySqlCommand stockCmd = new MySqlCommand(stockQuery, connection, transaction))
                                {
                                    stockCmd.Parameters.AddWithValue("@qty", quantity);
                                    stockCmd.Parameters.AddWithValue("@med", medicineId);
                                    stockCmd.ExecuteNonQuery();
                                }
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Sale completed successfully!");
                        dgvCart.Rows.Clear();
                        totalAmount = 0;
                        lblTotalAmount.Text = "0.00";
                        LoadMedicines();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Error processing sale: {ex.Message}");
                    }
                }
            }
        }
    }
}
