using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.DataAccess.Repositories
{
    public class FollowRepository : Repository<Follow>, IFollowRepository
    {
        public Task<Follow> FollowUser(UserProfile followed, UserProfile following)
        {
            throw new NotImplementedException();
        }

        public Task<Follow> UnfollowUser(UserProfile following, UserProfile followed)
        {
            throw new NotImplementedException();
        }
    }
}
