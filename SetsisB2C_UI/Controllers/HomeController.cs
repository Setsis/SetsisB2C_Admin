using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SetsisB2B.Class;
using SetsisB2C_UI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Controllers
{
    public class HomeController : Controller
    {
        IWebHostEnvironment _webHostEnvironment;

        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        
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
<<<<<<< HEAD
        public IActionResult Slider(SliderFile sliderFile, string name, string description, string imageLink, int orders, string imageName)
=======
        public IActionResult Slider (SliderFile sliderFile,string name,string description, string imageLink,int orders,string imageName)
>>>>>>> c6723686295671da63160cf824ef8aa9c6526e09
        {
            string value = "";
            //value = apiConnect.StrResponse;
            //var userControl = JsonConvert.DeserializeObject<SliderSettings>(value);
<<<<<<< HEAD

            if (ModelState.IsValid)
            {

                if (sliderFile.ImageName != null)
=======

            if (ModelState.IsValid)
            {
              
                if (sliderFile.ImageName !=null)
>>>>>>> c6723686295671da63160cf824ef8aa9c6526e09
                {
                    var ex = Path.GetExtension(sliderFile.ImageName.FileName);
                    var newImage = Guid.NewGuid() + ex;
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Image/" + newImage);
                    var stream = new FileStream(path, FileMode.Create);

                    imageName = newImage;
                    description = sliderFile.Description;
                    imageLink = sliderFile.ImageLink;
                    name = sliderFile.Name;
                    orders = sliderFile.Orders;
<<<<<<< HEAD

                }


                ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2071/Home/AddSlider?name=" + name + "&description=" + description + "&imageName=" + imageName + "&imageLink=" + imageLink + "&orders=" + orders);
=======
                   
                }

          
                ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2071/Home/AddSlider?name="+name+"&description="+description+"&imageName="+imageName+"&imageLink="+imageLink+ "&orders=" + orders);
>>>>>>> c6723686295671da63160cf824ef8aa9c6526e09
                return RedirectToAction("Index", "Home");
            }
            return View();

        }


    }
}
