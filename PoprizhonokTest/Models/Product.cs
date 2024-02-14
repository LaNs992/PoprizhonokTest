using System;
using System.Collections.Generic;

namespace PoprizhonokTest.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string? NamePr { get; set; }
        public int? TypeProductId { get; set; }
        public int? Articul { get; set; }
        public int? Count { get; set; }
        public int? CehProiz { get; set; }
        public int? Price { get; set; }

        public virtual TypeProduct? TypeProduct { get; set; }
    }
}
