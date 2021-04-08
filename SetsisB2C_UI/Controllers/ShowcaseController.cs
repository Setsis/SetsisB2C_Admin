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
            var vm = new ShowCaseViewModel();
            string pages = "";
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2071/Design/GetPages");
            pages = apiConnect.StrResponse;
            var proot = JsonConvert.DeserializeObject<List<Page>>(pages);
            vm.pages = proot;
            return View(vm);
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

        //[HttpPost]
        //public IActionResult Index(ShowCaseViewModel model)
        //{
        //    var vm = new ShowCaseViewModel();
        //    string pages = "";
        //    ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2071/Design/GetPages");
        //    pages = apiConnect.StrResponse;
        //    var proot = JsonConvert.DeserializeObject<List<Page>>(pages);
        //    vm.pages = proot;
        //    string showCase = "";
        //    apiConnect = new ApiConnect("http://10.20.8.6:2071/Design/GetShowcase?PageID=" + model.PageId);
        //    showCase = apiConnect.StrResponse;
        //    var _showCase = JsonConvert.DeserializeObject<List<ShowCase>>(showCase);
        //    vm.PageId = model.PageId;
        //    vm.showCases = _showCase.OrderBy(s => s.SortNumber).ToList();
        //    return View(vm);
           
        //}
        [HttpGet]
        public IActionResult List(Guid pageId)
        {
            return ViewComponent("ShowCase", pageId);
        }

        [HttpPost]
        public IActionResult Create(ShowCaseModalModel model)
        {
            string value = "";
            ApiConnect apiConnect = new ApiConnect("https://localhost:44356/Design/AddShowcase?PageID=" + model.PageId+"&DesignName="+model.DesignName+ "&DesignHeader=" + model.DesignHeader
                + "&Description=" +model.Description+ "&RowHeight=" +model.RowHeight+ "&RowWidth=" +model.RowWidth+"&ShowCaseDesingId=" + model.ShowCaseTypeId);
            value = apiConnect.StrResponse;
            if(value!="")
            {
                ModelState.AddModelError(string.Empty, "Vitrin Eklendi");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Vitrin Eklenemedi. Lütfen Tekrar Deneyin.");
            }
            return RedirectToAction("Index", "Showcase");
        }
        [HttpGet]
        public IActionResult TableGet(Guid showCaseId)
        {
            return ViewComponent("BarcodeTable", showCaseId);
        }
        [HttpPost]
        public IActionResult TablePost(string barcode, Guid showCaseId)
        {
            
            string caseProducts = "";
            List<ShowCaseProduct> _caseProducts = new List<ShowCaseProduct>();
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2071/Design/GetCaseProducts?PageDesignID=" + showCaseId);
            caseProducts = apiConnect.StrResponse;
            apiConnect = new ApiConnect("https://localhost:44356/Design/AddCaseProducts?PageDesignID=" + showCaseId + "&Barcode=" + barcode + "&ProductSortNumber=" + caseProducts.Count()+1);
            
            return ViewComponent("BarcodeTable", showCaseId);
        }
        [HttpDelete]
        public IActionResult DeleteShowcase(Guid showCaseId)
        {
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2071/Design/DeleteShowCase?PageDesignID=" + showCaseId);
            return RedirectToAction("Index", "Showcase");
        }
    }
}
