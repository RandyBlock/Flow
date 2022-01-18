using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public class DyeVerification: Verification
    {
       // if problem with the 2 below, then make a DyeMeasurementType Enum and
       // combine the tables into 1
        public ICollection<BathMeasurement>? BathMeasurement { get; set; }

        public ICollection<DyeMeasurement>? DyeMeasurement { get; set; }
        
        public double? ClearDyePPB { get; set; }
        public double? SewerDyePPB { get; set; }
        public double? ClearIntercept { get; set; }
        public double? SewerIntercept { get; set; }
        public double? RecoveryRatio { get; set; }
        public DateTime? DyeStarted { get; set; }
        public DateTime? DyeEnded { get; set; }
        public double? ManualInjectionRate { get; set; }
        public double? WeightAfter { get; set; }
        public double? WeightBefore { get; set; }
        public double? CalculateInjectionRate { get; set; }
        [MaxLength(60)]
        public string? VerificationInstrumentName { get; set; }
        public Calibration? CalibrationUsed { get; set; }
       // public SiteVisit? SiteVisit { get; set; }
       
    }
}
