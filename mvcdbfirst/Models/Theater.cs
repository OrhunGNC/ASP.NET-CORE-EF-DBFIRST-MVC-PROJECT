using System;
using System.Collections.Generic;

namespace mvcdbfirst.Models
{
    public partial class Theater
    {
        public Theater()
        {
            Showtimes = new HashSet<Showtime>();
        }

        public int TheaterId { get; set; }
        public string? TheaterName { get; set; }
        public string? Location { get; set; }
        public int? SeatingCapacity { get; set; }

        public virtual ICollection<Showtime> Showtimes { get; set; }
    }
}
