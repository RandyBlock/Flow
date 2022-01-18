using System;

namespace Flow.WPF.Models
{
    public class ClampOnConfirmationMeasurement : DomainObject
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
            public ClampOn? ClampOn { get; set; }


        }
    }
