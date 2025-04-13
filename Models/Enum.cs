using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Portfolio.Models
{
    public enum CryptoEnum
    {
        [Description("Bitcoin")]
        Bitcoin = 90,

        [Description("Monero")]
        Monero = 28,

        [Description("Ethereum")]
        Ethereum = 80,

        [Description("Tether")]
        Tether = 518,

        [Description("Ripple")]
        Ripple = 58,

        [Description("Binance Coin")]
        BinanceCoin = 2710,

        [Description("Solana")]
        Solana = 48543,

        [Description("Cardano")]
        Cardano = 257,

        [Description("Litecoin")]
        Litecoin = 1,

        [Description("Bitcoin Cash")]
        BitcoinCash = 2321,

        [Description("Shiba Inu")]
        ShibaInu = 45088,

        [Description("Dogecoin")]
        Dogecoin = 2,
    }

    public enum OperationEnum
    {
        Buy = 0,
        Sell = 1
    }
}