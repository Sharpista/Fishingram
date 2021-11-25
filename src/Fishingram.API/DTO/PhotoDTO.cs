using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fishingram.API.DTO
{
    public class PhotoDTO
    {
        [Key]
        public long Id { get; set; }
        public virtual string FileName { get; set; }
        public virtual string ContentType { get; set; }
    }
}
