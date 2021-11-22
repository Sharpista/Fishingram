using Fishingram.DataAccess.Context;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;

namespace Fishingram.DataAccess.Repositories
{
    public class PhotoRepository : Repository<Photo>, IPhotoRepository
    {
        public PhotoRepository(FishingramContext fishingramContext) : base(fishingramContext)
        {
        }
    }
}
