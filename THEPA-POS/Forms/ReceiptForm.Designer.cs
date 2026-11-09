using System.Windows.Forms;


namespace THEPA_POS.Forms
{
    partial class ReceiptForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblStoreSubtitle;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblCashier;
        private System.Windows.Forms.DataGridView dgvReceiptItems;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblAmountPaid;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblThankYou;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblStoreSubtitle = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.dgvReceiptItems = new System.Windows.Forms.DataGridView();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblAmountPaid = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblThankYou = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptItems)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            this.pnlHeader.Controls.Add(this.lblStoreName);
            this.pnlHeader.Controls.Add(this.lblStoreSubtitle);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(460, 105);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblStoreName
            // 
            this.lblStoreName.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblStoreName.ForeColor = System.Drawing.Color.White;
            this.lblStoreName.Location = new System.Drawing.Point(0, 12);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(460, 45);
            this.lblStoreName.TabIndex = 0;
            this.lblStoreName.Text = "THEPA POS";
            this.lblStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStoreSubtitle
            // 
            this.lblStoreSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStoreSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblStoreSubtitle.Location = new System.Drawing.Point(0, 58);
            this.lblStoreSubtitle.Name = "lblStoreSubtitle";
            this.lblStoreSubtitle.Size = new System.Drawing.Size(460, 25);
            this.lblStoreSubtitle.TabIndex = 1;
            this.lblStoreSubtitle.Text = "SALES RECEIPT";
            this.lblStoreSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrderNumber.Location = new System.Drawing.Point(25, 125);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(410, 25);
            this.lblOrderNumber.TabIndex = 1;
            this.lblOrderNumber.Text = "Order No: ";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrderDate.Location = new System.Drawing.Point(25, 153);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(410, 25);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Date: ";
            // 
            // lblCashier
            // 
            this.lblCashier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCashier.Location = new System.Drawing.Point(25, 181);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(410, 25);
            this.lblCashier.TabIndex = 3;
            this.lblCashier.Text = "Cashier: ";
            // 
            // dgvReceiptItems
            // 
            this.dgvReceiptItems.AllowUserToAddRows = false;
            this.dgvReceiptItems.AllowUserToDeleteRows = false;
            this.dgvReceiptItems.AllowUserToResizeRows = false;
            this.dgvReceiptItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceiptItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvReceiptItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceiptItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReceiptItems.ColumnHeadersHeight = 35;
            this.dgvReceiptItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceiptItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReceiptItems.EnableHeadersVisualStyles = false;
            this.dgvReceiptItems.Location = new System.Drawing.Point(25, 220);
            this.dgvReceiptItems.Name = "dgvReceiptItems";
            this.dgvReceiptItems.ReadOnly = true;
            this.dgvReceiptItems.RowHeadersVisible = false;
            this.dgvReceiptItems.RowHeadersWidth = 51;
            this.dgvReceiptItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptItems.Size = new System.Drawing.Size(410, 165);
            this.dgvReceiptItems.TabIndex = 4;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(25, 405);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(410, 25);
            this.lblSubtotal.TabIndex = 5;
            this.lblSubtotal.Text = "Subtotal: ₱0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTax
            // 
            this.lblTax.Location = new System.Drawing.Point(25, 433);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(410, 25);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax: ₱0.00";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Location = new System.Drawing.Point(25, 461);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(410, 25);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "Discount: ₱0.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            this.lblTotal.Location = new System.Drawing.Point(25, 495);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(410, 38);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "TOTAL: ₱0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Location = new System.Drawing.Point(25, 550);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(410, 23);
            this.lblPaymentMethod.TabIndex = 9;
            this.lblPaymentMethod.Text = "Payment Method: Cash";
            // 
            // lblAmountPaid
            // 
            this.lblAmountPaid.Location = new System.Drawing.Point(25, 577);
            this.lblAmountPaid.Name = "lblAmountPaid";
            this.lblAmountPaid.Size = new System.Drawing.Size(410, 23);
            this.lblAmountPaid.TabIndex = 10;
            this.lblAmountPaid.Text = "Amount Paid: ₱0.00";
            // 
            // lblChange
            // 
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            this.lblChange.Location = new System.Drawing.Point(25, 604);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(410, 25);
            this.lblChange.TabIndex = 11;
            this.lblChange.Text = "Change: ₱0.00";
            // 
            // lblThankYou
            // 
            this.lblThankYou.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblThankYou.ForeColor = System.Drawing.Color.Gray;
            this.lblThankYou.Location = new System.Drawing.Point(0, 0);
            this.lblThankYou.Name = "lblThankYou";
            this.lblThankYou.Size = new System.Drawing.Size(460, 30);
            this.lblThankYou.TabIndex = 0;
            this.lblThankYou.Text = "Thank you for your purchase!";
            this.lblThankYou.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(20)))), ((int)(((byte)(43)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(65, 42);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(155, 42);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print Receipt";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.Location = new System.Drawing.Point(240, 42);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(155, 42);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblThankYou);
            this.pnlFooter.Controls.Add(this.btnPrint);
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Location = new System.Drawing.Point(0, 640);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(460, 110);
            this.pnlFooter.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 750);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.lblCashier);
            this.Controls.Add(this.dgvReceiptItems);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPaymentMethod);
            this.Controls.Add(this.lblAmountPaid);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.pnlFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THEPA POS - Receipt";
            this.pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptItems)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
