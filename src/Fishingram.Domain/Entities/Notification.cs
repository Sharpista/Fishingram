using Fishingram.Shared.Entities;

namespace Fishingram.Domain.Entities
{
    public class Notification : EntityBase
    {
        public virtual string Content { get; private set; }
        public virtual UserProfile Sender { get; private set; }
        public virtual long SenderId { get; private set; }
        public virtual UserProfile Recepient { get; private set; }

        public Notification(string content, UserProfile sender, long senderId, UserProfile recepient)
        {
            Content = content;
            Sender = sender;
            SenderId = senderId;
            Recepient = recepient;
        }

        public Notification()
        {
                
        }
    }
} 