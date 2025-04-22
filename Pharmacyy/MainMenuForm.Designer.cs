namespace PharmacySystem
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnAddMedicine;
        private Button btnSellMedicine;
        private Button btnViewMedicine;
        private Button btnSearchMedicine;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private Button btnSalesReport;
        private Button btnRestock;


        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnAddMedicine = new Button();
            btnSellMedicine = new Button();
            btnViewMedicine = new Button();
            btnSearchMedicine = new Button();
            btnSalesReport = new Button();
            btnRestock = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(50, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(260, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Pharmacy Management System";
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Location = new Point(100, 60);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Size = new Size(150, 30);
            btnAddMedicine.TabIndex = 1;
            btnAddMedicine.Text = "Add Medicine";
            btnAddMedicine.Click += btnAddMedicine_Click;
            // 
            // btnSellMedicine
            // 
            btnSellMedicine.Location = new Point(100, 132);
            btnSellMedicine.Name = "btnSellMedicine";
            btnSellMedicine.Size = new Size(150, 30);
            btnSellMedicine.TabIndex = 2;
            btnSellMedicine.Text = "Sell Medicine";
            btnSellMedicine.Click += btnSellMedicine_Click;
            // 
            // btnViewMedicine
            // 
            btnViewMedicine.Location = new Point(100, 168);
            btnViewMedicine.Name = "btnViewMedicine";
            btnViewMedicine.Size = new Size(150, 30);
            btnViewMedicine.TabIndex = 3;
            btnViewMedicine.Text = "View Medicine";
            btnViewMedicine.Click += btnViewMedicine_Click;
            // 
            // btnSearchMedicine
            // 
            btnSearchMedicine.Location = new Point(100, 204);
            btnSearchMedicine.Name = "btnSearchMedicine";
            btnSearchMedicine.Size = new Size(150, 30);
            btnSearchMedicine.TabIndex = 4;
            btnSearchMedicine.Text = "Search Medicine";
            btnSearchMedicine.Click += btnSearchMedicine_Click;
            // 
            // btnSalesReport
            // 
            btnSalesReport.Location = new Point(100, 240);
            btnSalesReport.Name = "btnSalesReport";
            btnSalesReport.Size = new Size(150, 30);
            btnSalesReport.TabIndex = 0;
            btnSalesReport.Text = "Sales Report";
            btnSalesReport.Click += btnSalesReport_Click;
            // 
            // btnRestock
            // 
            btnRestock.Location = new Point(100, 96);
            btnRestock.Name = "btnRestock";
            btnRestock.Size = new Size(150, 30);
            btnRestock.TabIndex = 1;
            btnRestock.Text = "Restock";
            btnRestock.Click += btnRestock_Click;
            // 
            // MainMenuForm
            // 
            ClientSize = new Size(348, 285);
            Controls.Add(btnSalesReport);
            Controls.Add(btnRestock);
            Controls.Add(lblTitle);
            Controls.Add(btnAddMedicine);
            Controls.Add(btnSellMedicine);
            Controls.Add(btnViewMedicine);
            Controls.Add(btnSearchMedicine);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pharmacy Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}