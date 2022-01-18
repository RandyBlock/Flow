using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public class Manual : DomainObject
    {
       
        public ICollection<ManualConfirmationMeasurement>? Measurements { get; set; }
        public SiteVisit? SiteVisit { get; set; }
        
    }
}
