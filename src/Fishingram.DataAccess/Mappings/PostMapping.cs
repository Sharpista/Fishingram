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
    public class PostMapping : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> post)
        {
            post.HasKey(_ => _.Id);

            post.HasOne(_ => _.Photo);

            post.HasOne(_ => _.Recepient);

            post.HasOne(_ => _.Sender);

            post.HasMany(_ => _.Notifications);


        }
    }
}
