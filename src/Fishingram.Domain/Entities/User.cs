using Fishingram.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.Domain.Entities
{
    public class User : EntityBase
    {
        public virtual string Name { get; private set; }
        public virtual DateTime BirthDate { get; private set; }
        public virtual long ProfileId { get; private set; }
        public virtual Profile Profile { get; private set; }

        public User(string name, DateTime birthDate, long profileId, Profile profile)
        {
            Name = name;
            BirthDate = birthDate;
            ProfileId = profileId;
            Profile = profile;
        }
        public User()
        {

        }
    }
}
