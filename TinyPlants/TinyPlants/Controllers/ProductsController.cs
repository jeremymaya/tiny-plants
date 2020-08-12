using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TinyPlants.Models.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TinyPlants.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductManager _products;

        public ProductsController(IProductManager products)
        {
            _products = products;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var cereals = _products.GetCereals();

            return View(cereals);
        }
    }
}
