using System;
using System.Collections.Generic;
using System.Text;
using Cytec.Cinema.Domain.Common;

namespace Cytec.Cinema.Domain
{
    public class Booking : AuditableEntity
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public string User { get; set; }
        public string UserEmail { get; set; }
        public int ShowId { get; set; }
        public int Tickets { get; set; }
        public decimal Amount { get; set; }
        public virtual Show Show { get; set; }
    }
}
