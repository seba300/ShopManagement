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

        }
        private void B_choosePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png;)|*.jpg; *.jpeg; *.bmp; *.png;";
            
            if (open.ShowDialog() == DialogResult.OK)
            {
                PB_employeePhoto.Image = new Bitmap(open.FileName);
            }
        }

        private void DisplayEmployeePhotoFromDB(int idEmployee)
        {
            Query query = new Query();
            var employee = query.GetEmployeeById(idEmployee);

            MemoryStream ms = new MemoryStream(employee.Photo);
            PB_employeePhoto.Image = Image.FromStream(ms);
        }

        private void AddEmployeePhoto(int idEmployee, string imagePath)
        {
            Query query = new Query();

            //Format image to bytes
            var image = System.IO.File.ReadAllBytes(imagePath);

            //Get employee id
            var employee = query.GetEmployeeById(idEmployee);
            employee.Photo = image;

            query.SaveDBChanges();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
