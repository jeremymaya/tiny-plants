using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TinyPlants.Models.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TinyPlants.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryManager _inventories;

        public InventoryController(IInventoryManager inventories)
        {
            _inventories = inventories;
        }

        // GET: /<controller>/
        public async Task<IActionResult> IndexAsync()
        {
            return View(await _inventories.GetProducts());
        }
    }
}
