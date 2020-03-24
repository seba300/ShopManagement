using System;
using System.Collections.Generic;

namespace ShopManagement.Models
{
    public partial class Users
    {
        public int Idemployee { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Iduser { get; set; }

        public virtual Employees IdemployeeNavigation { get; set; }
    }
}
