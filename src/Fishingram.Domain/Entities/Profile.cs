using System.Collections.Generic;

namespace Fishingram.Domain.Entities
{
    public class Profile
    {
        public virtual string Email { get; private set; }
        public virtual string Password { get; private set; }
        public virtual int MyProperty { get; private set; }
        public virtual Photo ProfilePicture { get; private set; }
        public virtual User User { get; private set; }
        public virtual long ProfilePictureId { get; private set; }
        public virtual long UserId { get; private set; }
        public virtual IList<Profile> Followers { get; private set; }
        public virtual IList<Post> Posts { get; private set; }
        public virtual IList<Notification> Notifications { get; private set; }
    }
}