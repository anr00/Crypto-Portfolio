using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crypto_Portfolio.Models;
using Newtonsoft.Json;

namespace Crypto_Portfolio.Data
{
    public class CryptoData
    {
        public async Task<List<Crypto>> GetCryptosAsync()
        {
            string url = "https://api.coinlore.net/api/ticker/?id=90,28,80,518,58,2710,48543,257,1,2321,45088,2";

            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                throw new Exception("Couldn't connect to CoinLore");

            string json = await response.Content.ReadAsStringAsync();
            var list = JsonConvert.DeserializeObject<List<Crypto>>(json);
            return list;
        }
    }
}
