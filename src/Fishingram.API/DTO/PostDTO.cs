using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fishingram.API.DTO
{
    public class PostDTO
    {
        [Key]
        public long Id { get; set; }
        public virtual ProfileDTO Sender { get; private set; }
        public virtual long SenderId { get; private set; }
        public virtual ProfileDTO Recepient { get; private set; }
        public virtual long RecepientId { get; private set; }
        public virtual DateTime PublishDateTime { get; private set; }
        public virtual PhotoDTO Photo { get; private set; }
        public virtual long PhotoId { get; private set; }
        public virtual List<NotificationDTO> Notifications { get; private set; }
    }
}
