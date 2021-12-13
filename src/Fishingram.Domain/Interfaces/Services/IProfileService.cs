using Fishingram.Domain.Entities;
using System.Threading.Tasks;

namespace Fishingram.Domain.Interfaces.Services
{
    public interface IProfileService : IServiceBase<UserProfile>
    {
        Task<UserProfile> Auntenticate(string email, string password);
    }
}
