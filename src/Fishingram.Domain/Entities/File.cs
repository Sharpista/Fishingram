using Fishingram.Shared.Entities;
using System.IO;

namespace Fishingram.Domain.Entities
{
    public class File : EntityBase
    {
        public virtual string FileName { get; private set; }
        public virtual Stream BinaryContent { get; private set; }
        public virtual string ContentType { get; private set; }

    }
}
