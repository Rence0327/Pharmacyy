namespace PharmacySystem
{
    partial class AddMedicineForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblBrandName;
        private TextBox txtBrandName;
        private Label lblGenericName;
        private TextBox txtGenericName;
        private Label lblUseDescription;
        private TextBox txtUseDescription;
        private Label lblExpiryDate;
        private DateTimePicker dtpExpiryDate;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnSave;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblBrandName = new Label();
            txtBrandName = new TextBox();
            lblGenericName = new Label();
            txtGenericName = new TextBox();
            lblUseDescription = new Label();
            txtUseDescription = new TextBox();
            lblExpiryDate = new Label();
            dtpExpiryDate = new DateTimePicker();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblBrandName
            // 
            lblBrandName.Location = new Point(20, 20);
            lblBrandName.Name = "lblBrandName";
            lblBrandName.Size = new Size(100, 23);
            lblBrandName.TabIndex = 0;
            lblBrandName.Text = "Brand Name:";
            // 
            // txtBrandName
            // 
            txtBrandName.Location = new Point(120, 20);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(150, 23);
            txtBrandName.TabIndex = 1;
            // 
            // lblGenericName
            // 
            lblGenericName.Location = new Point(20, 50);
            lblGenericName.Name = "lblGenericName";
            lblGenericName.Size = new Size(100, 23);
            lblGenericName.TabIndex = 2;
            lblGenericName.Text = "Generic Name:";
            // 
            // txtGenericName
            // 
            txtGenericName.Location = new Point(120, 50);
            txtGenericName.Name = "txtGenericName";
            txtGenericName.Size = new Size(150, 23);
            txtGenericName.TabIndex = 3;
            // 
            // lblUseDescription
            // 
            lblUseDescription.Location = new Point(20, 80);
            lblUseDescription.Name = "lblUseDescription";
            lblUseDescription.Size = new Size(100, 23);
            lblUseDescription.TabIndex = 4;
            lblUseDescription.Text = "Description:";
            // 
            // txtUseDescription
            // 
            txtUseDescription.Location = new Point(120, 80);
            txtUseDescription.Name = "txtUseDescription";
            txtUseDescription.Size = new Size(150, 23);
            txtUseDescription.TabIndex = 5;
            // 
            // lblExpiryDate
            // 
            lblExpiryDate.Location = new Point(20, 110);
            lblExpiryDate.Name = "lblExpiryDate";
            lblExpiryDate.Size = new Size(100, 23);
            lblExpiryDate.TabIndex = 6;
            lblExpiryDate.Text = "Expiry Date:";
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Location = new Point(120, 110);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(150, 23);
            dtpExpiryDate.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(20, 140);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(120, 140);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 23);
            txtPrice.TabIndex = 9;
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(20, 170);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(100, 23);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(120, 169);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(150, 23);
            txtQuantity.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(70, 220);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(155, 220);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // AddMedicineForm
            // 
            ClientSize = new Size(286, 281);
            Controls.Add(lblBrandName);
            Controls.Add(txtBrandName);
            Controls.Add(lblGenericName);
            Controls.Add(txtGenericName);
            Controls.Add(lblUseDescription);
            Controls.Add(txtUseDescription);
            Controls.Add(lblExpiryDate);
            Controls.Add(dtpExpiryDate);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "AddMedicineForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Medicine";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}