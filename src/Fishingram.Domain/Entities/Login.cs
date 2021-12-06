using Fishingram.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.Domain.Entities
{
    public class Login : EntityBase
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public Login(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public Login()
        {

        }
    }
}
