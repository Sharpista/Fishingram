using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fishingram.API.DTO
{
    public class FollowDTO
    {
        public ProfileDTO Followed { get; set; }
        public ProfileDTO Following { get; set; }
    }
}
