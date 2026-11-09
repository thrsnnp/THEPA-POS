
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using THEPA_POS.Data.Repositories;

namespace THEPA_POS.Forms
{
    public partial class POSForm : Form
    {
        private readonly ProductRepository productRepository =
            new ProductRepository();

        private readonly SalesRepository salesRepository =
            new SalesRepository();

        private readonly int loggedInUserId;
        private readonly string cashierName;

        private decimal currentSubtotal;
        private decimal currentTax;
        private decimal currentDiscount;
        private decimal currentTotal;

        private DataTable allProducts = new DataTable();
        private DataTable cart = new DataTable();

        public POSForm()
        {
            InitializeComponent();
        }

        public POSForm(int userId, string name) : this()
        {
            loggedInUserId = userId;
            cashierName = name;

            InitializeCart();

            LoadCategories();
            LoadProducts();

            txtSearchProduct.TextChanged +=
                txtSearchProduct_TextChanged;

            cmbCategory.SelectedIndexChanged +=
                cmbCategory_SelectedIndexChanged;

            txtAmountPaid.TextChanged +=
                txtAmountPaid_TextChanged;

            numDiscountPercent.ValueChanged +=
                numDiscountPercent_ValueChanged;

            btnClearCart.Click += btnClearCart_Click;
            btnRemoveItem.Click += btnRemoveItem_Click;
            btnBack.Click += btnBack_Click;
            btnCheckout.Click += btnCheckout_Click;
        }

        private void InitializeCart()
        {
            cart.Columns.Add("ProductId", typeof(int));
            cart.Columns.Add("ProductName", typeof(string));
            cart.Columns.Add("UnitPrice", typeof(decimal));
            cart.Columns.Add("Quantity", typeof(int));
            cart.Columns.Add("LineTotal", typeof(decimal));

            dgvCart.DataSource = cart;
        }

        private void LoadCategories()
        {
            try
            {
                DataTable categories =
                    productRepository.GetActiveCategories();

                DataRow allRow = categories.NewRow();
                allRow["CategoryId"] = 0;
                allRow["Name"] = "All Categories";

                categories.Rows.InsertAt(allRow, 0);

                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load categories.\n\n" + ex.Message);
            }
        }

