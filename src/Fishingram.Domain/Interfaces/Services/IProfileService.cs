using Fishingram.Domain.Entities;
using System.Threading.Tasks;

namespace Fishingram.Domain.Interfaces.Services
{
    public interface IProfileService : IServiceBase<UserProfile>
    {
        Task<UserProfile> Login(string email, string password);
    }
}
