using System;
using System.Collections.Generic;

namespace ShopManagement.Models
{
    public partial class Employees
    {
        public Employees()
        {
            Orders = new HashSet<Orders>();
            Users = new HashSet<Users>();
        }

        public int Idemployee { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Photo { get; set; }
        public string Comments { get; set; }
        public int? Chief { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
