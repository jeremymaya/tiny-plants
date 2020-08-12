using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TinyPlants.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public bool IsFeatured { get; set; }
    }
}
