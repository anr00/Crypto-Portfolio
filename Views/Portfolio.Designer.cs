namespace Crypto_Portfolio.Views
{
    partial class Portfolio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbId = new Label();
            lbCrypto = new Label();
            lbPrice = new Label();
            lbQuantity = new Label();
            label6 = new Label();
            cbCrypto = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(78, 123);
            lbId.Name = "lbId";
            lbId.Size = new Size(24, 20);
            lbId.TabIndex = 0;
            lbId.Text = "ID";
            // 
            // lbCrypto
            // 
            lbCrypto.AutoSize = true;
            lbCrypto.Location = new Point(78, 166);
            lbCrypto.Name = "lbCrypto";
            lbCrypto.Size = new Size(53, 20);
            lbCrypto.TabIndex = 1;
            lbCrypto.Text = "Crypto";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(78, 208);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 2;
            lbPrice.Text = "Price";
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(78, 255);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(65, 20);
            lbQuantity.TabIndex = 3;
            lbQuantity.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 123);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 5;
            // 
            // cbCrypto
            // 
            cbCrypto.FormattingEnabled = true;
            cbCrypto.Location = new Point(186, 163);
            cbCrypto.Name = "cbCrypto";
            cbCrypto.Size = new Size(153, 28);
            cbCrypto.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 255);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(153, 27);
            textBox2.TabIndex = 8;
            // 
            // Portfolio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 353);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(cbCrypto);
            Controls.Add(label6);
            Controls.Add(lbQuantity);
            Controls.Add(lbPrice);
            Controls.Add(lbCrypto);
            Controls.Add(lbId);
            Name = "Portfolio";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private Label lbCrypto;
        private Label lbPrice;
        private Label lbQuantity;
        private Label label6;
        private ComboBox cbCrypto;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}