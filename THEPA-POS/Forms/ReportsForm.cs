
using System;
using System.Data;
using System.Windows.Forms;
using THEPA_POS.Data.Repositories;

namespace THEPA_POS.Forms
{
    public partial class ReportsForm : Form
    {
        private readonly ReportsRepository reportsRepository =
            new ReportsRepository();

        public ReportsForm()
        {
            InitializeComponent();

            // Set default dates.
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;

            // Connect buttons and filters.
            btnApplyFilter.Click += btnApplyFilter_Click;
            btnRefresh.Click += btnRefresh_Click;
            btnBack.Click += btnBack_Click;

            cmbDateFilter.SelectedIndexChanged +=
                cmbDateFilter_SelectedIndexChanged;

            // Load initial report.
            LoadReports();
        }

        private void LoadReports()
        {
            try
            {
                DateTime startDate;
                DateTime endDate;

                GetDateRange(out startDate, out endDate);

                // Load summary.
                DataTable summary =
                    reportsRepository.GetSalesSummary(
                        startDate, endDate);

                if (summary.Rows.Count > 0)
                {
                    DataRow row = summary.Rows[0];

                    decimal totalSales =
                        Convert.ToDecimal(row["TotalSales"]);

                    int transactions =
                        Convert.ToInt32(row["TotalTransactions"]);

                    decimal averageSale =
                        Convert.ToDecimal(row["AverageSale"]);

                    lblTotalSalesValue.Text =
                        totalSales.ToString("C2");

                    lblTransactionsValue.Text =
                        transactions.ToString();

                    lblAverageSaleValue.Text =
                        averageSale.ToString("C2");
                }

                // Load sales transactions.
                dgvSales.DataSource =
                    reportsRepository.GetSalesTransactions(
                        startDate, endDate);

                // Format sales columns.
                if (dgvSales.Columns.Contains("OrderDate"))
                    dgvSales.Columns["OrderDate"].DefaultCellStyle.Format =
                        "MMM dd, yyyy hh:mm tt";

                string[] moneyColumns =
                {
                    "Subtotal",
                    "TaxAmount",
                    "DiscountAmount",
                    "Total",
                    "AmountPaid",
                    "ChangeDue"
                };

                foreach (string column in moneyColumns)
                {
                    if (dgvSales.Columns.Contains(column))
                        dgvSales.Columns[column].DefaultCellStyle.Format =
                            "C2";
                }

                // Load best-selling products.
                dgvTopProducts.DataSource =
                    reportsRepository.GetTopProducts(
                        startDate, endDate);

                if (dgvTopProducts.Columns.Contains("TotalSales"))
                    dgvTopProducts.Columns["TotalSales"].DefaultCellStyle.Format =
                        "C2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load reports.\n\n" + ex.Message,
                    "THEPA POS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void GetDateRange(
            out DateTime startDate,
            out DateTime endDate)
        {
            DateTime today = DateTime.Today;

            switch (cmbDateFilter.Text)
            {
                case "Today":
                    startDate = today;
                    endDate = today.AddDays(1);
                    break;

                case "This Week":
                    startDate = today.AddDays(
                        -(int)today.DayOfWeek + 1);

                    if (today.DayOfWeek == DayOfWeek.Sunday)
                        startDate = today.AddDays(-6);

                    endDate = startDate.AddDays(7);
                    break;

                case "This Month":
                    startDate = new DateTime(
                        today.Year, today.Month, 1);

                    endDate = startDate.AddMonths(1);
                    break;

                case "This Year":
                    startDate = new DateTime(today.Year, 1, 1);
                    endDate = startDate.AddYears(1);
                    break;

                case "Custom Range":
                    startDate = dtpStartDate.Value.Date;
                    endDate = dtpEndDate.Value.Date.AddDays(1);
                    break;

                default:
                    startDate = today;
                    endDate = today.AddDays(1);
                    break;
            }
        }

        private void btnApplyFilter_Click(
            object sender, EventArgs e)
        {
            if (cmbDateFilter.Text == "Custom Range" &&
                dtpStartDate.Value.Date > dtpEndDate.Value.Date)
            {
                MessageBox.Show(
                    "Start date cannot be later than end date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            LoadReports();
        }

        private void btnRefresh_Click(
            object sender, EventArgs e)
        {
            cmbDateFilter.SelectedIndex = 0;

            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;

            LoadReports();
        }

        private void cmbDateFilter_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            bool isCustom =
                cmbDateFilter.Text == "Custom Range";

            lblStartDate.Visible = isCustom;
            lblEndDate.Visible = isCustom;
            dtpStartDate.Visible = isCustom;
            dtpEndDate.Visible = isCustom;
        }

        private void btnBack_Click(
            object sender, EventArgs e)
        {
            Close();
        }
    }
}
