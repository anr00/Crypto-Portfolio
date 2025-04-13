
using Crypto_Portfolio.Views;

namespace Crypto_Portfolio
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cryptoGrid = new DataGridView();
            btnPortifolio = new Button();
            ((System.ComponentModel.ISupportInitialize)cryptoGrid).BeginInit();
            SuspendLayout();
            // 
            // cryptoGrid
            // 
            cryptoGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cryptoGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cryptoGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cryptoGrid.Location = new Point(52, 85);
            cryptoGrid.MultiSelect = false;
            cryptoGrid.Name = "cryptoGrid";
            cryptoGrid.RowHeadersWidth = 51;
            cryptoGrid.Size = new Size(698, 371);
            cryptoGrid.TabIndex = 0;
            cryptoGrid.CellFormatting += CryptoGrid_CellFormatting;
            // 
            // btnPortifolio
            // 
            btnPortifolio.Location = new Point(53, 44);
            btnPortifolio.Name = "btnPortifolio";
            btnPortifolio.Size = new Size(94, 29);
            btnPortifolio.TabIndex = 1;
            btnPortifolio.Text = "Portifolio";
            btnPortifolio.UseVisualStyleBackColor = true;
            btnPortifolio.Click += this.btnPortifolio_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 484);
            Controls.Add(btnPortifolio);
            Controls.Add(cryptoGrid);
            Name = "Main";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cryptoGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView cryptoGrid;
        private Button btnPortifolio;
    }
}
