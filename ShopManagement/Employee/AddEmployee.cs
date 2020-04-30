using ShopManagement.Data;
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

namespace ShopManagement.Employee
{
    public partial class AddEmployee : Form
    {
        private byte[] imagePath { get; set; } = null;
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
                imagePath = System.IO.File.ReadAllBytes(open.FileName);
            }
        }

        //TODO : Improve this system by adding list of bosses and changing font color of labels which haven't filled textboxes
        private void B_signUpEmployee_Click(object sender, EventArgs e)
        {
            Query query = new Query();

            if (IsEmptyField())
            {
                L_emptyFields.Visible = true;
            }
            else
            {
                string name = TB_name.Text;
                string surname = TB_surname.Text;
                DateTime birthDate = DTP_birthDate.Value.Date;
                string address = TB_address.Text;
                string zipCode = TB_zipCode.Text;
                string city = TB_city.Text;
                string phoneNumber = TB_phoneNumber.Text;
                string region = TB_region.Text;
                string position = TB_position.Text;
                DateTime employmentDate = DTP_employmentDate.Value.Date;
                string comment = string.IsNullOrWhiteSpace(TB_comment.Text) ? null : TB_comment.Text;
                int chief = string.IsNullOrWhiteSpace(TB_chief.Text) ? 0 : Convert.ToInt32(TB_chief.Text);

                query.SignUpEmployee(name, surname, birthDate, address,
                                   zipCode, city, phoneNumber, region,
                                   position, employmentDate, chief, comment, imagePath);

                ClearControls();
            }

        }

        private bool IsEmptyField()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox && item.Name != "TB_chief" && item.Name != "TB_comment")
                {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void ClearControls()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    tb.Text = null;
                }
                else if (item is PictureBox)
                {
                    PictureBox pb = (PictureBox)item;
                    pb.Image = null;
                }
            }
            L_emptyFields.Visible = false;
        }

        private void DisplayEmployeePhotoFromDB(int idEmployee)
        {
            Query query = new Query();
            var employee = query.GetEmployeeById(idEmployee);

            MemoryStream ms = new MemoryStream(employee.Photo);
            PB_employeePhoto.Image = Image.FromStream(ms);
        }

        private void B_closeChildForm_Click(object sender,EventArgs e)
        {
            this.Close();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
