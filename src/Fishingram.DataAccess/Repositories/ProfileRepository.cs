using Fishingram.DataAccess.Context;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;

namespace Fishingram.DataAccess.Repositories
{
    public class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        public ProfileRepository(FishingramContext fishingramContext) : base(fishingramContext)
        {
        }
    }
}
