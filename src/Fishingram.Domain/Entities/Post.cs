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
        public virtual long  ProfileId { get; private set; }
        public virtual string Description { get; private set; }
        public virtual string Title { get; private set; }


        public Post(Photo photo,  string description, string title, long profileId)
        {
            ProfileId = profileId;
            PublishDateTime = DateTime.Now;
            Photo = photo;
            Description = description;
            Title = title;

        }
        public Post()
        {

        }
    }
}