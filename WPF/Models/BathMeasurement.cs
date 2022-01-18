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
    public class BathMeasurement : VerificationMeasurement
    {
        int DropNumber { get; set; }
        double mlAdded { get; set; }
        public  BathType BathType { get; set; }
        

    }
}
