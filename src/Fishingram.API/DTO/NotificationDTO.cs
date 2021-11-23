using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fishingram.API.DTO
{
    public class NotificationDTO
    {
        public long Id { get; set; }
        public virtual string Content { get; set; }
        public virtual ProfileDTO Sender { get; set; }
        public virtual long SenderId { get; set; }
        public virtual ProfileDTO Recepient { get; set; }
    }
}
