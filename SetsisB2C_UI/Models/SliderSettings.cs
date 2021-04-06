using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Models
{
    public class SliderSettings
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public string ImageLink { get; set; }
        public int Orders { get; set; }
    

    }
}
