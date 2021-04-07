using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Models
{
    public class ShowCaseProduct
    {
        public Guid CaseProductId { get; set; }
        public Guid PageDesignId { get; set; }
        public string Barcode { get; set; }
        public int ProductSortNumber { get; set; }
    }
}
