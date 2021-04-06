using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SetsisB2B.Class;
using SetsisB2C_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Controllers
{
    public class ShowcaseController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> pr = new List<Product>();
            return View(pr);
        }

        [HttpGet]
        public IActionResult PostItemCode(string ItemCode)
        {
            string value = ""; 
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2071/Stock/GetItemDesc?ItemCode="+ItemCode);
            value = apiConnect.StrResponse;
            var userControl = JsonConvert.DeserializeObject<List<Product>>(value);

            return Json("GeneralSettings",userControl);
        }
  

     



    }
}
