using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Controllers
{
    public class ShowCase : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
