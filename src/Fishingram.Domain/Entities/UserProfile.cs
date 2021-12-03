using Fishingram.Domain.ValueObject.Entities;
using Fishingram.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fishingram.Domain.Entities
{
    public class UserProfile : EntityBase
    {
        public virtual string Name { get; private set; }
        public virtual string Email { get; private set; }
        public virtual string Password { get; private set; }
        public virtual DateTime BirthDate { get; private set; }
        public virtual FullAddress Address { get; private set; }
        public virtual Photo ProfilePicture { get; private set; }
        public virtual IList<Post> Posts { get; private set; }
        public virtual IList<Notification> Notifications { get; private set; }
        public virtual IList<PhotoAlbum> PhotoAlbums { get; private set; }



        public UserProfile(string name, DateTime birthdate,string email, string password, FullAddress fullAdress, Photo profilePicture)
        {
            Name = name;
            BirthDate = birthdate;
            Email = email;
            Password = password;
            Address = fullAdress;
            ProfilePicture = profilePicture;
            Posts = new List<Post>();
            Notifications = new List<Notification>();
            PhotoAlbums = new List<PhotoAlbum>();
        }

        public UserProfile()
        {
                
        }
    }
}