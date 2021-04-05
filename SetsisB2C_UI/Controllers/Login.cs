
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SetsisB2B.Class;
using SetsisB2C_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Index(string username,string password)
        {
            string value = "";
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2071/Login/UserControl?Username="+username+"&Password="+password);
            value = apiConnect.StrResponse;
            var userControl = JsonConvert.DeserializeObject<List<User>>(value);
                if (userControl.Count() > 0)
                {
               
                    return RedirectToAction("Index", "Home");
                }
               ModelState.AddModelError(string.Empty, "Kullanıcı Adı veya Şifre Yanlış");
            
            return View();
        }
    }
}
