using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement.Data
{
    public class Query
    {
        private ShopContext shopContext { get; set; }
        //Check dbconnection and connect to database
        public Query()
        {
            if (!DbConnection.CheckDbConnection())
            {
                MessageBox.Show("Connection Failed. Call to IT");
                Application.Exit();
            }
            else
            {
                shopContext = new ShopContext();
            }
        }
         ~Query()
        {
            shopContext.Dispose();
        }

        //Returns product information from the list
        public ReceiptList GetProductInfo(int Idproduct)
        {
            var res = shopContext.Products.Join(shopContext.Categories, x => x.Idcategory, y => y.Idcategory, (x, y) => new
            {
                Discount = x.Discount,
                Vat = x.IdcategoryNavigation.Vat,
                Idproduct = x.Idproduct,
                Idcategory = x.Idcategory,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                UnitQuantity = x.UnitQuantity,
            })
                .Where(x => x.Idproduct == Idproduct);

            ReceiptList receiptLists = new ReceiptList();
            foreach (var item in res)
            {
                receiptLists.Discount = item.Discount;
                receiptLists.Idcategory = item.Idcategory;
                receiptLists.Idproduct = item.Idproduct;
                receiptLists.ProductName = item.ProductName;
                receiptLists.UnitPrice = Math.Round(item.UnitPrice,2);//Because in database i have type money which is not rounded to two places after pointer
                receiptLists.UnitQuantity = item.UnitQuantity;
                receiptLists.Vat = item.Vat;
            }
            return receiptLists;
        }
    }
}
