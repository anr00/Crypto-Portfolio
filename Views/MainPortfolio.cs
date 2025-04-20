using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypto_Portfolio.Data;
using Crypto_Portfolio.Models;

namespace Crypto_Portfolio.Views
{
    public partial class MainPortfolio : Form
    {
        public MainPortfolio()
        {
            InitializeComponent();
            PopulatePortfolio();
        }

        private async void PopulatePortfolio()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Ticker");
            dataTable.Columns.Add("Operation");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Total Spent");
 
            var data = new CryptoData();
            var transactions = await data.GetTransactionsAsync();

            foreach (var transaction in transactions)
            {
                var row = dataTable.NewRow();
                row["ID"] = transaction.Id;
                row["Ticker"] = transaction.CryptoTicker;
                row["Operation"] = Enum.GetName(typeof(OperationEnum), transaction.Operation);
                row["Date"] = transaction.Date.ToString("MM/dd/yyyy");
                row["Price"] = transaction.Price.ToString("C2"); 
                row["Quantity"] = transaction.Quantity.ToString("N2"); ;
                row["Total Spent"] = transaction.TotalSpent.ToString("C2");

                dataTable.Rows.Add(row);
            }
            transactionsGrid.DataSource = dataTable;
        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            var charts = new Charts();
            charts.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUpdate addUpdate = new AddUpdate();
            if (addUpdate.ShowDialog() == DialogResult.OK)
                PopulatePortfolio();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            var id = this.transactionsGrid.SelectedRows[0].Cells[0].Value.ToString();
            if (id == null || id.Length == 0)
                return;

            int transactionId = int.Parse(id);

            var data = new CryptoData();
            var transaction = await data.GetTransactionAsync(transactionId);
            if (transaction == null)
                return;

            AddUpdate addUpdate = new AddUpdate();
            addUpdate.UpdateTransaction(transaction);
            if (addUpdate.ShowDialog() == DialogResult.OK)
                PopulatePortfolio();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var id = this.transactionsGrid.SelectedRows[0].Cells[0].Value.ToString();
            if (id == null || id.Length == 0)
                return;

            int transactionId = int.Parse(id);

            DialogResult dialogResult = MessageBox.Show("Do you really want to delete this transaction?",
                "Delete Transaction", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No)
                return;

            var data = new CryptoData();
            await data.DeleteTransactionAsync(transactionId);
            PopulatePortfolio();
        }
    }
}
