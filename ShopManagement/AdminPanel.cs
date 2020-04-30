using ShopManagement.Data;
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
using ShopManagement.Models;

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
            CloseActiveChildForms();

            AddEmployee addEmployee = new AddEmployee();

            //Set addEmployee form the kid form from AdminPanel form
            addEmployee.MdiParent = this;
            addEmployee.Show();
        }

        private void addProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseActiveChildForms();

            AddProduct addProduct = new AddProduct();
            addProduct.MdiParent = this;

            addProduct.Show();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveChildForms();

            AddCategory addCategory = new AddCategory();
            addCategory.MdiParent = this;
            addCategory.Show();
        }

        private void modifyProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseActiveChildForms();

            ModifyProduct modifyProduct = new ModifyProduct();
            modifyProduct.MdiParent = this;
            modifyProduct.Show();
        }

        private void modifyCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveChildForms();

            ModifyCategory modifyCategory = new ModifyCategory();
            modifyCategory.MdiParent = this;
            modifyCategory.Show();
        }

        private void CloseActiveChildForms()
        {
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
        }
    }
}
