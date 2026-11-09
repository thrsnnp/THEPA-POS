using System.Windows.Forms;

namespace THEPA_POS.Forms
{
    partial class POSForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Panel pnlProductSearch;
        private System.Windows.Forms.Panel pnlOrderSummary;
        private System.Windows.Forms.Panel pnlPayment;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.NumericUpDown numDiscountPercent;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.TextBox txtAmountPaid;

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;

        private System.Windows.Forms.FlowLayoutPanel flpProducts;

        private System.Windows.Forms.DataGridView dgvCart;

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnRemoveItem;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.flpProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProductSearch = new System.Windows.Forms.Panel();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.pnlPayment = new System.Windows.Forms.Panel();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.pnlOrderSummary = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.numDiscountPercent = new System.Windows.Forms.NumericUpDown();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlProducts.SuspendLayout();
            this.pnlProductSearch.SuspendLayout();
            this.pnlCart.SuspendLayout();
            this.pnlPayment.SuspendLayout();
            this.pnlOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblCashier);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1250, 75);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "THEPA POS";
            // 
            // lblCashier
            // 
            this.lblCashier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCashier.AutoSize = true;
            this.lblCashier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCashier.ForeColor = System.Drawing.Color.White;
            this.lblCashier.Location = new System.Drawing.Point(1900, 27);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(172, 23);
            this.lblCashier.TabIndex = 1;
            this.lblCashier.Text = "Cashier: Current User";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(2175, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlProducts);
            this.pnlMain.Controls.Add(this.pnlCart);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 75);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMain.Size = new System.Drawing.Size(1250, 685);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlProducts
            // 
            this.pnlProducts.BackColor = System.Drawing.Color.White;
            this.pnlProducts.Controls.Add(this.flpProducts);
            this.pnlProducts.Controls.Add(this.pnlProductSearch);
            this.pnlProducts.Controls.Add(this.lblProductTitle);
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProducts.Location = new System.Drawing.Point(15, 15);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Padding = new System.Windows.Forms.Padding(15);
            this.pnlProducts.Size = new System.Drawing.Size(790, 655);
            this.pnlProducts.TabIndex = 0;
            // 
            // flpProducts
            // 
            this.flpProducts.AutoScroll = true;
            this.flpProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.flpProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpProducts.Location = new System.Drawing.Point(15, 125);
            this.flpProducts.Name = "flpProducts";
            this.flpProducts.Padding = new System.Windows.Forms.Padding(10);
            this.flpProducts.Size = new System.Drawing.Size(760, 515);
            this.flpProducts.TabIndex = 0;
            // 
            // pnlProductSearch
            // 
            this.pnlProductSearch.Controls.Add(this.txtSearchProduct);
            this.pnlProductSearch.Controls.Add(this.cmbCategory);
            this.pnlProductSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductSearch.Location = new System.Drawing.Point(15, 60);
            this.pnlProductSearch.Name = "pnlProductSearch";
            this.pnlProductSearch.Size = new System.Drawing.Size(760, 65);
            this.pnlProductSearch.TabIndex = 1;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearchProduct.Location = new System.Drawing.Point(5, 12);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(280, 30);
            this.txtSearchProduct.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.Location = new System.Drawing.Point(300, 12);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(190, 31);
            this.cmbCategory.TabIndex = 1;
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProductTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblProductTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            this.lblProductTitle.Location = new System.Drawing.Point(15, 15);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(760, 45);
            this.lblProductTitle.TabIndex = 2;
            this.lblProductTitle.Text = "PRODUCTS";
            this.lblProductTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCart
            // 
            this.pnlCart.BackColor = System.Drawing.Color.White;
            this.pnlCart.Controls.Add(this.pnlPayment);
            this.pnlCart.Controls.Add(this.pnlOrderSummary);
            this.pnlCart.Controls.Add(this.dgvCart);
            this.pnlCart.Controls.Add(this.lblCartTitle);
            this.pnlCart.Controls.Add(this.btnClearCart);
            this.pnlCart.Dock = DockStyle.Right;
            this.pnlCart.Width = 500;
            this.pnlCart.Location = new System.Drawing.Point(805, 15);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Padding = new System.Windows.Forms.Padding(15);
            this.pnlCart.Size = new System.Drawing.Size(500, 0);
            this.pnlCart.TabIndex = 1;
            // 
            // pnlPayment
            // 
            this.pnlPayment.BackColor = System.Drawing.Color.White;
            this.pnlPayment.Controls.Add(this.lblPaymentMethod);
            this.pnlPayment.Controls.Add(this.cmbPaymentMethod);
            this.pnlPayment.Controls.Add(this.lblAmountPaid);
            this.pnlPayment.Controls.Add(this.txtAmountPaid);
            this.pnlPayment.Controls.Add(this.lblChange);
            this.pnlPayment.Controls.Add(this.btnRemoveItem);
            this.pnlPayment.Controls.Add(this.btnCheckout);
            this.pnlPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPayment.Location = new System.Drawing.Point(15, 300);
            this.pnlPayment.Name = "pnlPayment";
            this.pnlPayment.Padding = new System.Windows.Forms.Padding(10);
            this.pnlPayment.Size = new System.Drawing.Size(400, 180);
            this.pnlPayment.TabIndex = 0;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPaymentMethod.Location = new System.Drawing.Point(10, 5);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(150, 22);
            this.lblPaymentMethod.TabIndex = 0;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "GCash"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(10, 28);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(180, 28);
            this.cmbPaymentMethod.TabIndex = 1;
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAmountPaid.Location = new System.Drawing.Point(205, 5);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(150, 22);
            this.lblAmountPaid.TabIndex = 2;
            this.lblAmountPaid.Text = "Amount Paid";
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAmountPaid.Location = new System.Drawing.Point(205, 28);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(180, 32);
            this.txtAmountPaid.TabIndex = 3;
            // 
            // lblChange
            // 
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChange.Location = new System.Drawing.Point(10, 68);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(370, 25);
            this.lblChange.TabIndex = 4;
            this.lblChange.Text = "Change: ₱0.00";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.Location = new System.Drawing.Point(10, 105);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(140, 40);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(165, 105);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(220, 40);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "COMPLETE SALE";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // pnlOrderSummary
            // 
            this.pnlOrderSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pnlOrderSummary.Controls.Add(this.lblSubtotal);
            this.pnlOrderSummary.Controls.Add(this.lblTax);
            this.pnlOrderSummary.Controls.Add(this.lblDiscountPercent);
            this.pnlOrderSummary.Controls.Add(this.numDiscountPercent);
            this.pnlOrderSummary.Controls.Add(this.lblDiscount);
            this.pnlOrderSummary.Controls.Add(this.lblTotal);
            this.pnlOrderSummary.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOrderSummary.Location = new System.Drawing.Point(15, 480);
            this.pnlOrderSummary.Name = "pnlOrderSummary";
            this.pnlOrderSummary.Padding = new System.Windows.Forms.Padding(12);
            this.pnlOrderSummary.Size = new System.Drawing.Size(400, 190);
            this.pnlOrderSummary.TabIndex = 1;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtotal.Location = new System.Drawing.Point(12, 12);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(370, 25);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:                         ₱0.00";
            // 
            // lblTax
            // 
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTax.Location = new System.Drawing.Point(12, 43);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(370, 25);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax:                                  ₱0.00";
            // lblDiscountPercent
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiscountPercent.Location =
                new System.Drawing.Point(12, 74);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size =
                new System.Drawing.Size(120, 23);
            this.lblDiscountPercent.Text = "Discount (%):";

            // numDiscountPercent
            this.numDiscountPercent.DecimalPlaces = 2;
            this.numDiscountPercent.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.numDiscountPercent.Increment = 1;
            this.numDiscountPercent.Location =
                new System.Drawing.Point(260, 70);
            this.numDiscountPercent.Maximum = 100;
            this.numDiscountPercent.Minimum = 0;
            this.numDiscountPercent.Name = "numDiscountPercent";
            this.numDiscountPercent.Size =
                new System.Drawing.Size(120, 27);
            this.numDiscountPercent.Value = 0;

            // lblDiscount
            this.lblDiscount.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.lblDiscount.Location =
                new System.Drawing.Point(12, 105);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size =
                new System.Drawing.Size(370, 25);
            this.lblDiscount.Text = "Discount: ₱0.00";

            // lblTotal
            this.lblTotal.Font =
                new System.Drawing.Font("Segoe UI", 15F,
                    System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.lblTotal.Location =
                new System.Drawing.Point(12, 140);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size =
                new System.Drawing.Size(370, 35);
            this.lblTotal.Text = "TOTAL: ₱0.00";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeight = 29;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvCart.Location = new System.Drawing.Point(15, 95);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(400, 545);
            this.dgvCart.TabIndex = 2;
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCartTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            this.lblCartTitle.Location = new System.Drawing.Point(15, 50);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(400, 45);
            this.lblCartTitle.TabIndex = 3;
            this.lblCartTitle.Text = "SHOPPING CART";
            this.lblCartTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearCart
            // 
            this.btnClearCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            this.btnClearCart.Location = new System.Drawing.Point(15, 15);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(400, 35);
            this.btnClearCart.TabIndex = 4;
            this.btnClearCart.Text = "Clear Cart";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Product";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1250, 760);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "POSForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THEPA POS - Point of Sale";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlProducts.ResumeLayout(false);
            this.pnlProductSearch.ResumeLayout(false);
            this.pnlProductSearch.PerformLayout();
            this.pnlCart.ResumeLayout(false);
            this.pnlPayment.ResumeLayout(false);
            this.pnlPayment.PerformLayout();
            this.pnlOrderSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}