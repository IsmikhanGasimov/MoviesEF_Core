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
    public class SubtitlesConfiguration : IEntityTypeConfiguration<Subtitles>
    {
        public void Configure(EntityTypeBuilder<Subtitles> builder)
        {
            builder.Property(x => x.SubtitleLanguage)
                   .IsRequired()
                   .HasMaxLength(80);

            builder.HasMany(x => x.MovieSubtitles)
                   .WithOne(x => x.Subtitles)
                   .HasForeignKey(x => x.SubtitleId);
        }
    }
}
