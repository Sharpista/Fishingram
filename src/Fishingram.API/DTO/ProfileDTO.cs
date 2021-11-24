using Fishingram.Domain.ValueObject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fishingram.API.DTO
{
    public class ProfileDTO
    {
        [Key]
        public long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual string Email { get;  set; }
        public virtual string Password { get;  set; }
        public virtual FullAddress Address { get;  set; }
        public virtual PhotoDTO ProfilePicture { get;  set; }
        public virtual long ProfilePictureId { get;  set; }
        public virtual List<ProfileDTO> Followers { get;  set; }
        public virtual List<PostDTO> Posts { get;  set; }
        public virtual List<NotificationDTO> Notifications { get;  set; }
        public virtual List<PhotoAlbumDTO> PhotoAlbums { get;  set; }
    }
}
