using System;
using System.Threading.Tasks;
using TinyPlants.Models.Interfaces;

namespace TinyPlants.Models.Services
{
    public class ProductManager : IProductManager
    {
        private readonly IProductManager _products;

        public ProductManager(IProductManager products)
        {
            _products = products;
        }

        public Task<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
