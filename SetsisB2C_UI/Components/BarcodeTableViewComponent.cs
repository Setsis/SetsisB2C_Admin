using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SetsisB2B.Class;
using SetsisB2C_UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Components
{
    public class BarcodeTableViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(Guid designId)
        {
            string caseProducts = "";
            List<ShowCaseProduct> _caseProducts = new List<ShowCaseProduct>();
            ApiConnect apiConnect = new ApiConnect("http://10.20.8.6:2071/Design/GetCaseProducts?PageDesignID=" + designId);
            caseProducts = apiConnect.StrResponse;
            _caseProducts = JsonConvert.DeserializeObject<List<ShowCaseProduct>>(caseProducts);
            return View("ProductTable",_caseProducts);

        }
    }
}
