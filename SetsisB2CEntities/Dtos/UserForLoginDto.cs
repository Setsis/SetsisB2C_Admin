using SetsisB2C_Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SetsisB2C_Entities.Dtos
{
  public class UserForLoginDto:IDto
    {

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
