﻿using ShopManagement.Data;
using System;
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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();

        }

        private void TB_idProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TB_quantity.Select();
            }
        }

        private void TB_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(string.IsNullOrWhiteSpace(TB_idProduct.Text) || string.IsNullOrWhiteSpace(TB_quantity.Text)))
                {
                    TB_idProduct.Select();

                    Query query = new Query();
                    query.InsertDelivery(TB_idProduct.Text, TB_quantity.Text);

                    L_AddConfirm.Text = "Dodano: " + query.GetProductName(Convert.ToInt32(TB_idProduct.Text));
                    L_AddConfirm.Visible = true;

                    TB_idProduct.Text = null;
                    TB_quantity.Text = null;
                }
            }
        }
    }
}
