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
    public class MoviesConfiguration : IEntityTypeConfiguration<Movies>
    {
        public void Configure(EntityTypeBuilder<Movies> builder)
        {
            builder.Property(x => x.MovieName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.MovieReleaseDate)
                   .IsRequired();

            builder.Property(x => x.Description)
                   .IsRequired(false);


            builder.HasOne(x => x.MoviesImdbDetail)
                   .WithOne(x => x.Movies)
                   .HasForeignKey<MoviesImdbDetail>(x => x.MovieId);

            builder.HasMany(x => x.MovieSubtitles)
                   .WithOne(x => x.Movies)
                   .HasForeignKey(x => x.MovieId);
        }
    }
}
