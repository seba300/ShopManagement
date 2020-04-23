using ShopManagement.Employee;
using ShopManagement.Product;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();

            //Set this form parent form
            IsMdiContainer = true;
        }

        private void addEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();

            //Set addEmployee form the kid form from AdminPanel form
            addEmployee.MdiParent = this;
            addEmployee.Dock = DockStyle.Fill;
            addEmployee.Show();
        }

        private void addProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifyProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void modifyCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
