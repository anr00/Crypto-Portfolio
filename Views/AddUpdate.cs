using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crypto_Portfolio.Data;
using Crypto_Portfolio.Models;

namespace Crypto_Portfolio.Views
{
    public partial class AddUpdate : Form
    {
        private int transactionId = 0;
        public AddUpdate()
        {
            InitializeComponent();
            SetComboBox();
        }

        public void UpdateTransaction(Transaction transaction)
        {
            this.Text = "Edit Transaction";
            this.lbTitle.Text = "Edit Transaction";
            this.lbShowId.Text = "" + transaction.Id;

            foreach (var crypto in cbCrypto.Items)
            {
                if (crypto is ComboBoxItem comboItem && comboItem.Value == transaction.CryptoId)
                {
                    cbCrypto.SelectedItem = comboItem;
                    break;
                }
            }

            cbOperation.SelectedIndex = transaction.Operation;
            dtDate.Value = transaction.Date;
            tbPrice.Text = transaction.Price.ToString();
            tbQuantity.Text = transaction.Quantity.ToString();
            this.transactionId = transaction.Id;
        }

        private void SetComboBox()
        {
            cbCrypto.Items.Clear();

            foreach (CryptoEnum crypto in Enum.GetValues(typeof(CryptoEnum)))
            {
                string description = GetEnumDescription(crypto);
                int id = (int)(object)crypto; // cast enum to int

                cbCrypto.Items.Add(new ComboBoxItem { Text = description, Value = id });
            }

            cbCrypto.DisplayMember = "Text";
            cbCrypto.ValueMember = "Value";

            cbOperation.Items.Clear();
            cbOperation.Items.AddRange(Enum.GetNames(typeof(Models.OperationEnum)));
        }

        private string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Id = this.transactionId;
            transaction.CryptoId = ((ComboBoxItem)cbCrypto.SelectedItem).Value;
            transaction.Operation = cbOperation.SelectedIndex;
            transaction.Date = dtDate.Value;
            transaction.Price = Convert.ToDouble(tbPrice.Text);
            transaction.Quantity = Convert.ToDouble(tbQuantity.Text);
            transaction.TotalSpent = Math.Round(transaction.Quantity * transaction.Price, 2);

            var data = new CryptoData();
            if (transaction.Id == 0)
                await data.AddTransactionAsync(transaction);
            else
                await data.UpdateTransactionAsync(transaction);

            this.DialogResult = DialogResult.OK;
        }
        private void btcCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
