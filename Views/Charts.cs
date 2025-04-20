using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Crypto_Portfolio.Data;
using Crypto_Portfolio.Models;

namespace Crypto_Portfolio.Views
{
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
            PopulateChart();
            PopulateGrid();
        }

        private async void PopulateChart()
        {
            CryptoData data = new CryptoData();
            var transactions = await data.GetTransactionsAsync();
            var buyTransactions = transactions.Where(x => x.Operation == 0);
            var totalPortfolio = buyTransactions.Sum(x => x.TotalSpent);

            var grouped = buyTransactions
                .GroupBy(t => t.CryptoId)
                .Select(g => new
                {
                    CryptoId = g.Key,
                    CryptoName = g.First().CryptoName, 
                    TotalSpent = g.Sum(t => t.TotalSpent)
                })
                .OrderByDescending(x => x.TotalSpent); 

            Series series = new Series
            {
                Name = "Crypto Portfolio",
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie,
                Label = "#PERCENT{P1}", 
                LegendText = "#VALX", 
            };

            foreach (var item in grouped)
            {
                string label = item.CryptoName;
                DataPoint point = new DataPoint();
                point.SetValueXY(label, item.TotalSpent);
                point.LegendText = $"{label} ({item.TotalSpent:C})"; 
                series.Points.Add(point);
            }

            chart.Series.Clear();
            chart.Series.Add(series);
            chart.Legends[0].Enabled = true;
            chart.Titles.Clear();
            chart.Titles.Add("Cryptocurrency Portfolio Distribution");
            chart.Titles.Add(new Title($"Total Portfolio Value: ${totalPortfolio:N2}"));
        }

        private async void PopulateGrid()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Total Spent");
            dataTable.Columns.Add("Total Current");
            dataTable.Columns.Add("Profit/Loss");
            dataTable.Columns.Add("% Profit");

            CryptoData data = new CryptoData();
            var transactions = await data.GetTransactionsAsync();
            var buyTransactions = transactions.Where(x => x.Operation == 0);
            var totalPortfolio = buyTransactions.Sum(x => x.TotalSpent);
            var ids = transactions.Select(t => t.CryptoId).Distinct().ToList();
            var cryptoApi = await data.GetCryptosListAsync(ids);
            var priceLookup = cryptoApi.ToDictionary(x => x.id, x => x.price_usd);

            var grouped = buyTransactions
                .GroupBy(t => t.CryptoId)
                .Select(g => new
                {
                    CryptoId = g.Key,
                    CryptoName = g.First().CryptoName,
                    Quantity = g.Sum(t => t.Quantity),  
                    TotalSpent = g.Sum(t => t.TotalSpent)
                })
                .OrderByDescending(x => x.TotalSpent);

            foreach (var item in grouped)
            {
                var row = dataTable.NewRow();
                row["Name"] = item.CryptoName;
                row["Total Spent"] = Math.Round(item.TotalSpent, 2);
                priceLookup.TryGetValue(item.CryptoId, out var currentPrice);
                var currentValue = item.Quantity * currentPrice;
                row["Total Current"] = Math.Round(currentValue, 2);
                row["Profit/Loss"] = Math.Round(currentValue - item.TotalSpent, 2);
                row["% Profit"] = Math.Round((currentValue - item.TotalSpent) / item.TotalSpent * 100, 2);

                dataTable.Rows.Add(row);
            }

            dataGrid.DataSource = dataTable;
        }
        private void CryptoGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var header = dataGrid.Columns[e.ColumnIndex].HeaderText;
            if (header == "Profit/Loss" || header == "% Profit")
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
