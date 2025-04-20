using System.Drawing;
using System.Windows.Forms;


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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cryptoGrid = new System.Windows.Forms.DataGridView();
            this.btnPortifolio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cryptoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cryptoGrid
            // 
            this.cryptoGrid.AllowUserToAddRows = false;
            this.cryptoGrid.AllowUserToDeleteRows = false;
            this.cryptoGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cryptoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cryptoGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cryptoGrid.CellFormatting += CryptoGrid_CellFormatting;
            this.cryptoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cryptoGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.cryptoGrid.Location = new System.Drawing.Point(52, 68);
            this.cryptoGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cryptoGrid.MultiSelect = false;
            this.cryptoGrid.Name = "cryptoGrid";
            this.cryptoGrid.RowHeadersWidth = 51;
            this.cryptoGrid.Size = new System.Drawing.Size(698, 287);
            this.cryptoGrid.TabIndex = 0;
            // 
            // btnPortifolio
            // 
            this.btnPortifolio.Location = new System.Drawing.Point(53, 35);
            this.btnPortifolio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPortifolio.Name = "btnPortifolio";
            this.btnPortifolio.Size = new System.Drawing.Size(94, 23);
            this.btnPortifolio.TabIndex = 1;
            this.btnPortifolio.Text = "Portifolio";
            this.btnPortifolio.UseVisualStyleBackColor = true;
            this.btnPortifolio.Click += btnPortifolio_Click;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.btnPortifolio);
            this.Controls.Add(this.cryptoGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.cryptoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView cryptoGrid;
        private Button btnPortifolio;
    }
}
