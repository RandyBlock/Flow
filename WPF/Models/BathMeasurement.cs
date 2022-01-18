using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow.WPF.Models
{
    public enum BathType
    {
        Sewer,
        Water
    }
    public class BathMeasurement : DomainObject
    {
        
        public DateTime? TimeStamp { get; set; }

        public double? PPB { get; set; }

        public double? MVolt { get; set; }

        public double? Temperature { get; set; }

        public  BathType? BathType { get; set; }
        public Dye? Dye { get; set; }

    }
}
