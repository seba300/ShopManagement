namespace ShopManagement
{
    partial class AdminPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyProductToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.addProductToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem1});
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.addEmployeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem1
            // 
            this.addEmployeeToolStripMenuItem1.Name = "addEmployeeToolStripMenuItem1";
            this.addEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.addEmployeeToolStripMenuItem1.Text = "Add employee";
            this.addEmployeeToolStripMenuItem1.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem1_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem1,
            this.addCategoryToolStripMenuItem,
            this.modifyProductToolStripMenuItem1,
            this.modifyCategoryToolStripMenuItem});
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.addProductToolStripMenuItem.Text = "Product";
            // 
            // addProductToolStripMenuItem1
            // 
            this.addProductToolStripMenuItem1.Name = "addProductToolStripMenuItem1";
            this.addProductToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.addProductToolStripMenuItem1.Text = "Add product";
            this.addProductToolStripMenuItem1.Click += new System.EventHandler(this.addProductToolStripMenuItem1_Click);
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addCategoryToolStripMenuItem.Text = "Add category";
            this.addCategoryToolStripMenuItem.Enabled = false;
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // modifyProductToolStripMenuItem1
            // 
            this.modifyProductToolStripMenuItem1.Name = "modifyProductToolStripMenuItem1";
            this.modifyProductToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.modifyProductToolStripMenuItem1.Text = "Modify product";
            this.modifyProductToolStripMenuItem1.Enabled = false;
            this.modifyProductToolStripMenuItem1.Click += new System.EventHandler(this.modifyProductToolStripMenuItem1_Click);
            // 
            // modifyCategoryToolStripMenuItem
            // 
            this.modifyCategoryToolStripMenuItem.Name = "modifyCategoryToolStripMenuItem";
            this.modifyCategoryToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.modifyCategoryToolStripMenuItem.Text = "Modify category";
            this.modifyCategoryToolStripMenuItem.Enabled = false;
            this.modifyCategoryToolStripMenuItem.Click += new System.EventHandler(this.modifyCategoryToolStripMenuItem_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 639);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyProductToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem1;
    }
}