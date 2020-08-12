using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TinyPlants.Models.Interfaces
{
    public interface IInventoryManager
    {
        Task<Product> CreateProduct(Product product);
        Task DeleteProduct(int id);
        Task<List<Product>> GetProducts();
        Task<Product> GetProduct(int id);
        Task UpdateProduct(Product product);
    }
}
