using System;
using System.Collections.Generic;
using System.IO;
using TinyPlants.Models.Interfaces;

namespace TinyPlants.Models.Services
{
    public class ProductManager : IProductManager
    {
        public List<Cereal> GetCereals()
        {
            var cereals = ImportCerealCSV();

            return cereals;
        }

        private List<Cereal> ImportCerealCSV()
        {
            List<Cereal> cereals = new List<Cereal>();

            string path = Environment.CurrentDirectory;
            string newPath = Path.GetFullPath(Path.Combine(path, @"wwwroot/cereal.csv"));

            using (var reader = new StreamReader(newPath))
            {
                int id = 1;
                string header = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    cereals.Add(new Cereal()
                    {
                        Id = id++,
                        Name = line[0],
                        Manufacutrer = line[1],
                        Type = line[2],
                        Calories = int.Parse(line[3]),
                        Protein = int.Parse(line[4]),
                        Fat = int.Parse(line[5]),
                        Sodium = int.Parse(line[6]),
                        Fiber = double.Parse(line[7]),
                        Carbohydrate = double.Parse(line[8]),
                        Sugar = int.Parse(line[9]),
                        Potassium = int.Parse(line[10]),
                        Vitamin = int.Parse(line[11]),
                        ShelfLife = int.Parse(line[12]),
                        Weight = double.Parse(line[13]),
                        Cups = double.Parse(line[14]),
                        Rating = decimal.Parse(line[15]),
                    });
                }
            }

            return cereals;
        }
    }
}
