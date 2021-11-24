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
    public class ProfileMapping : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> profile)
        {
            profile.HasKey(_ => _.Id);
            profile.HasIndex(_ => _.Email).IsUnique();

            profile.Property(_ => _.Email)
                .HasMaxLength(50)
                .IsRequired();
            profile.OwnsOne(_ => _.Address);
            profile.Property(_ => _.Name);

            profile.Property(_ => _.Password)
                .IsRequired();

            profile.HasOne(_ => _.ProfilePicture);

            profile.HasMany(_ => _.PhotoAlbums);
            profile.HasMany(_ => _.Posts);
            profile.HasMany(_ => _.Notifications);


        }
    }
}
