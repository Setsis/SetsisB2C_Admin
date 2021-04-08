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
    public class ShowCaseModalViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var vm = new ShowCaseModalModel();
            string pages = "";
            string types = "";
            ApiConnect apiConnect = new ApiConnect("https://localhost:44356/Design/GetPages");
            pages = apiConnect.StrResponse;
            var proot = JsonConvert.DeserializeObject<List<Page>>(pages);
            apiConnect = new ApiConnect("https://localhost:44356/Design/GetShowcaseTypes");
            types = apiConnect.StrResponse;
            var showCaseTypes = JsonConvert.DeserializeObject<List<ShowCaseType>>(types);
            vm.pages = proot;
            vm.Types = showCaseTypes;
            return View("ShowCaseModal",vm);
        }
        
    }
}
