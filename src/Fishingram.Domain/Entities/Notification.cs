﻿using Fishingram.Shared.Entities;

namespace Fishingram.Domain.Entities
{
    public class Notification : EntityBase
    {
        public virtual string Content { get; private set; }
        public virtual Profile Sender { get; private set; }
        public virtual long SenderId { get; private set; }
        public virtual Profile Recepient { get; private set; }
    }
}