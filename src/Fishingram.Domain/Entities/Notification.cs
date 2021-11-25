using Fishingram.Shared.Entities;

namespace Fishingram.Domain.Entities
{
    public class Notification : EntityBase
    {
        public virtual string Content { get; private set; }
        public virtual UserProfile Sender { get; private set; }

        public Notification(string content, UserProfile sender)
        {
            Content = content;
            Sender = sender;
        }

        public Notification()
        {
                
        }
    }
} 