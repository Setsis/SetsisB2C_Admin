using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Controllers
{
    public class OrderController : Controller
    {
        public ActionResult AllOrder()
        {
            return View();
        }
        public ActionResult ReturnOrder()
        {
            return View();
        }
        public ActionResult SlipsOrder()
        {
            return View();
        }
        public ActionResult BillsOrder()
        {
            return View();
        }
    }
}
