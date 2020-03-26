using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement
{
    public class ReceiptList
    {
        public int Idproduct { get; set; }
        public string ProductName { get; set; }
        public string UnitQuantity { get; set; }
        public float Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int Idcategory { get; set; }
        public decimal Discount { get; set; }
        public short Vat { get; set; }
        public decimal Gross { get; set; }
    }
}
