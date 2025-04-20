using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Crypto_Portfolio.Models;
using Newtonsoft.Json;
using Npgsql;

namespace Crypto_Portfolio.Data
{
    public class CryptoData
    {
        string connectionString = "server=localhost;port=5432;userid=postgres;password=123;database=postgres";
        public async Task<List<Crypto>> GetCryptosAsync()
        {
            string url = "https://api.coinlore.net/api/ticker/?id=90,28,80,518,58,2710,48543,257,1,2321,45088,2";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Couldn't connect to CoinLore");

                string json = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<Crypto>>(json);
                return list;
            }
        }

        public async Task<List<Crypto>> GetCryptosListAsync(List<int> ids)
        {
            string listIds = string.Join(",", ids);
            string url = "https://api.coinlore.net/api/ticker/?id=" + listIds;

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                    throw new Exception("Couldn't connect to CoinLore");

                string json = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<Crypto>>(json);
                return list;
            }
        }

        public async Task<Transaction> GetTransactionAsync(int id)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string sql = @"SELECT portfolio.id, crypto_id, crypto_name, 
                              operation, date, price, quantity
                              FROM portfolio 
                              LEFT JOIN crypto ON portfolio.crypto_id = crypto.id
                              WHERE portfolio.id = @id";

                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            Transaction transaction = new Transaction();
                            transaction.Id = reader.GetInt32(0);
                            transaction.CryptoId = reader.GetInt32(1);
                            transaction.CryptoName = reader.GetString(2);
                            transaction.Operation = reader.GetInt32(3);
                            transaction.Date = reader.GetDateTime(4);
                            transaction.Price = reader.GetDouble(5);
                            transaction.Quantity = reader.GetDouble(6);

                            return transaction;
                        }
                    }
                }
            }
            return null; 
        }

        public async Task<List<Transaction>> GetTransactionsAsync()
        {
            var transactions = new List<Transaction>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string sql = @"SELECT portfolio.id, crypto_id, crypto_name, crypto_ticker,
                              operation, date, price, quantity, total_spent 
                              FROM portfolio 
                              LEFT JOIN crypto ON portfolio.crypto_id = crypto.id";

                using (var command = new NpgsqlCommand(sql, connection))
                {
                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var transaction = new Transaction
                            {
                                Id = reader.GetInt32(0),
                                CryptoId = reader.GetInt32(1),
                                CryptoName = reader.GetString(2),
                                CryptoTicker = reader.GetString(3),
                                Operation = reader.GetInt32(4),
                                Date = reader.GetDateTime(5),
                                Price = reader.GetDouble(6),
                                Quantity = reader.GetDouble(7),
                                TotalSpent = reader.GetDouble(8),
                            };
                            transactions.Add(transaction);
                        }
                    }
                }
            }
            return transactions;
        }

        public async Task UpdateTransactionAsync(Transaction transaction)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string sql = "UPDATE portfolio SET crypto_id = @crypto_id, operation = @operation, " +
                             "date = @date, price = @price, quantity = @quantity, total_spent = @total_spent " +
                             "WHERE id = @id";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@crypto_id", transaction.CryptoId);
                    command.Parameters.AddWithValue("@operation", transaction.Operation);
                    command.Parameters.AddWithValue("@date", transaction.Date);
                    command.Parameters.AddWithValue("@price", transaction.Price);
                    command.Parameters.AddWithValue("@quantity", transaction.Quantity);
                    command.Parameters.AddWithValue("@total_spent", transaction.TotalSpent);
                    command.Parameters.AddWithValue("@id", transaction.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public async Task AddTransactionAsync(Transaction transaction)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string sql = "INSERT INTO portfolio (crypto_id, operation, date, price, quantity, total_spent) " +
                             "VALUES(@crypto_id, @operation, @date, @price, @quantity, @total_spent)";

                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@crypto_id", transaction.CryptoId);
                    command.Parameters.AddWithValue("@operation", transaction.Operation);
                    command.Parameters.AddWithValue("@date", transaction.Date);
                    command.Parameters.AddWithValue("@price", transaction.Price);
                    command.Parameters.AddWithValue("@quantity", transaction.Quantity);
                    command.Parameters.AddWithValue("@total_spent", transaction.TotalSpent);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task DeleteTransactionAsync(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string sql = "DELETE FROM portfolio WHERE id = @id";

                using (var command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
