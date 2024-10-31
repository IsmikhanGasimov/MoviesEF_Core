using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesEF_Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesEF_Core.Configurations
{
    public class DirectorsConfiguration : IEntityTypeConfiguration<Directors>
    {
        public void Configure(EntityTypeBuilder<Directors> builder)
        {
            builder.Property(x => x.FirstName)
                   .IsRequired();

            builder.Property(x => x.LastName)
                   .IsRequired();

            builder.Property(x => x.DateOfBirth)
                   .HasDefaultValue("1999-01-01");

            builder.HasMany(x => x.Moviess)
                   .WithOne(x => x.Directors)
                   .HasForeignKey(x => x.DirectorId);
        }
    }
}
