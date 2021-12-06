using Fishingram.Shared.Entities;

namespace Fishingram.Domain.Entities
{
    public class Follow : EntityBase
    {
        public UserProfile Followed { get; set; }
        public UserProfile Following { get; set; }

    }
}
