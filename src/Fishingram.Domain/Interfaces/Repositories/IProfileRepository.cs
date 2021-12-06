using Fishingram.Domain.Entities;
using System.Threading.Tasks;

namespace Fishingram.Domain.Interfaces.Repositories
{
    public interface IProfileRepository : IRepository<UserProfile>
    {
        Task<UserProfile> Login(string name, string password);
    }
}
