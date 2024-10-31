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
    public class MovieSubtitleConfiguration : IEntityTypeConfiguration<MovieSubtitle>
    {
        public void Configure(EntityTypeBuilder<MovieSubtitle> builder)
        {
            builder.HasKey(x => new { x.SubtitleId, x.MovieId });
        }
    }
}
