using Fishingram.DataAccess.Context;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Fishingram.DataAccess.Repositories
{
    public class ProfileRepository : Repository<UserProfile>, IProfileRepository
    {
        public ProfileRepository(FishingramContext fishingramContext) : base(fishingramContext)
        {
        }

        public async Task<UserProfile> Authenticate(string email, string password)
        {
            return await DbSet.AsNoTracking().Where(x => x.Email == email && x.Password == password).SingleOrDefaultAsync();
        }
    }
}
