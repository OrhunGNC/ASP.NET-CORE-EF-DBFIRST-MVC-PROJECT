using System;
using System.Collections.Generic;

namespace mvcdbfirst.Models
{
    public partial class Customer
    {
        public Customer()
        {
            TicketSales = new HashSet<TicketSale>();
        }

        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? Contactinfo { get; set; }

        public virtual ICollection<TicketSale> TicketSales { get; set; }
    }
}
