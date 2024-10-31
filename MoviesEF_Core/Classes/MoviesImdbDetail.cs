using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesEF_Core.Classes
{
    public class MoviesImdbDetail
    {
        public int Id { get; set; }
        public int ImdbPoint { get; set; }
        public int MovieId { get; set; }
        public Movies Movies { get; set; }



    }
}
