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
        BTC = 90,

        [Description("Monero")]
        XMR = 28,

        [Description("Ethereum")]
        ETH = 80,

        [Description("Tether")]
        USDT = 518,

        [Description("Ripple")]
        XRP = 58,

        [Description("Binance Coin")]
        BNB = 2710,

        [Description("Solana")]
        SOL = 48543,

        [Description("Cardano")]
        ADA = 257,

        [Description("Litecoin")]
        LTC = 1,

        [Description("Bitcoin Cash")]
        BCH = 2321,

        [Description("Shiba Inu")]
        SHIB = 45088,

        [Description("Dogecoin")]
        DOGE = 2,
    }
    public enum OperationEnum
    {
        Buy = 0,
        Sell = 1
    }
}