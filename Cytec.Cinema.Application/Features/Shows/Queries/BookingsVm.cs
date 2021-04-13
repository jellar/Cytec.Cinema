using System;
using System.Collections.Generic;
using System.Text;

namespace Cytec.Cinema.Application.Features.Shows.Queries
{
    public class BookingsVm
    {
        public DateTime BookingDate { get; set; }
        public string User { get; set; }
        public string UserEmail { get; set; }
        public int ShowId { get; set; }
        public int Tickets { get; set; }
        public decimal Amount { get; set; }
        public string Movie { get; set; }
        
    }
}
