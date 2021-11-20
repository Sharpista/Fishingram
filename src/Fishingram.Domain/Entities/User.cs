using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.Domain.Entities
{
    public class User
    {
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public long ProfileId { get; private set; }
        public Profile Profile { get; private set; }

        public User(string name, DateTime birthDate, long profileId, Profile profile)
        {
            Name = name;
            BirthDate = birthDate;
            ProfileId = profileId;
            Profile = profile;
        }
    }
}
