using Fishingram.Domain.ValueObject.Entities;
using Fishingram.Shared.Entities;
using System.Collections.Generic;

namespace Fishingram.Domain.Entities
{
    public class Profile : EntityBase
    {
        public virtual string Email { get; private set; }
        public virtual string Password { get; private set; }
        public virtual FullAddress Address { get; private set; }
        public virtual Photo ProfilePicture { get; private set; }
        public virtual long ProfilePictureId { get; private set; }
        public virtual User User { get; private set; }
        public virtual long UserId { get; private set; }
        public virtual IList<Profile> Followers { get; private set; }
        public virtual IList<Post> Posts { get; private set; }
        public virtual IList<Notification> Notifications { get; private set; }

        public Profile(string email, string password, FullAddress fullAdress, Photo profilePicture, User user, long profilePictureId, long userId)
        {
            Email = email;
            Password = password;
            Address = fullAdress;
            ProfilePicture = profilePicture;
            User = user;
            ProfilePictureId = profilePictureId;
            UserId = userId;
            Followers = new List<Profile>();
            Posts = new List<Post>();
            Notifications = new List<Notification>();
        }
    }
}