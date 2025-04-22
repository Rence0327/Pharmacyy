using PharmacySystem;

namespace PharmacySystem
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        // Add this button to your MainMenuForm designer


        private void btnRestock_Click(object sender, EventArgs e)
        {
            RestockForm restockForm = new RestockForm();
            restockForm.ShowDialog();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicineForm addMedicineForm = new AddMedicineForm();
            addMedicineForm.ShowDialog();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            SalesReportForm reportForm = new SalesReportForm();
            reportForm.ShowDialog();
        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            SellMedicineForm sellMedicineForm = new SellMedicineForm();
            sellMedicineForm.ShowDialog();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            ViewMedicineForm viewMedicineForm = new ViewMedicineForm();
            viewMedicineForm.ShowDialog();
        }

        private void btnSearchMedicine_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }
    }
}