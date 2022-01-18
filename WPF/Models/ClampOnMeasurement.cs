using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public class ClampOnMeasurement : VerificationMeasurement
    {
        [MaxLength(100)]
        public string? MeterName { get; set; }
        public DateTime TimeStamp { get; set; }  

    }
}
