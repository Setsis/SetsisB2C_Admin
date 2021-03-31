using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SetsisB2C_UI.Models
{
    public class OperationClaim:IdentityUser
    {

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
