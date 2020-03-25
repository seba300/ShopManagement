using ShopManagement.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ShopManagement
{
    public partial class CashRegister : Form
    {
        public CashRegister()
        {
            InitializeComponent();
        }
        public string GetIdEmployee(string idEmployee)
        {
            return idEmployee;
        }
        private void TB_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int Idproduct = Convert.ToInt32(TB_barcode.Text);
                TakeProductParamsFromDatabase(Idproduct);
            }
        }
        private void AddToRegisterListView(int Idproduct)
        {

        }

        private void TakeProductParamsFromDatabase(int Idproduct)
        {
            var shopContext = new ShopContext();

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

            List<ReceiptList> receiptLists = new List<ReceiptList>();
            foreach (var item in res)
            {
                receiptLists.Add(new ReceiptList
                {
                    Discount = item.Discount,
                    Idcategory = item.Idcategory,
                    Idproduct = item.Idproduct,
                    ProductName = item.ProductName,
                    UnitPrice = item.UnitPrice,
                    UnitQuantity = item.UnitQuantity,
                    Vat = item.Vat
                });
            }
        }

        private void CashRegister_Load(object sender, EventArgs e)
        {
            TB_barcode.Select();

            string[] row = { "1", "2", "3", "4", "5", "6"};
            var lvi = new ListViewItem(row);
            LV_receipt.Items.Add(lvi);

            var lvi2 = new ListViewItem(row);
            LV_receipt.Items.Add(lvi2);

            

            ////One method add one by one col
            //string[] row = { "1", "2", "3", "4", "5", "6", "7" };
            //var lvi = new ListViewItem(row);
            //lvi.SubItems[1].Text = "!2";
            //LV_receipt.Items.Add(lvi);
        }
    }
}
