using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Data
{
    static class DbConnection
    {
        //Check database connection
        public static bool CheckDbConnection()
        {
            using (var shopContext = new ShopContext())
            {
                return (shopContext.Database.CanConnect());
            }
        }
    }
}
