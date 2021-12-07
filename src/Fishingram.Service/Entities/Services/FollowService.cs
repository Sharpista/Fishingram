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
    public class FollowService : ServiceBase<Follow>, IFollowService
    {
        private readonly IFollowRepository _followRepository;

        public FollowService(IFollowRepository repository) : base(repository)
        {
            _followRepository = repository;
        }
    }
}
