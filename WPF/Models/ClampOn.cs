using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public class ClampOn : DomainObject
    {
       
        public ICollection<ClampOnConfirmationMeasurement>? Measurements{ get; set; }
        [MaxLength(60)]
        public string? VerificationInstrumentName { get; set; }
        public SiteVisit? SiteVisit { get; set; }
    }
}
