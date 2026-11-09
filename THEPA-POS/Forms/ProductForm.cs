
using System;
using System.Data;
using System.Windows.Forms;
using THEPA_POS.Data.Repositories;

namespace THEPA_POS.Forms
{
    public partial class ProductForm : Form
    {
        private readonly ProductRepository productRepository =
            new ProductRepository();
        private readonly int loggedInUserId;

        private DataTable allProducts = new DataTable();

        // Used by the Visual Studio Designer
        public ProductForm()
        {
            InitializeComponent();
        }

        // Used when opening the form from your application
        public ProductForm(int userId) : this()
        {
            loggedInUserId = userId;

            btnSearch.Click += btnSearch_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnBack.Click += btnBack_Click;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;

            txtSearch.KeyDown += txtSearch_KeyDown;

            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                allProducts = productRepository.GetAll();
                dgvProducts.DataSource = allProducts;
                dgvProducts.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load products.\n\n" + ex.Message,
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SearchProducts();
            }
        }

        private void SearchProducts()
        {
            string search = txtSearch.Text.Trim();

            if (allProducts == null || allProducts.Columns.Count == 0)
                return;

            try
            {
                if (string.IsNullOrWhiteSpace(search))
                {
                    dgvProducts.DataSource = allProducts;
                    return;
                }

                DataView view = new DataView(allProducts);
                string safeSearch = search.Replace("'", "''")
                                          .Replace("[", "[[]")
                                          .Replace("%", "[%]")
                                          .Replace("*", "[*]");

                view.RowFilter =
                    "Convert(ProductId, 'System.String') LIKE '%" + safeSearch + "%' OR " +
                    "Sku LIKE '%" + safeSearch + "%' OR " +
                    "Name LIKE '%" + safeSearch + "%' OR " +
                    "Barcode LIKE '%" + safeSearch + "%'";

                dgvProducts.DataSource = view;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed: " + ex.Message,
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (ProductEditorForm editor =
                new ProductEditorForm(loggedInUserId))
            {
                if (editor.ShowDialog(this) == DialogResult.OK)
                {
                    LoadProducts();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadProducts();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null ||
                dgvProducts.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select a product to update.",
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int productId = Convert.ToInt32(
                    dgvProducts.CurrentRow.Cells["ProductId"].Value);

                using (ProductEditorForm editor =
                    new ProductEditorForm(loggedInUserId, productId))
                {
                    if (editor.ShowDialog(this) == DialogResult.OK)
                    {
                        LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to open product for editing.\n\n" + ex.Message,
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null ||
                dgvProducts.CurrentRow.IsNewRow)
            {
                MessageBox.Show(
                    "Please select a product to deactivate.",
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int productId = Convert.ToInt32(
                dgvProducts.CurrentRow.Cells["ProductId"].Value);

            string productName = Convert.ToString(
                dgvProducts.CurrentRow.Cells["Name"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to deactivate this product?\n\n" +
                productName,
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                productRepository.Deactivate(productId);

                MessageBox.Show(
                    "Product deactivated successfully.",
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to deactivate product.\n\n" + ex.Message,
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}
