using Fishingram.Domain.Entities;
using System.Threading.Tasks;

namespace Fishingram.Domain.Interfaces.Repositories
{
    public interface IProfileRepository : IRepository<UserProfile>
    {
        Task<UserProfile> Authenticate(string name, string password);
    }
}
