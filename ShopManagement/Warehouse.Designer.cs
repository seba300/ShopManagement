namespace ShopManagement
{
    partial class Warehouse
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
            this.TB_idProduct = new System.Windows.Forms.TextBox();
            this.TB_quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_AddConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_idProduct
            // 
            this.TB_idProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TB_idProduct.Location = new System.Drawing.Point(64, 28);
            this.TB_idProduct.Name = "TB_idProduct";
            this.TB_idProduct.Size = new System.Drawing.Size(270, 53);
            this.TB_idProduct.TabIndex = 0;
            this.TB_idProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_idProduct_KeyDown);
            // 
            // TB_quantity
            // 
            this.TB_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.TB_quantity.Location = new System.Drawing.Point(64, 100);
            this.TB_quantity.Name = "TB_quantity";
            this.TB_quantity.Size = new System.Drawing.Size(270, 53);
            this.TB_quantity.TabIndex = 1;
            this.TB_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_quantity_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(-6, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "Qty:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_AddConfirm
            // 
            this.L_AddConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.L_AddConfirm.ForeColor = System.Drawing.Color.Green;
            this.L_AddConfirm.Location = new System.Drawing.Point(61, 161);
            this.L_AddConfirm.Name = "L_AddConfirm";
            this.L_AddConfirm.Size = new System.Drawing.Size(273, 25);
            this.L_AddConfirm.TabIndex = 4;
            this.L_AddConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_AddConfirm.Visible = false;
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 188);
            this.Controls.Add(this.L_AddConfirm);
            this.Controls.Add(this.TB_quantity);
            this.Controls.Add(this.TB_idProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Warehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warehouse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_idProduct;
        private System.Windows.Forms.TextBox TB_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_AddConfirm;
    }
}