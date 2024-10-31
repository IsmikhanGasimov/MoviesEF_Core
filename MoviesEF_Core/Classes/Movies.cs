using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesEF_Core.Classes
{
    public class Movies
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public DateTime? MovieReleaseDate { get; set; }
        public string Description { get; set; }

        public MoviesImdbDetail MoviesImdbDetail { get; set; }
        public ICollection<MovieSubtitle> MovieSubtitles { get; set; }
        public int DirectorId { get; set; }
        public Directors Directors { get; set; }




    }
}
