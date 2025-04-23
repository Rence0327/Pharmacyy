namespace PharmacySystem
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnSortNameAsc;
        private System.Windows.Forms.Button btnSortNameDesc;
        private System.Windows.Forms.Button btnSortIDAsc;
        private System.Windows.Forms.Button btnSortIDDesc;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvResults = new DataGridView();
            txtSearchTerm = new TextBox();
            btnSearch = new Button();
            btnViewAll = new Button();
            btnSortNameAsc = new Button();
            btnSortNameDesc = new Button();
            btnSortIDAsc = new Button();
            btnSortIDDesc = new Button();
            btnClose = new Button();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // dgvResults
            // 
            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Location = new Point(20, 54);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.Size = new Size(760, 300);
            dgvResults.TabIndex = 4;
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.Location = new Point(200, 20);
            txtSearchTerm.Name = "txtSearchTerm";
            txtSearchTerm.Size = new Size(300, 23);
            txtSearchTerm.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(510, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnViewAll
            // 
            btnViewAll.Location = new Point(600, 18);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(80, 30);
            btnViewAll.TabIndex = 3;
            btnViewAll.Text = "View All";
            btnViewAll.Click += btnViewAll_Click;
            // 
            // btnSortNameAsc
            // 
            btnSortNameAsc.Location = new Point(20, 370);
            btnSortNameAsc.Name = "btnSortNameAsc";
            btnSortNameAsc.Size = new Size(90, 30);
            btnSortNameAsc.TabIndex = 7;
            btnSortNameAsc.Text = "Sort A-Z";
            btnSortNameAsc.Click += btnSortAscName_Click;
            // 
            // btnSortNameDesc
            // 
            btnSortNameDesc.Location = new Point(120, 370);
            btnSortNameDesc.Name = "btnSortNameDesc";
            btnSortNameDesc.Size = new Size(90, 30);
            btnSortNameDesc.TabIndex = 8;
            btnSortNameDesc.Text = "Sort Z-A";
            btnSortNameDesc.Click += btnSortDescName_Click;
            // 
            // btnSortIDAsc
            // 
            btnSortIDAsc.Location = new Point(216, 370);
            btnSortIDAsc.Name = "btnSortIDAsc";
            btnSortIDAsc.Size = new Size(90, 30);
            btnSortIDAsc.TabIndex = 5;
            btnSortIDAsc.Text = "Sort First-Last";
            btnSortIDAsc.Click += btnSortAscID_Click;
            // 
            // btnSortIDDesc
            // 
            btnSortIDDesc.Location = new Point(312, 370);
            btnSortIDDesc.Name = "btnSortIDDesc";
            btnSortIDDesc.Size = new Size(90, 30);
            btnSortIDDesc.TabIndex = 6;
            btnSortIDDesc.Text = "Sort Last-First";
            btnSortIDDesc.Click += btnSortDescID_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(680, 370);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 30);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSearch.Location = new Point(20, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(180, 25);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Medicines:";
            // 
            // SearchForm
            // 
            ClientSize = new Size(800, 420);
            Controls.Add(lblSearch);
            Controls.Add(txtSearchTerm);
            Controls.Add(btnSearch);
            Controls.Add(btnViewAll);
            Controls.Add(dgvResults);
            Controls.Add(btnSortIDAsc);
            Controls.Add(btnSortIDDesc);
            Controls.Add(btnSortNameAsc);
            Controls.Add(btnSortNameDesc);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Medicines";
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
