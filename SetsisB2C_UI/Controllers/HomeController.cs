using Microsoft.AspNetCore.Authorization;
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
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Slider()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Slider(SliderSettings sliderSettings)
        {
            string value = "";
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2071/UserControl?Username=" + sliderSettings.Orders + "&Password=" + sliderSettings.Name);
            value = apiConnect.StrResponse;
            var userControl = JsonConvert.DeserializeObject<List<User>>(value);

           
            return View();
        }


    }
}
