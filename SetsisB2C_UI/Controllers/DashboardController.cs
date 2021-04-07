using Microsoft.AspNetCore.Mvc;
using SetsisB2B.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            DateTime dateTime = DateTime.Now; 
            string value = "";
            string valueCredit = "";
            string valueCancel = "";
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2071/Dashboard/GetCountOrder?day=" +dateTime);
            ApiConnect sumCredit = new ApiConnect("https://localhost:44356/Dashboard/GetCredit?day=2019-05-20 14:06:38.393");
            ApiConnect getCancel = new ApiConnect("https://localhost:44356/Dashboard/GetCancel?day=2019-04-22 11:26:45.183");
            value = apiConnect.StrResponse;
            valueCredit = sumCredit.StrResponse;
            valueCancel = getCancel.StrResponse;

            ViewData["Count"] = value;
            ViewData["Sum"] = valueCredit;
            ViewData["Cancel"] = valueCancel;
            return View();
        }

        public IActionResult Report()
        {
          

      


            return View();
        }
        public IActionResult DayReport()
        {

            return View();
        }
    }
}
