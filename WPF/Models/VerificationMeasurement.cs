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
        MillionGallonsPerDayUK,
        ppB,
        Volt,
        Celsius,
        Farenhieght
        
    }
    public enum MeasurementType

    {
        Depth,
        Velocity,
        Flow,
        Temperature,
        Concentration,
        Voltage

    }
    public class VerificationMeasurement : DomainObject
    {
        //public int Id { get; set; }
        public double MValue { get; set; }
        public MeasurementType MType { get; set; }
        public UnitType UType { get; set; }          


    }
}
