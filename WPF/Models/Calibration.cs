using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public class Calibration : DomainObject
    {
        //public int Id { get; set; }
        public DateTime? DateCalibrated { get; set; }
        public double? Intercept { get; set; }
        public double? Slope { get; set; }
        public double? TargetppB { get; set; }
        public DyeVerification? DyeVerification { get; set; }
       
        //public ICollection<BathMeasurement>? CalibrationBath { get; set; }
    }
}
