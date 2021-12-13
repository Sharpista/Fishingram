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
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual string ZipCode { get;  set; }
        public virtual string Street { get;  set; }
        public virtual string District { get; set; }
        public virtual string Number { get;  set; }
        public virtual string Complement { get;  set; }
        public virtual string State { get;  set; }
        public virtual string City { get;  set; }
        public virtual PhotoDTO ProfilePicture { get;  set; }

    }
}
