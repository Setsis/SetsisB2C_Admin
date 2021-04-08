using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Models.Orders
{
    public class Orders
    {
        public string OrderNumber { get; set; }
        public string FullName { get; set; }
        public int Qty1 { get; set; }
        public decimal Price { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string ColorDescription { get; set; }
        public int InvoiceQty1 { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
