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

            post.Property(_ => _.PublishDateTime).HasColumnName("DataDePublicacao");
            post.Property(_ => _.Title).HasColumnName("Titulo");
            post.Property(_ => _.Description).HasColumnName("Descricao");

            post.HasOne(_ => _.Photo);




        }
    }
}
