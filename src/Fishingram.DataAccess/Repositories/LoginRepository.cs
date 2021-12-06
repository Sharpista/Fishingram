using Fishingram.DataAccess.Context;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.DataAccess.Repositories
{
    public class LoginRepository : Repository<Login>, ILoginRepository
    {
        public LoginRepository(FishingramContext fishingramContext) : base(fishingramContext)
        {
        }

        public async Task<Login> Login(string email, string password)
        {
             return await DbSet.AsNoTracking().Where(x => x.Email == email && x.Password == password).SingleOrDefaultAsync();
        }

    }
}
