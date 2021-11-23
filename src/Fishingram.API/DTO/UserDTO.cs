using System;
using System.ComponentModel.DataAnnotations;

namespace Fishingram.API.DTO
{
    public class UserDTO
    {
        [Key]
        public long Id { get; set; }
        public virtual string Name { get;  set; }
        public virtual DateTime BirthDate { get;  set; }
        public virtual long ProfileId { get;  set; }
        public virtual ProfileDTO Profile { get;  set; }
    }
}
