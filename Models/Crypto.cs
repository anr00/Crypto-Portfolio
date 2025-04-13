using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Portfolio.Models
{
    public class Crypto
    {   
        public string id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public string price_usd { get; set; }
        public double percent_change_24h { get; set; }
        public double percent_change_1h { get; set; }
        public double percent_change_7d { get; set; }
    }
}

