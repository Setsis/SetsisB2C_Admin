using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Models
{
    public class Param
    {


        public string ItemCode { get; set; }
        public List<Product> Products { get; set; }

        public Param()
        {
            Products = new List<Product>();
        }
    }
}
