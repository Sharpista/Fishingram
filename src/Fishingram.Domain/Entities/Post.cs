using Fishingram.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Fishingram.Domain.Entities
{
    public class Post : EntityBase
    {
        public virtual DateTime PublishDateTime { get; private set; }
        public virtual Photo Photo { get; private set; }
        public virtual UserProfile Profile { get; private set; }


        public Post(Photo photo, UserProfile profile)
        {
            Profile = profile;
            PublishDateTime = DateTime.Now;
            Photo = photo;
        }
        public Post()
        {

        }
    }
}