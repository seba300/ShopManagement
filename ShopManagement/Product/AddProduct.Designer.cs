namespace ShopManagement.Product
{
    partial class AddProduct
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
            this.TB_productName = new System.Windows.Forms.TextBox();
            this.TB_unitQuantity = new System.Windows.Forms.TextBox();
            this.TB_unitPrice = new System.Windows.Forms.TextBox();
            this.TB_idCategory = new System.Windows.Forms.TextBox();
            this.TB_discount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_productName
            // 
            this.TB_productName.Location = new System.Drawing.Point(350, 200);
            this.TB_productName.Name = "TB_productName";
            this.TB_productName.Size = new System.Drawing.Size(200, 20);
            this.TB_productName.TabIndex = 0;
            // 
            // TB_unitQuantity
            // 
            this.TB_unitQuantity.Location = new System.Drawing.Point(350, 250);
            this.TB_unitQuantity.Name = "TB_unitQuantity";
            this.TB_unitQuantity.Size = new System.Drawing.Size(200, 20);
            this.TB_unitQuantity.TabIndex = 1;
            // 
            // TB_unitPrice
            // 
            this.TB_unitPrice.Location = new System.Drawing.Point(350, 300);
            this.TB_unitPrice.Name = "TB_unitPrice";
            this.TB_unitPrice.Size = new System.Drawing.Size(200, 20);
            this.TB_unitPrice.TabIndex = 2;
            // 
            // TB_idCategory
            // 
            this.TB_idCategory.Location = new System.Drawing.Point(350, 350);
            this.TB_idCategory.Name = "TB_idCategory";
            this.TB_idCategory.Size = new System.Drawing.Size(200, 20);
            this.TB_idCategory.TabIndex = 3;
            // 
            // TB_discount
            // 
            this.TB_discount.Location = new System.Drawing.Point(350, 400);
            this.TB_discount.Name = "TB_discount";
            this.TB_discount.Size = new System.Drawing.Size(200, 20);
            this.TB_discount.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(250, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product name:*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(250, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unit quantity:*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(250, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Unit price:*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(250, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID category:*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(250, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Discount:*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(280, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fill blank fields";
            this.label6.Visible = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_productName);
            this.Controls.Add(this.TB_unitQuantity);
            this.Controls.Add(this.TB_unitPrice);
            this.Controls.Add(this.TB_idCategory);
            this.Controls.Add(this.TB_discount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_productName;
        private System.Windows.Forms.TextBox TB_unitQuantity;
        private System.Windows.Forms.TextBox TB_unitPrice;
        private System.Windows.Forms.TextBox TB_idCategory;
        private System.Windows.Forms.TextBox TB_discount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}