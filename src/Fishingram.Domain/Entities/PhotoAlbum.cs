using Fishingram.Shared.Entities;
using System;
using System.Collections.Generic;

namespace Fishingram.Domain.Entities
{
    public class PhotoAlbum : EntityBase
    {
        public virtual string Description { get; private set; }
        public virtual DateTime CreationDate { get; private set; }
        public virtual IList<Photo> Photos { get; private set; }

        public PhotoAlbum(string description)
        {
            Description = description;
            CreationDate = DateTime.Now;
            Photos = new List<Photo>();
        }

        public PhotoAlbum()
        {

        }
    }
}
