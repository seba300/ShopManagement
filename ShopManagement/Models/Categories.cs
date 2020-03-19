using System;
using System.Collections.Generic;

namespace ShopManagement.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        public int Idcategory { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public short Vat { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
