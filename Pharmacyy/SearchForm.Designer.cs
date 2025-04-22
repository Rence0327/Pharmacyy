namespace PharmacySystem
{
    partial class SearchForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnSortAsc;
        private System.Windows.Forms.Button btnSortDesc;
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
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnSortAsc = new System.Windows.Forms.Button();
            this.btnSortDesc = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();

            // lblSearch
            this.lblSearch.Text = "Search Medicines:";
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearch.Location = new System.Drawing.Point(20, 20);
            this.lblSearch.Size = new System.Drawing.Size(180, 25);

            // txtSearchTerm
            this.txtSearchTerm.Location = new System.Drawing.Point(200, 20);
            this.txtSearchTerm.Size = new System.Drawing.Size(300, 27);

            // btnSearch
            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(510, 18);
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // btnViewAll
            this.btnViewAll.Text = "View All";
            this.btnViewAll.Location = new System.Drawing.Point(600, 18);
            this.btnViewAll.Size = new System.Drawing.Size(80, 30);
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);

            // dgvResults
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(20, 60);
            this.dgvResults.Size = new System.Drawing.Size(760, 300);
            this.dgvResults.ReadOnly = true;
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // btnSortAsc
            this.btnSortAsc.Text = "Sort A-Z";
            this.btnSortAsc.Location = new System.Drawing.Point(20, 370);
            this.btnSortAsc.Size = new System.Drawing.Size(90, 30);
            this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);

            // btnSortDesc
            this.btnSortDesc.Text = "Sort Z-A";
            this.btnSortDesc.Location = new System.Drawing.Point(120, 370);
            this.btnSortDesc.Size = new System.Drawing.Size(90, 30);
            this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);

            // btnClose
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(680, 370);
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // SearchForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnSortAsc);
            this.Controls.Add(this.btnSortDesc);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Medicines";

            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
