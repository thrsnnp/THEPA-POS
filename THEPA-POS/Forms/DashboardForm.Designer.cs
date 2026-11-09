
namespace THEPA_POS.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTotalProducts;
        private System.Windows.Forms.Label lblActiveProducts;
        private System.Windows.Forms.Label lblLowStockCount;
        private System.Windows.Forms.DataGridView dgvLowStock;
        private System.Windows.Forms.Label lblLowStockTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTotalProducts = new System.Windows.Forms.Label();
            this.lblActiveProducts = new System.Windows.Forms.Label();
            this.lblLowStockCount = new System.Windows.Forms.Label();
            this.dgvLowStock = new System.Windows.Forms.DataGridView();
            this.lblLowStockTitle = new System.Windows.Forms.Label();

            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).BeginInit();
            this.SuspendLayout();

            // DashboardForm
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THEPA POS | Dashboard";
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // lblWelcome
            this.lblWelcome.Font = new System.Drawing.Font(
                "Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.lblWelcome.Location = new System.Drawing.Point(35, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(750, 45);
            this.lblWelcome.Text = "Welcome to THEPA POS";

            // lblRole
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRole.ForeColor =
                System.Drawing.Color.FromArgb(100, 100, 100);
            this.lblRole.Location = new System.Drawing.Point(39, 75);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(500, 25);
            this.lblRole.Text = "Role:";

            // btnInventory
            this.btnInventory.BackColor =
                System.Drawing.Color.White;
            this.btnInventory.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.FlatAppearance.BorderSize = 1;
            this.btnInventory.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(220, 220, 225);
            this.btnInventory.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnInventory.ForeColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.btnInventory.Location = new System.Drawing.Point(35, 125);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(320, 60);
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Cursor =
                System.Windows.Forms.Cursors.Hand;

            // btnPOS
            this.btnPOS.BackColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.btnPOS.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Location = new System.Drawing.Point(390, 125);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(320, 60);
            this.btnPOS.Text = "POINT OF SALE";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Cursor =
                System.Windows.Forms.Cursors.Hand;

            // btnReports
            this.btnReports.BackColor =
                System.Drawing.Color.White;
            this.btnReports.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.FlatAppearance.BorderSize = 1;
            this.btnReports.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(220, 220, 225);
            this.btnReports.Font = new System.Drawing.Font(
                "Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.btnReports.Location = new System.Drawing.Point(745, 125);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(320, 60);
            this.btnReports.Text = "REPORTS";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Cursor =
                System.Windows.Forms.Cursors.Hand;

            // lblTotalProducts
            this.lblTotalProducts.BackColor =
                System.Drawing.Color.White;
            this.lblTotalProducts.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalProducts.Font = new System.Drawing.Font(
                "Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotalProducts.ForeColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.lblTotalProducts.Location = new System.Drawing.Point(35, 220);
            this.lblTotalProducts.Name = "lblTotalProducts";
            this.lblTotalProducts.Size = new System.Drawing.Size(320, 90);
            this.lblTotalProducts.Text = "TOTAL PRODUCTS\r\n0";
            this.lblTotalProducts.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // lblActiveProducts
            this.lblActiveProducts.BackColor =
                System.Drawing.Color.White;
            this.lblActiveProducts.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblActiveProducts.Font = new System.Drawing.Font(
                "Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblActiveProducts.ForeColor =
                System.Drawing.Color.FromArgb(40, 130, 90);
            this.lblActiveProducts.Location = new System.Drawing.Point(390, 220);
            this.lblActiveProducts.Name = "lblActiveProducts";
            this.lblActiveProducts.Size = new System.Drawing.Size(320, 90);
            this.lblActiveProducts.Text = "ACTIVE PRODUCTS\r\n0";
            this.lblActiveProducts.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // lblLowStockCount
            this.lblLowStockCount.BackColor =
                System.Drawing.Color.White;
            this.lblLowStockCount.BorderStyle =
                System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLowStockCount.Font = new System.Drawing.Font(
                "Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblLowStockCount.ForeColor =
                System.Drawing.Color.FromArgb(190, 120, 30);
            this.lblLowStockCount.Location = new System.Drawing.Point(745, 220);
            this.lblLowStockCount.Name = "lblLowStockCount";
            this.lblLowStockCount.Size = new System.Drawing.Size(320, 90);
            this.lblLowStockCount.Text = "LOW-STOCK ITEMS\r\n0";
            this.lblLowStockCount.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // lblLowStockTitle
            this.lblLowStockTitle.Font = new System.Drawing.Font(
                "Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblLowStockTitle.ForeColor =
                System.Drawing.Color.FromArgb(45, 45, 55);
            this.lblLowStockTitle.Location = new System.Drawing.Point(35, 340);
            this.lblLowStockTitle.Name = "lblLowStockTitle";
            this.lblLowStockTitle.Size = new System.Drawing.Size(600, 35);
            this.lblLowStockTitle.Text = "LOW-STOCK ITEM DETAILS";

            // dgvLowStock
            this.dgvLowStock.AllowUserToAddRows = false;
            this.dgvLowStock.AllowUserToDeleteRows = false;
            this.dgvLowStock.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLowStock.BackgroundColor =
                System.Drawing.Color.White;
            this.dgvLowStock.BorderStyle =
                System.Windows.Forms.BorderStyle.None;
            this.dgvLowStock.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLowStock.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLowStock.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.dgvLowStock.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;
            this.dgvLowStock.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 10F,
                    System.Drawing.FontStyle.Bold);
            this.dgvLowStock.ColumnHeadersHeight = 42;
            this.dgvLowStock.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 10F);
            this.dgvLowStock.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(245, 225, 230);
            this.dgvLowStock.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(45, 45, 55);
            this.dgvLowStock.EnableHeadersVisualStyles = false;
            this.dgvLowStock.GridColor =
                System.Drawing.Color.FromArgb(235, 235, 240);
            this.dgvLowStock.Location = new System.Drawing.Point(35, 385);
            this.dgvLowStock.MultiSelect = false;
            this.dgvLowStock.Name = "dgvLowStock";
            this.dgvLowStock.ReadOnly = true;
            this.dgvLowStock.RowHeadersVisible = false;
            this.dgvLowStock.RowTemplate.Height = 38;
            this.dgvLowStock.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLowStock.Size = new System.Drawing.Size(1030, 220);
            this.dgvLowStock.TabIndex = 6;

            // btnLogout
            this.btnLogout.BackColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.btnLogout.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(915, 620);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 40);
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Cursor =
                System.Windows.Forms.Cursors.Hand;

            // statusStrip
            this.statusStrip.BackColor =
                System.Drawing.Color.White;
            this.statusStrip.ImageScalingSize =
                new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[] {
                    this.statusLabel
                });
            this.statusStrip.Location =
                new System.Drawing.Point(0, 674);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size =
                new System.Drawing.Size(1100, 26);

            // statusLabel
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size =
                new System.Drawing.Size(137, 20);
            this.statusLabel.Text = "THEPA POS | Ready";

            // Add controls
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnPOS);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.lblTotalProducts);
            this.Controls.Add(this.lblActiveProducts);
            this.Controls.Add(this.lblLowStockCount);
            this.Controls.Add(this.lblLowStockTitle);
            this.Controls.Add(this.dgvLowStock);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.statusStrip);

            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLowStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
