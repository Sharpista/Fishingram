using Fishingram.DataAccess.Context;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;

namespace Fishingram.DataAccess.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(FishingramContext fishingramContext) : base(fishingramContext)
        {
        }
    }
}
