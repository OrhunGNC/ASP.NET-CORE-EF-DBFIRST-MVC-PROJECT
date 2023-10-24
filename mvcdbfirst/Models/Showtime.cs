using System;
using System.Collections.Generic;

namespace mvcdbfirst.Models
{
    public partial class Showtime
    {
        public Showtime()
        {
            TicketSales = new HashSet<TicketSale>();
        }

        public int ShowtimeId { get; set; }
        public int? MovieId { get; set; }
        public int? TheaterId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public virtual Movie? Movie { get; set; }
        public virtual Theater? Theater { get; set; }
        public virtual ICollection<TicketSale> TicketSales { get; set; }
    }
}
