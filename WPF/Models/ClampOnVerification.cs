using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public class ClampOnVerification: Verification
    {
        [MaxLength(100)]
        public string? MeterType { get; set; }
        [MaxLength(100)]
        public string? SensorType { get; set;}
        
    }
}
