namespace ShopManagement
{
    partial class CashRegister
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
            this.LV_receipt = new System.Windows.Forms.ListView();
            this.ProdCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuanCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPriceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VatCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DiscCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrossCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TB_barcode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LV_receipt
            // 
            this.LV_receipt.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.LV_receipt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProdCol,
            this.QuanCol,
            this.UnitPriceCol,
            this.VatCol,
            this.DiscCol,
            this.GrossCol});
            this.LV_receipt.GridLines = true;
            this.LV_receipt.HideSelection = false;
            this.LV_receipt.Location = new System.Drawing.Point(12, 12);
            this.LV_receipt.Name = "LV_receipt";
            this.LV_receipt.Size = new System.Drawing.Size(554, 576);
            this.LV_receipt.TabIndex = 0;
            this.LV_receipt.UseCompatibleStateImageBehavior = false;
            this.LV_receipt.View = System.Windows.Forms.View.Details;
            // 
            // ProdCol
            // 
            this.ProdCol.Text = "Product";
            this.ProdCol.Width = 280;
            // 
            // QuanCol
            // 
            this.QuanCol.Text = "Quantity";
            this.QuanCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuanCol.Width = 52;
            // 
            // UnitPriceCol
            // 
            this.UnitPriceCol.Text = "Unit Price";
            this.UnitPriceCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnitPriceCol.Width = 58;
            // 
            // VatCol
            // 
            this.VatCol.Text = "Vat";
            this.VatCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.VatCol.Width = 28;
            // 
            // DiscCol
            // 
            this.DiscCol.Text = "Discount";
            this.DiscCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiscCol.Width = 54;
            // 
            // GrossCol
            // 
            this.GrossCol.Text = "Gross";
            this.GrossCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GrossCol.Width = 78;
            // 
            // TB_barcode
            // 
            this.TB_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TB_barcode.Location = new System.Drawing.Point(598, 122);
            this.TB_barcode.MaxLength = 7;
            this.TB_barcode.Name = "TB_barcode";
            this.TB_barcode.Size = new System.Drawing.Size(256, 38);
            this.TB_barcode.TabIndex = 1;
            this.TB_barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_barcode_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "CloseRegister";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_barcode);
            this.Controls.Add(this.LV_receipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Register";
            this.Load += new System.EventHandler(this.CashRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView LV_receipt;
        private System.Windows.Forms.TextBox TB_barcode;
        private System.Windows.Forms.ColumnHeader ProdCol;
        private System.Windows.Forms.ColumnHeader QuanCol;
        private System.Windows.Forms.ColumnHeader UnitPriceCol;
        private System.Windows.Forms.ColumnHeader VatCol;
        private System.Windows.Forms.ColumnHeader DiscCol;
        private System.Windows.Forms.ColumnHeader GrossCol;
        private System.Windows.Forms.Button button1;
    }
}