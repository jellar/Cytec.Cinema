using System;
using System.Collections.Generic;
using System.Text;
using Cytec.Cinema.Domain.Common;

namespace Cytec.Cinema.Domain
{
    public class Show : AuditableEntity
    {
        public int Id { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public Movie Movie { get; set; }
        public Screen Screen { get; set; }
    }
}
