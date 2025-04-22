namespace PharmacySystem
{
    partial class RestockForm
    {
        private ComboBox cmbMedicines;
        private Label lblMedicine;
        private Label lblGenericName;
        private TextBox txtGenericName;
        private Label lblCurrentQty;
        private TextBox txtCurrentQty;
        private Label lblAddQty;
        private TextBox txtAddQty;
        private Label lblRestockDate;
        private DateTimePicker dtpRestockDate;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnRestock;
        private Button btnCancel;

        private void InitializeComponent()
        {
            // Form Setup
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Text = "Restock Medicine";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Medicine Selection
            lblMedicine = new Label();
            lblMedicine.Text = "Medicine:";
            lblMedicine.Location = new Point(20, 20);
            this.Controls.Add(lblMedicine);

            cmbMedicines = new ComboBox();
            cmbMedicines.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedicines.Location = new Point(120, 20);
            cmbMedicines.Size = new Size(250, 21);
            cmbMedicines.SelectedIndexChanged += cmbMedicines_SelectedIndexChanged;
            this.Controls.Add(cmbMedicines);

            // Medicine Details
            lblGenericName = new Label();
            lblGenericName.Text = "Generic Name:";
            lblGenericName.Location = new Point(20, 50);
            this.Controls.Add(lblGenericName);

            txtGenericName = new TextBox();
            txtGenericName.ReadOnly = true;
            txtGenericName.Location = new Point(120, 50);
            txtGenericName.Size = new Size(250, 20);
            this.Controls.Add(txtGenericName);

            lblCurrentQty = new Label();
            lblCurrentQty.Text = "Current Qty:";
            lblCurrentQty.Location = new Point(20, 80);
            this.Controls.Add(lblCurrentQty);

            txtCurrentQty = new TextBox();
            txtCurrentQty.ReadOnly = true;
            txtCurrentQty.Location = new Point(120, 80);
            txtCurrentQty.Size = new Size(100, 20);
            this.Controls.Add(txtCurrentQty);

            // Restock Details
            lblAddQty = new Label();
            lblAddQty.Text = "Add Quantity:";
            lblAddQty.Location = new Point(20, 110);
            this.Controls.Add(lblAddQty);

            txtAddQty = new TextBox();
            txtAddQty.Location = new Point(120, 110);
            txtAddQty.Size = new Size(100, 20);
            this.Controls.Add(txtAddQty);

            lblRestockDate = new Label();
            lblRestockDate.Text = "Restock Date:";
            lblRestockDate.Location = new Point(20, 140);
            this.Controls.Add(lblRestockDate);

            dtpRestockDate = new DateTimePicker();
            dtpRestockDate.Location = new Point(120, 140);
            dtpRestockDate.Size = new Size(150, 20);
            this.Controls.Add(dtpRestockDate);

            lblNotes = new Label();
            lblNotes.Text = "Notes:";
            lblNotes.Location = new Point(20, 170);
            this.Controls.Add(lblNotes);

            txtNotes = new TextBox();
            txtNotes.Multiline = true;
            txtNotes.Location = new Point(120, 170);
            txtNotes.Size = new Size(250, 100);
            this.Controls.Add(txtNotes);

            // Buttons
            btnRestock = new Button();
            btnRestock.Text = "Restock";
            btnRestock.Location = new Point(120, 280);
            btnRestock.Size = new Size(100, 30);
            btnRestock.Click += btnRestock_Click;
            this.Controls.Add(btnRestock);

            btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(230, 280);
            btnCancel.Size = new Size(100, 30);
            btnCancel.Click += (s, e) => this.Close();
            this.Controls.Add(btnCancel);
        }
    }
}