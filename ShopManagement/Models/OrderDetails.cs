using System;
using System.Collections.Generic;

namespace ShopManagement.Models
{
    public partial class OrderDetails
    {
        public int Idorder { get; set; }
        public int Idproduct { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public short Vat { get; set; }
        public decimal Discount { get; set; }

        public virtual Orders IdorderNavigation { get; set; }
        public virtual Products IdproductNavigation { get; set; }
    }
}
