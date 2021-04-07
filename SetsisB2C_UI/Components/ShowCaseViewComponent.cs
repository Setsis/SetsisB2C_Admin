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
    public class ShowCaseViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(Guid pageId)
        {
            string showCase = "";
            ApiConnect apiConnect = new ApiConnect("https://localhost:44356/Design/GetShowcase?PageID=" + pageId);
            showCase = apiConnect.StrResponse;
            var _showCase = JsonConvert.DeserializeObject<List<ShowCase>>(showCase);

            return View("ShowCaseList",_showCase.OrderBy(s => s.SortNumber).ToList());
        }
    }
}
