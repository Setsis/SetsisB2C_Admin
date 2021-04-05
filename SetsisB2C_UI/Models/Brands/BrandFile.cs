using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Models.Brands
{
    public class BrandFile
    {
        public string brandID { get; set; }
        public string brandName { get; set; }
        public string brandCode { get; set; }
        public IFormFile brandImgPath { get; set; }
    }
}
