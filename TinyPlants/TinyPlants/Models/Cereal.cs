using System;
namespace TinyPlants.Models
{
    // Cereal Inherits from Product
    public class Cereal : Product
    {
        public override int Id { get; set; }
        public override string Name { get; set; }
        public string Manufacutrer { get; set; }
        public string Type { get; set; }
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Sodium { get; set; }
        public double Fiber { get; set; }
        public double Carbohydrate { get; set; }
        public int Sugar { get; set; }
        public int Potassium { get; set; }
        public int Vitamin { get; set; }
        public int ShelfLife { get; set; }
        public double Weight { get; set; }
        public double Cups { get; set; }
        public override decimal Rating { get; set; }
    }
}
