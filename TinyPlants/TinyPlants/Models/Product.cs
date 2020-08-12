using System;
namespace TinyPlants.Models
{
    public abstract class Product
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract decimal Rating { get; set; }
    }
}
