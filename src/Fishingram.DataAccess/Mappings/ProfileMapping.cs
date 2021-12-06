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

            profile.Property(_ => _.Name).HasColumnName("Nome");



            profile.Property(_ =>_.State ).HasColumnName("Estado");
            profile.Property(_ => _.Street).HasColumnName("Rua");
            profile.Property(_ => _.ZipCode).HasColumnName("CEP");
            profile.Property(_ => _.Complement).HasColumnName("Complemento");
            profile.Property(_ => _.City).HasColumnName("Cidade");
            profile.Property(_ => _.BirthDate).HasColumnName("DataDeNascimento");
            profile.HasOne(_ => _.ProfilePicture);
 


        }
    }
}
