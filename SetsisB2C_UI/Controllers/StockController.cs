using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SetsisB2B.Class;
using SetsisB2C_UI.Models.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Controllers
{
    public class StockController : Controller
    {
        public IActionResult GetStock()
        {
            string a = "sfdfsd";
            return View();
        }
        public IActionResult AddStock()
        {
            return View();
        }
        public IActionResult RequestStock()
        {
            return View();
        }
        public IActionResult ProductStocked()
        {
            return View();
        }
        public IActionResult ProductStockless()
        {
            return View();
        }
        //Marka Yönetimi Controller Başlangıcı
        public IActionResult Brands()
        {
            return View();
        }
        public IActionResult _PartialBrandsAdd()
        {
            return View();
        }
        public IActionResult _PartialBrandsUpdate()
        {
            return View();
        }
        public IActionResult _PartialBrandsDelete()
        {
            return View();
        }
        //Tedarikçi Yönetimi Başlangıcı
        public IActionResult Supliers()
        {
            return View();
        }
        public IActionResult _PartialSupliersAdd()
        {
            return View();
        }
        public IActionResult _PartialSupliersUpdate()
        {
            return View();
        }
        public IActionResult _PartialSupliersDelete()
        {
            return View();
        }
        //Özellik Yönetimi Controller Başlangıcı
        public IActionResult Properties()
        {
            return View();
        }
        public IActionResult _PartialPropertiesAdd()
        {
            return View();
        }
        public IActionResult _PartialPropertiesUpdate()
        {
            return View();
        }
        public IActionResult _PartialPropertiesDelete()
        {
            return View();
        }
        public IActionResult PropertyValues()
        {
            return View();
        }
        public IActionResult _PartialValuesAdd()
        {
            return View();
        }
        public IActionResult _PartialValuesUpdate()
        {
            return View();
        }
        public IActionResult _PartialValuesDelete()
        {
            return View();
        }
        //Kategori Yönetimi Controller Başlangıcı
        public IActionResult MainMenu()
        {
            Root rt;
            string value = "";
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2023/Stock/GetHierarchy");
            value = apiConnect.StrResponse;
            rt = JsonConvert.DeserializeObject<Root>(value);
            return View(rt.Hierarchies.ToList());
        }
        public IActionResult _PartialCategoryUpdate()
        {
            return View();
        }
        public IActionResult _PartialCategoryDelete()
        {
            return View();
        }
        public IActionResult _PartialCategoryAdd()
        {
            return View();
        }
        //Ürün Yönetimi Controller Başlangıcı
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult _PartialProductPhotos()
        {
            return View();
        }
        public IActionResult _PartialProductEditPrice()
        {
            return View();
        }
        public IActionResult _PartialProductsUpdate()
        {
            return View();
        }
    }
}
