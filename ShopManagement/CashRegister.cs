﻿using ShopManagement.Data;
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
        //List of products
        private List<ReceiptList> receiptLists = new List<ReceiptList>();
        //Employeer id
        private string IdEmployee { get; set; }
        public CashRegister()
        {
            InitializeComponent();
        }
        //Sign in system is sending here Employeer id to recognize him
        public void GetIdEmployee(string idEmployee)
        {
            IdEmployee = idEmployee;
        }
        //If in the barcode textbox user press enter
        private void TB_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(TB_barcode.Text!="")
                {
                    int Idproduct = Convert.ToInt32(TB_barcode.Text);
                    TB_barcode.Text = null;
                    TakeProductParamsFromDatabase(Idproduct);
                }
            }
        }
        //Create lists view
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

            //Get info of the product with specified ID
            receiptLists.Add(queryResult.GetProductInfo(Idproduct));

            //If last item of the list has 'kg' then employeer must set how many kilos
            if (receiptLists.Last().UnitQuantity == "kg")
            {
                InsertWeight insertWeight = new InsertWeight();
                insertWeight.ShowDialog();

                //Get kilos
                receiptLists.Last().Quantity = insertWeight.GetWeight();
            }
            else
            {
                receiptLists.Last().Quantity = 1f;
            }

            receiptLists.Last().Gross = GetGross(receiptLists.Last());

            AddToRegisterListView(receiptLists.Last());
        }
        //Calculation of the gross amount
        private decimal GetGross(ReceiptList listItem)
        {
            decimal quantity = (decimal)listItem.Quantity;
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
    }
}
