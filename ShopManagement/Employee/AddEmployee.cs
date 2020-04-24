using ShopManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement.Employee
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();

            ShopContext p1 = new ShopContext();
            var a = p1.Employees.Where(x => x.Idemployee == 4).Select(x => x.Photo).SingleOrDefault();

            MemoryStream ms = new MemoryStream(a);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShopContext p1 = new ShopContext();
            var a = p1.Employees.Where(x => x.Idemployee == 4).Select(x=>x.Photo).SingleOrDefault();

            MemoryStream ms = new MemoryStream(a);
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
