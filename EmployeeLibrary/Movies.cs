using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Movies
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Language { get; set; }

        public Movies(int movieId, string movieName, string language)
        {
            MovieId = movieId;
            MovieName = movieName;
            Language = language;
        }
    }
}
