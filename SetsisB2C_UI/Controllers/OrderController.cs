using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SetsisB2B.Class;
using SetsisB2C_UI.Models.Orders;
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
            string value = "";
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2071/Order/GetOrders");
            value = apiConnect.StrResponse;
            var orders = JsonConvert.DeserializeObject<List<Orders>>(value);
            orders = orders.Where(x => x.InvoiceQty1 == 0).Take(100).ToList();
            return View(orders.ToList());
        }
        
        public ActionResult CancelOrder()
        {
            return View();
        }
        public ActionResult ReturnOrder()
        {
            return View();
        }
        
        public ActionResult ComnpleteOrder()
        {
            return View();
        }
        
        public ActionResult TransportOrder()
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
