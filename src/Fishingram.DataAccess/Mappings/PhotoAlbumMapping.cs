using Fishingram.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.DataAccess.Mappings
{
    public class PhotoAlbumMapping : IEntityTypeConfiguration<PhotoAlbum>
    {
        public void Configure(EntityTypeBuilder<PhotoAlbum> photoAlbum)
        {
            photoAlbum.HasKey(_ => _.Id);

            //photoAlbum.HasOne(_ => _.Profile);

            photoAlbum.HasMany(_ => _.Photos);
        }
    }
}
