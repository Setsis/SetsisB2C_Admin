using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Models
{
    public class Page
    {
        public Guid PageId { get; set; }
        public string PageName { get; set; }
        public string Description { get; set; }
        public int PageType { get; set; }
    }
}
