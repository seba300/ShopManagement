using System;
using System.Collections.Generic;

namespace ShopManagement.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Idorder { get; set; }
        public int Idemployee { get; set; }
        public DateTime SellDate { get; set; }

        public virtual Employees IdemployeeNavigation { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
