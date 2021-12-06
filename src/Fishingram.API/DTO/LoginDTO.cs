using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fishingram.API.DTO
{
    public class LoginDTO 
    {
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
}
