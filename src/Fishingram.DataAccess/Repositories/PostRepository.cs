using Fishingram.DataAccess.Context;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fishingram.DataAccess.Repositories
{
    public class PostRepository : Repository<Post>, IPostRepository
    {
        public PostRepository(FishingramContext fishingramContext) : base(fishingramContext)
        {
        }

        public async Task<IEnumerable<Post>> GetAllPostFromUser(long id)
        {
            var posts = await DbSet.ToListAsync();

            return posts.Where(x => x.ProfileId == id).ToList();
        }
    }
}
