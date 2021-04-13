using System;
using System.Collections.Generic;
using System.Text;
using Cytec.Cinema.Domain.Common;

namespace Cytec.Cinema.Domain
{
    public class Screen : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ScreenCapacity { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
