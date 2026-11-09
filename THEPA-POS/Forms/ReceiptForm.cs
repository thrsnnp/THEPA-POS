
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace THEPA_POS.Forms
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm(
            string orderNumber,
            DateTime orderDate,
            string cashierName,
            DataTable purchasedItems,
            decimal subtotal,
            decimal tax,
            decimal discount,
            decimal total,
            string paymentMethod,
            decimal amountPaid,
            decimal change)
        {
            InitializeComponent();

            // Order information
            lblOrderNumber.Text = "Order No: " + orderNumber;
            lblOrderDate.Text = "Date: " + orderDate.ToString("MMM dd, yyyy hh:mm tt");
            lblCashier.Text = "Cashier: " + cashierName;

            // Purchased products
            DataTable receiptItems = new DataTable();

            receiptItems.Columns.Add("ProductName", typeof(string));
            receiptItems.Columns.Add("Quantity", typeof(int));
            receiptItems.Columns.Add("UnitPrice", typeof(decimal));
            receiptItems.Columns.Add("LineTotal", typeof(decimal));

            foreach (DataRow item in purchasedItems.Rows)
            {
                receiptItems.Rows.Add(
                    item["ProductName"],
                    item["Quantity"],
                    item["UnitPrice"],
                    item["LineTotal"]);
            }

            // Remove existing Designer columns.
            dgvReceiptItems.Columns.Clear();

            // Automatically generate columns from the DataTable.
            dgvReceiptItems.AutoGenerateColumns = true;
            dgvReceiptItems.DataSource = receiptItems;

            // Set column headers.
            dgvReceiptItems.Columns["ProductName"].HeaderText = "Product";
            dgvReceiptItems.Columns["Quantity"].HeaderText = "Qty";
            dgvReceiptItems.Columns["UnitPrice"].HeaderText = "Price";
            dgvReceiptItems.Columns["LineTotal"].HeaderText = "Total";

            // Set column widths.
            dgvReceiptItems.Columns["ProductName"].Width = 150;
            dgvReceiptItems.Columns["Quantity"].Width = 50;
            dgvReceiptItems.Columns["UnitPrice"].Width = 85;
            dgvReceiptItems.Columns["LineTotal"].Width = 85;

            // Format prices.
            dgvReceiptItems.Columns["UnitPrice"].DefaultCellStyle.Format = "N2";
            dgvReceiptItems.Columns["LineTotal"].DefaultCellStyle.Format = "N2";

            // Payment summary
            lblSubtotal.Text = "Subtotal: " + subtotal.ToString("C2");
            lblTax.Text = "Tax: " + tax.ToString("C2");
            lblDiscount.Text = "Discount: " + discount.ToString("C2");
            lblTotal.Text = "TOTAL: " + total.ToString("C2");

            lblPaymentMethod.Text = "Payment Method: " + paymentMethod;
            lblAmountPaid.Text = "Amount Paid: " + amountPaid.ToString("C2");
            lblChange.Text = "Change: " + change.ToString("C2");

            // Buttons
            btnClose.Click += (s, e) => this.Close();
        }
    }
}
