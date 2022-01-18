using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public class DyeMeasurement : VerificationMeasurement
    {
        public DateTime TimeStamp { get; set; }
        public double FlowRate { get; set; }   
        public UnitType UnitType { get; set; }  

    }
}
