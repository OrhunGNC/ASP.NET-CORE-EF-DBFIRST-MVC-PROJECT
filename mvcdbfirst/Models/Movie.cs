using System;
using System.Collections.Generic;

namespace mvcdbfirst.Models
{
    public partial class Movie
    {
        public Movie()
        {
            Showtimes = new HashSet<Showtime>();
        }

        public int MovieId { get; set; }
        public string? MovieTitle { get; set; }
        public string? Director { get; set; }
        public string? Genre { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public virtual ICollection<Showtime> Showtimes { get; set; }
    }
}
