using System;
using System.Collections.Generic;

namespace PoprizhonokTest.Models
{
    public partial class TypeProduct
    {
        public TypeProduct()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string? Titel { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
