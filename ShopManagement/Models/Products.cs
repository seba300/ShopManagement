using System;
using System.Collections.Generic;

namespace ShopManagement.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
        }

        public int Idproduct { get; set; }
        public string ProductName { get; set; }
        public string UnitQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int InventoryState { get; set; }
        public bool Discontinued { get; set; }
        public int Idcategory { get; set; }
        public decimal Discount { get; set; }

        public virtual Categories IdcategoryNavigation { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
