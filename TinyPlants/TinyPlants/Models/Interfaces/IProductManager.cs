using System;
using System.Threading.Tasks;

namespace TinyPlants.Models.Interfaces
{
    public interface IProductManager
    {
        Task<Product> GetProducts();
    }
}
