using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Models
{
    public class ShowCaseModalModel
    {
        public Guid PageId { get; set; }
        public List<Page> pages { get; set; }
        public Guid ShowCaseTypeId { get; set; }
        public List<ShowCaseType> Types { get; set; }
        public string DesignName { get; set; }
        public string DesignHeader { get; set; }
        public string Description { get; set; }
        public int RowHeight { get; set; }
        public int RowWidth { get; set; }
    }
}
