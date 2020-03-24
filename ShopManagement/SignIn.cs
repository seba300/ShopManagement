using IdentityModel.Client;
using ShopManagement.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();

            if(!DbConnection.CheckDbConnection())
            {
                MessageBox.Show("Connection Failed. Call to IT");
                Application.Exit();
            }
        }
        private void B_signIn(object sender, EventArgs e)
        {
            //Takes values from textboxes : login and password
            string login = TB_login.Text;
            string password = TB_password.Text;
           
            //Database connection
            var shopContext = new ShopContext();

            var idEmployee = shopContext.Users
                .Where(x => (x.Login == login) && (x.Password == password))
                .Select(x => x.Idemployee).FirstOrDefault().ToString();


            //If login and password are correct call OpenNewForm()
            if (idEmployee != "0")
            {
                OpenNewForm(idEmployee);
            }

            //If login or password are incorrect show "login failed"
            else
            {
                LogFailed.Visible = true;
            }
        }
        private void OpenNewForm(string idEmployee)
        {
            //Hide this form. This operration doesn't affect to performance
            this.Hide();

            CashRegister cashRegisterForm = new CashRegister();

            cashRegisterForm.GetIdEmployee(idEmployee);

            //Open next form. 
            //Until the next form won't be closed, this function will be waiting to make this.Close();
            //This form is base form. Can't be closed before closing next forms.
            cashRegisterForm.ShowDialog();
            this.Close();
        }
        private void TB_login_KeyDown(object sender, KeyEventArgs e)
        {
            //If enter will be pressed in textbox
            if (e.KeyCode == Keys.Enter)
            {
                B_signIn(this, new EventArgs());
            }
        }
        private void TB_password_KeyDown(object sender, KeyEventArgs e)
        {
            //If enter will be pressed in textbox
            if (e.KeyCode == Keys.Enter)
            {
                B_signIn(this, new EventArgs());
            }
        }
    }
}
