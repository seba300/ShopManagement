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
        private List<ReceiptList> receiptLists = new List<ReceiptList>();
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
                TB_barcode.Text = null;
                TakeProductParamsFromDatabase(Idproduct);
            }
        }
        private void AddToRegisterListView(ReceiptList listItem)
        {
            string[] row = {
                listItem.ProductName,
                listItem.Quantity + listItem.UnitQuantity,
                listItem.UnitPrice.ToString(),
                listItem.Vat.ToString(),
                listItem.Discount.ToString(),
                listItem.Gross.ToString()
            };

            var lvi = new ListViewItem(row);
            LV_receipt.Items.Add(lvi);
        }

        private void TakeProductParamsFromDatabase(int Idproduct)
        {
            var queryResult = new Query();

            receiptLists.Add(queryResult.GetProductInfo(Idproduct));

            if (receiptLists.Last().UnitQuantity == "kg")
            {
                InsertWeight insertWeight = new InsertWeight();
                insertWeight.ShowDialog();

                receiptLists.Last().Quantity = insertWeight.GetWeight();
            }
            else
            {
                receiptLists.Last().Quantity = 1f;
            }

            receiptLists.Last().Gross = GetGross(receiptLists.Last());

            AddToRegisterListView(receiptLists.Last());
        }

        private decimal GetGross(ReceiptList listItem)
        {
            decimal quantity = (decimal)listItem.Quantity;
            decimal price = listItem.UnitPrice - (listItem.UnitPrice * (listItem.Discount / 100));//Cena = cena jedn z rabatem
            decimal value = price * quantity; //Wartosc = price *ilosc
            decimal gross = value + (value * ((decimal)listItem.Vat / 100));//Brutto = wartosc+vat

            //Because in database i have type money which is not rounded to two places after pointer
            return Math.Round(gross,2);
        }

        private void CashRegister_Load(object sender, EventArgs e)
        {
            TB_barcode.Select();
        }
    }
}
