using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Flow.WPF.Models
{
    public class CheckList : DomainObject
    {
        
        public bool? BatteryChanged { get; set; }
               
        public bool? SensorCleaned { get; set; }
        
        public bool? Calibrated { get; set; }

        public bool? Verified { get; set; }

        public bool? EquipmentInstalled { get; set; }

        public bool? EquipmentRemoved { get; set; }

        public bool? EquipmentRepaired{ get; set; }

        public bool? Inspected { get; set; }
        public SiteVisit? SiteVisit { get; set; }

    }
}
