namespace Crypto_Portfolio.Views
{
    partial class AddUpdate
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbCrypto = new System.Windows.Forms.Label();
            this.lbShowId = new System.Windows.Forms.Label();
            this.cbCrypto = new System.Windows.Forms.ComboBox();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lbOperation = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btcCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(108, 43);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(178, 58);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Add Transaction";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(65, 123);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(20, 16);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "ID";
            // 
            // lbCrypto
            // 
            this.lbCrypto.AutoSize = true;
            this.lbCrypto.Location = new System.Drawing.Point(65, 161);
            this.lbCrypto.Name = "lbCrypto";
            this.lbCrypto.Size = new System.Drawing.Size(46, 16);
            this.lbCrypto.TabIndex = 2;
            this.lbCrypto.Text = "Crypto";
            // 
            // lbShowId
            // 
            this.lbShowId.AutoSize = true;
            this.lbShowId.Location = new System.Drawing.Point(162, 123);
            this.lbShowId.Name = "lbShowId";
            this.lbShowId.Size = new System.Drawing.Size(0, 16);
            this.lbShowId.TabIndex = 3;
            // 
            // cbCrypto
            // 
            this.cbCrypto.FormattingEnabled = true;
            this.cbCrypto.Location = new System.Drawing.Point(165, 161);
            this.cbCrypto.Name = "cbCrypto";
            this.cbCrypto.Size = new System.Drawing.Size(121, 24);
            this.cbCrypto.TabIndex = 4;
            // 
            // cbOperation
            // 
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(165, 207);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(121, 24);
            this.cbOperation.TabIndex = 5;
            // 
            // dtDate
            // 
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(165, 252);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(121, 22);
            this.dtDate.TabIndex = 6;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(165, 304);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(121, 22);
            this.tbPrice.TabIndex = 7;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(165, 347);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(121, 22);
            this.tbQuantity.TabIndex = 8;
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Location = new System.Drawing.Point(68, 207);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(66, 16);
            this.lbOperation.TabIndex = 9;
            this.lbOperation.Text = "Operation";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(68, 257);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(36, 16);
            this.lbDate.TabIndex = 10;
            this.lbDate.Text = "Date";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(68, 304);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(38, 16);
            this.lbPrice.TabIndex = 11;
            this.lbPrice.Text = "Price";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(68, 347);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(55, 16);
            this.lbQuantity.TabIndex = 12;
            this.lbQuantity.Text = "Quantity";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(86, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btcCancel
            // 
            this.btcCancel.Location = new System.Drawing.Point(184, 402);
            this.btcCancel.Name = "btcCancel";
            this.btcCancel.Size = new System.Drawing.Size(75, 23);
            this.btcCancel.TabIndex = 14;
            this.btcCancel.Text = "Cancel";
            this.btcCancel.UseVisualStyleBackColor = true;
            this.btcCancel.Click += new System.EventHandler(this.btcCancel_Click);
            // 
            // AddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.btcCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbOperation);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.cbCrypto);
            this.Controls.Add(this.lbShowId);
            this.Controls.Add(this.lbCrypto);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbTitle);
            this.Name = "AddUpdate";
            this.Text = "Add Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbCrypto;
        private System.Windows.Forms.Label lbShowId;
        private System.Windows.Forms.ComboBox cbCrypto;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lbOperation;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btcCancel;
    }
}