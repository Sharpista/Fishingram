using Fishingram.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Fishingram.Domain.Entities
{
    public class Post : EntityBase
    {
        public virtual DateTime PublishDateTime { get; private set; }
        public virtual Photo Photo { get; private set; }
        public virtual long PhotoId { get; private set; }
        public virtual IList<Notification>Notifications { get; private set; }


        public Post(Photo photo, long photoId)
        {
            PublishDateTime = DateTime.Now;
            Photo = photo;
            PhotoId = photoId;
            Notifications = new List<Notification>();
        }
        public Post()
        {

        }
    }
}