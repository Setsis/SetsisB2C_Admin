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
        public IActionResult Brands()
        {
            return View();
        }
        public IActionResult _PartialBrandsAdd()
        {
            return View();
        }
        public IActionResult _PartialBrandsUpdate()
        {
            return View();
        }
        public IActionResult _PartialBrandsDelete()
        {
            return View();
        }
        public IActionResult Supliers()
        {
            return View();
        }
        public IActionResult _PartialSupliersAdd()
        {
            return View();
        }
        public IActionResult _PartialSupliersUpdate()
        {
            return View();
        }
        public IActionResult _PartialSupliersDelete()
        {
            return View();
        }
        public IActionResult Properties()
        {
            return View();
        }
        public IActionResult _PartialPropertiesAdd()
        {
            return View();
        }
    }
}
