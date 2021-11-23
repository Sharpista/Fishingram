using Fishingram.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Fishingram.Domain.Entities
{
    public class Post : EntityBase
    {
        public virtual UserProfile Sender { get; private set; }
        public virtual long SenderId { get; private set; }
        public virtual UserProfile Recepient { get; private set; }
        public virtual long RecepientId { get; private set; } 
        public virtual DateTime PublishDateTime { get; private set; }
        public virtual Photo Photo { get; private set; }
        public virtual long PhotoId { get; private set; }
        public virtual IList<Notification>Notifications { get; private set; }


        public Post(UserProfile sender,long senderId, UserProfile recepient,long recepientId,Photo photo, long photoId)
        {
            Sender = sender;
            SenderId = senderId;
            Recepient = recepient;
            RecepientId = recepientId;
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