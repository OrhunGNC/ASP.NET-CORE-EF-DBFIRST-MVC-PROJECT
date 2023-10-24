using System;
using System.Collections.Generic;

namespace mvcdbfirst.Models
{
    public partial class TicketSale
    {
        public int TicketId { get; set; }
        public int? CustomerId { get; set; }
        public int? ShowtimeId { get; set; }
        public int? SeatNumber { get; set; }
        public decimal? Price { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Showtime? Showtime { get; set; }
    }
}
