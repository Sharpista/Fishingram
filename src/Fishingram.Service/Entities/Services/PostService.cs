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
    public class PostService : ServiceBase<Post>, IPostService
    {
        private readonly IPostRepository _repository;
        public PostService(IPostRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
