using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagement.Data;

namespace ShopManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!DbConnection.CheckDbConnection())
            {
                MessageBox.Show("Connection Failed. Call to IT");
                Application.Exit();
            }

            //Application.Run(new Warehouse());
            Application.Run(new SignIn());
            //Application.Run(new CashRegister());
            //Application.Run(new InsertWeight());
            //Application.Run(new AdminPanel());
        }
    }
}
