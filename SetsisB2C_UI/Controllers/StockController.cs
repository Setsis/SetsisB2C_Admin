using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Controllers
{
    public class StockController : Controller
    {
        public IActionResult GetStock()
        {
            return View();
        }
        public IActionResult AddStock()
        {
            return View();
        }
        public IActionResult RequestStock()
        {
            return View();
        }
        public IActionResult ProductStocked()
        {
            return View();
        }
        public IActionResult ProductStockless()
        {
            return View();
        }
    }
}
