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
    public class LoginMapping : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Email).IsUnique();
        }
    }
}
