using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public class Verification: DomainObject
    {
        //public int Id { get; set; } 
        public int SampleRateSeconds { get; set; }
        public SiteVisit? SiteVisit  { get; set; }
        public ICollection<VerificationMeasurement>? VerificationMeasurements { get; set;}
    }
}
