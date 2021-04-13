using System;
using System.Collections.Generic;
using System.Text;

namespace Cytec.Cinema.Domain.Common
{
    public class AuditableEntity
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
    
}
