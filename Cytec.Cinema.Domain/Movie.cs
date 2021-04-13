using System;
using System.Collections.Generic;
using System.Text;
using Cytec.Cinema.Domain.Common;

namespace Cytec.Cinema.Domain
{
    public class Movie : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan RunningTime { get; set; }
        public decimal Price { get; set; }
    }
}
