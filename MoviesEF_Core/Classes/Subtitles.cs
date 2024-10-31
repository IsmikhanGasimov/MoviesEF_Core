using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesEF_Core.Classes
{
    public class Subtitles
    {
        public int Id { get; set; }
        public string SubtitleLanguage { get; set; }

        public ICollection<MovieSubtitle> MovieSubtitles { get; set; }

    }
}
