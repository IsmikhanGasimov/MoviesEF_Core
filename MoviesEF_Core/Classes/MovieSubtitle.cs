using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesEF_Core.Classes
{
    public class MovieSubtitle
    {
        public int MovieId { get; set; }
        public Movies Movies { get; set; }
        public int SubtitleId { get; set; }
        public Subtitles Subtitles { get; set; }

    }
}
