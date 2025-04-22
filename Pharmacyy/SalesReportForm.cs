using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace PharmacySystem
{
    public partial class SalesReportForm : Form
    {
        private string connectionString = "Server=localhost;Database=dbmeds;Uid=root;Pwd=neko;";

        public SalesReportForm()
        {
            InitializeComponent();
            dtpFrom.Value = DateTime.Now.AddDays(-30);
            dtpTo.Value = DateTime.Now;
            LoadReport();
        }

        private void LoadReport()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT p.purchase_id, c.full_name AS customer, m.brand_name AS medicine, 
                               p.quantity_bought, s.total_amount, p.purchase_date
                               FROM tblpurchases p
                               JOIN tblcustomers c ON p.customer_id = c.customer_id
                               JOIN medicines m ON p.medicine_id = m.id
                               JOIN tblsales s ON p.purchase_id = s.purchase_id
                               WHERE p.purchase_date BETWEEN @from AND @to
                               ORDER BY p.purchase_date DESC";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@from", dtpFrom.Value.Date);
                cmd.Parameters.AddWithValue("@to", dtpTo.Value.Date.AddDays(0));

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvReport.DataSource = table;

                // Calculate and display totals
                decimal totalSales = 0;
                if (table.Rows.Count > 0)
                {
                    totalSales = Convert.ToDecimal(table.Compute("SUM(total_amount)", ""));
                }
                lblTotalSales.Text = $"Total Sales: {totalSales.ToString("N2")}";
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Simple print functionality - you can enhance this
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += (s, ev) =>
                {
                    Bitmap bmp = new Bitmap(this.Width, this.Height);
                    this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
                    ev.Graphics.DrawImage(bmp, 0, 0);
                };
                doc.Print();
            }
        }
    }
}