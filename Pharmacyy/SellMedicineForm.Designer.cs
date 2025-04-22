namespace PharmacySystem
{
    partial class SellMedicineForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblCustomer;
        private ComboBox cmbCustomers;
        private Label lblMedicine;
        private ComboBox cmbMedicines;
        private Label lblGenericName;
        private TextBox txtGenericName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblAvailableQty;
        private TextBox txtAvailableQty;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private GroupBox grpDiscount;
        private RadioButton rbNone;
        private RadioButton rbSenior;
        private RadioButton rbPWD;
        private Button btnAddToCart;
        private DataGridView dgvCart;
        private Label lblTotal;
        private Label lblTotalAmount;
        private Button btnClose;
        private GroupBox grpPayment;
        private Label lblCashAmount;
        private TextBox txtCashAmount;
        private Label lblExchange;
        private Label lblExchangeValue;
        private Button btnProcessPayment;

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
            lblCustomer = new Label();
            cmbCustomers = new ComboBox();
            lblMedicine = new Label();
            cmbMedicines = new ComboBox();
            lblGenericName = new Label();
            txtGenericName = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblAvailableQty = new Label();
            txtAvailableQty = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            grpDiscount = new GroupBox();
            rbNone = new RadioButton();
            rbSenior = new RadioButton();
            rbPWD = new RadioButton();
            btnAddToCart = new Button();
            dgvCart = new DataGridView();
            lblTotal = new Label();
            lblTotalAmount = new Label();
            btnClose = new Button();
            grpPayment = new GroupBox();
            lblCashAmount = new Label();
            txtCashAmount = new TextBox();
            lblExchange = new Label();
            lblExchangeValue = new Label();
            btnProcessPayment = new Button();
            grpDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            grpPayment.SuspendLayout();
            SuspendLayout();
            // 
            // lblCustomer
            // 
            lblCustomer.Location = new Point(20, 20);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(100, 23);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer:";
            // 
            // cmbCustomers
            // 
            cmbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomers.Location = new Point(126, 20);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(250, 23);
            cmbCustomers.TabIndex = 1;
            // 
            // lblMedicine
            // 
            lblMedicine.Location = new Point(20, 50);
            lblMedicine.Name = "lblMedicine";
            lblMedicine.Size = new Size(100, 23);
            lblMedicine.TabIndex = 2;
            lblMedicine.Text = "Brand name:";
            // 
            // cmbMedicines
            // 
            cmbMedicines.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedicines.Location = new Point(126, 49);
            cmbMedicines.Name = "cmbMedicines";
            cmbMedicines.Size = new Size(250, 23);
            cmbMedicines.TabIndex = 3;
            cmbMedicines.SelectedIndexChanged += cmbMedicines_SelectedIndexChanged;
            // 
            // lblGenericName
            // 
            lblGenericName.Location = new Point(20, 80);
            lblGenericName.Name = "lblGenericName";
            lblGenericName.Size = new Size(100, 23);
            lblGenericName.TabIndex = 4;
            lblGenericName.Text = "Generic Name:";
            // 
            // txtGenericName
            // 
            txtGenericName.Location = new Point(126, 77);
            txtGenericName.Name = "txtGenericName";
            txtGenericName.ReadOnly = true;
            txtGenericName.Size = new Size(250, 23);
            txtGenericName.TabIndex = 5;
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(20, 110);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 6;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(126, 110);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 7;
            // 
            // lblAvailableQty
            // 
            lblAvailableQty.Location = new Point(20, 140);
            lblAvailableQty.Name = "lblAvailableQty";
            lblAvailableQty.Size = new Size(100, 23);
            lblAvailableQty.TabIndex = 8;
            lblAvailableQty.Text = "Available Qty:";
            // 
            // txtAvailableQty
            // 
            txtAvailableQty.Location = new Point(126, 139);
            txtAvailableQty.Name = "txtAvailableQty";
            txtAvailableQty.ReadOnly = true;
            txtAvailableQty.Size = new Size(100, 23);
            txtAvailableQty.TabIndex = 9;
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
            txtQuantity.Location = new Point(126, 170);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 11;
            // 
            // grpDiscount
            // 
            grpDiscount.Controls.Add(rbNone);
            grpDiscount.Controls.Add(rbSenior);
            grpDiscount.Controls.Add(rbPWD);
            grpDiscount.Location = new Point(246, 110);
            grpDiscount.Name = "grpDiscount";
            grpDiscount.Size = new Size(130, 80);
            grpDiscount.TabIndex = 12;
            grpDiscount.TabStop = false;
            grpDiscount.Text = "Discount";
            // 
            // rbNone
            // 
            rbNone.Checked = true;
            rbNone.Location = new Point(10, 15);
            rbNone.Name = "rbNone";
            rbNone.Size = new Size(104, 24);
            rbNone.TabIndex = 0;
            rbNone.TabStop = true;
            rbNone.Text = "None";
            // 
            // rbSenior
            // 
            rbSenior.Location = new Point(10, 35);
            rbSenior.Name = "rbSenior";
            rbSenior.Size = new Size(104, 24);
            rbSenior.TabIndex = 1;
            rbSenior.Text = "Senior (20%)";
            // 
            // rbPWD
            // 
            rbPWD.Location = new Point(10, 55);
            rbPWD.Name = "rbPWD";
            rbPWD.Size = new Size(104, 24);
            rbPWD.TabIndex = 2;
            rbPWD.Text = "PWD (20%)";
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(20, 200);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(100, 30);
            btnAddToCart.TabIndex = 13;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.Location = new Point(20, 240);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(740, 250);
            dgvCart.TabIndex = 14;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(6, 90);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(110, 23);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblTotalAmount.Location = new Point(122, 91);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(42, 20);
            lblTotalAmount.TabIndex = 16;
            lblTotalAmount.Text = "0.00";
            lblTotalAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(546, 154);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 23);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.Click += BtnClose_Click;
            // 
            // grpPayment
            // 
            grpPayment.Controls.Add(lblCashAmount);
            grpPayment.Controls.Add(txtCashAmount);
            grpPayment.Controls.Add(lblExchange);
            grpPayment.Controls.Add(lblExchangeValue);
            grpPayment.Controls.Add(lblTotal);
            grpPayment.Controls.Add(lblTotalAmount);
            grpPayment.Location = new Point(400, 19);
            grpPayment.Name = "grpPayment";
            grpPayment.Size = new Size(240, 130);
            grpPayment.TabIndex = 0;
            grpPayment.TabStop = false;
            grpPayment.Text = "Payment";
            // 
            // lblCashAmount
            // 
            lblCashAmount.Location = new Point(10, 25);
            lblCashAmount.Name = "lblCashAmount";
            lblCashAmount.Size = new Size(100, 23);
            lblCashAmount.TabIndex = 0;
            lblCashAmount.Text = "Cash Amount:";
            // 
            // txtCashAmount
            // 
            txtCashAmount.Location = new Point(107, 25);
            txtCashAmount.Name = "txtCashAmount";
            txtCashAmount.Size = new Size(120, 23);
            txtCashAmount.TabIndex = 1;
            txtCashAmount.TextChanged += TxtCashAmount_TextChanged;
            // 
            // lblExchange
            // 
            lblExchange.Location = new Point(10, 55);
            lblExchange.Name = "lblExchange";
            lblExchange.Size = new Size(100, 23);
            lblExchange.TabIndex = 2;
            lblExchange.Text = "Exchange:";
            // 
            // lblExchangeValue
            // 
            lblExchangeValue.ForeColor = Color.Green;
            lblExchangeValue.Location = new Point(114, 55);
            lblExchangeValue.Name = "lblExchangeValue";
            lblExchangeValue.Size = new Size(113, 23);
            lblExchangeValue.TabIndex = 3;
            lblExchangeValue.Text = "0.00";
            // 
            // btnProcessPayment
            // 
            btnProcessPayment.Location = new Point(400, 155);
            btnProcessPayment.Name = "btnProcessPayment";
            btnProcessPayment.Size = new Size(103, 22);
            btnProcessPayment.TabIndex = 4;
            btnProcessPayment.Text = "Process Payment";
            btnProcessPayment.Click += btnCompleteSale_Click;
            // 
            // SellMedicineForm
            // 
            ClientSize = new Size(800, 600);
            Controls.Add(grpPayment);
            Controls.Add(lblCustomer);
            Controls.Add(cmbCustomers);
            Controls.Add(lblMedicine);
            Controls.Add(btnProcessPayment);
            Controls.Add(cmbMedicines);
            Controls.Add(lblGenericName);
            Controls.Add(txtGenericName);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblAvailableQty);
            Controls.Add(txtAvailableQty);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(grpDiscount);
            Controls.Add(btnAddToCart);
            Controls.Add(dgvCart);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "SellMedicineForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sell Medicine";
            grpDiscount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void InitializeCartColumns()
        {
            // Hidden Medicine ID column
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "MedicineID",
                HeaderText = "Medicine ID",
                Visible = false
            });

            // Visible columns
            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "BrandName",
                HeaderText = "Brand Name",
                Width = 150,
                ReadOnly = true
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "GenericName",
                HeaderText = "Generic Name",
                Width = 150,
                ReadOnly = true
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                HeaderText = "Price",
                Width = 80,
                ReadOnly = true
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Quantity",
                HeaderText = "Qty",
                Width = 50,
                ReadOnly = true
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Subtotal",
                HeaderText = "Subtotal",
                Width = 80,
                ReadOnly = true
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Discount",
                HeaderText = "Discount",
                Width = 80,
                ReadOnly = true
            });

            dgvCart.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Total",
                HeaderText = "Total",
                Width = 80,
                ReadOnly = true
            });
        }
    }
}