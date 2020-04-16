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
            string[] fruits = { "Apple", "mango", "Grapes", "orange", "Red Orange" };
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteCustomSource.AddRange(fruits);
        }
    }
}
