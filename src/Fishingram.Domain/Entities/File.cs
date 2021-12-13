using Fishingram.Shared.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace Fishingram.Domain.Entities
{
    public class File : EntityBase
    {
        public virtual string FileName { get; private set; }
        public virtual string ImageURL { get; private set; }
        public virtual string ContentType { get; private set; }

    }
}
