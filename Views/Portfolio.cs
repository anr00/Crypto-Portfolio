using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypto_Portfolio.Models;

namespace Crypto_Portfolio.Views
{
    public partial class Portfolio : Form
    {
        public Portfolio()
        {
            InitializeComponent();
            SetCryptoOptions();
        }
        private void SetCryptoOptions()
        {
            cbCrypto.Items.Clear();
            //cbCrypto.Items.AddRange(System.Enum.GetNames(Models.CryptoEnum)); 
        }

    }
}
