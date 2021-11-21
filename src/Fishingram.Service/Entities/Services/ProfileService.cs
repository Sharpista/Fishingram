using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Domain.Interfaces.Services;

namespace Fishingram.Service.Entities.Services
{
    public class ProfileService : ServiceBase<Profile>, IProfileService
    {
        private readonly IProfileRepository _repository;
        public ProfileService(IProfileRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