        private void LoadProducts()
        {
            try
            {
                allProducts =
                    productRepository.GetActiveProductsForPOS();

                DisplayProducts(allProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load POS products.\n\n" + ex.Message,
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void DisplayProducts(DataTable products)
        {
            flpProducts.Controls.Clear();

            foreach (DataRow row in products.Rows)
            {
                Button productButton = new Button();

                string name = row["Name"].ToString();
                decimal price = Convert.ToDecimal(row["Price"]);
                int stock = Convert.ToInt32(row["StockQty"]);

                productButton.Width = 180;
                productButton.Height = 115;
                productButton.Margin = new Padding(8);

                productButton.FlatStyle = FlatStyle.Flat;
                productButton.BackColor = Color.White;
                productButton.ForeColor =
                    Color.FromArgb(123, 20, 43);

                productButton.Font = new Font(
                    "Segoe UI", 10F, FontStyle.Bold);

                productButton.Text =
                    name + "\n\n" +
                    price.ToString("C2") + "\n" +
                    "Stock: " + stock;

                int productId = Convert.ToInt32(row["ProductId"]);

                productButton.Tag = productId;

                productButton.Click +=
                    (sender, e) =>
                    {
                        AddToCart(productId);
                    };

                flpProducts.Controls.Add(productButton);
            }
        }

        private void FilterProducts()
        {
            if (allProducts == null ||
                allProducts.Rows.Count == 0)
                return;

            DataView view = new DataView(allProducts);

            string search = txtSearchProduct.Text.Trim()
                .Replace("'", "''")
                .Replace("[", "[[]")
                .Replace("%", "[%]")
                .Replace("*", "[*]");

            string filter = "";

            if (!string.IsNullOrWhiteSpace(search))
            {
                filter =
                    "Name LIKE '%" + search + "%' OR " +
                    "Barcode LIKE '%" + search + "%'";
            }

            if (cmbCategory.SelectedValue != null &&
                cmbCategory.SelectedValue != DBNull.Value)
            {
                int categoryId = Convert.ToInt32(
                    cmbCategory.SelectedValue);

                if (categoryId != 0)
                {
                    string categoryFilter =
                        "CategoryId = " + categoryId;

                    filter = string.IsNullOrEmpty(filter)
                        ? categoryFilter
                        : "(" + filter + ") AND " +
                          categoryFilter;
                }
            }

            view.RowFilter = filter;

            DisplayProducts(view.ToTable());
        }

        private void txtSearchProduct_TextChanged(
            object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void cmbCategory_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void AddToCart(int productId)
        {
            DataRow[] products = allProducts.Select(
                "ProductId = " + productId);

            if (products.Length == 0)
                return;

            DataRow product = products[0];

            int stock = Convert.ToInt32(product["StockQty"]);

            DataRow[] existingItems = cart.Select(
                "ProductId = " + productId);

            if (existingItems.Length > 0)
            {
                int currentQuantity =
                    Convert.ToInt32(existingItems[0]["Quantity"]);

                if (currentQuantity >= stock)
                {
                    MessageBox.Show(
                        "Not enough stock available.",
                        "THEPA POS",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                existingItems[0]["Quantity"] =
                    currentQuantity + 1;
            }
            else
            {
                DataRow newRow = cart.NewRow();

                newRow["ProductId"] = productId;
                newRow["ProductName"] = product["Name"];
                newRow["UnitPrice"] = product["Price"];
                newRow["Quantity"] = 1;

                cart.Rows.Add(newRow);
            }

            UpdateCart();
        }

        private void UpdateCart()
        {
            currentSubtotal = 0;

            foreach (DataRow row in cart.Rows)
            {
                decimal price = Convert.ToDecimal(row["UnitPrice"]);
                int quantity = Convert.ToInt32(row["Quantity"]);

                decimal lineTotal = price * quantity;

                row["LineTotal"] = lineTotal;
                currentSubtotal += lineTotal;
            }

            currentTax = Math.Round(
                currentSubtotal * 0.12m, 2);

            decimal discountPercent =
                numDiscountPercent.Value;

            currentDiscount = Math.Round(
                currentSubtotal * discountPercent / 100m, 2);

            currentTotal =
                currentSubtotal + currentTax - currentDiscount;

            lblSubtotal.Text =
                "Subtotal: " + currentSubtotal.ToString("C2");

            lblTax.Text =
                "Tax (12%): " + currentTax.ToString("C2");

            lblDiscount.Text =
                "Discount: " + currentDiscount.ToString("C2");

            lblTotal.Text =
                "TOTAL: " + currentTotal.ToString("C2");

            UpdateChange();
        }

        private void numDiscountPercent_ValueChanged(
            object sender, EventArgs e)
        {
            UpdateCart();
        }

        private void UpdateChange()
        {
            decimal amountPaid = 0;

            decimal.TryParse(
                txtAmountPaid.Text, out amountPaid);

            decimal change = amountPaid - currentTotal;

            if (change < 0)
                change = 0;

            lblChange.Text =
                "Change: " + change.ToString("C2");
        }

        private void txtAmountPaid_TextChanged(
            object sender, EventArgs e)
        {
            UpdateChange();
        }

        private void btnClearCart_Click(
            object sender, EventArgs e)
        {
            if (cart.Rows.Count == 0)
                return;

            cart.Clear();
            txtAmountPaid.Clear();
            numDiscountPercent.Value = 0;

            UpdateCart();
        }

        private void btnRemoveItem_Click(
            object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow == null)
                return;

            int productId = Convert.ToInt32(
                dgvCart.CurrentRow.Cells["ProductId"].Value);

            DataRow[] rows = cart.Select(
                "ProductId = " + productId);

            if (rows.Length > 0)
                cart.Rows.Remove(rows[0]);

            UpdateCart();
        }

        private void btnCheckout_Click(
            object sender, EventArgs e)
        {
            if (cart.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Please add products to the cart first.",
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            decimal amountPaid;

            if (!decimal.TryParse(
                txtAmountPaid.Text, out amountPaid))
            {
                MessageBox.Show(
                    "Please enter a valid payment amount.",
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            UpdateCart();

            if (amountPaid < currentTotal)
            {
                MessageBox.Show(
                    "Insufficient payment. Please enter the correct amount.",
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string paymentMethod = cmbPaymentMethod.Text;

            if (string.IsNullOrWhiteSpace(paymentMethod))
            {
                MessageBox.Show(
                    "Please select a payment method.");

                return;
            }

            try
            {
                string orderNumber;

                decimal subtotal;
                decimal tax;
                decimal discount;
                decimal total;

                salesRepository.CompleteSale(
                    cart,
                    loggedInUserId,
                    paymentMethod,
                    amountPaid,
                    numDiscountPercent.Value,
                    out orderNumber,
                    out subtotal,
                    out tax,
                    out discount,
                    out total
                );

                decimal change = amountPaid - total;

                DataTable receiptItems = cart.Copy();

                using (ReceiptForm receipt = new ReceiptForm(
                    orderNumber,
                    DateTime.Now,
                    cashierName,
                    receiptItems,
                    subtotal,
                    tax,
                    discount,
                    total,
                    paymentMethod,
                    amountPaid,
                    change))
                {
                    receipt.ShowDialog(this);
                }

                cart.Clear();
                txtAmountPaid.Clear();
                numDiscountPercent.Value = 0;

                LoadProducts();
                UpdateCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Checkout failed.\n\n" + ex.Message,
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(
            object sender, EventArgs e)
        {
            Close();
        }
    }
}
