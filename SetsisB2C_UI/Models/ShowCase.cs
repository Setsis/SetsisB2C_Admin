using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Models
{
    public class ShowCase
    {
        public Guid PageDesignId { get; set; }
        public Guid PageId { get; set; }
        public Guid ShowCaseDesignId { get; set; }
        public string DesignName { get; set; }
        public string DesignHeader { get; set; }
        public string Description { get; set; }
        public int RowHeight { get; set; }
        public int RowWidth { get; set; }
        public int SortNumber { get; set; }
        public string TypeName { get; set; }
    }
}
