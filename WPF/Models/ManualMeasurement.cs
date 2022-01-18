using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public class ManualMeasurement: VerificationMeasurement
    {
        public double MeterValue { get; set; }
        public UnitType UnitType { get; set; }
        public MeasurementType MeasurementType { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}
