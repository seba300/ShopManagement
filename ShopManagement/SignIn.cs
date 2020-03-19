using ShopManagement.Data;
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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            DbConnection.CheckDbConnection();
        }

        private void B_signIn(object sender, EventArgs e)
        {
            string login = TB_login.Text;
            string password = TB_password.Text;

            var shopContext = new ShopContext();

            var idEmployee = shopContext.Users
                .Where(x => x.Login == login && x.Password == password)
                .Select(x => x.Idemployee).FirstOrDefault().ToString();

            if(idEmployee!="0")
            {
                OpenNewForm(idEmployee);
            }
            else
            {
                LogFailed.Visible = true;
            }
        }
        private void OpenNewForm(string idEmployee)
        {
            this.Hide();
            CashRegister cashRegisterForm = new CashRegister();
            cashRegisterForm.ShowDialog();
            this.Close();
        }

    }
}
