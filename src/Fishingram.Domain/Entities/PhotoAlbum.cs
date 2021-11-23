using Fishingram.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Fishingram.Domain.Entities
{
    public class PhotoAlbum : EntityBase
    {
        public virtual UserProfile Profile { get; private set; }
        public virtual long ProfileId { get; private set; }
        public virtual string Description { get; private set; }
        public virtual DateTime CreationDate { get; private set; }
        public virtual IList<Photo> Photos { get; private set; }

        public PhotoAlbum(UserProfile profile, long profileId, string description)
        {
            Profile = profile;
            ProfileId = profileId;
            Description = description;
            CreationDate = DateTime.Now;
            Photos = new List<Photo>();
        }

        public PhotoAlbum()
        {

        }
    }
}
