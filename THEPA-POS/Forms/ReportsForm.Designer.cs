
namespace THEPA_POS.Forms
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblDateFilter;
        private System.Windows.Forms.ComboBox cmbDateFilter;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Panel pnlTotalSales;
        private System.Windows.Forms.Label lblTotalSalesTitle;
        private System.Windows.Forms.Label lblTotalSalesValue;

        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Label lblTransactionsTitle;
        private System.Windows.Forms.Label lblTransactionsValue;

        private System.Windows.Forms.Panel pnlAverageSale;
        private System.Windows.Forms.Label lblAverageSaleTitle;
        private System.Windows.Forms.Label lblAverageSaleValue;

        private System.Windows.Forms.TabControl tabReports;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.DataGridView dgvTopProducts;

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblDateFilter = new System.Windows.Forms.Label();
            this.cmbDateFilter = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.pnlTotalSales = new System.Windows.Forms.Panel();
            this.lblTotalSalesTitle = new System.Windows.Forms.Label();
            this.lblTotalSalesValue = new System.Windows.Forms.Label();

            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.lblTransactionsTitle = new System.Windows.Forms.Label();
            this.lblTransactionsValue = new System.Windows.Forms.Label();

            this.pnlAverageSale = new System.Windows.Forms.Panel();
            this.lblAverageSaleTitle = new System.Windows.Forms.Label();
            this.lblAverageSaleValue = new System.Windows.Forms.Label();

            this.tabReports = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.dgvTopProducts = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProducts)).BeginInit();
            this.tabReports.SuspendLayout();
            this.tabSales.SuspendLayout();
            this.tabProducts.SuspendLayout();
            this.SuspendLayout();

            // FORM
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 248);
            this.ClientSize = new System.Drawing.Size(1150, 760);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THEPA POS - Reports";

            // HEADER
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(123, 20, 43);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 100;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 12);
            this.lblTitle.Text = "REPORTS";

            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubtitle.Location = new System.Drawing.Point(30, 62);
            this.lblSubtitle.Text = "Sales performance and product reports";

            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.lblSubtitle);

            // FILTER PANEL
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.Location = new System.Drawing.Point(25, 120);
            this.pnlFilters.Size = new System.Drawing.Size(1100, 85);
            this.pnlFilters.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            this.lblDateFilter.AutoSize = true;
            this.lblDateFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDateFilter.Location = new System.Drawing.Point(15, 12);
            this.lblDateFilter.Text = "Date Range";

            this.cmbDateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbDateFilter.Items.AddRange(new object[]
            {
                "Today",
                "This Week",
                "This Month",
                "This Year",
                "Custom Range"
            });
            this.cmbDateFilter.SelectedIndex = 0;
            this.cmbDateFilter.Location = new System.Drawing.Point(15, 38);
            this.cmbDateFilter.Size = new System.Drawing.Size(145, 28);

            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStartDate.Location = new System.Drawing.Point(180, 12);
            this.lblStartDate.Text = "Start Date";

            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(180, 40);
            this.dtpStartDate.Size = new System.Drawing.Size(135, 22);

            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEndDate.Location = new System.Drawing.Point(335, 12);
            this.lblEndDate.Text = "End Date";

            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(335, 40);
            this.dtpEndDate.Size = new System.Drawing.Size(135, 22);

            this.btnApplyFilter.BackColor = System.Drawing.Color.FromArgb(123, 20, 43);
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.Location = new System.Drawing.Point(495, 35);
            this.btnApplyFilter.Size = new System.Drawing.Size(115, 35);
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = false;

            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(620, 35);
            this.btnRefresh.Size = new System.Drawing.Size(95, 35);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;

            this.btnBack.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(730, 35);
            this.btnBack.Size = new System.Drawing.Size(85, 35);
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;

            this.pnlFilters.Controls.Add(this.lblDateFilter);
            this.pnlFilters.Controls.Add(this.cmbDateFilter);
            this.pnlFilters.Controls.Add(this.lblStartDate);
            this.pnlFilters.Controls.Add(this.dtpStartDate);
            this.pnlFilters.Controls.Add(this.lblEndDate);
            this.pnlFilters.Controls.Add(this.dtpEndDate);
            this.pnlFilters.Controls.Add(this.btnApplyFilter);
            this.pnlFilters.Controls.Add(this.btnRefresh);
            this.pnlFilters.Controls.Add(this.btnBack);

            // TOTAL SALES CARD
            this.pnlTotalSales.BackColor = System.Drawing.Color.White;
            this.pnlTotalSales.Location = new System.Drawing.Point(25, 225);
            this.pnlTotalSales.Size = new System.Drawing.Size(350, 105);

            this.lblTotalSalesTitle.AutoSize = true;
            this.lblTotalSalesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTotalSalesTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalSalesTitle.Location = new System.Drawing.Point(18, 15);
            this.lblTotalSalesTitle.Text = "TOTAL SALES";

            this.lblTotalSalesValue.AutoSize = true;
            this.lblTotalSalesValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTotalSalesValue.ForeColor = System.Drawing.Color.FromArgb(123, 20, 43);
            this.lblTotalSalesValue.Location = new System.Drawing.Point(18, 42);
            this.lblTotalSalesValue.Text = "₱0.00";

            this.pnlTotalSales.Controls.Add(this.lblTotalSalesTitle);
            this.pnlTotalSales.Controls.Add(this.lblTotalSalesValue);

            // TRANSACTIONS CARD
            this.pnlTransactions.BackColor = System.Drawing.Color.White;
            this.pnlTransactions.Location = new System.Drawing.Point(400, 225);
            this.pnlTransactions.Size = new System.Drawing.Size(350, 105);

            this.lblTransactionsTitle.AutoSize = true;
            this.lblTransactionsTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTransactionsTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTransactionsTitle.Location = new System.Drawing.Point(18, 15);
            this.lblTransactionsTitle.Text = "TOTAL TRANSACTIONS";

            this.lblTransactionsValue.AutoSize = true;
            this.lblTransactionsValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTransactionsValue.ForeColor = System.Drawing.Color.FromArgb(123, 20, 43);
            this.lblTransactionsValue.Location = new System.Drawing.Point(18, 42);
            this.lblTransactionsValue.Text = "0";

            this.pnlTransactions.Controls.Add(this.lblTransactionsTitle);
            this.pnlTransactions.Controls.Add(this.lblTransactionsValue);

            // AVERAGE SALE CARD
            this.pnlAverageSale.BackColor = System.Drawing.Color.White;
            this.pnlAverageSale.Location = new System.Drawing.Point(775, 225);
            this.pnlAverageSale.Size = new System.Drawing.Size(350, 105);

            this.lblAverageSaleTitle.AutoSize = true;
            this.lblAverageSaleTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAverageSaleTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblAverageSaleTitle.Location = new System.Drawing.Point(18, 15);
            this.lblAverageSaleTitle.Text = "AVERAGE SALE";

            this.lblAverageSaleValue.AutoSize = true;
            this.lblAverageSaleValue.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblAverageSaleValue.ForeColor = System.Drawing.Color.FromArgb(123, 20, 43);
            this.lblAverageSaleValue.Location = new System.Drawing.Point(18, 42);
            this.lblAverageSaleValue.Text = "₱0.00";

            this.pnlAverageSale.Controls.Add(this.lblAverageSaleTitle);
            this.pnlAverageSale.Controls.Add(this.lblAverageSaleValue);

            // REPORT TABS
            this.tabReports.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabReports.Location = new System.Drawing.Point(25, 350);
            this.tabReports.Size = new System.Drawing.Size(1100, 385);
            this.tabReports.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;

            // SALES TAB
            this.tabSales.Text = "Sales Transactions";
            this.tabSales.BackColor = System.Drawing.Color.White;

            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.BackgroundColor = System.Drawing.Color.White;
            this.dgvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSales.ReadOnly = true;
            this.dgvSales.RowHeadersVisible = false;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.MultiSelect = false;
            this.dgvSales.AutoGenerateColumns = true;

            this.tabSales.Controls.Add(this.dgvSales);

            // PRODUCTS TAB
            this.tabProducts.Text = "Best-Selling Products";
            this.tabProducts.BackColor = System.Drawing.Color.White;

            this.dgvTopProducts.AllowUserToAddRows = false;
            this.dgvTopProducts.AllowUserToDeleteRows = false;
            this.dgvTopProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTopProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopProducts.ReadOnly = true;
            this.dgvTopProducts.RowHeadersVisible = false;
            this.dgvTopProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopProducts.MultiSelect = false;
            this.dgvTopProducts.AutoGenerateColumns = true;

            this.tabProducts.Controls.Add(this.dgvTopProducts);

            this.tabReports.Controls.Add(this.tabSales);
            this.tabReports.Controls.Add(this.tabProducts);

            // ADD CONTROLS
            this.Controls.Add(this.tabReports);
            this.Controls.Add(this.pnlAverageSale);
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.pnlTotalSales);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlHeader);

            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProducts)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            this.tabProducts.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlTotalSales.ResumeLayout(false);
            this.pnlTotalSales.PerformLayout();
            this.pnlTransactions.ResumeLayout(false);
            this.pnlTransactions.PerformLayout();
            this.pnlAverageSale.ResumeLayout(false);
            this.pnlAverageSale.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
