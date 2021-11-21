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
    public class UserService : ServiceBase<User>, IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository): base(repository)
        {
            _repository = repository;
        }
    }
}
