using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fishingram.API.DTO
{
    public class PhotoAlbumDTO
    {
        [Key]
        public long Id { get; set; }
        public virtual string Description { get; private set; }
        public virtual DateTime CreationDate { get; private set; }
        public virtual List<PhotoDTO> Photos { get; private set; }
    }
}
