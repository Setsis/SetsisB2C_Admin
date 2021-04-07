using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Models
{
    public class ShowCaseViewModel
    {
        public Guid PageId { get; set; }
        public List<Page> pages {get;set;}
        public List<ShowCase> showCases { get; set; }
    }
}
