using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Fishingram.Service.Entities.Services
{
    public class ProfileService : ServiceBase<UserProfile>, IProfileService
    {
        private readonly IProfileRepository _repository;
        public ProfileService(IProfileRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<UserProfile> Login(string email, string password)
        {
            return await _repository.Login(email, password);
        }
    }
}
