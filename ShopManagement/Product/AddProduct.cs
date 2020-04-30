using ShopManagement.Data;
using ShopManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement.Product
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private bool IsEmptyField()
        {
            foreach (Control item in Controls)
            {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {
                        return true;
                    }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsEmptyField())
            {
                label6.Visible = true;
            }
            else
            {
                label6.Visible = false;
                Products product = new Products();

                product.ProductName = TB_productName.Text;
                product.UnitQuantity = TB_unitQuantity.Text;
                product.UnitPrice = Math.Round(Convert.ToDecimal(TB_unitPrice.Text),2);
                product.Idcategory = Convert.ToInt32(TB_idCategory.Text);
                product.Discount = Math.Round(Convert.ToDecimal(TB_discount.Text), 2);

                Query query = new Query();
                query.SaveProductInDB(product);

                ClearControls();
            }
        }
        private void ClearControls()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    tb.Text = null;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
