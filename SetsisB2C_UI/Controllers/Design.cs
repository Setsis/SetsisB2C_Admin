using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SetsisB2B.Class;
using SetsisB2C_UI.Models.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Controllers
{
    public class Design : Controller
    {
        public IActionResult Banners()
        {
            return View();
        }
        public IActionResult Temp()
        {
            return View();
        }
        public IActionResult TopHeader()
        {
            return View();
        }
        public IActionResult ShowCase()
        {
            return View();
        }
        
    }
}
