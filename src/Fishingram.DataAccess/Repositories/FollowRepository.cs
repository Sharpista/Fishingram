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
    }
}
