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
    public class ShowCase : Controller
    {
        [HttpGet]
        public IActionResult Index(string itemCode)
        {
            string value = "";
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2023/Stock/GetItemDesc?ItemCode=" +itemCode);
            value = apiConnect.StrResponse;
            var userControl = JsonConvert.DeserializeObject<List<Product>>(value);

            return View(userControl);
        }
        [HttpGet]
        public PartialViewResult GeneralSettings(string itemCode)
        {

            //string value = "";
            //ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2023/Stock/GetItemDesc?ItemCode=B");
            //value = apiConnect.StrResponse;
            //var userControl = JsonConvert.DeserializeObject<List<Product>>(value);

            return PartialView();
        }



    }
}
