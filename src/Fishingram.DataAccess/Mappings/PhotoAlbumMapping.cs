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
            photoAlbum.Property(_ => _.CreationDate).HasColumnName("DataDeCriacao");
            photoAlbum.Property(_ => _.Description).HasColumnName("Descricao");
            photoAlbum.HasMany(_ => _.Photos);
        }
    }
}
