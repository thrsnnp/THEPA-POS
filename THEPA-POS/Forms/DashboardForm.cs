
using System;
using System.Data;
using System.Windows.Forms;
using THEPA_POS.Domain.Entities;
using THEPA_POS.Data.Repositories;

namespace THEPA_POS.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly User loggedInUser;
        private readonly ProductRepository productRepository;

        public DashboardForm(User user)
        {
            InitializeComponent();

            loggedInUser = user;
            productRepository = new ProductRepository();

            lblWelcome.Text = "Welcome, " + user.FullName + "!";
            lblRole.Text = "Role: " + user.RoleName;

            btnInventory.Click += btnProducts_Click;

            btnPOS.Click += btnPOS_Click;

            btnReports.Click += btnReports_Click;

            btnLogout.Click += btnLogout_Click;

            LoadDashboardData();

            ApplyRolePermissions();
        }

        private void LoadDashboardData()
        {
            try
            {
                int totalProducts =
                    productRepository.GetTotalProductCount();

                int activeProducts =
                    productRepository.GetActiveProductCount();

                int lowStockCount =
                    productRepository.GetLowStockItemCount();

                DataTable lowStockItems =
                    productRepository.GetLowStockItems();

                lblTotalProducts.Text =
                    "Total Products: " + totalProducts;

                lblActiveProducts.Text =
                    "Active Products: " + activeProducts;

                lblLowStockCount.Text =
                    "Low-Stock Items: " + lowStockCount;

                dgvLowStock.DataSource = lowStockItems;

                // Hide the internal product ID.
                if (dgvLowStock.Columns.Contains("ProductId"))
                    dgvLowStock.Columns["ProductId"].Visible = false;

                // Make the column headings easier to read.
                if (dgvLowStock.Columns.Contains("Name"))
                    dgvLowStock.Columns["Name"].HeaderText = "Product Name";

                if (dgvLowStock.Columns.Contains("Sku"))
                    dgvLowStock.Columns["Sku"].HeaderText = "SKU";

                if (dgvLowStock.Columns.Contains("Barcode"))
                    dgvLowStock.Columns["Barcode"].HeaderText = "Barcode";

                if (dgvLowStock.Columns.Contains("CategoryName"))
                    dgvLowStock.Columns["CategoryName"].HeaderText = "Category";

                if (dgvLowStock.Columns.Contains("StockQty"))
                    dgvLowStock.Columns["StockQty"].HeaderText = "Current Stock";

                if (dgvLowStock.Columns.Contains("ReorderLevel"))
                    dgvLowStock.Columns["ReorderLevel"].HeaderText = "Reorder Level";

                if (dgvLowStock.Columns.Contains("Price"))
                    dgvLowStock.Columns["Price"].DefaultCellStyle.Format = "N2";

                if (lowStockItems.Rows.Count == 0)
                {
                    statusLabel.Text =
                        "THEPA POS | No low-stock items";
                }
                else
                {
                    statusLabel.Text =
                        "THEPA POS | " + lowStockCount +
                        " low-stock item(s) need attention";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard data.\n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ApplyRolePermissions()
        {
            string role = loggedInUser.RoleName;

            // Cashiers can use the POS only.
            if (role == "Cashier")
            {
                btnInventory.Enabled = false;
                btnReports.Enabled = false;
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            using (ProductForm productForm =
                new ProductForm(loggedInUser.UserId))
            {
                productForm.ShowDialog(this);

                // Refresh the dashboard after closing Products.
                LoadDashboardData();
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POSForm posForm = new POSForm(
                loggedInUser.UserId,
                loggedInUser.FullName
            );
            posForm.ShowDialog(this);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            using (ReportsForm reportsForm = new ReportsForm())
            {
                reportsForm.ShowDialog(this);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
