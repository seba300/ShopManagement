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
    }
}
