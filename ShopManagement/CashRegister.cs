using ShopManagement.Data;
using ShopManagement.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class CashRegister : Form
    {
        //List of products
        private List<ReceiptList> receiptLists = new List<ReceiptList>();
        //Employeer id
        private int IdEmployee { get; set; }
        public CashRegister()
        {
            InitializeComponent();
        }
        ~CashRegister()
        {
            ClearReceipt();
        }
        //Sign in system is sending here Employeer id to recognize him
        public void GetEmployee(int idEmployee)
        {
            IdEmployee = idEmployee;
        }
        //If in the barcode textbox user press enter
        private void TB_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(TB_barcode.Text))
                {
                    int Idproduct = Convert.ToInt32(TB_barcode.Text);
                    TB_barcode.Text = null;
                    CreateProductList(Idproduct);
                }
            }
        }
        //Create lists view
        private void AddToRegisterListView(ReceiptList listItem)
        {
            string[] row = {
                listItem.ProductName,
                listItem.Quantity + "x " + listItem.UnitQuantity,
                listItem.UnitPrice.ToString(),
                listItem.Vat.ToString(),
                listItem.Discount.ToString(),
                listItem.Gross.ToString()
            };

            var lvi = new ListViewItem(row);
            LV_receipt.Items.Add(lvi);
        }

        private void CreateProductList(int Idproduct)
        {
            var queryResult = new Query();

            if (queryResult.ExistsProduct(Idproduct))
            {
                //Get info of the product with specified ID
                receiptLists.Add(queryResult.GetProductInfo(Idproduct));

                receiptLists.Last().Gross = GetGross(receiptLists.Last());

                AddToRegisterListView(receiptLists.Last());
            }
            else
            {
                MessageBox.Show("The product has not been added to the system");
            }

        }
        //Calculation of the gross amount
        private decimal GetGross(ReceiptList listItem)
        {
            int quantity = listItem.Quantity;
            decimal price = listItem.UnitPrice - (listItem.UnitPrice * (listItem.Discount / 100));//Cena = cena jedn z rabatem
            decimal value = price * quantity; //Wartosc = price *ilosc
            decimal gross = value + (value * ((decimal)listItem.Vat / 100));//Brutto = wartosc+vat

            //Because in database i have type money which is not rounded to two places after pointer
            return Math.Round(gross, 2);
        }
        //Set focus on barcode textbox
        private void CashRegister_Load(object sender, EventArgs e)
        {
            TB_barcode.Select();
        }

        //TODO : ADD ASYNCH
        private void B_closeRegister_Click(object sender, EventArgs e)
        {
            CloseOrder();
            PrintReceipt();
            PrintPriceToPay();
            ClearReceipt();
        }

        private void CloseOrder()
        {
            var query = new Query();
            query.AddOrderToDatabase(receiptLists, IdEmployee);
        }
        private void ClearReceipt()
        {
            LV_receipt.Items.Clear();
            receiptLists.Clear();
        }

        private void PrintPriceToPay()
        {
            decimal toPay = 0;
            foreach (var item in receiptLists)
            {
                toPay += item.Gross;
            }

            toPay = Math.Round(toPay, 2);
            MessageBox.Show("To pay: " + toPay + "zł");
        }

        //@"ShopManagement/ShopManagement/Receipts/"
        private void PrintReceipt()
        {
            Query query = new Query();
            DateTime thisDate = DateTime.Now;

            //Get actual order number
            int idOrder = query.GetIdOrder(IdEmployee);

            //Create unique name for file
            string receiptName = idOrder + thisDate.ToString("_dd_MM_yyyy");

            string path = @"..\..\Receipts\" + receiptName + ".txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("====RECEIPT====");

                List<OrderDetails> orderDetailsList = new List<OrderDetails>();
                orderDetailsList = query.GroupProductList(idOrder, receiptLists);

                foreach (var item in orderDetailsList)
                {
                    var gross = receiptLists.Where(x => x.Idproduct == item.Idproduct).Sum(x => x.Gross);

                    sw.WriteLine("n:" + query.GetProductName(item.Idproduct) + " q:" + item.Quantity + " g:" + gross + "zł");
                }
            }
        }

        private void B_signOut_Click(object sender, EventArgs e)
        {
            SignOut();
        }

        private void SignOut()
        {
            this.Close();
        }
    }
}
