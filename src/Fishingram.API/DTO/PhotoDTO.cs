using System.ComponentModel.DataAnnotations;

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
