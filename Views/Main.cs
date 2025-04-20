using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Crypto_Portfolio.Data;
using Crypto_Portfolio.Views;

namespace Crypto_Portfolio
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            PopulateCrypto();
        }

        private async void PopulateCrypto()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Ticker");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("% Change 1h");
            dataTable.Columns.Add("% Change 24h");
            dataTable.Columns.Add("% Change 7d");

            var data = new CryptoData();
            var cryptos = await data.GetCryptosAsync();

            foreach (var crypto in cryptos)
            {
                var row = dataTable.NewRow();
                row["Ticker"] = crypto.symbol;
                row["Name"] = crypto.name;
                row["Price"] = crypto.price_usd.ToString("C2"); 
                row["% Change 1h"] = crypto.percent_change_1h;
                row["% Change 24h"] = crypto.percent_change_24h;
                row["% Change 7d"] = crypto.percent_change_7d;

                dataTable.Rows.Add(row);
            }

            this.cryptoGrid.DataSource = dataTable;
        }

        private void btnPortifolio_Click(object sender, EventArgs e)
        {
            var mainPortfolio = new MainPortfolio();
            mainPortfolio.Show();
        }

        private void CryptoGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var header = cryptoGrid.Columns[e.ColumnIndex].HeaderText;
            if ((header == "% Change 1h" || header == "% Change 24h" || header == "% Change 7d"))
            {
                if (double.TryParse(e.Value.ToString(), out double change))
                {
                    if (change < 0)
                        e.CellStyle.ForeColor = Color.Red;

                    else
                        e.CellStyle.ForeColor = Color.Green;
                }
            }
        }
    }
}
