using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{

    public enum UnitType
    {
        Meter,
        Millimeter,
        Centimeter,
        Inch,
        MetersPerSecond,
        FeetPerSecond,
        LitersPerSecond,
        MillionLitersPerDay,
        MillionGallonsPerDayUS,
        MillionGallonsPerDayUK
    }
    public enum MeasurementType

    {
        Depth,
        Velocity,
        Flow
    }
    public class DyeConfirmationMeasurement : DomainObject
    {
       
       
        public DateTime? TimeStamp { get; set; }
        public double? ConfirmationValue { get; set; }
        public double? MeterValue { get; set; }

        /* repository is Scada*/
        public double? RepositoryValue { get; set; }
        public MeasurementType? MeasurementType { get; set; } 
        public UnitType? UnitType { get; set; }
       // public ClampOn ClampOn { get; set; }
       // public Manual Manual { get; set; }
        public Dye? Dye { get; set; }


    }
}
