using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SetsisB2B.Class;
using SetsisB2C_UI.Models.Brands;
using SetsisB2C_UI.Models.Hierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Controllers
{
    public class StockController : Controller
    {
        //Marka Yönetimi Controller Başlangıcı
        public IActionResult ManageBrand()
        {   
            string value = "";
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2023/Stock/GetBrands");
            value = apiConnect.StrResponse;
            var br = JsonConvert.DeserializeObject<List<Brands>>(value);
            return View(br);
            
        }
        [HttpGet]
        public IActionResult _PartialBrandsAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBrands(string BrandName, string BrandCode, IFormFile BrandImgPath)
        {
            string value = "";
            ApiConnect apiConnect = new ApiConnect($"http://10.20.8.6:2023/Stock/AddBrands?BrandName={BrandName}&BrandCode={BrandCode}&BrandImgPath={BrandImgPath}");
            value = apiConnect.StrResponse;
            var br = JsonConvert.DeserializeObject<object>(value);
            return RedirectToAction("ManageBrand");
        }
        [HttpGet]
        public IActionResult _PartialBrandsUpdate()
        {
            string value = "";
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2023/Stock/GetBrands");
            value = apiConnect.StrResponse;
            var br = JsonConvert.DeserializeObject<List<Brands>>(value);
            return View(br);
        }
        public IActionResult UpdateBrand(string? BrandName, string? BrandCode, IFormFile? BrandImgPath, Guid? BrandID)
        {
            string value = "";
            ApiConnect apiConnect = new ApiConnect($"http://10.20.8.6:2023/Stock/UpdateBrands?BrandName={BrandName}&BrandCode={BrandCode}&BrandImgPath={BrandImgPath}&BrandID={BrandID}");
            value = apiConnect.StrResponse;
            var br = JsonConvert.DeserializeObject<object>(value);
            return RedirectToAction("ManageBrand");
        }
        [HttpGet]
        public IActionResult _PartialBrandsDelete()
        {
            string value = "";
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2023/Stock/GetBrands");
            value = apiConnect.StrResponse;
            var br = JsonConvert.DeserializeObject<List<Brands>>(value);
            return View(br);
        }
        [HttpPost]
        public IActionResult DeleteBrand(Guid? BrandID)
        {
            string value = "";
            ApiConnect apiConnect = new ApiConnect($"http://10.20.8.6:2023/Stock/DeleteBrands?BrandID={BrandID}");
            value = apiConnect.StrResponse;
            var br = JsonConvert.DeserializeObject<object>(value);
            return RedirectToAction("ManageBrand");
        }
        //Tedarikçi Yönetimi Başlangıcı
        public IActionResult ManageSuplier()
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
        public IActionResult ManageProperty()
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
        public IActionResult ManageCategory()
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
            Root rt;
            string value = "";
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2023/Stock/GetHierarchy");
            value = apiConnect.StrResponse;
            rt = JsonConvert.DeserializeObject<Root>(value);
            return View(rt.Hierarchies.ToList());
        }
        //Ürün Yönetimi Controller Başlangıcı
        public IActionResult ManageProduct()
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
        public IActionResult _PartialProductsDelete()
        {
            return View();
        }
        public IActionResult ProductsAdd()
        {
            return View();
        }
        public IActionResult _PartialProductsAdd01()
        {
            return View();
        }
        public IActionResult _PartialProductsAdd02()
        {
            return View();
        }
        public IActionResult _PartialProductsAdd03()
        {
            return View();
        }
        public IActionResult _PartialProductsAdd04()
        {
            return View();
        }
    }
}
