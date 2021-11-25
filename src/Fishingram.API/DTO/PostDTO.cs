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
        public virtual DateTime PublishDateTime { get; private set; }
        public virtual PhotoDTO Photo { get; private set; }
    }
}
