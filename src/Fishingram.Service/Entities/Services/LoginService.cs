using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.Service.Entities.Services
{
    public class LoginService : ServiceBase<Login>, ILoginService
    {
        private ILoginRepository _loginRespoitory;
        public LoginService(ILoginRepository loginRespoitory) : base(loginRespoitory)
        {
            _loginRespoitory = loginRespoitory;
        }

        public async Task<Login> Login(string name, string password)
        {
           return await _loginRespoitory.Login(name, password);
        }
    }
}
