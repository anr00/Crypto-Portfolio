using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Portfolio.Models
{
    public class Crypto
    {
        public int id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public double price_usd { get; set; }
        public double percent_change_24h { get; set; }
        public double percent_change_1h { get; set; }
        public double percent_change_7d { get; set; }
    }

    public class Transaction
    {
        public int Id { get; set; }
        public int CryptoId { get; set; }
        public string CryptoName { get; set; }
        public string CryptoTicker { get; set; }
        public int Operation { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double TotalSpent { get; set; }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }
    }

}

