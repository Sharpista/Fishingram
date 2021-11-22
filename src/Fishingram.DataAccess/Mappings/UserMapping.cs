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
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> user)
        {
            user.HasKey(_ => _.Id);

            user.Property(_ => _.Name)
                .IsRequired()
                .HasMaxLength(50);

            user.Property(_ => _.Profile)
                .IsRequired();

            user.Property(_ => _.BirthDate)
                .IsRequired();

            user.HasOne(_ => _.Profile);

        }
    }
}
