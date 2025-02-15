﻿using System;
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
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime PublishDateTime { get;  set; }
        public virtual PhotoDTO Photo { get;  set; }
        public virtual long ProfileId { get; set; }
    }
}
