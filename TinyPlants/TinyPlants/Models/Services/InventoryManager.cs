using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TinyPlants.Data;
using TinyPlants.Models.Interfaces;

namespace TinyPlants.Models.Services
{
    public class InventoryManager : IInventoryManager
    {
        private readonly StoreDbContext _context;

        public InventoryManager(StoreDbContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Added;

            await _context.SaveChangesAsync();

            return product;
        }

        public async Task DeleteProduct(int id)
        {
            var product = await GetProduct(id);

            _context.Entry(product).State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);

            return product;
        }

        public async Task<List<Product>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();

            return products;
        }

        public async Task UpdateProduct(Product product)
        {
            _context.Products.Update(product);

            await _context.SaveChangesAsync();
        }
    }
}
