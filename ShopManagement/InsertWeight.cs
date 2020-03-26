using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ShopManagement
{
    public partial class InsertWeight : Form
    {
        private string Weight { get; set; }
        private decimal weight { get; set; }
        private CultureInfo cultures = new CultureInfo("en-US");
        public InsertWeight()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Weight += 1;
            weightResult.Text = Weight;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Weight += 2;
            weightResult.Text = Weight;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Weight += 3;
            weightResult.Text = Weight;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Weight += 4;
            weightResult.Text = Weight;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Weight += 5;
            weightResult.Text = Weight;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Weight += 6;
            weightResult.Text = Weight;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Weight += 7;
            weightResult.Text = Weight;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Weight += 8;
            weightResult.Text = Weight;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Weight += 9;
            weightResult.Text = Weight;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Weight += 0;
            weightResult.Text = Weight;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Weight += ".";
            weightResult.Text = Weight;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
        private void CloseForm()
        {
            this.Close();
        }

        public float GetWeight()
        {
            weight = Convert.ToDecimal(Weight, cultures);
            weight = Math.Round(weight, 2);
            return (float)weight;
        }
    }
}
