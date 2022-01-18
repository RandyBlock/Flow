using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public class Calibration : DomainObject
    {
        public DateTime? DateCalibrated { get; set; }
        public double? Intercept { get; set; }
        public double? Slope { get; set; }
        public double? TargetppB { get; set; }
        public Dye? Dye { get; set; }
       
        //public ICollection<BathMeasurement>? CalibrationBath { get; set; }
    }
}
