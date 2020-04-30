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
        }
        private void B_signIn(object sender, EventArgs e)
        {
            //Takes values from textboxes : login and password
            string login = TB_login.Text;
            string password = TB_password.Text;

            //Database connection
            var shopContext = new Query();

            var idEmployee = shopContext.GetIdEmployee(login, password);

            //If login and password are correct call OpenNewForm()
            if (idEmployee != 0)
            {
                Query query = new Query();

                string position = query.GetWorkPosition(idEmployee);

                OpenNewForm(position, idEmployee);
            }

            //If login or password are incorrect show "login failed"
            else
            {
                LogFailed.Visible = true;
            }
        }

        private void OpenNewForm(string position, int idEmployee)
        {
            //Hide this form. This operration doesn't affect to performance
            this.Hide();

            TB_login.Text = "";
            TB_password.Text = "";
            LogFailed.Visible = false;
            TB_login.Select();

            if (position == "Sprzedawca")
            {
                CashRegister cashRegister = new CashRegister();
                cashRegister.GetEmployee(idEmployee);

                //Open next form. 
                //Until the next form won't be closed, this function will be waiting to make this.Close();
                //This form is base form. Can't be closed before closing next forms.
                cashRegister.ShowDialog();
            }
            else if (position == "Szef")
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.ShowDialog();
            }
            else if (position == "Magazynier")
            {
                Warehouse wareHouse = new Warehouse();
                wareHouse.ShowDialog();
            }

            this.Show();
        }

        #region Solution which will reduce openform methods.
        ////TODO: Solution which will reduce openform methods. At this moment dont know how to call form method and i must send idEmployee 
        //private void OpenNewForm<T>()where T:Form, new()
        //{
        //    //Hide this form. This operration doesn't affect to performance
        //    this.Hide();
        //    TB_login.Text = "";
        //    TB_password.Text = "";
        //    LogFailed.Visible = false;

        //    T newForm = new T();

        //    //Open next form. 
        //    //Until the next form won't be closed, this function will be waiting to make this.Close();
        //    //This form is base form. Can't be closed before closing next forms.
        //    newForm.ShowDialog();
        //    this.Show();
        //    //cashRegisterForm.GetEmployee(idEmployee);
        //}
        #endregion

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
