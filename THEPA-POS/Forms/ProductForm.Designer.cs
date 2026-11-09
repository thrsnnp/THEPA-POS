
namespace THEPA_POS.Forms
{
    partial class ProductForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();

            // ProductForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(1150, 760);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THEPA POS - Inventory Management";

            // pnlHeader
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(123, 20, 43);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1150, 115);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(35, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "Inventory Management";

            // lblSubtitle
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor =
                System.Drawing.Color.FromArgb(240, 220, 225);
            this.lblSubtitle.Location = new System.Drawing.Point(39, 72);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Manage products, stock levels, and inventory records";

            // pnlToolbar
            this.pnlToolbar.BackColor = System.Drawing.Color.White;
            this.pnlToolbar.Controls.Add(this.lblSearch);
            this.pnlToolbar.Controls.Add(this.txtSearch);
            this.pnlToolbar.Controls.Add(this.btnSearch);
            this.pnlToolbar.Controls.Add(this.btnAdd);
            this.pnlToolbar.Controls.Add(this.btnEdit);
            this.pnlToolbar.Controls.Add(this.btnDelete);
            this.pnlToolbar.Controls.Add(this.btnRefresh);
            this.pnlToolbar.Location = new System.Drawing.Point(30, 140);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1090, 125);
            this.pnlToolbar.TabIndex = 1;
            this.pnlToolbar.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // lblSearch
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(65, 65, 75);
            this.lblSearch.Location = new System.Drawing.Point(22, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Text = "SEARCH PRODUCTS";

            // txtSearch
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(25, 43);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 30);
            this.txtSearch.TabIndex = 0;

            // btnSearch
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(123, 20, 43);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(390, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(123, 20, 43);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+ ADD PRODUCT";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnEdit
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(235, 235, 240);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(55, 55, 65);
            this.btnEdit.Location = new System.Drawing.Point(180, 85);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 32);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "EDIT PRODUCT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnDelete
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(190, 55, 65);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(335, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 32);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "DEACTIVATE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;

            // btnRefresh
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(235, 235, 240);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(55, 55, 65);
            this.btnRefresh.Location = new System.Drawing.Point(500, 85);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 32);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;

            // lblTableTitle
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.lblTableTitle.AutoSize = true;
            this.lblTableTitle.Font = new System.Drawing.Font(
                "Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTableTitle.ForeColor =
                System.Drawing.Color.FromArgb(45, 45, 55);
            this.lblTableTitle.Location = new System.Drawing.Point(32, 285);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Text = "Product Inventory";

            // dgvProducts
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.ColumnHeadersHeight = 45;
            this.dgvProducts.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor =
                System.Drawing.Color.FromArgb(235, 235, 240);
            this.dgvProducts.Location = new System.Drawing.Point(30, 320);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 38;
            this.dgvProducts.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1090, 350);
            this.dgvProducts.TabIndex = 6;
            this.dgvProducts.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // Column headers
            this.dgvProducts.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvProducts.ColumnHeadersDefaultCellStyle.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvProducts.ColumnHeadersDefaultCellStyle.Padding =
                new System.Windows.Forms.Padding(8, 0, 0, 0);

            // Rows
            this.dgvProducts.DefaultCellStyle.BackColor =
                System.Drawing.Color.White;
            this.dgvProducts.DefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(50, 50, 60);
            this.dgvProducts.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 9F);
            this.dgvProducts.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(248, 230, 235);
            this.dgvProducts.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(80, 20, 35);
            this.dgvProducts.DefaultCellStyle.Padding =
                new System.Windows.Forms.Padding(8, 0, 0, 0);

            this.dgvProducts.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(249, 249, 251);

            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(210, 210, 215);
            this.btnBack.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(65, 65, 75);
            this.btnBack.Location = new System.Drawing.Point(970, 690);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 38);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "BACK TO DASHBOARD";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;

            // Add controls
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.lblTableTitle);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnBack);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.Button btnBack;
    }
}
