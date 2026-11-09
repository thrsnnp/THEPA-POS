
namespace THEPA_POS.Forms
{
    partial class ProductEditorForm
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
            this.lblSku = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblCost = new System.Windows.Forms.Label();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.lblReorder = new System.Windows.Forms.Label();
            this.numReorder = new System.Windows.Forms.NumericUpDown();
            this.lblActive = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorder)).BeginInit();

            this.SuspendLayout();

            // ProductEditorForm
            this.BackColor =
                System.Drawing.Color.FromArgb(245, 246, 250);
            this.ClientSize = new System.Drawing.Size(520, 650);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductEditorForm";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THEPA POS - Product Editor";

            // lblTitle
            this.lblTitle.BackColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location =
                new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size =
                new System.Drawing.Size(520, 75);
            this.lblTitle.Text = "PRODUCT DETAILS";
            this.lblTitle.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // lblSku
            this.lblSku.AutoSize = true;
            this.lblSku.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSku.Location =
                new System.Drawing.Point(40, 105);
            this.lblSku.Name = "lblSku";
            this.lblSku.Text = "SKU:";

            // txtSku
            this.txtSku.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSku.Location =
                new System.Drawing.Point(180, 101);
            this.txtSku.MaxLength = 30;
            this.txtSku.Name = "txtSku";
            this.txtSku.Size =
                new System.Drawing.Size(290, 30);
            this.txtSku.TabIndex = 0;

            // lblBarcode
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBarcode.Location =
                new System.Drawing.Point(40, 150);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Text = "Barcode:";

            // txtBarcode
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBarcode.Location =
                new System.Drawing.Point(180, 146);
            this.txtBarcode.MaxLength = 50;
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size =
                new System.Drawing.Size(290, 30);
            this.txtBarcode.TabIndex = 1;

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblName.Location =
                new System.Drawing.Point(40, 195);
            this.lblName.Name = "lblName";
            this.lblName.Text = "Product Name:";

            // txtName
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location =
                new System.Drawing.Point(180, 191);
            this.txtName.MaxLength = 150;
            this.txtName.Name = "txtName";
            this.txtName.Size =
                new System.Drawing.Size(290, 30);
            this.txtName.TabIndex = 2;

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location =
                new System.Drawing.Point(40, 240);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Text = "Category:";

            // cmbCategory
            this.cmbCategory.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.Location =
                new System.Drawing.Point(180, 236);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size =
                new System.Drawing.Size(290, 30);
            this.cmbCategory.TabIndex = 3;

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location =
                new System.Drawing.Point(40, 285);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Text = "Selling Price:";

            // numPrice
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numPrice.Location =
                new System.Drawing.Point(180, 281);
            this.numPrice.Maximum = 100000000;
            this.numPrice.Name = "numPrice";
            this.numPrice.Size =
                new System.Drawing.Size(290, 30);
            this.numPrice.TabIndex = 4;
            this.numPrice.ThousandsSeparator = true;

            // lblCost
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCost.Location =
                new System.Drawing.Point(40, 330);
            this.lblCost.Name = "lblCost";
            this.lblCost.Text = "Cost:";

            // numCost
            this.numCost.DecimalPlaces = 2;
            this.numCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numCost.Location =
                new System.Drawing.Point(180, 326);
            this.numCost.Maximum = 100000000;
            this.numCost.Name = "numCost";
            this.numCost.Size =
                new System.Drawing.Size(290, 30);
            this.numCost.TabIndex = 5;
            this.numCost.ThousandsSeparator = true;

            // lblStock
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStock.Location =
                new System.Drawing.Point(40, 375);
            this.lblStock.Name = "lblStock";
            this.lblStock.Text = "Initial Stock:";

            // numStock
            this.numStock.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numStock.Location =
                new System.Drawing.Point(180, 371);
            this.numStock.Maximum = 1000000;
            this.numStock.Name = "numStock";
            this.numStock.Size =
                new System.Drawing.Size(290, 30);
            this.numStock.TabIndex = 6;
            this.numStock.ThousandsSeparator = true;

            // lblReorder
            this.lblReorder.AutoSize = true;
            this.lblReorder.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblReorder.Location =
                new System.Drawing.Point(40, 420);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Text = "Reorder Level:";

            // numReorder
            this.numReorder.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numReorder.Location =
                new System.Drawing.Point(180, 416);
            this.numReorder.Maximum = 1000000;
            this.numReorder.Name = "numReorder";
            this.numReorder.Size =
                new System.Drawing.Size(290, 30);
            this.numReorder.TabIndex = 7;
            this.numReorder.ThousandsSeparator = true;

            // lblActive
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblActive.Location =
                new System.Drawing.Point(40, 465);
            this.lblActive.Name = "lblActive";
            this.lblActive.Text = "Status:";

            // chkActive
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState =
                System.Windows.Forms.CheckState.Checked;
            this.chkActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkActive.Location =
                new System.Drawing.Point(180, 464);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size =
                new System.Drawing.Size(80, 25);
            this.chkActive.TabIndex = 8;
            this.chkActive.Text = "Active";

            // btnSave
            this.btnSave.BackColor =
                System.Drawing.Color.FromArgb(123, 20, 43);
            this.btnSave.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location =
                new System.Drawing.Point(180, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size =
                new System.Drawing.Size(140, 42);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE PRODUCT";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Cursor =
                System.Windows.Forms.Cursors.Hand;

            // btnCancel
            this.btnCancel.BackColor =
                System.Drawing.Color.White;
            this.btnCancel.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderColor =
                System.Drawing.Color.FromArgb(200, 200, 205);
            this.btnCancel.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor =
                System.Drawing.Color.FromArgb(70, 70, 80);
            this.btnCancel.DialogResult =
                System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location =
                new System.Drawing.Point(330, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size =
                new System.Drawing.Size(140, 42);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Cursor =
                System.Windows.Forms.Cursors.Hand;

            // Add controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSku);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.numCost);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.lblReorder);
            this.Controls.Add(this.numReorder);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);

            this.AcceptButton = this.btnSave;
            this.CancelButton = this.btnCancel;

            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReorder)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.NumericUpDown numReorder;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
